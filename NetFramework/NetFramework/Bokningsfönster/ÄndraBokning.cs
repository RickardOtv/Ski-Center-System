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
        /// <summary>
        /// Metoden btn_Spara_För_Alla extraherar start- och slutdatum från respektive datumväljare och använder dessa datum tillsammans med en specifik bokningsrad för att uppdatera alla bokningsrader. Efter uppdatering visas en dialogruta som bekräftar den uppdaterade bokningen tillsammans med dess uppdaterade detaljer, inklusive det nya priset om det har justerats. Slutligen stängs det nuvarande fönstret.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Spara_För_Alla(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Parse(startDatePicker.Text);
            DateTime endDate = DateTime.Parse(endDatePicker.Text);

            if (startDatePicker.Text == endDatePicker.Text)
            {
                MessageBox.Show($"Från datum och Till datum får inte vara samma");
            }
            else if (startDate > endDate)
            {

                MessageBox.Show($"Från Datum måste vara tidigare än Till Datum");

            }
            else
            {
                kontroller.ÄndraAllaBokningsRader(startDate, endDate, valdBokningsrad);
                MessageBox.Show($"Bokning Uppdaterad! \n BokningsID: {valdBokningsrad.BokningsID}\n Nytt Från Datum: {startDate.ToString("yyyy-MM-dd")}\n Nytt Till Datum: {endDate.ToString("yyyy-MM-dd")}");
                this.Close();
            }
        }
        /// <summary>
        /// Metoden btn_Spara_För_En extraherar start- och slutdatum från respektive datumväljare och använder dessa datum tillsammans med en specifik bokningsrad för att uppdatera en enskild bokningsrad. Efter uppdatering visas en dialogruta som bekräftar den uppdaterade bokningen tillsammans med dess uppdaterade detaljer, inklusive det nya priset om det har justerats. Slutligen stängs det nuvarande fönstret.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Spara_För_En(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Parse(startDatePicker.Text);
            DateTime endDate = DateTime.Parse(endDatePicker.Text);

            if (startDatePicker.Text == endDatePicker.Text)
            {
                MessageBox.Show($"Från datum och Till datum får inte vara samma");
            }
            else if (startDate > endDate)
            {

                MessageBox.Show($"Från Datum måste vara tidigare än Till Datum");

            }
            else
            {
                kontroller.ÄndraEnBokningsRad(startDate, endDate, valdBokningsrad);
                MessageBox.Show($"Bokning Uppdaterad! \n BokningsRadID: {valdBokningsrad.BokningsradID}\n Nytt Från Datum: {startDate.ToString("yyyy-MM-dd")}\n Nytt Till Datum: {endDate.ToString("yyyy-MM-dd")}");
                this.Close();
            }
        }
    }
}
