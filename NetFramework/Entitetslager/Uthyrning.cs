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
        public IList<Utrustning> Utrustning { get; set; }
        public string UtrustningsID { get; set; }

        [Required]
        public Bokning BokningsID { get; set; }

        public Uthyrning(DateTime från, DateTime till, Bokning bokningsID, IList<Utrustning> utrustning)
        {
            Utrustning = utrustning;
            Från = från;
            Till = till;
            BokningsID = bokningsID;
        }


        public Uthyrning()
        {

        }
    }
}
