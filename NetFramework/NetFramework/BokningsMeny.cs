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
    public partial class BokningsMeny : Form
    {
        //private HuvudMeny huvudMeny;
        private Kontroller kontroller;
        private HuvudMeny huvudMeny;
        private LoggaIn loggaIn;

        public BokningsMeny(HuvudMeny huvudMeny, Kontroller kontroller)
        {
            InitializeComponent();
           this.huvudMeny = huvudMeny;
           this.kontroller = kontroller;
        }
        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }

        private void btnVisaBokning_Click(object sender, EventArgs e)
        {
            Bokningcs bokningscs = new Bokningcs();
            bokningscs.Show();
        }

        private void btnLediga_Click(object sender, EventArgs e)
        {

        }

        private void btnBokning_Click(object sender, EventArgs e)
        {

        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
           // HuvudMeny huvudMeny = new HuvudMeny();
        }
    }
}
