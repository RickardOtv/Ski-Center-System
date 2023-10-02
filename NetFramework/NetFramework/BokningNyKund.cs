using Affärslager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            BokningsTyp bokningsTyp = new BokningsTyp(loggaIn, kontroller);
            bokningsTyp.Show();
        }

        
        /*
        private void txtboxPersonNr_Enter(object sender, EventArgs e)
        {
            TextBox txtboxPersonNr = (TextBox)sender;
            if (txtboxPersonNr.Text == "Personnummer:")
            {
                txtboxPersonNr.Text = "";
                txtboxPersonNr.ForeColor = SystemColors.WindowText; // Återställ textfärg om den har ändrats
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
            if (txtboxNamn.Text == "Personnummer:")
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
                textBox.Text = "Personnummer:";
                textBox.ForeColor = SystemColors.GrayText; // Ändra textfärg till grå om ingen text har matats in
            }
        }
        */
        private void TxtBox_EnterLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox txtboxPersonNr = (System.Windows.Forms.TextBox)sender;
            if (txtboxPersonNr.Text == "Personnummer:")
            {
                txtboxPersonNr.Text = "";
                txtboxPersonNr.ForeColor = SystemColors.WindowText; 
            }
            else if(string.IsNullOrWhiteSpace(txtboxPersonNr.Text))
            {
                txtboxPersonNr.Text = "Personnummer:";
                txtboxPersonNr.ForeColor = SystemColors.GrayText; 
            }
            System.Windows.Forms.TextBox txtboxNamn = (System.Windows.Forms.TextBox)sender;
            if (txtboxNamn.Text == "Personnummer:")
            {
                txtboxNamn.Text = "";
                txtboxNamn.ForeColor = SystemColors.WindowText; 
            }
            else if (string.IsNullOrWhiteSpace(txtboxNamn.Text))
            {
                txtboxNamn.Text = "Namn";
                txtboxNamn.ForeColor = SystemColors.GrayText; 
            }
        }
    }
}
