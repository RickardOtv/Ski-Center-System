using Affärslager;
using Entitetslager;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace NetFramework
{
    public partial class BokningNyKund : Form
    {
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        PrivatKundMaxbelopp globalData = PrivatKundMaxbelopp.Instance;

        public BokningNyKund(LoggaIn loggaIn, Kontroller kontroller)
        {
            InitializeComponent();
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
        }

        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }

        //Skapar en ny kund
        private void btnGaVidare_Click(object sender, EventArgs e)
        {
            //Kollar så att alla textboxes är inmatade korrekt
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
            else // Om alla boxes är skrivna korrekt så skapas kunden
            {

                string personnummer = txtBoxPersonNr.Text;
                string namn = txtboxNamn.Text;
                string telefonnummer = txtBoxTelefonNr.Text;
                string email = txtBoxEmail.Text;
                string adress = txtBoxAdress.Text;
                string postNr = txtBoxPostNr.Text;
                string postOrt = txtBoxOrt.Text;

                Kund nyKund = kontroller.SkapaNyKund(personnummer, namn, telefonnummer, email, adress, postNr, postOrt, "Privat", globalData.GlobalVariable);
                MessageBox.Show($"Ny kund skapad!\n Namn: {nyKund.Namn}\n Personnummer: {nyKund.Personnummer}\n kredit: {nyKund.Maxbeloppskreditgräns}");
                BokningBefintligKund befintligKund = new BokningBefintligKund(loggaIn, kontroller);
                this.Close();
                befintligKund.Show();
            }
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            BokningsTyp bokningsTyp = new BokningsTyp(loggaIn, kontroller);
            bokningsTyp.Show();
            bokningsTyp.InloggadAnvandare = txtAnvandarnamn.Text;
            this.Close();
        }

        #region EnterLeaves

        private void txtboxPersonNr_Enter(object sender, EventArgs e)
        {
            TextBox txtBoxPersonNr = (TextBox)sender;
            if (txtBoxPersonNr.Text == "Personnummer: (YYYYMMDDXXXX)")
            {
                txtBoxPersonNr.Text = "";
                txtBoxPersonNr.ForeColor = SystemColors.WindowText; // Återställ textfärg om den har ändrats
            }
        }
        private void txtboxPersonNr_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Personnummer: (YYYYMMDDXXXX)";
                textBox.ForeColor = SystemColors.GrayText; // Ändra textfärg till grå om ingen text har matats in
            }
        }

        private void textBoxNamn_Enter(object sender, EventArgs e)
        {
            TextBox txtboxNamn = (TextBox)sender;
            if (txtboxNamn.Text == "Namn:")
            {
                txtboxNamn.Text = "";
                txtboxNamn.ForeColor = SystemColors.WindowText; // Återställ textfärg om den har ändrats
            }
        }
        private void textBoxNamn_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Namn:";
                textBox.ForeColor = SystemColors.GrayText; // Ändra textfärg till grå om ingen text har matats in
            }
        }
        private void txtBoxEmail_Enter(object sender, EventArgs e)
        {

            TextBox txtBoxEmail = (TextBox)sender;
            if (txtBoxEmail.Text == "Email:")
            {
                txtBoxEmail.Text = "";
                txtBoxEmail.ForeColor = SystemColors.WindowText; // Återställ textfärg om den har ändrats
            }

        }
        private void txtBoxEmail_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Email:";
                textBox.ForeColor = SystemColors.GrayText; // Ändra textfärg till grå om ingen text har matats in
            }
        }
        private void txtBoxPostNr_Enter(object sender, EventArgs e)
        {
            TextBox txtBoxNamn = (TextBox)sender;
            if (txtBoxPostNr.Text == "Postnummer:")
            {
                txtBoxPostNr.Text = "";
                txtBoxPostNr.ForeColor = SystemColors.WindowText; // Återställ textfärg om den har ändrats
            }
        }
        private void textBoxPostNr_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Postnummer:";
                textBox.ForeColor = SystemColors.GrayText; // Ändra textfärg till grå om ingen text har matats in
            }
        }

        private void txtBoxTelefonNr_Enter(object sender, EventArgs e)
        {
            TextBox txtBoxTelefonNr = (TextBox)sender;
            if (txtBoxTelefonNr.Text == "Telefonnummer:")
            {
                txtBoxTelefonNr.Text = "";
                txtBoxTelefonNr.ForeColor = SystemColors.WindowText; // Återställ textfärg om den har ändrats
            }
        }
        private void txtBoxTelefonNr_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Telefonnummer:";
                textBox.ForeColor = SystemColors.GrayText; // Ändra textfärg till grå om ingen text har matats in
            }
        }
        private void txtBoxAdress_Enter(object sender, EventArgs e)
        {
            TextBox txtBoxAdress = (TextBox)sender;
            if (txtBoxAdress.Text == "Adress:")
            {
                txtBoxAdress.Text = "";
                txtBoxAdress.ForeColor = SystemColors.WindowText; // Återställ textfärg om den har ändrats
            }
        }
        private void txtBoxAdress_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Adress:";
                textBox.ForeColor = SystemColors.GrayText; // Ändra textfärg till grå om ingen text har matats in
            }
        }

        private void txtBoxOrt_Enter(object sender, EventArgs e)
        {
            TextBox txtBoxOrt = (TextBox)sender;
            if (txtBoxOrt.Text == "Postort:")
            {
                txtBoxOrt.Text = "";
                txtBoxOrt.ForeColor = SystemColors.WindowText; // Återställ textfärg om den har ändrats
            }
        }
        private void txtBoxOrt_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Postort:";
                textBox.ForeColor = SystemColors.GrayText; // Ändra textfärg till grå om ingen text har matats in
            }
        }

        private void txtBoxKredit_Enter(object sender, EventArgs e)
        {
            TextBox txtBoxKredit = (TextBox)sender;
            if (txtBoxKredit.Text == "Kreditgräns:")
            {
                txtBoxKredit.Text = "";
                txtBoxKredit.ForeColor = SystemColors.WindowText; // Återställ textfärg om den har ändrats
            }
        }
        private void txtBoxKredit_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Kreditgräns:";
                textBox.ForeColor = SystemColors.GrayText; // Ändra textfärg till grå om ingen text har matats in
            }
        }
    }
    #endregion
}
