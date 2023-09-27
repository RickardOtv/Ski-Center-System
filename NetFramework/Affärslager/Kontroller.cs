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

        UnitOfWork unitOfWork = new UnitOfWork();
        public Anställd LoggedIn
        {
            get; private set;
        }

        public bool LoggaIn(int anställningsNr, string lösenord)
        {
            //unitOfWork = new UnitOfWork();
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

    }
}
