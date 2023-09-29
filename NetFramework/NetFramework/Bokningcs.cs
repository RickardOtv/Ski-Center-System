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
    public partial class Bokningcs : Form
    {
        public Bokningcs()
        {
            InitializeComponent();
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

                string select = "SELECT Logi.*, Bokning.* " +
                                "FROM Logi " +
                                "LEFT JOIN Bokning ON Logi.LogiID = Bokning.LogiID " +
                                "WHERE Från >= @StartDate AND Till <= @EndDate";
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
                dataGridView1.Columns["IsAvailable"].HeaderText = "Tillgänglighet";
                
                
                // Tabellnamn för bokningsdel
                dataGridView1.Columns["Från"].HeaderText = "Startdatum";
                dataGridView1.Columns["Till"].HeaderText = "Slutdatum";

                label1.Text = "Du är ihopkopplad";
            }
            catch (Exception ex)
            {
                label1.Text = "Det funkar inte" + ex.Message;
                conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
