using Affärslager;
using Entitetslager;
using System;
using System.Windows.Forms;

namespace NetFramework.Marknadsfönster
{
    public partial class ÄndraFakturaMoms : Form
    {
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        // Get the global data instance
        private int nyMoms;
        private Faktura valdFaktura;
        public ÄndraFakturaMoms(LoggaIn loggaIn, Kontroller kontroller, Faktura faktura)
        {
            InitializeComponent();
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
            textBox_GammalMoms.Text = faktura.Momsats.ToString();
            valdFaktura = faktura;
        }

        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }

        //Knapp för att kunna gå tillbaka
        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Knapp för att spara den nya momsen
        private void btn_Spara_Click(object sender, EventArgs e)
        {
            //Kollar så att inmatning är ett helt nummer
            if (int.TryParse(textBox_NyMoms.Text, out nyMoms))
            {
                //Kollar så att inmatning är en procent sats
                if (kontroller.IsValidIntegerForPrecent(nyMoms))
                {
                    kontroller.ÄndraFakturaMoms(valdFaktura, nyMoms);
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
