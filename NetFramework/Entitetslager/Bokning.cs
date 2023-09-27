using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    public class Bokning
    {
        [Key]
        public int BokningsID { get; set; }
        public DateTime Från { get; set; }
        public DateTime Till { get; set; }
        public Uthyrning Uthyrning { get; set; }
        public int UthyrningsID { get; set; }

        public Kund Kund { get; set; }
        public int KundID { get; set; }
        public Logi Logi { get; set; }
        public string LogiID { get; set; }

        public Skidlektion Skidlektion { get; set; }
        public int LektionsID { get; set; }

        [Required]
        public Faktura Faktura { get; set; }
        public int FakturaID { get; set; }
        

        public Bokning(int bokningsID, DateTime från, DateTime till, int kundID)
        {
            BokningsID = bokningsID;
            Från = från;
            Till = till;
            KundID = kundID;
        }


        public Bokning()
        {

        }
    }
}
