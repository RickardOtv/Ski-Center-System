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


        ExpeditKontroller expeditKontroller = new ExpeditKontroller();
        UnitOfWork unitOfWork = new UnitOfWork();
        public LoggaIn()
        {
            InitializeComponent();
        }

        //Knapp för att logga in och ta sig till huvudmenyn
        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            int angivetAnstNr = int.Parse(txtAnstNr.Text);
            //LINQ-satser för att matcha anställningsnummer / lösenord med de lagrade värdena
            var anstNr = (from exp in unitOfWork.expediter where exp.ExpeditID == angivetAnstNr select exp.ExpeditID).FirstOrDefault();
            var lösen = (from exp in unitOfWork.expediter where exp.lösenord == txtLösen.Text select exp.lösenord).FirstOrDefault();

            bool inmatning = expeditKontroller.LoggaIn(anstNr, lösen);
            if (inmatning == true)
            {
                HuvudMeny huvudMeny = new HuvudMeny(this, expeditKontroller);
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
