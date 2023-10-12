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
        private Bokning valdBokning;
        /*
        public ÄndraBokning(LoggaIn loggaIn, Kontroller kontroller, Bokning bokning)
        {
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
            InitializeComponent();
            valdBokning = bokning;
            textBox_BokningsNr.Text = bokning.BokningsID.ToString();
            startDatePicker.Value = valdBokning.Från;
            endDatePicker.Value = valdBokning.Till;

        }
        */


        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }


        private void btn_Tillbaka_Click(object sender, EventArgs e)
        {
            this.Close();        
        }

        private void btn_Spara_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Parse(startDatePicker.Text);
            DateTime endDate = DateTime.Parse(endDatePicker.Text);
            //kontroller.ÄndraBokning(startDate, endDate, valdBokning);

            MessageBox.Show($"Bokning Uppdaterad! \n BokningsID: {valdBokning.BokningsID}\n Nytt Från Datum: {startDate.ToString("yyyy-MM-dd")}\n Nytt Till Datum: {endDate.ToString("yyyy-MM-dd")}\n Nytt Pris: Inte Fixad");
            this.Close();
        }
    }
}
