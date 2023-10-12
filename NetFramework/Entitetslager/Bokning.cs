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
        public Kund Kund { get; set; }
        public int KundID { get; set; }
 
        public IList<Bokningsrad> Bokningsrader { get; set; }
        public IList<Lektionsrad> Lektionsrader { get; set; }

        public Uthyrning Uthyrning { get; set; }
        public int UthyrningsID { get; set; }
        public DateTime Från { get; set; }
        public DateTime Till { get; set; }

        public Bokning(int bokningsID, int kundID, int uthyrningsID, IList<Bokningsrad> bokningsrader, DateTime från, DateTime till)
        {
            Bokningsrader = bokningsrader ?? new List<Bokningsrad>();
            BokningsID = bokningsID;
            KundID = kundID;
            UthyrningsID = uthyrningsID;
            Från = från;
            Till = till;
        }





        public Bokning()
        {

        }
    }
}