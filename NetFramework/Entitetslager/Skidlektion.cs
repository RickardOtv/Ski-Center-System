using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    [Table("Skidlektion")]
    public class Skidlektion
    {
        [Key]
        public int LektionsID { get; set; }

        public string Grupp { get; set; }


        public Skidlektion(int lektionsID, string grupp, int antal)
        {
            LektionsID = lektionsID;
            Grupp = grupp;
          
        }


        public Skidlektion()
        {

        }
    }
}
