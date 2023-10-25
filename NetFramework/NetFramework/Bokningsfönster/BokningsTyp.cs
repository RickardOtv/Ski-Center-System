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

        private void btnBefintlig_Click(object sender, EventArgs e)
        {
            BokningBefintligKund befintligKund = new BokningBefintligKund(loggaIn, kontroller);
            befintligKund.Show();
            befintligKund.InloggadAnvandare = txtAnvandarnamn.Text;
            this.Close();
        }

        private void btnNyKund_Click(object sender, EventArgs e)
        {
            BokningNyKund nyKund = new BokningNyKund(loggaIn, kontroller);
            nyKund.Show();
            nyKund.InloggadAnvandare = txtAnvandarnamn.Text;
            this.Close();
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
