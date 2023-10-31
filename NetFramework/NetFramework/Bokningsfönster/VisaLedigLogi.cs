using Affärslager;
using Datalager;
using Entitetslager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class VisaLedigLogi : Form
    {
        private LoggaIn loggaIn;
        private Kontroller kontroller;
        Logi valdLogi = new Logi();
        private List<Logi> ledigaLogier; // En lista för att lagra de lediga logierna
        public VisaLedigLogi(LoggaIn loggaIn, Kontroller kontroller)
        {
            InitializeComponent();
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
        }

        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }

        //Hämtar alla lediga login i valt intervall
        private void button1_Click_1(object sender, EventArgs e)
        {
            UppdateraLogiGrid();
        }
        private void UppdateraLogiGrid()
        {
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;

            RefreshLogi(startDate, endDate);
        }

        internal void RefreshLogi(DateTime startDate, DateTime endDate)
        {
            // Anropa din metod från entitetslagerprojektet för att hämta lediga logier
            var ledigaLogier = kontroller.HämtaLedigaLogier(startDate, endDate);

            // Uppdatera ditt användargränssnitt med lediga logier
            dataGridView1.DataSource = ledigaLogier;

            // Ställ in kolumnrubriker om det behövs
            dataGridView1.Columns["LogiID"].HeaderText = "LogiID för boende";
            dataGridView1.Columns["Typ"].HeaderText = "Typ av boende";

        }



        //Kollar pris på ett valt logi inom valt intervall
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Hämta den markerade raden från datagriden
                var selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as Logi;
                if (selectedRow != null)
                {
                    DateTime startDate = startDatePicker.Value;
                    DateTime endDate = endDatePicker.Value;
                    decimal pris = kontroller.KollaPris(startDate, endDate, selectedRow.Typ);
                    MessageBox.Show($"Totalpris för valda datum: {pris}");
                }
                else
                {
                    MessageBox.Show("Felaktig logi vald.");
                }
            }
            else
            {
                MessageBox.Show("Ingen logi vald.");
            }
        }

        //Knapp för att gå tillbaka
        private void TillbakaKnapp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
