using Affärslager;
using Entitetslager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
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

        /// <summary>
        /// Metoden button1_Click_1 öppnar en anslutning till en databas och utför en SQL-fråga för att hämta tillgängliga boenden inom ett specificerat tidsintervall. Den använder två DateTime-objekt för att representera start- och slutdatumet för sökningen. En SQL-fråga används för att hämta de tillgängliga boendena från databasen baserat på det specificerade tidsintervallet. Resultatet av frågan används sedan för att fylla en DataGridView-kontroll med information om tillgängliga boenden. Om det uppstår något undantag under processen stängs anslutningen till databasen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            string cs = "Data Source=sqlutb2.hb.se,56077;Initial Catalog=suht2304;User ID=suht2304;Password=smax99;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(cs);

            try
            {
                conn.Open();

                DateTime startDate = startDatePicker.Value;
                DateTime endDate = endDatePicker.Value;

                string select = "SELECT Logi.* " +
                       "FROM Logi " +
                       "LEFT JOIN Bokningsrad ON Logi.LogiID = Bokningsrad.LogiID " +
                       "AND (@EndDate >= Bokningsrad.Från AND @StartDate <= Bokningsrad.Till) " +
                       "WHERE Bokningsrad.Från IS NULL";

                var c = new SqlConnection(cs);
                var dataAdapter = new SqlDataAdapter(select, c);

                dataAdapter.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;

                // Spara de lediga logierna i listan ledigaLogier
                ledigaLogier = ds.Tables[0].AsEnumerable().Select(row =>
                    new Logi
                    {
                        LogiID = row.Field<string>("LogiID"),
                        Typ = row.Field<string>("Typ")
                        // Fyll i med andra fält som behövs
                    }).ToList();

                dataGridView1.DataSource = ds.Tables[0];

                // Tabellnamn för Logidel
                dataGridView1.Columns["LogiID"].HeaderText = "LogiID för boende";
                dataGridView1.Columns["Typ"].HeaderText = "Typ av boende";
            }
            catch (Exception ex)
            {
                conn.Close();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Metoden button2_Click kontrollerar om det finns markerade rader i en DataGridView-kontroll. Om en rad är markerad hämtas informationen om den specifika raden och dess motsvarande pris baserat på valda datum. Denna information visas sedan i en dialogruta. Om ingen rad är markerad eller om den valda raden är ogiltig, visas lämpliga meddelanden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Hämta den markerade logien från listan av lediga logier
                var selectedRow = dataGridView1.SelectedRows[0];
                var rowIndex = selectedRow.Index;
                if (rowIndex >= 0 && rowIndex < ledigaLogier.Count)
                {
                    var valdLogi = ledigaLogier[rowIndex];

                    DateTime startDate = startDatePicker.Value;
                    DateTime endDate = endDatePicker.Value;
                    decimal pris = kontroller.KollaPris(startDate, endDate, valdLogi.Typ);
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







        private void TillbakaKnapp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
