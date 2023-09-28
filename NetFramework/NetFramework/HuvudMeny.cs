using Affärslager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class HuvudMeny : Form
    {


        private LoggaIn loggaInMeny;
        private Kontroller kontroller;
        public HuvudMeny(LoggaIn loggaInMeny, Kontroller kontroller)
        {
            this.loggaInMeny = loggaInMeny;
            this.kontroller = kontroller;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=sqlutb2.hb.se,56077;Initial Catalog=suht2304;User ID=suht2304;Password=smax99;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(cs);

            try
            {
                conn.Open();
                var select = "SELECT * FROM Logi";
                var c = new SqlConnection(cs); // Your Connection String here
                var dataAdapter = new SqlDataAdapter(select, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
                label1.Text = "Du är ihopkopplad";
            }
            catch (Exception ex)
            {
                label1.Text = "Det funkar inte" + ex.Message;
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
