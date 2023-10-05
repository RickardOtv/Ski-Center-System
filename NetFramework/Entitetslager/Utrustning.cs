using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    [Table("Utrustning")]
    public class Utrustning
    {
        [Key]
        public string UtrustningsID { get; set; }
        public string Typ { get; set; }

        public int Storlek { get; set; }

        public Utrustning(string utrustningsID, string typ, int storlek)
        {
            UtrustningsID = utrustningsID;
            Typ = typ;
            Storlek = storlek;
        }

        public Utrustning()
        {

        }
    }
}
