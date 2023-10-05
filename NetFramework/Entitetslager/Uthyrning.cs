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

        public DateTime Från { get; set; }
        public DateTime Till { get; set; }

        public Utrustning UtrustningsID { get; set; }


        [Required]
        public Bokning BokningsID { get; set; }

        public Uthyrning(int uthyrningsID, DateTime från, DateTime till, Utrustning utrustningsID, Bokning bokningsID)
        {
            UthyrningsID = uthyrningsID;
            Från = från;
            Till = till;
            UtrustningsID = utrustningsID;
            BokningsID = bokningsID;
        }


        public Uthyrning()
        {

        }
    }
}
