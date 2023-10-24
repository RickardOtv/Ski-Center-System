using Affärslager;
using Datalager;
using Entitetslager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class ÄndraKund : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private LoggaIn loggaIn;
        private Kontroller kontroller;
        private Kund valdKund;
        PrivatKundMaxbelopp globalData = PrivatKundMaxbelopp.Instance;

        public ÄndraKund(LoggaIn loggaIn, Kontroller kontroller, Kund kund)
        {
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
            InitializeComponent();
            valdKund = kund;
            txtBoxKundID.Text = kund.KundID.ToString();
            txtBoxPersonNr.Text = kund.Personnummer.ToString();
            txtboxNamn.Text = kund.Namn.ToString();
            txtBoxAdress.Text = kund.Adress.ToString();
            txtBoxEmail.Text = kund.Email.ToString();
            txtBoxOrt.Text = kund.PostOrt.ToString();
            txtBoxPostNr.Text = kund.PostNr.ToString();
            txtBoxTelefonNr.Text = kund.Telefonnummer.ToString();
        }

        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }
        /// <summary>
        /// Denna metod btnSpara_Click sparar ändringar som gjorts i informationen för en kund. Den hämtar de nya värdena från textfälten för personnummer, namn, adress, e-post, postort, postnummer och telefonnummer. Sedan uppdateras kundens information med de nya värdena genom att anropa metoden ÄndraKund i kontroller med de uppdaterade värdena. Efter att ändringarna har sparats visas en bekräftelsemeddelande och fönstret stängs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpara_Click(object sender, EventArgs e)
        {
            string nyttPersonNr = txtBoxPersonNr.Text;
            string nyttNamn = txtboxNamn.Text;
            string nyAdress = txtBoxAdress.Text;
            string nyEmail = txtBoxEmail.Text;
            string nyPostOrt = txtBoxOrt.Text;
            string nyPostNr = txtBoxPostNr.Text;
            string nyTelefonNr = txtBoxTelefonNr.Text;

            valdKund.Personnummer = nyttPersonNr;
            valdKund.Namn = nyttNamn;
            valdKund.Adress = nyAdress;
            valdKund.Email = nyEmail;
            valdKund.PostOrt = nyPostOrt;
            valdKund.PostNr = nyPostNr;
            valdKund.Telefonnummer = nyTelefonNr;
            kontroller.ÄndraKund(nyttPersonNr,nyttNamn, nyTelefonNr, nyPostNr, nyPostOrt, "Privat", nyAdress, nyEmail, globalData.GlobalVariable, valdKund);
            
            MessageBox.Show("Kund uppdaterad!");
            
            this.Close();
            
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
