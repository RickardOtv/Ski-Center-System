using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitetslager
{
    public class Privatperson : Kund
    {
        public int PersonNummer { get; set; }
        public string Namn { get; set; }

        public Privatperson(int personNummer, string namn)
        {
            PersonNummer = personNummer;
            Namn = namn;
        }


        public Privatperson()
        {
            
        }
    }
}
