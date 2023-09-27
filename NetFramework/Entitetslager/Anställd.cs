using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    public class Anställd
    {
        [Key]
        public int AnställningsNr { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Användarnamn { get; set; }
        public string Lösenord { get; set; }
        public string Behörighet { get; set; }


        public Anställd(int anställningsNr, string förnamn, string efternamn, string lösenord, string behörighet)
        {
            AnställningsNr = anställningsNr;
            Förnamn = förnamn;
            Efternamn = efternamn;
            Lösenord = lösenord;
            Behörighet = behörighet;
        }

        public Anställd()
        {

        }
    }  
}