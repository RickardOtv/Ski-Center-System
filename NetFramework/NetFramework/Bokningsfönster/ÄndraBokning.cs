using Affärslager;
using Datalager;
using Entitetslager;
using System;
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
        
        //Knapp för att gå tillbaka
        private void btn_Tillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Sparar nytt valt intervall för alla logi på en bokning
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

        //Sparar nytt valt intervall för ett specifik logi på en bokning
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
