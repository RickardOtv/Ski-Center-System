using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    [Table("Kund")]
    public class Kund
    {
        [Key]
        public int KundID {  get; set; }
        public string Typ {  get; set; }
        public int Maxbeloppskreditgräns {  get; set; }
        public string Adress {  get; set; }
        public string Namn {  get; set; }
        public string Telefonnummer { get; set; }
        public string Email { get; set; }


        public Kund(int kundID, string typ, int maxbeloppskreditgräns, string adress, string namn, string telefonnummer, string email)
        {
            KundID = kundID;
            Typ = typ;
            Maxbeloppskreditgräns = maxbeloppskreditgräns;
            Adress = adress;
            Namn = namn;
            Telefonnummer = telefonnummer;
            Email = email;
        }
    }
}
