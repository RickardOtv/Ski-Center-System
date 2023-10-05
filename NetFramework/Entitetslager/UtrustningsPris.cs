using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    [Table("UtrustningsPris")]
    public class UtrustningsPris
    {
        [Key, Column(Order = 1)]
        public string Typ { get; set; }
        public int EnDagsPris { get; set; }
        public int TvåDagsPris { get; set; }
        public int TreDagsPris { get; set; }
        public int FyrDagsPris { get; set; }
        public int FemDagsPris { get; set; }
        public UtrustningsPris(string typ, int enDagsPris, int tvåDagsPris, int treDagsPris, int fyrDagsPris, int femDagsPris)
        {
            Typ = typ;
            EnDagsPris = enDagsPris;
            TvåDagsPris = tvåDagsPris;
            TreDagsPris = treDagsPris;
            FyrDagsPris = fyrDagsPris;
            FemDagsPris = femDagsPris;
        }
        public UtrustningsPris() { }
    }
}
