using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    public class Företag : Kund
    {
        [Key]

        public int FöretagsNr { get; set; }
        public string FöretagsNamn { get; set; }


        public Företag(int företagsNr, string företagsnamn)
        {
            FöretagsNr = företagsNr;
            FöretagsNamn = företagsnamn;

        }


        public Företag()
        {
            
        }
    }
}
