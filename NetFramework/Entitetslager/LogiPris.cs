﻿using System;
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
        [Key, Column(Order = 1)]
        public string Typ { get; set; }
        [Key, Column(Order = 2)]
        public int Vecka { get; set; }
        public int VeckoPris { get; set; }
        public int VardagsPris { get; set; }
        public int HelgPris { get; set; }

        public LogiPris(string typ, int vecka, int veckoPris, int vardagsPris, int helgPris)
        {
            Typ = typ;
            Vecka = vecka;
            VeckoPris = veckoPris;
            VardagsPris = vardagsPris;
            HelgPris = helgPris;
        }

        public LogiPris()
        {

        }
    }
}