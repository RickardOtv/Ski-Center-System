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
        
        
    }
}
