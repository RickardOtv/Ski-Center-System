using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{   
    [Table("Uthyrningsrad")]
    public class Uthyrningsrad
    {
        [Key]
        public int UthyrningsradID { get; set; }

        [ForeignKey("Utrustning")]
        public string UtrustningsID { get; set; }
        public Utrustning Utrustning { get; set; }
        public DateTime Från { get; set; }
        public DateTime Till { get; set; }
        public Uthyrning Uthyrning { get; set; }
        public int UthyrningsID { get; set; }

        public Uthyrningsrad(string utrustningsID, DateTime från, DateTime till, int uthyrningsID)
        {
            UtrustningsID = utrustningsID;
            Från = från;
            Till = till;
            UthyrningsID = uthyrningsID;
        }

        public Uthyrningsrad()
        {
            
        }


    }
}
