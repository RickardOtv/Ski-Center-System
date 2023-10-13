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
            txtBoxKredit.Text = kund.Maxbeloppskreditgräns.ToString();
            txtBoxPostNr.Text = kund.PostNr.ToString();
            txtBoxTelefonNr.Text = kund.Telefonnummer.ToString();
            cmbTyp.Text = kund.Typ.ToString();
        }

        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }
       
        private void btnSpara_Click(object sender, EventArgs e)
        {
            string nyttPersonNr = txtBoxPersonNr.Text;
            string nyttNamn = txtboxNamn.Text;
            string nyAdress = txtBoxAdress.Text;
            string nyEmail = txtBoxEmail.Text;
            string nyPostOrt = txtBoxOrt.Text;
            int nyKreditgrans = int.Parse(txtBoxKredit.Text);
            string nyPostNr = txtBoxPostNr.Text;
            string nyTelefonNr = txtBoxTelefonNr.Text;
            string nyTyp = cmbTyp.Text;

            valdKund.Personnummer = nyttPersonNr;
            valdKund.Namn = nyttNamn;
            valdKund.Adress = nyAdress;
            valdKund.Email = nyEmail;
            valdKund.PostOrt = nyPostOrt;
            valdKund.Maxbeloppskreditgräns = nyKreditgrans;
            valdKund.PostNr = nyPostNr;
            valdKund.Telefonnummer = nyTelefonNr;
            valdKund.Typ = nyTyp;
            kontroller.ÄndraKund(nyttPersonNr,nyttNamn, nyTelefonNr, nyPostNr, nyPostOrt, nyTyp, nyAdress, nyEmail, nyKreditgrans, valdKund);
            
            MessageBox.Show("Kund uppdaterad!");
            
            this.Close();
            
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
