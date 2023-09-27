using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    public class Kund
    {
        [Key]
        public int KundID { get; set; }
        public string Adress { get; set; }
        public string PostOrt { get; set; }
        public string Telefonnummer { get; set; }
        public string Email { get; set; }

        public Kund(int kundID, string adress, string postOrt, string telefonnummer, string email)
        {
            KundID = kundID;
            Adress = adress;
            PostOrt = postOrt;
            Telefonnummer = telefonnummer;
            Email = email;
        }

        public Kund()
        {
            
        }
    }
}