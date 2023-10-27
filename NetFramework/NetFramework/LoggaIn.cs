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
    public partial class LoggaIn : Form
    {
        Kontroller kontroller = new Kontroller();
        UnitOfWork unitOfWork = new UnitOfWork();


        public LoggaIn()
        {
            InitializeComponent();
            txtLösen.PasswordChar = '*';
        }
        /// <summary>
        /// Metoden utför inloggning med angivet anställningsnummer och lösenord, kontrollerar giltigheten och öppnar en ny huvudmeny om inloggningen lyckas, annars visar den ett meddelande om misslyckad inloggning.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoggaIn_Click(object sender, EventArgs e)
        {

            int angivetAnstNr = int.Parse(txtAnstNr.Text);
            var anstNr = (from anst in unitOfWork.anställda where anst.AnställningsNr == angivetAnstNr select anst.AnställningsNr).FirstOrDefault();
            var lösen = (from anst in unitOfWork.anställda where anst.Lösenord == txtLösen.Text select anst.Lösenord).FirstOrDefault();
            // txtLösen.PasswordChar = '*';
            bool inmatning = kontroller.LoggaIn(anstNr, lösen);
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

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }








    }
}
