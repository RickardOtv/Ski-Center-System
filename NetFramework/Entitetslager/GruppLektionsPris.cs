using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Entitetslager
{
    [Table("GruppLektionsPris")]
    public class GruppLektionsPris
    {
        [Key]
        public string Grupp { get; set; }

        public int MåndagTillOnsdagPris { get; set; }
        public int TorsdagTillFredagPris { get; set; }
        public int PrivatPris { get; set; }

        public GruppLektionsPris(int måndagTillOnsdagPris, int torsdagTillFredagPris, int privatPris)
        {
            MåndagTillOnsdagPris = måndagTillOnsdagPris;
            TorsdagTillFredagPris = torsdagTillFredagPris;
            PrivatPris = privatPris;
        }

        public GruppLektionsPris()
        {
            
        }
    }
}
