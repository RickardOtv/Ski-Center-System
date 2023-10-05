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
    [Table("Bokning")]
    public class Bokning
    {
        [Key]
        public int BokningsID { get; set; }
        public DateTime Från { get; set; }
        public DateTime Till { get; set; }
        public Uthyrning Uthyrning { get; set; }
        public int UthyrningsID { get; set; }
        public IList<Logi> Logi { get; set; }
        public string LogiID { get; set; }
        public Kund Kund { get; set; }
        public int KundID { get; set; }
        public Skidlektion Skidlektion { get; set; }
        public int LektionsID { get; set; }

        public Bokning(DateTime från, DateTime till, IList<Logi> l, Kund k)
        {
            Från = från;
            Till = till;
            Logi = l;
            Kund = k;
        }

        public Bokning()
        {

        }
    }
}