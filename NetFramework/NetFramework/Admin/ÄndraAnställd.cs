using Affärslager;
using Datalager;
using Entitetslager;
using System;
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
            // Kontrollera om förnamnet är giltigt och inte tomt
            if (!kontroller.IsValidName(txtBoxFörnamn.Text) || string.IsNullOrWhiteSpace(txtBoxFörnamn.Text))
            {
                MessageBox.Show("Ange ett giltigt Förnamn", "Ogiltig Förnamn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxFörnamn.Focus();
            }
            // Kontrollera om efternamnet är giltigt och inte tomt
            else if (!kontroller.IsValidName(txtBoxEfternamn.Text) || string.IsNullOrWhiteSpace(txtBoxEfternamn.Text))
            {
                MessageBox.Show("Ange en giltig Efternamn", "Ogiltig Efternamn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxEfternamn.Focus();
            }
            // Kontrollera om lösenordet inte är tomt
            else if (string.IsNullOrWhiteSpace(txtBoxLösenord.Text))
            {
                MessageBox.Show("Ange ett giltigt Lösenord", "Ogiltig Lösenord", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxLösenord.Focus();
            }
            else
            {
                // Hämta de nya värdena från inmatningsfälten
                string nyttFörnamn = txtBoxFörnamn.Text;
                string nyttEfternamn = txtBoxEfternamn.Text;
                string nyttLösenord = txtBoxLösenord.Text;
                string nyBehörighet = cmbBehörighet.Text;

                // Uppdatera egenskaperna för den valda anställda
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
