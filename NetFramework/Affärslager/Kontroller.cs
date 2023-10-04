using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Datalager;
using Entitetslager;


namespace Affärslager
{
    public class Kontroller
    {

        private UnitOfWork unitOfWork;
        public Kontroller() { }
        public Anställd LoggedIn
        {
            get; private set;
        }

        public bool LoggaIn(int anställningsNr, string lösenord)
        {
            unitOfWork = new UnitOfWork();
            Anställd a = (from anst in unitOfWork.anställda where anst.AnställningsNr == anställningsNr select anst).FirstOrDefault();
            if (a != null && a.VerifieraLösenord(lösenord))
            {
                LoggedIn = a;
                return true;
                unitOfWork.SaveChanges();
            }
            else
                LoggedIn = null;
            return false;
        }

        public Bokning SkapaBokning(DateTime från, DateTime till, Logi l, Kund k)
        {
            if (LoggedIn == null)
            {
                throw new ApplicationException("Ingen har loggat in");
            }

            if (!l.IsAvailable)
            {
                throw new ApplicationException("Logi " + l.LogiID + " är redan reserverad av någon annan.");
            }

            Bokning bokning = new Bokning(från, till, l, k);
            l.IsAvailable = false;
            unitOfWork.bokningar.Add(bokning);
            unitOfWork.SaveChanges();
            return bokning;

        }

        public Kund SkapaNyKund(string personnummer, string namn, string telefonnummer, string email, string adress, string postNr, string postOrt, string typ, int maxbeloppskreditgräns)
        {
            Kund kund = new Kund(personnummer, namn, telefonnummer, email, adress, postNr, postOrt, typ, maxbeloppskreditgräns);
            unitOfWork.kunder.Add(kund);
            unitOfWork.SaveChanges();
            return kund;

        }



        public void TaBortBokning(Bokning b, Logi l)
        {
            //Saknar att utrusning/skidskola blir available
            //l.IsAvailable = true; //Buggat för nån anledning
            unitOfWork.bokningar.Remove(b);
            unitOfWork.SaveChanges();
        }
        public Kund HittaKund(int kundID)
        {
            return unitOfWork.kunder.FirstOrDefault(k => k.KundID == kundID);
        }
        public Kund HittaKund(string personNummer)
        {
            return unitOfWork.kunder.FirstOrDefault(k => k.Personnummer == personNummer);
        }
        public Logi HittaLogi(string logiID)
        {
            return unitOfWork.logier.FirstOrDefault(l => l.LogiID == logiID);
        }
        public IList<Logi> HämtaTillgängligLogi()
        {
            List<Logi> logier = (from l in unitOfWork.logier where l.IsAvailable == true select l).ToList<Logi>();
            return logier;
        }
        public IList<Kund> HämtaKunder()
        {
            return unitOfWork.kunder.ToList<Kund>();
        }
        public decimal KollaPris(DateTime från, DateTime till)
        {
            var cultureInfo = CultureInfo.CurrentCulture; // You can specify a specific culture if needed

            // Find the relevant week and year combinations for the given date range
            var relevantWeeksAndYears = Enumerable.Range(0, (int)(till - från).TotalDays + 1)
                .Select(offset => new {
                    WeekNumber = cultureInfo.Calendar.GetWeekOfYear(från.AddDays(offset), cultureInfo.DateTimeFormat.CalendarWeekRule, cultureInfo.DateTimeFormat.FirstDayOfWeek),
                    Year = från.AddDays(offset).Year
                })
                .Distinct()
                .ToList();

            // Extract the week numbers from the relevantWeeksAndYears list
            var relevantWeekNumbers = relevantWeeksAndYears.Select(ry => ry.WeekNumber).ToList();

            // Query the LogisticsPrice table to get prices for the relevant week numbers
            var prices = unitOfWork.logiPris
                .Where(lp => relevantWeekNumbers.Contains(lp.Vecka))
                .Select(lp => lp.Pris)
                .ToList();

            // Calculate the total price based on the prices for all relevant weeks
            decimal totalPrice = prices.Sum();

            return totalPrice;
        }

        public IList<Bokning> HämtaBokningar()
        {
            return unitOfWork.bokningar.ToList<Bokning>();
        }

        public void ÄndraBokning(DateTime från, DateTime till, Bokning bokning)
        {
            bokning.Från = från;
            bokning.Till = till;
            unitOfWork.SaveChanges();
            //return bokning;
        }

        public Bokning HittaBokning(string söktBokningsNummer)
        {
            int matadBokningsNr = Int32.Parse(söktBokningsNummer);
            Bokning matchadBokning = unitOfWork.bokningar.FirstOrDefault(b => b.BokningsID == matadBokningsNr);
            return matchadBokning;
        }

    }
}
