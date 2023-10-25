using Affärslager;
using NetFramework.Marknadsfönster;
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
    public partial class MarknadsMeny : Form
    {
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        public MarknadsMeny(LoggaIn loggaIn, Kontroller kontroller)
        {
            InitializeComponent();
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
        }

        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVisaStatistik_Click(object sender, EventArgs e)
        {
            VisaStatistik visaStatistik = new VisaStatistik(loggaIn, kontroller);
            visaStatistik.Show();
            visaStatistik.InloggadAnvandare = txtAnvandarnamn.Text;
        }

        private void btnRegFöretagsKund_Click(object sender, EventArgs e)
        {
            SkapaFöretagskund skapaFöretagskund = new SkapaFöretagskund(loggaIn, kontroller);
            skapaFöretagskund.Show();
            skapaFöretagskund.InloggadAnvandare = txtAnvandarnamn.Text;
        }

        private void btnÄndraMaxbelopp_Click(object sender, EventArgs e)
        {
            ÄndraMaxbelopp ändraMaxbelopp = new ÄndraMaxbelopp(loggaIn, kontroller);
            ändraMaxbelopp.Show();
            ändraMaxbelopp.InloggadAnvandare = txtAnvandarnamn.Text;
        }

        private void btn_visaFaktura_Click(object sender, EventArgs e)
        {
            VisaFakturor visaFakturor = new VisaFakturor(loggaIn, kontroller);
            visaFakturor.Show();
            visaFakturor.InloggadAnvandare = txtAnvandarnamn.Text;
        }
    }
}
