using System;
using System.Collections.Generic;
using System.Linq;
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

        public void TaBortBokning(Bokning b)
        {
            b.Logi.IsAvailable = true;
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
    }
}
