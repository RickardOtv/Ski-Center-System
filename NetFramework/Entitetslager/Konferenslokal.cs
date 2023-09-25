using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    public class Konferenslokal
    {
        [Key]
        public int KonferensID { get; set; }
        public string Typ { get; set; }
        public bool IsAvailable { get; set; }


        public Konferenslokal(int konferensID, string typ, bool isAvailable)
        {
            KonferensID = konferensID;
            Typ = typ;
            IsAvailable = isAvailable;

        }

        public Konferenslokal()
        {
            
        }
    }
}
