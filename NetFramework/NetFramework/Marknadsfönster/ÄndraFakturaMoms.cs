using Affärslager;
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
        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Spara_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_NyMoms.Text, out nyMoms) /*|| string.IsNullOrEmpty(textBox_NyRabatt.Text)*/)
            {
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
