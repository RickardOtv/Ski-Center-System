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
    public partial class SkapaAnställd : Form
    {
        private Kontroller kontroller;
        private LoggaIn loggaIn;

        public SkapaAnställd(LoggaIn loggaIn, Kontroller kontroller)
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


        private void btnSpara_Click(object sender, EventArgs e)
        {
            if ((txtBoxFörnamn.Text == "Förnamn:") | (txtBoxEfternamn.Text == "Efternamn:") | (txtBoxLösenord.Text == "Lösenord:") | string.IsNullOrEmpty((string)cmbBehörighet.SelectedItem))
            {
                MessageBox.Show("Fyll i alla rader tack!");
            }
            else if (!kontroller.IsValidName(txtBoxFörnamn.Text))
            {
                MessageBox.Show("Ange ett giltigt Förnamn", "Ogiltig Förnamn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxFörnamn.Focus();
            }
            else if (!kontroller.IsValidName(txtBoxEfternamn.Text))
            {
                MessageBox.Show("Ange en giltig Efternamn", "Ogiltig Efternamn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxEfternamn.Focus();
            }
            else
            {
                string förnamn = txtBoxFörnamn.Text;
                string efternamn = txtBoxEfternamn.Text;
                string lösenord = txtBoxLösenord.Text;
                string behörighet = cmbBehörighet.Text;

                Anställd nyAnställd = kontroller.SkapaNyAnställd(förnamn, efternamn, lösenord, behörighet);
                MessageBox.Show($"Ny Anställd skapad!\n Namn: {nyAnställd.Förnamn} {nyAnställd.Efternamn}\n AnställningsNr: {nyAnställd.AnställningsNr}\n Behörighet: {nyAnställd.Behörighet}");
                this.Close();
            }

        }

        private void txtBoxFörnamn_Enter(object sender, EventArgs e)
        {
            TextBox txtBoxFörnamn = (TextBox)sender;
            if (txtBoxFörnamn.Text == "Förnamn:")
            {
                txtBoxFörnamn.Text = "";
                txtBoxFörnamn.ForeColor = SystemColors.WindowText; // Återställ textfärg om den har ändrats
            }
        }
        private void txtBoxFörnamn_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Förnamn:";
                textBox.ForeColor = SystemColors.GrayText; // Ändra textfärg till grå om ingen text har matats in
            }
        }

        private void txtBoxEfternamn_Enter(object sender, EventArgs e)
        {
            TextBox txtBoxEfternamn = (TextBox)sender;
            if (txtBoxEfternamn.Text == "Efternamn:")
            {
                txtBoxEfternamn.Text = "";
                txtBoxEfternamn.ForeColor = SystemColors.WindowText; // Återställ textfärg om den har ändrats
            }
        }
        private void txtBoxEfternamn_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Efternamn:";
                textBox.ForeColor = SystemColors.GrayText; // Ändra textfärg till grå om ingen text har matats in
            }
        }
        private void txtBoxLösenord_Enter(object sender, EventArgs e)
        {

            TextBox txtBoxLösenord = (TextBox)sender;
            if (txtBoxLösenord.Text == "Lösenord:")
            {
                txtBoxLösenord.Text = "";
                txtBoxLösenord.ForeColor = SystemColors.WindowText; // Återställ textfärg om den har ändrats
            }

        }
        private void txtBoxLösenord_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Lösenord:";
                textBox.ForeColor = SystemColors.GrayText; // Ändra textfärg till grå om ingen text har matats in
            }
        }



        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
