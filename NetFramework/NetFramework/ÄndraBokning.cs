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
    public partial class ÄndraBokning : Form
    {

        UnitOfWork unitOfWork = new UnitOfWork();
        private LoggaIn loggaIn;
        private Kontroller kontroller;
        private Bokning valdBokning;

        public ÄndraBokning(LoggaIn loggaIn, Kontroller kontroller, Bokning bokning)
        {
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
            InitializeComponent();
            label_FrånDatum.Text = bokning.Från.ToString("yyyy-MM-dd");
            label_TillDatum.Text = bokning.Till.ToString("yyyy-MM-dd");
 
        }

        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }


        private void btn_Tillbaka_Click(object sender, EventArgs e)
        {
            VisaBokningar visabokningar = new VisaBokningar(loggaIn, kontroller);
            visabokningar.InloggadAnvandare = txtAnvandarnamn.Text;
            this.Close();
            visabokningar.Show();
            
        }

        private void btn_Spara_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
