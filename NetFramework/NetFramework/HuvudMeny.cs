using Affärslager;
using System;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class HuvudMeny : Form
    {
        private LoggaIn loggaInMeny;
        private Kontroller kontroller;

        public HuvudMeny(LoggaIn loggaInMeny, Kontroller kontroller)
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

        //Klickeventet öppnar ett nytt fönster för kundregister
        private void btnKundregister_Click(object sender, EventArgs e)
        {
            Kundregister kundregister = new Kundregister(loggaInMeny, kontroller);
            kundregister.InloggadAnvandare = txtAnvandarnamn.Text;
            kundregister.Show();
            this.Close();
        }
 
        //Öppnar en marknads-meny om användaren har antingen "Admin" eller "Marknad" som behörighet
        private void btnMarknad_Click(object sender, EventArgs e)
        {
            string inmatning = kontroller.HittaBehörighet(int.Parse(txtAnvandarnamn.Text));
            if (inmatning == "Admin" || inmatning == "Marknad")
            {
                MarknadsMeny marknadsMeny = new MarknadsMeny(loggaInMeny, kontroller);
                marknadsMeny.InloggadAnvandare = txtAnvandarnamn.Text;
                marknadsMeny.Show();
                this.Close();
            }
            else
                MessageBox.Show("Du har ej rätt behörighet.");
        }

        //Öppnar en administratörsmeny om användaren har behörigheten "Admin"
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string inmatning = kontroller.HittaBehörighet(int.Parse(txtAnvandarnamn.Text));
            if (inmatning == "Admin")
            {
                AdminMeny adminMeny = new AdminMeny(loggaInMeny, kontroller);
                adminMeny.InloggadAnvandare = txtAnvandarnamn.Text;
                adminMeny.Show();
                this.Close();

            }
            else
                MessageBox.Show("Du har ej rätt behörighet.");
        }

        //Öppnar en uthyrningsmeny om användaren har behörigheten "Uthyrare", "Bokare" eller "Admin"
        private void btnUthyrning_Click(object sender, EventArgs e)
        {
            string inmatning = kontroller.HittaBehörighet(int.Parse(txtAnvandarnamn.Text));
            if (inmatning == "Uthyrare" || inmatning == "Bokare" || inmatning == "Admin")
            {
                UthyrningsMeny uthyrningsMeny = new UthyrningsMeny(loggaInMeny, kontroller);
                uthyrningsMeny.InloggadAnvandare = txtAnvandarnamn.Text;
                uthyrningsMeny.Show();
                this.Close();
            }
            else
                MessageBox.Show("Du har ej rätt behörighet.");
        }

        //Öppnar en bokningsmeny om användaren har behörigheten "Bokare" eller "Admin"
        private void btn_BokningsMeny_Click(object sender, EventArgs e)
        {
            string inmatning = kontroller.HittaBehörighet(int.Parse(txtAnvandarnamn.Text));
            if (inmatning == "Bokare" || inmatning == "Admin")
            {
                BokningsMeny bokningsMeny = new BokningsMeny(loggaInMeny, kontroller);
                bokningsMeny.InloggadAnvandare = txtAnvandarnamn.Text;
                bokningsMeny.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Du har ej rätt behörighet.");
            }
        }

        //Loggar ur system
        private void btnLoggaUt_Click(object sender, EventArgs e)
        {
            this.Close();
            LoggaIn loggaIn = new LoggaIn();
            loggaIn.Show();
        }
    }
}
