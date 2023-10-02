using Affärslager;
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
    public partial class BokningNyKund : Form
    {
        private Kontroller kontroller;
        private LoggaIn loggaIn;

        public BokningNyKund(LoggaIn loggaIn, Kontroller kontroller)
        {
            InitializeComponent();
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
        }
      /*  public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }
      */
        private void btnGaVidare_Click(object sender, EventArgs e)
        {
            string personnummer = txtBoxPersonNr.Text;
            string namn = txtboxNamn.Text;
            string telefonnummer = txtBoxTelefonNr.Text;
            string email = txtBoxEmail.Text;
            string adress = txtBoxAdress.Text;
            string postNr = txtBoxPostNr.Text;
            string postOrt = txtBoxOrt.Text;
            string typ = txtBoxTyp.Text;
            int maxbeloppskreditgräns = int.Parse(txtBoxKredit.Text);

            Kund nyKund = kontroller.SkapaNyKund(personnummer, namn, telefonnummer, email, adress, postNr, postOrt, typ, maxbeloppskreditgräns);
            MessageBox.Show($"Ny kund skapad!\n Namn: {nyKund.Namn}\n Personnummer: {nyKund.Personnummer}\n kredit: {nyKund.Maxbeloppskreditgräns}");

            //MessageBox.Show($"Från: {nyBokning.Från.ToShortDateString()} \nTill: {nyBokning.Till.ToShortDateString()} \n Vald logi: {nyBokning.Logi.LogiID}




        }


        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region EnterLeaves

        private void txtboxPersonNr_Enter(object sender, EventArgs e)
        {
            TextBox txtBoxPersonNr = (TextBox)sender;
            if (txtBoxPersonNr.Text == "Personnummer:")
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
                textBox.Text = "Personnummer:";
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
        private void txtBoxTyp_Enter(object sender, EventArgs e)
        {
            TextBox txtBoxTyp = (TextBox)sender;
            if (txtBoxTyp.Text == "Privat/företag:")
            {
                txtBoxTyp.Text = "";
                txtBoxTyp.ForeColor = SystemColors.WindowText; // Återställ textfärg om den har ändrats
            }
        }

        private void textBoxTyp_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Privat/företag:";
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
