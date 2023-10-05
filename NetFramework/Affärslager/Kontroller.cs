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

            Bokning bokning = new Bokning(från, till, l, k);
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

        public void TaBortKund(Kund k)
        {
            unitOfWork.kunder.Remove(k);
            unitOfWork.SaveChanges();
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
            return unitOfWork.logier.ToList<Logi>();
        }
        public IList<Kund> HämtaKunder()
        {
            return unitOfWork.kunder.ToList<Kund>();
        }
        public decimal KollaPris(DateTime från, DateTime till, string logiTyp)
        {
            decimal totalPrice = 0;
            DateTime currentDate = från;
            while (currentDate <= till)
            {
                // Hämta veckonummer för det aktuella datumet
                int vecka = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(currentDate, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

                // Hämta prisinformation för den aktuella veckan och logitypen
                var logiPris = unitOfWork.logiPris.FirstOrDefault(lp => lp.Vecka == vecka && lp.Typ == logiTyp);

                if (logiPris != null)
                {
                    if (currentDate.DayOfWeek >= DayOfWeek.Monday && currentDate.DayOfWeek <= DayOfWeek.Thursday)
                    {
                        // Om det är en vardag (måndag till torsdag), använd vardagspriset
                        totalPrice += logiPris.VardagsPris;
                    }

                    else
                    {
                        // Annars är det en helgdag (fredag till söndag), använd helgpriset
                        totalPrice += logiPris.HelgPris;
                    }
                }
                else
                {
                    // Om prisinformation saknas för den aktuella veckan och logitypen, bryt loopen
                    break;
                }

                // Gå till nästa dag
                currentDate = currentDate.AddDays(1);

                // Om vi har passerat "till"-datumet, bryt loopen
                if (currentDate > till)
                {
                    break;
                }
            }

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

        public void ÄndraKund(string personnummer, string namn, string telefonnummer, string postNr, string postOrt, string typ, string adress, string email, int kredit, Kund kund)
        {
            kund.Personnummer = personnummer;
            kund.Namn = namn;
            kund.Telefonnummer = telefonnummer;
            kund.PostNr = postNr;
            kund.PostOrt = postOrt;
            kund.Typ = typ;
            kund.Adress = adress;
            kund.Email = email;
            kund.Maxbeloppskreditgräns = kredit;
            unitOfWork.SaveChanges();
        }

        public Bokning HittaBokning(string söktBokningsNummer)
        {
            int matadBokningsNr = Int32.Parse(söktBokningsNummer);
            Bokning matchadBokning = unitOfWork.bokningar.FirstOrDefault(b => b.BokningsID == matadBokningsNr);
            return matchadBokning;
        }

        public string HittaBehörighet(int anstllningsNr)
        {
            Anställd anställd = unitOfWork.anställda.FirstOrDefault(k => k.AnställningsNr == anstllningsNr);
            return anställd.Behörighet;
        }
    }
}
