using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    public class Anställd
    {
        public int AnställningsNr { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public int Ålder { get; set; }
        public Anställd(int anställningsNr, string förnamn, string efternamn, int ålder)
        {
            AnställningsNr = anställningsNr;
            Förnamn = förnamn;
            Efternamn = efternamn;
            Ålder = ålder;
        }

        public Anställd()
        {

        }
    }  
}
