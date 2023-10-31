using Affärslager;
using Entitetslager;
using System;
using System.Windows.Forms;

namespace NetFramework.Marknadsfönster
{
    public partial class ÄndraFakturaRabatt : Form
    {
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        // Get the global data instance
        private int nyRabatt;
        private Faktura valdFaktura;
        public ÄndraFakturaRabatt(LoggaIn loggaIn, Kontroller kontroller, Faktura faktura)
        {
            InitializeComponent();
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
            textBox_GammalRabatt.Text = faktura.Rabattsats.ToString();
            valdFaktura = faktura;
        }

        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }

        //Knapp för att gå tillbaka
        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Knapp för att spara den nya rabatten
        private void btnSpara_Click(object sender, EventArgs e)
        {
            //Kollar så att inmatning är ett helt nummer
            if (int.TryParse(textBox_NyRabatt.Text, out nyRabatt))
            {   //Kollar så att inmatning är en procentsats
                if (kontroller.IsValidIntegerForPrecent(nyRabatt))
                {
                    kontroller.ÄndraFakturaRabatt(valdFaktura, nyRabatt);
                    Close();
                }
                else
                {
                    MessageBox.Show("Det nya värdet måste vara mellan 0 till 100, tack!");
                }
            }
            else
            {
                MessageBox.Show("Matta in det nya värdet först, tack!");
            }
        }
    }
}
