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
        

       


        private void btnKundregister_Click(object sender, EventArgs e)
        {
            Kundregister kundregister = new Kundregister(loggaInMeny, kontroller);
            kundregister.InloggadAnvandare = txtAnvandarnamn.Text;
            kundregister.Show();
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
                AdminMeny adminMeny = new AdminMeny(loggaInMeny, kontroller);
                adminMeny.InloggadAnvandare = txtAnvandarnamn.Text;
                adminMeny.Show();
                
                
            }
            else
                MessageBox.Show("Du har ej rätt behörighet.");
        }

        private void btnUthyrning_Click(object sender, EventArgs e)
        {
            string inmatning = kontroller.HittaBehörighet(int.Parse(txtAnvandarnamn.Text));
            if (inmatning == "Uthyrare" || inmatning == "Bokare" || inmatning == "Admin")
            {
                UthyrningsMeny uthyrningsMeny = new UthyrningsMeny(loggaInMeny, kontroller);
                uthyrningsMeny.InloggadAnvandare = txtAnvandarnamn.Text;
                uthyrningsMeny.Show();

                //MessageBox.Show("Du har åtkomst när denna rutan är klar");
            }
            else
                MessageBox.Show("Du har ej rätt behörighet.");
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

        private void btnLoggaUt_Click(object sender, EventArgs e)
        {
            this.Close();
            LoggaIn loggaIn = new LoggaIn();
            loggaIn.Show();
        }
    }
}
