using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    public class Faktura
    {
        [Key]

        public int FakturaID { get; set; }
        public int Momsats { get; set; }
        public int Rabattsats { get; set; }
        public float TotalPris { get; set; }
        public Bokning Bokning { get; set; }
        public int BokningsID { get; set; }

        public Faktura(int fakturaID, int moms, int rabattsats, float totalpris)
        {
            FakturaID = fakturaID;
            Momsats = moms;
            Rabattsats = rabattsats;
            TotalPris = totalpris;
        }

        public Faktura()
        {
            
        }
    }
}
