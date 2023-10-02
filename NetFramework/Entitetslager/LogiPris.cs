using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    [Table("LogiPris")]
    public class LogiPris
    {
        public Logi Logi { get; set; }
        public string LogiID { get; set; }
        [Key, Column(Order = 1)]
        public string Typ { get; set; }
        [Key, Column(Order = 2)]
        public int Vecka { get; set; }
        public int Pris { get; set; }

        public LogiPris(int vecka, int pris)
        {
            Vecka = vecka;
            Pris = pris;
        }

        public LogiPris() 
        {
            
        }
    }
}