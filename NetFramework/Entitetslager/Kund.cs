using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    public class Kund
    {
        [Key]
        public int KundID { get; set; }
        public string Adress { get; set; }

       // public Bokning BokningsID { get; set; }


        public int MyProperty { get; set; }

        public Kund(int kundID, string adress/* Bokning bokningsID*/)
        {
            KundID = kundID;
            Adress = adress;
           // BokningsID = bokningsID;
        }

        public Kund()
        {
            
        }
    }
}
