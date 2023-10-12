using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace Entitetslager
{
    [Table("Lektionsrad")]
    public class Lektionsrad
    {
        [Key]
        public int LektionsradsID { get; set; }

        public Skidlektion skidlektion { get; set; }
        public int LektionsID { get; set; }

        public DateTime Från { get; set; }
        public DateTime Till { get; set; }
        public Bokning bokning { get; set; }
        [Required]
        public int BokningsID { get; set; }

        public Lektionsrad(int lektionsradsID, int lektionsID, DateTime från, DateTime till, int bokningsID)
        {
            LektionsradsID = lektionsradsID;
            LektionsID = lektionsID;
            Från = från;
            Till = till;
            BokningsID = bokningsID;
        }


        public Lektionsrad()
        {
            
        }
    }
}
