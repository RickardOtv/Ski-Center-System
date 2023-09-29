using Affärslager;
using Datalager;
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
        //private HuvudMeny huvudMeny;
        Kontroller kontroller = new Kontroller();
        UnitOfWork unitOfWork = new UnitOfWork();
       // public TextBox txtAnvandarnamn;


        public LoggaIn()
        {
            InitializeComponent();
        }

        //Knapp för att logga in och ta sig till huvudmenyn
        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            int angivetAnstNr = int.Parse(txtAnstNr.Text);
            //LINQ-satser för att matcha anställningsnummer / lösenord med de lagrade värdena
            var anstNr = (from anst in unitOfWork.anställda where anst.AnställningsNr == angivetAnstNr select anst.AnställningsNr).FirstOrDefault();
            var lösen = (from anst in unitOfWork.anställda where anst.Lösenord == txtLösen.Text select anst.Lösenord).FirstOrDefault();

            bool inmatning = kontroller.LoggaIn(anstNr, lösen);
            if (inmatning == true)
            {
                HuvudMeny huvudMeny = new HuvudMeny(this, kontroller);
                huvudMeny.InloggadAnvandare = txtAnstNr.Text;
                huvudMeny.Show();
            }
            else
                MessageBox.Show("Inloggning misslyckades");
        }

        //Avsluta programmet
        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        

        

       

        
    }
}
