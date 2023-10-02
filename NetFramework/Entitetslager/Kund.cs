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
        public int KundID { get; set; }
        public string Typ { get; set; }
        public int Maxbeloppskreditgräns { get; set; }
        public string Adress { get; set; }
        public string PostOrt { get; set; }
        public string PostNr { get; set; }
        public string Personnummer { get; set; }
        public string Namn { get; set; }
        public string Telefonnummer { get; set; }
        public string Email { get; set; }


        public Kund(string personnummer, string namn, string telefonnummer, string email, string adress, string postNr, string postOrt, string typ, int maxbeloppskreditgräns)
        {
            Personnummer = personnummer;
            Namn = namn;
            Telefonnummer = telefonnummer;
            Email = email;
            Adress = adress;
            PostNr = postNr;
            PostOrt = postOrt;
            Typ = typ;
            Maxbeloppskreditgräns = maxbeloppskreditgräns;
            
        }
        
        public Kund() { }
    }
}
