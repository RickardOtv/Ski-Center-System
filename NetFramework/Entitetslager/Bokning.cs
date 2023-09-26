using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    public class Bokning
    {
        [Key]
        public int BokningsID { get; set; }



        // en massa FK´s, detta får vi titta på
        public Uthyrning UthyrningsID { get; set; }

        public Kund KundID { get; set; }

        public Logi LogiID { get; set; }

        


        public Konferenslokal KonferensID { get; set; }

        public Skidlektion LektionsID { get; set; }

        public Faktura FakturaID { get; set; }




        public DateTime Från { get; set; }
        public DateTime Till { get; set; }

        public Bokning(int bokningsID, DateTime från, DateTime till)
        {
            BokningsID = bokningsID;
            Från = från;
            Till = till;
        }


        public Bokning()
        {

        }
    }
}
