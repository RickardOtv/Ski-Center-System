using Affärslager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class HuvudMeny : Form
    {
        private LoggaIn loggaInMeny;
        private Kontroller kontroller;
        public HuvudMeny(LoggaIn loggaInMeny, Kontroller kontroller)
        {
            this.loggaInMeny = loggaInMeny;
            this.kontroller = kontroller;
            InitializeComponent();
        }
        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {


            string inmatning = kontroller.HittaBehörighet(int.Parse(txtAnvandarnamn.Text));
            if (inmatning == "Bokare" || inmatning == "Admin")
            {
                BokningsMeny bokningsMeny = new BokningsMeny(loggaInMeny, kontroller);
                bokningsMeny.InloggadAnvandare = txtAnvandarnamn.Text;
                bokningsMeny.Show();
            }
            else
                MessageBox.Show("Du har ej rätt behörighet.");
        }

        private void lblMata_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUthyrning_Click(object sender, EventArgs e)
        {
            string inmatning = kontroller.HittaBehörighet(int.Parse(txtAnvandarnamn.Text));
            if (inmatning == "Uthyrare" || inmatning == "Bokare" || inmatning == "Admin")
            {
                MessageBox.Show("Du har åtkomst när denna rutan är klar");
            }
            else
                MessageBox.Show("Du har ej rätt behörighet.");
        }

        private void btnMarknad_Click(object sender, EventArgs e)
        {
            string inmatning = kontroller.HittaBehörighet(int.Parse(txtAnvandarnamn.Text));
            if (inmatning == "Admin")
            {
                MessageBox.Show("Du har åtkomst när denna rutan är klar");
            }
            else
                MessageBox.Show("Du har ej rätt behörighet.");
        }


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string inmatning = kontroller.HittaBehörighet(int.Parse(txtAnvandarnamn.Text));
            if (inmatning == "Admin")
            {
                MessageBox.Show("Du har åtkomst när denna rutan är klar");
            }
            else
                MessageBox.Show("Du har ej rätt behörighet.");
        }
    }
}
