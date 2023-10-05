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
    [Table("Logi")]
    public class Logi
    {
        [Key]
        public string LogiID { get; set; }
        public string Typ { get; set; }

        public Logi(string logiID, string typ)
        {
            LogiID = logiID;
            Typ = typ;
        }

        public Logi()
        {

        }
    }
}