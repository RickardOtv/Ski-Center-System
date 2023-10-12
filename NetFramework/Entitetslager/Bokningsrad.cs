﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    [Table("Bokningsrad")]
    public class Bokningsrad
    {
        [Key]
        public int BokningsradID { get; set; }

        public Logi logi { get; set; }
        [ForeignKey("Logi")]
        public int LogiID { get; set; }

        public Bokning bokning { get; set; }
        public DateTime Från { get; set; }
        public DateTime Till { get; set; }
        public int BokningsID { get;set; }

       

        public Bokningsrad(int logiID, DateTime från, DateTime till, int bokningsID)
        {
            LogiID = logiID;
            Från = från;
            Till = till;
            BokningsID = bokningsID;
        }

        public Bokningsrad()
        {

        }


    }
}
