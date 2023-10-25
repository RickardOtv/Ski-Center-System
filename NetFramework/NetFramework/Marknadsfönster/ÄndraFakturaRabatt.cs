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
        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Spara_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_NyRabatt.Text, out nyRabatt) /*|| string.IsNullOrEmpty(textBox_NyRabatt.Text)*/)
            {
                kontroller.ÄndraFakturaRabatt(valdFaktura, nyRabatt);
                Close();
            }
            else
            {
                MessageBox.Show("Matta in nya värden först, tack!");
            }
        }


    }
}
