using System;
using Affärslager;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class UthyrningsMeny : Form
    {
        private Kontroller kontroller;
        private LoggaIn loggaIn;

        public UthyrningsMeny(LoggaIn loggaIn, Kontroller kontroller)
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

        //Knapp för att gå till skapa uthyrningsfönster
        private void btnSkapaUthyrning_Click(object sender, EventArgs e)
        {
            SkapaUthyrning skapaUthyrning = new SkapaUthyrning(loggaIn, kontroller);
            skapaUthyrning.Show();
            skapaUthyrning.InloggadAnvandare = txtAnvandarnamn.Text;
        }

        //knapp för att gå till återlämningsfönster
        private void btnÅterlämning_Click(object sender, EventArgs e)
        {
            ÅterlämningUthyrning återlämningUthyrning = new ÅterlämningUthyrning(loggaIn, kontroller);
            återlämningUthyrning.Show();
            återlämningUthyrning.InloggadAnvandare = txtAnvandarnamn.Text;
        }

        //Knapp för att gå till visa uthyrningarfönster
        private void btnVisaUthyrningar_Click(object sender, EventArgs e)
        {
            VisaUthyrningar visaUthyrningar = new VisaUthyrningar(loggaIn, kontroller);
            visaUthyrningar.InloggadAnvandare = txtAnvandarnamn.Text;
            visaUthyrningar.Show();
        }
    }
}