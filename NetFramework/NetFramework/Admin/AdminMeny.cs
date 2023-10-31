using Affärslager;
using System;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class AdminMeny : Form
    {
        private LoggaIn loggaInMeny;
        private Kontroller kontroller;
        public AdminMeny(LoggaIn loggaInMeny, Kontroller kontroller)
        {
            this.loggaInMeny = loggaInMeny;
            this.kontroller = kontroller;
            InitializeComponent();
        }
        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }

        private void btnHanteraAnställd_Click(object sender, EventArgs e)
        {
            AnställdaRegister anställdaRegister = new AnställdaRegister(loggaInMeny, kontroller);
            anställdaRegister.InloggadAnvandare = txtAnvandarnamn.Text;
            anställdaRegister.Show();
            this.Close();
        }

        private void btnSkapaAnställd_Click(object sender, EventArgs e)
        {
            SkapaAnställd skapaAnställd = new SkapaAnställd(loggaInMeny, kontroller);
            skapaAnställd.InloggadAnvandare = txtAnvandarnamn.Text;
            skapaAnställd.Show();
            this.Close();
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            HuvudMeny huvudMeny = new HuvudMeny(loggaInMeny, kontroller);
            huvudMeny.Show();
            huvudMeny.InloggadAnvandare = txtAnvandarnamn.Text;
            this.Close();
        }
    }
}
