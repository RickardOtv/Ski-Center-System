using Affärslager;
using Datalager;
using Entitetslager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class LoggaIn : Form
    {
        Kontroller kontroller = new Kontroller();
        UnitOfWork unitOfWork = new UnitOfWork();

        public LoggaIn()
        {
            InitializeComponent();
            txtLösen.PasswordChar = '*';
        }

        //Kontrollerar giltigheten och öppnar en ny huvudmeny om inloggningen lyckas
        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            int angivetAnstNr = int.Parse(txtAnstNr.Text);
            //Hittar anställd
            var anstNr = (from anst in unitOfWork.anställda where anst.AnställningsNr == angivetAnstNr select anst.AnställningsNr).FirstOrDefault();
            var lösen = (from anst in unitOfWork.anställda where anst.Lösenord == txtLösen.Text select anst.Lösenord).FirstOrDefault();
            // txtLösen.PasswordChar = '*';
            bool inmatning = kontroller.LoggaIn(anstNr, lösen);
            //Om inlogging gick igenom
            if (inmatning == true)
            {
                HuvudMeny huvudMeny = new HuvudMeny(this, kontroller);
                huvudMeny.Show();
                huvudMeny.InloggadAnvandare = txtAnstNr.Text;
                IList<Kund> allaKunder = kontroller.HämtaKunder();
                kontroller.ÄndraMaxbeloppFörAllaPrivatKunder(allaKunder, 12000);
            }
            else
                MessageBox.Show("Inloggning misslyckades");
        }

        //Stänger av programet
        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
