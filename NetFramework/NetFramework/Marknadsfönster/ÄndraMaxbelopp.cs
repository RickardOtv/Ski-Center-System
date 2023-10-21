using Affärslager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NetFramework.Marknadsfönster
{
    public partial class ÄndraMaxbelopp : Form
    {
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        // Get the global data instance
        PrivatKundMaxbelopp globalData = PrivatKundMaxbelopp.Instance;
        private int nyttMaxbelopp;

        public ÄndraMaxbelopp(LoggaIn loggaIn, Kontroller kontroller)
        {
            InitializeComponent();
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
            textBox_GammalMaxbelopp.Text = globalData.GlobalVariable.ToString();
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

        private void btnSpara_Click(object sender, EventArgs e)
        {
            // Access and modify the global variable
            if(int.TryParse(textBox_nyttMaxbelopp.Text, out nyttMaxbelopp) || string.IsNullOrEmpty(textBox_nyttMaxbelopp.Text))
            {
                globalData.GlobalVariable = nyttMaxbelopp;
                Close();
            } else
            {
                MessageBox.Show("Matta in ett nytt maxbelopp först, tack!");
            }
            
        }
    }
}
