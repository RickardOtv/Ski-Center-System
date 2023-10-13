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

        private void button2_Click(object sender, EventArgs e)
        {
            valdLogi = dataGridView1.SelectedRows[0].DataBoundItem as Logi;
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;
            decimal pris = kontroller.KollaPris(startDate, endDate, valdLogi.Typ);
            MessageBox.Show($"Totalpris för valda datum:{pris}");
        }

        private void TillbakaKnapp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
