using Affärslager;
using System;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class BokningsTyp : Form
    {
        private LoggaIn loggaIn;
        private Kontroller kontroller;
        public BokningsTyp(LoggaIn loggaIn, Kontroller kontroller)
        {
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
            InitializeComponent();
        }
        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }

        //Forsätt med bokning för en befintlig kund
        private void btnBefintlig_Click(object sender, EventArgs e)
        {
            BokningBefintligKund befintligKund = new BokningBefintligKund(loggaIn, kontroller);
            befintligKund.Show();
            befintligKund.InloggadAnvandare = txtAnvandarnamn.Text;
            this.Close();
        }

        //Registrera en ny privat kund först
        private void btnNyKund_Click(object sender, EventArgs e)
        {
            BokningNyKund nyKund = new BokningNyKund(loggaIn, kontroller);
            nyKund.Show();
            nyKund.InloggadAnvandare = txtAnvandarnamn.Text;
            this.Close();
        }

        //Gå tillbaka
        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
