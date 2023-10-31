using Affärslager;
using NetFramework.Marknadsfönster;
using System;
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

        //Knapp för att gå tillbaka till huvudmeny
        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            HuvudMeny huvudMeny = new HuvudMeny(loggaIn, kontroller);
            huvudMeny.Show();
            huvudMeny.InloggadAnvandare = txtAnvandarnamn.Text;
            this.Close();
        }

        //Knapp för att gå till meny för registrering av ny företagskund
        private void btnRegFöretagsKund_Click(object sender, EventArgs e)
        {
            SkapaFöretagskund skapaFöretagskund = new SkapaFöretagskund(loggaIn, kontroller);
            skapaFöretagskund.Show();
            skapaFöretagskund.InloggadAnvandare = txtAnvandarnamn.Text;
            this.Close();
        }

        //Knapp för at gå till meny där maxbelopp syns och kan ändras
        private void btnÄndraMaxbelopp_Click(object sender, EventArgs e)
        {
            ÄndraMaxbelopp ändraMaxbelopp = new ÄndraMaxbelopp(loggaIn, kontroller);
            ändraMaxbelopp.Show();
            ändraMaxbelopp.InloggadAnvandare = txtAnvandarnamn.Text;
            this.Close();
        }

        //Knapp för att gå till vy med fakturor
        private void btn_visaFaktura_Click(object sender, EventArgs e)
        {
            VisaFakturor visaFakturor = new VisaFakturor(loggaIn, kontroller);
            visaFakturor.Show();
            visaFakturor.InloggadAnvandare = txtAnvandarnamn.Text;
            this.Close();
        }
    }
}
