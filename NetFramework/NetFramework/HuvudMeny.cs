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
            InitializeComponent();
            this.loggaInMeny = loggaInMeny;
            this.kontroller = kontroller;

        }
        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BokningsMeny bokningsMeny = new BokningsMeny(this, kontroller);
            bokningsMeny.InloggadAnvandare = txtAnvandarnamn.Text;
            bokningsMeny.Show();
        }

        private void lblMata_Click(object sender, EventArgs e)
        {

        }
    }
}
