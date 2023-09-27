using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    public class Skidlektion
    {
        [Key]
        public int LektionsID { get; set; }
        public Anställd Anställd { get; set; }
        public int AnställningsNr { get; set; }
        public Bokning Bokning { get; set; }
        public int BokningsID { get; set; }
        public string Grupp { get; set; }
        public int Antal { get; set; }

        public Skidlektion(int lektionsID, string grupp, int antal)
        {
            LektionsID = lektionsID;
            Grupp = grupp;
            Antal = antal;
        }


        public Skidlektion()
        {
            
        }
    }
}
