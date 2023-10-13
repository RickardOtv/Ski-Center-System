using System;
using Affärslager;
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
    public partial class SkapaUthyrning : Form
    {
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        public SkapaUthyrning(LoggaIn loggain, Kontroller kontroller)
        {
            InitializeComponent();
            this.loggaIn = loggain;
            this.kontroller = kontroller;
        }
        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }

        private void btnTillbaka_Click_1(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
