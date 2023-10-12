using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    [Table("Utrustningsrad")]
    public class Uthyrningsrad
    {
        [Key]
        public int UthyrningsradID { get; set; }

        public Utrustning utrustning { get; set; }
        public string UtrustningsID { get; set; }

        public DateTime Från { get; set; }
        public DateTime Till { get; set; }

        public Bokning bokning { get; set; }
        public int BokningsID { get; set; }

        public Uthyrningsrad(string utrustningsID, DateTime från, DateTime till, int bokningsID)
        {
            UtrustningsID = utrustningsID;
            Från = från;
            Till = till;
            BokningsID = bokningsID;


        }

        public Uthyrningsrad()
        {
            
        }


    }
}
