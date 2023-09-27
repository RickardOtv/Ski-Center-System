using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    public class Utrustning
    {
        [Key]
        public string UtrustningsID { get; set; }
        public string Typ { get; set; }

        public int Storlek { get; set; }

        public bool isAvailable { get; set; }

        public Utrustning(string utrustningsID, string typ, int storlek, bool isAvailable)
        {
            UtrustningsID = utrustningsID;
            Typ = typ;
            Storlek = storlek;
            this.isAvailable = isAvailable;
        }

        public Utrustning()
        {
            
        }
    }
}
