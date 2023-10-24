using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    [Table("Faktura")]
    public class Faktura
    {
        [Key]

        public int FakturaID { get; set; }
        public int Momsats { get; set; }
        public int Rabattsats { get; set; }
        public float TotalPris { get; set; }
        [ForeignKey("Bokning")]
        public int BokningsID { get; set; }
        public Bokning Bokning { get; set; }
        

        public Faktura(int bokningsID, int moms, int rabattsats, float totalpris)
        {
            BokningsID = bokningsID;
            Momsats = moms;
            Rabattsats = rabattsats;
            TotalPris = totalpris;
        }

        public Faktura()
        {

        }
    }
}
