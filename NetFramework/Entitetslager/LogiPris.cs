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
        [Key, Column(Order = 1)] // This is the first part of the composite key
        public string Typ { get; set; }
        [Key, Column(Order = 2)] // This is the second part of the composite key
        public string Tid { get; set; }
        public int V51 { get; set; }
        public int V52 { get; set; }
        public int V1 { get; set; }
        public int V2 { get; set; }
        public int V3 { get; set; }
        public int V4 { get; set; }
        public int V5 { get; set; }
        public int V6 { get; set; }
        public int V7 { get; set; }
        public int V8 { get; set; }
        public int V9 { get; set; }
        public int V10 { get; set; }
        public int V11 { get; set; }
        public int V12 { get; set; }
        public int V13 { get; set; }
        public int V1422 { get; set; }
        public int V2350 { get; set; }


        public LogiPris(string typ, string tid, int v51, int v52, int v1, int v2, int v3, int v4, int v5, int v6, int v7, int v8, int v9, int v10, int v11, int v12, int v13, int v1422, int v2350)
        {
            Typ = typ;
            Tid = tid;
            V51 = v51;
            V52 = v52;
            V1 = v1;
            V2 = v2;
            V3 = v3;
            V4 = v4;
            V5 = v5;
            V6 = v6;
            V7 = v7;
            V8 = v8;
            V9 = v9;
            V10 = v10;
            V11 = v11;
            V12 = v12;
            V13 = v13;
            V1422 = v1422;
            V2350 = v2350;
        }
        public LogiPris() 
        {
            
        }
    }
}
