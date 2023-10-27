using Affärslager;
using Datalager;
using Entitetslager;
using System;
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

        //Sparar den nya infromationen om kund
        private void btnSpara_Click(object sender, EventArgs e)
        {
            //Kollar så att inmatning matchar rätt format
            if ((txtBoxPersonNr.Text == "Personnummer: (YYYYMMDDXXXX)") | (txtboxNamn.Text == "Namn:") | (txtBoxTelefonNr.Text == "Telefonnummer:") | (txtBoxEmail.Text == "Email:") | (txtBoxAdress.Text == "Adress:") | (txtBoxOrt.Text == "Postort:"))
            {
                MessageBox.Show("Fyll i alla rader tack!");
            }
            else if (!kontroller.IsValidEmail(txtBoxEmail.Text))
            {
                MessageBox.Show("Ange en giltig e-postadress.", "Ogiltig Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxEmail.Focus();
                return;
            }
            else if (!kontroller.IsValidSwedishSSN(txtBoxPersonNr.Text))
            {
                MessageBox.Show("Ange ett giltigt PersonNr", "Ogiltig PersonNr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxPersonNr.Focus();
            }
            else if (!kontroller.IsValidName(txtboxNamn.Text))
            {
                MessageBox.Show("Ange ett giltigt Namn", "Ogiltig Namn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxNamn.Focus();
            }
            else if (!kontroller.IsValidAddress(txtBoxAdress.Text))
            {
                MessageBox.Show("Ange en giltig adress", "Ogiltig Adress", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxAdress.Focus();
            }
            else if (!kontroller.IsValidPhoneNumber(txtBoxTelefonNr.Text))
            {
                MessageBox.Show("Ange ett giltigt TelefonNr", "Ogiltigt TelefonNr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxTelefonNr.Focus();
            }
            else if (!kontroller.IsValidName(txtBoxOrt.Text))
            {
                MessageBox.Show("Ange ett giltigt Postort", "Ogiltigt Postort", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxOrt.Focus();
            }
            else if (!kontroller.IsValidPostalCode(txtBoxPostNr.Text))
            {
                MessageBox.Show("Ange ett giltigt Postnr", "Ogiltigt Postnr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxPostNr.Focus();
            }
            else //Om inmatning matchar rätt format
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
                kontroller.ÄndraKund(nyttPersonNr, nyttNamn, nyTelefonNr, nyPostNr, nyPostOrt, "Privat", nyAdress, nyEmail, globalData.GlobalVariable, valdKund);

                MessageBox.Show("Kund uppdaterad!");
                this.Close();
            }  
        }

        //Knapp för att gå tillbaka
        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
