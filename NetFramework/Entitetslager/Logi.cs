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
        public int LogiID { get; set; }
        public int AntalBäddar { get; set; }
        public int Area { get; set; }

        public bool IsAvailable { get; set; }


        public Logi(int logiID, int antalBäddar, int area, bool isAvailable)
        {
            LogiID = logiID;
            AntalBäddar = antalBäddar;
            Area = area;
            IsAvailable = isAvailable;
        }

        public Logi()
        {
            
        }
    }
}
