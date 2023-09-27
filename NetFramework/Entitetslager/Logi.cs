using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    public class Logi
    {
        [Key]
        public string LogiID { get; set; }
        public string Typ { get; set; }

        public bool IsAvailable { get; set; }


        public Logi(string logiID, string typ, bool isAvailable)
        {
            LogiID = logiID;
            Typ = typ;
            IsAvailable = isAvailable;
        }

        public Logi()
        {
            
        }
    }
}