using Affärslager;
using Entitetslager;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NetFramework.Marknadsfönster
{
    public partial class ÄndraMaxbelopp : Form
    {
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        private int nyttMaxbelopp;

        public ÄndraMaxbelopp(LoggaIn loggaIn, Kontroller kontroller)
        {
            InitializeComponent();
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
            Kund hittadFörstaKund = kontroller.HämtaFörstaPrivatKund();
            textBox_GammalMaxbelopp.Text = hittadFörstaKund.Maxbeloppskreditgräns.ToString();
        }

        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }

        //Knapp för att kunna gå tillbaka
        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Knapp för att spara den nya maxbeloppen för privatkunder
        private void btnSpara_Click(object sender, EventArgs e)
        {
            // Kollar så att inmatning är i rätt format
            if (int.TryParse(textBox_nyttMaxbelopp.Text, out nyttMaxbelopp) || string.IsNullOrEmpty(textBox_nyttMaxbelopp.Text))
            {
                if (nyttMaxbelopp >= 0)
                {
                    IList<Kund> allaKunder = kontroller.HämtaKunder();
                    kontroller.ÄndraMaxbeloppFörAllaPrivatKunder(allaKunder, nyttMaxbelopp);
                    Close();
                }
                else
                {
                    MessageBox.Show("Maxbelopp får inte vara ett negativt värde, tack!");
                }
            }
            else
            {
                MessageBox.Show("Matta in ett nytt maxbelopp först, tack!");
            }
        }
    }
}
