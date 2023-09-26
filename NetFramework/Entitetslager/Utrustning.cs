﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    public class Utrustning
    {
        [Key]
        public int UtrustningsID { get; set; }
        public string Typ { get; set; }

        public string Storlek { get; set; }

        public Utrustning(int utrustningsID, string typ, string storlek)
        {
            UtrustningsID = utrustningsID;
            Typ = typ;
            Storlek = storlek;
        }

        public Utrustning()
        {
            
        }
    }
}