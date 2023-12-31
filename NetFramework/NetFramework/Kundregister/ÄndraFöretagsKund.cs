﻿using Affärslager;
using Datalager;
using Entitetslager;
using System;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class ÄndraFöretagsKund : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private LoggaIn loggaIn;
        private Kontroller kontroller;
        private Kund valdKund;
        int result;

        public ÄndraFöretagsKund(LoggaIn loggaIn, Kontroller kontroller, Kund kund)
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
        }

        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }

        //Knapp för att gå tillbaka
        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Sparar ändringar gjord på kund
        private void btnSpara_Click(object sender, EventArgs e)
        {
            //Kollar så att inmattningar matchar rätt format
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
            else if (!int.TryParse(txtBoxKredit.Text, out result))
            {
                MessageBox.Show("Ange en giltigt Kreditgräns", "Ogiltigt Kreditgräns", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxKredit.Focus();
            }
            else //Om inmatning matchade rätt format
            {
                string nyttPersonNr = txtBoxPersonNr.Text;
                string nyttNamn = txtboxNamn.Text;
                string nyAdress = txtBoxAdress.Text;
                string nyEmail = txtBoxEmail.Text;
                string nyPostOrt = txtBoxOrt.Text;
                int nyKreditgrans = int.Parse(txtBoxKredit.Text);
                string nyPostNr = txtBoxPostNr.Text;
                string nyTelefonNr = txtBoxTelefonNr.Text;

                valdKund.Personnummer = nyttPersonNr;
                valdKund.Namn = nyttNamn;
                valdKund.Adress = nyAdress;
                valdKund.Email = nyEmail;
                valdKund.PostOrt = nyPostOrt;
                valdKund.Maxbeloppskreditgräns = nyKreditgrans;
                valdKund.PostNr = nyPostNr;
                valdKund.Telefonnummer = nyTelefonNr;
                kontroller.ÄndraKund(nyttPersonNr, nyttNamn, nyTelefonNr, nyPostNr, nyPostOrt, "Företag", nyAdress, nyEmail, nyKreditgrans, valdKund);

                MessageBox.Show("Kund uppdaterad!");
                this.Close();
            }
        }
    }
}
