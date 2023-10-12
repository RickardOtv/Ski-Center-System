using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    [Table("Uthyrning")]
    public class Uthyrning
    {
        [Key]
        public int UthyrningsID { get; set; }
        [ForeignKey("Bokning")]
        public int BokningsID { get; set; }
        public Bokning Bokning { get; set; }
        public IList<Uthyrningsrad> Uthyrningsrader { get; set; }


        public Uthyrning(int bokningsID, IList<Uthyrningsrad> uthyrningsrader)
        {
            Uthyrningsrader = uthyrningsrader ?? new List<Uthyrningsrad>();
            BokningsID = bokningsID;
        }


        public Uthyrning()
        {

        }
    }
}
