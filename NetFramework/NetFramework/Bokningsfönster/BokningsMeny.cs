using Affärslager;
using System;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class BokningsMeny : Form
    {
        private Kontroller kontroller;
        private LoggaIn loggaIn;

        public BokningsMeny(LoggaIn loggaIn, Kontroller kontroller)
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

        //Gå till Lediga Logi
        private void btnLediga_Click(object sender, EventArgs e)
        {
            VisaLedigLogi ledigLogi = new VisaLedigLogi(loggaIn, kontroller);
            ledigLogi.Show();
            ledigLogi.InloggadAnvandare = txtAnvandarnamn.Text;
        }

        //Gå tillbaka
        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            HuvudMeny huvudMeny = new HuvudMeny(loggaIn, kontroller);
            huvudMeny.Show();
            huvudMeny.InloggadAnvandare = txtAnvandarnamn.Text;
        }

        //Påbörja skapande av bokning
        private void btnSkapaBokning_Click(object sender, EventArgs e)
        {
            BokningsTyp bokningsTyp = new BokningsTyp(loggaIn, kontroller);
            bokningsTyp.Show();
            bokningsTyp.InloggadAnvandare = txtAnvandarnamn.Text;
        }

        //Visa alla bokningar
        private void btnVisaBokningar_Click(object sender, EventArgs e)
        {
            VisaBokningar visabokningar = new VisaBokningar(loggaIn, kontroller);
            visabokningar.Show();
            visabokningar.InloggadAnvandare = txtAnvandarnamn.Text;
        }
    }
}
