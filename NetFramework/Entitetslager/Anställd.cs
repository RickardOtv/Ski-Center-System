﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    [Table("Anställd")]
    public class Anställd
    {
        [Key]
        public int AnställningsNr { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Användarnamn { get; set; }
        public string Lösenord { get; set; }
        public string Behörighet { get; set; }


        public Anställd(string förnamn, string efternamn, string lösenord, string behörighet)
        {
            Förnamn = förnamn;
            Efternamn = efternamn;
            Lösenord = lösenord;
            Behörighet = behörighet;
        }
        public bool VerifieraLösenord(string given)
        {
            return Lösenord == given;
        }

        public Anställd()
        {

        }
    }
}