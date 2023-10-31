using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    [Table("Bokningsrad")]
    public class Bokningsrad
    {
        [Key]
        public int BokningsradID { get; set; }
        
        [ForeignKey("Logi")]
        public string LogiID { get; set; }
        public Logi Logi { get; set; }
        public Bokning bokning { get; set; }
        public DateTime Från { get; set; }
        public DateTime Till { get; set; }
        public int BokningsID { get;set; }

        public Bokningsrad(string logiID, DateTime från, DateTime till, int bokningsID)
        {
            LogiID = logiID;
            Från = från;
            Till = till;
            BokningsID = bokningsID;
        }

        public Bokningsrad()
        {

        }


    }
}
