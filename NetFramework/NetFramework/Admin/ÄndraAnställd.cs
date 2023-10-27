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
    public partial class ÄndraAnställd : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private LoggaIn loggaIn;
        private Kontroller kontroller;
        private Anställd valdAnställd;

        public ÄndraAnställd(LoggaIn loggaIn, Kontroller kontroller, Anställd anställd)
        {
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
            InitializeComponent();
            txtBoxAnställningsNr.Text = anställd.AnställningsNr.ToString();
            valdAnställd = anställd;
            txtBoxFörnamn.Text = anställd.Förnamn.ToString();
            txtBoxEfternamn.Text = anställd.Efternamn.ToString();
            txtBoxLösenord.Text = anställd.Lösenord.ToString();
            cmbBehörighet.Text = anställd.Behörighet.ToString();

        }

        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }
        private void btnSpara_Click(object sender, EventArgs e)
        {
            if (!kontroller.IsValidName(txtBoxFörnamn.Text) || string.IsNullOrWhiteSpace(txtBoxFörnamn.Text))
            {
                MessageBox.Show("Ange ett giltigt Förnamn", "Ogiltig Förnamn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxFörnamn.Focus();
            }
            else if (!kontroller.IsValidName(txtBoxEfternamn.Text) || string.IsNullOrWhiteSpace(txtBoxEfternamn.Text))
            {
                MessageBox.Show("Ange en giltig Efternamn", "Ogiltig Efternamn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxEfternamn.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtBoxLösenord.Text))
            {
                MessageBox.Show("Ange en giltig Lösenord", "Ogiltig Lösenord", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxLösenord.Focus();
            }
            else
            {
                string nyttFörnamn = txtBoxFörnamn.Text;
                string nyttEfternamn = txtBoxEfternamn.Text;
                string nyttLösenord = txtBoxLösenord.Text;
                string nyBehörighet = cmbBehörighet.Text;

                valdAnställd.Förnamn = nyttFörnamn;
                valdAnställd.Efternamn = nyttEfternamn;
                valdAnställd.Lösenord = nyttLösenord;
                valdAnställd.Behörighet = nyBehörighet;

                kontroller.ÄndraAnställd(nyttFörnamn, nyttEfternamn, nyttLösenord, nyBehörighet, valdAnställd);

                MessageBox.Show("Anställd uppdaterad!");

                this.Close();
            }
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
