using Affärslager;
using Datalager;
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

namespace NetFramework
{
    public partial class ÄndraBokning : Form
    {

        UnitOfWork unitOfWork = new UnitOfWork();
        private LoggaIn loggaIn;
        private Kontroller kontroller;
        private Bokningsrad valdBokningsrad;
        
        public ÄndraBokning(LoggaIn loggaIn, Kontroller kontroller, Bokningsrad valdRad)
        {
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
            InitializeComponent();
            valdBokningsrad = valdRad;
            textBox_BokningsNr.Text = valdRad.BokningsID.ToString();
            startDatePicker.Value = valdRad.Från;
            endDatePicker.Value = valdRad.Till;
        }
        


        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }


        private void btn_Tillbaka_Click(object sender, EventArgs e)
        {
            this.Close();        
        }

        private void btn_Spara_För_Alla(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Parse(startDatePicker.Text);
            DateTime endDate = DateTime.Parse(endDatePicker.Text);
            kontroller.ÄndraAllaBokningsRader(startDate, endDate, valdBokningsrad);
            MessageBox.Show($"Bokning Uppdaterad! \n BokningsID: {valdBokningsrad.BokningsID}\n Nytt Från Datum: {startDate.ToString("yyyy-MM-dd")}\n Nytt Till Datum: {endDate.ToString("yyyy-MM-dd")}\n Nytt Pris: Inte Fixad");
            this.Close();
        }

        private void btn_Spara_För_En(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Parse(startDatePicker.Text);
            DateTime endDate = DateTime.Parse(endDatePicker.Text);
            kontroller.ÄndraEnBokningsRad(startDate, endDate, valdBokningsrad);
            MessageBox.Show($"Bokning Uppdaterad! \n BokningsRadID: {valdBokningsrad.BokningsradID}\n Nytt Från Datum: {startDate.ToString("yyyy-MM-dd")}\n Nytt Till Datum: {endDate.ToString("yyyy-MM-dd")}\n Nytt Pris: Inte Fixad");
            this.Close();
        }
    }
}
