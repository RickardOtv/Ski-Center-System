using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    [Table("Företag")]
    public class Företag
    {
        [Key]
        public int FöretagsID { get; set; }
        public string FöretagsNamn { get; set; }


        public Företag(int företagsID, string företagsnamn)
        {
            FöretagsID = företagsID;
            FöretagsNamn = företagsnamn;

        }


        public Företag()
        {
            
        }
    }
}
