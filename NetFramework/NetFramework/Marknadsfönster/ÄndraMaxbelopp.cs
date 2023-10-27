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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NetFramework.Marknadsfönster
{
    public partial class ÄndraMaxbelopp : Form
    {
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        // Get the global data instance
        //PrivatKundMaxbelopp globalData = PrivatKundMaxbelopp.Instance;
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

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Denna metod btnSpara_Click försöker först parsa innehållet i textBox_nyttMaxbelopp till en integer-variabel nyttMaxbelopp. Om parsingen är framgångsrik eller om textrutan är tom, tilldelas värdet av nyttMaxbelopp till det globala variabeln GlobalVariable. Om parsingen misslyckas och textrutan inte är tom visas ett felmeddelande. Efter att ha uppdaterat det globala värdet stängs fönstret.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpara_Click(object sender, EventArgs e)
        {
            // Access and modify the global variable
            if (int.TryParse(textBox_nyttMaxbelopp.Text, out nyttMaxbelopp) || string.IsNullOrEmpty(textBox_nyttMaxbelopp.Text))
            {
                if (nyttMaxbelopp >= 0)
                {
                    IList<Kund> allaKunder = kontroller.HämtaKunder();
                    kontroller.ÄndraMaxbeloppFörAllaPrivatKunder(allaKunder, nyttMaxbelopp);
                    //globalData.GlobalVariable = nyttMaxbelopp;
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
