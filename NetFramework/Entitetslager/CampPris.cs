﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    [Table("CampPris")]
    public class CampPris
    {
        [Key, Column(Order = 1)]
        public string Typ { get; set; }
        [Key, Column(Order = 2)]
        public int Vecka { get; set; }
        public int VeckoPris { get; set; }
        public int DygnsPris { get; set; }

        public CampPris(string typ, int vecka, int veckoPris, int dygnsPris)
        {
            Typ = typ;
            Vecka = vecka;
            VeckoPris = veckoPris;
            DygnsPris = dygnsPris;
        }

        public CampPris() { }

    }
}
