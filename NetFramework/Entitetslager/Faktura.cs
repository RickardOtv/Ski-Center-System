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
        public int Moms { get; set; }
        public int Rabattsats { get; set; }
        public int TotalPris { get; set; }

        [Required]
        public Bokning BokningsID { get; set; }

        public Faktura(int fakturaID, int moms, int rabattsats, int totalpris)
        {
            FakturaID = fakturaID;
            Moms = moms;
            Rabattsats = rabattsats;
            TotalPris = totalpris;
        }

        public Faktura()
        {
            
        }
    }
}
