using Affärslager;
using Datalager;
using Entitetslager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NetFramework
{
    public partial class BokningBefintligKund : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private LoggaIn loggaInMeny;
        private Kontroller kontroller;
        private Kund valdKund;
        Logi valdLogi;
        Bokningsrad valdRad;
        DateTime från;
        DateTime till;
        Bokning nyBokning;
        private List<Logi> ledigaLogier;

        public BokningBefintligKund(LoggaIn loggaInMeny, Kontroller kontroller)
        {
            this.loggaInMeny = loggaInMeny;
            this.kontroller = kontroller;
            InitializeComponent();
        }
        
        internal void RefreshLogi()
        {
            string cs = "Data Source=sqlutb2.hb.se,56077;Initial Catalog=suht2304;User ID=suht2304;Password=smax99;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(cs);

            try
            {
                conn.Open();

                DateTime startDate = dateFrån.Value;
                DateTime endDate = dateTill.Value;

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
                gridLogi.ReadOnly = true;

                // Spara de lediga logierna i listan ledigaLogier
                ledigaLogier = ds.Tables[0].AsEnumerable().Select(row =>
                    new Logi
                    {
                        LogiID = row.Field<string>("LogiID"),
                        Typ = row.Field<string>("Typ")
                        // Fyll i med andra fält som behövs
                    }).ToList();

                gridLogi.DataSource = ds.Tables[0];

                // Tabellnamn för Logidel
                gridLogi.Columns["LogiID"].HeaderText = "LogiID för boende";
                gridLogi.Columns["Typ"].HeaderText = "Typ av boende";
            }
            catch (Exception ex)
            {
                conn.Close();
            }
        }
        internal void RefreshRader()
        {
            var rader = kontroller.HämtaRader(nyBokning.BokningsID);
            gridRader.DataSource = rader;
            gridRader.AutoGenerateColumns = false;
            gridRader.Columns["Bokning"].Visible = false;
            gridRader.Columns["Logi"].Visible = false;
            gridRader.Columns["BokningsradID"].DisplayIndex = 0;
            gridRader.Columns["LogiID"].DisplayIndex = 1;
            gridRader.Columns["Från"].DisplayIndex = 2;
            gridRader.Columns["Till"].DisplayIndex = 3;
            gridRader.Columns["BokningsID"].DisplayIndex = 4;

            for (int i = 0; i < gridRader.Rows.Count; i++)
            {
                DataGridViewRow row = gridRader.Rows[i];
                Bokningsrad bokningsrad = rader[i]; // Assuming rader is a List<Bokningsrad>
                row.Tag = bokningsrad;
            }
        }

        internal void RefreshKunder()
        {
            var kunder = kontroller.HämtaKunder();
            gridKunder.DataSource = kunder;
            gridKunder.AutoGenerateColumns = false;
            gridKunder.Columns["Maxbeloppskreditgräns"].Visible = false;
            gridKunder.Columns["Adress"].Visible = false;
            gridKunder.Columns["PostOrt"].Visible = false;
            gridKunder.Columns["PostNr"].Visible = false;
            gridKunder.Columns["Telefonnummer"].Visible = false;
            gridKunder.Columns["Email"].Visible = false;
            gridKunder.Columns["KundID"].DisplayIndex = 0;
            gridKunder.Columns["Namn"].DisplayIndex = 1;
            gridKunder.Columns["Typ"].DisplayIndex = 2;
            gridKunder.Columns["Personnummer"].DisplayIndex = 3;
        }

        private void BokningBefintligKund_Load(object sender, EventArgs e)
        {
            //RefreshLogi();
            RefreshKunder();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            if(nyBokning != null)
            {
                
                DialogResult result = MessageBox.Show("Om du går tillbaka så avbryter du bokningen", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    kontroller.TaBortBokning(nyBokning);
                    this.Close();
                }
                else if (result == DialogResult.No)
                {

                }
            } else
            {
                this.Close();
            }
        }
        private void btnSök_Click(object sender, EventArgs e)
        {
            string matatPersNr = txtFilter.Text;
            var matchadKund = unitOfWork.kunder.FirstOrDefault(k => k.Personnummer == matatPersNr);
            if (matchadKund != null)
            {
                gridKunder.DataSource = new List<Kund> { matchadKund };
            }
            else
            {
                MessageBox.Show("Kund ej hittad, försök igen");
            }
        }

        private void btnKollaPris_Click(object sender, EventArgs e)
        {
            if (gridLogi.SelectedRows.Count > 0)
            {
                // Hämta den markerade logien från listan av lediga logier
                var selectedRow = gridLogi.SelectedRows[0];
                var rowIndex = selectedRow.Index;
                if (rowIndex >= 0 && rowIndex < ledigaLogier.Count)
                {
                    var valdLogi = ledigaLogier[rowIndex];

                    DateTime startDate = dateFrån.Value;
                    DateTime endDate = dateTill.Value;
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

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            if(valdKund != null)
            {
                if (gridLogi.SelectedRows.Count > 0)
                {
                    // Hämta den markerade logien från listan av lediga logier
                    var selectedRow = gridLogi.SelectedRows[0];
                    var rowIndex = selectedRow.Index;
                    if (rowIndex >= 0 && rowIndex < ledigaLogier.Count)
                    {
                        var valdLogi = ledigaLogier[rowIndex];
                        DateTime startDate = DateTime.Parse(dateFrån.Text);
                        DateTime endDate = DateTime.Parse(dateTill.Text);
                        Bokningsrad nyBokningsrad = kontroller.SkapaBokningsRad(startDate, endDate, valdLogi, nyBokning.BokningsID);
                        MessageBox.Show($"Ny bokningsrad har skapats med Logi:{valdLogi.LogiID}\nBokningsID:{nyBokning.BokningsID}\nBokningsradID som genererats: {nyBokningsrad.BokningsradID}");
                        RefreshRader();
                        RefreshLogi();
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

            }  else
            {
                MessageBox.Show("Välj först kund. ");
            } 
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {

            if (gridRader.SelectedRows.Count > 0)
            {
                valdRad = gridRader.SelectedRows[0].DataBoundItem as Bokningsrad;
                kontroller.TaBortBokningsRad(valdRad);
                RefreshRader();
                RefreshLogi();
            }
                else
                {
                    MessageBox.Show("Måste först välja rad");
                }
        }

        private void btnVäljKund_Click(object sender, EventArgs e)
        {
            valdKund = gridKunder.SelectedRows[0].DataBoundItem as Kund;
            nyBokning = kontroller.SkapaBokning(valdKund);
            MessageBox.Show($"Bokning har skapats med ID:{nyBokning.BokningsID} för kund:{valdKund.Namn}");
        }

        private void btnKlar_Click(object sender, EventArgs e)
        {
            if (nyBokning != null)
            {
                if (gridRader.SelectedRows.Count > 0)
                {
                    decimal totalSumma = 0;
                    int momsSatts = 0;
                    int rabattsatts = 0;

                    foreach (DataGridViewRow row in gridRader.Rows)
                    {
                        if (row.Tag is Bokningsrad bokningsrad)
                        {
                            // Call your method on the Bokningsrad object
                            Logi ettLogi = kontroller.HittaLogi(bokningsrad.LogiID);

                            //Något gör så att det blir en extra dag, därför tar jag bort den här
                            DateTime newDate = bokningsrad.Till.AddDays(-1);
                            decimal pris = kontroller.KollaPris(bokningsrad.Från, newDate, ettLogi.Typ);
                            totalSumma += pris;
                        }
                    }
                    Faktura nyFaktura = kontroller.SkapaFaktura(nyBokning.BokningsID, momsSatts, rabattsatts, (float)totalSumma);
                    MessageBox.Show($"BokningsID: {nyBokning.BokningsID} \nFrån feeem \nTill: fjeem \nPris: {nyFaktura.TotalPris}kr \n\nFaktura skapad \nID: {nyFaktura.FakturaID} \nRabatt: {nyFaktura.Rabattsats}% \nMoms: {nyFaktura.Momsats}%", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                } else
                {
                    MessageBox.Show($"Välj först ett Logi, tack!");
                }
            } else
            {
                MessageBox.Show($"Välj först en Kund, tack!");
            }
        }

        private void btn_sökLogi_Click(object sender, EventArgs e)
        {
            RefreshLogi();
        }
        private void btnLogiInfo_Click(object sender, EventArgs e)
        {
            if (gridLogi.SelectedRows.Count > 0)
            {
                // Hämta den markerade logien från listan av lediga logier
                var selectedRow = gridLogi.SelectedRows[0];
                var rowIndex = selectedRow.Index;
                if (rowIndex >= 0 && rowIndex < ledigaLogier.Count)
                {
                    var valdLogi = ledigaLogier[rowIndex];
                    switch (valdLogi.Typ)
                    {
                        case "LGH.1":
                            MessageBox.Show($"Du har valt: {valdLogi.LogiID} \n\nEnrumslägenhet \nKök \nFyra bäddar \n50m² \n(50 st totalt)");
                            break;
                        case "LGH.2":
                            MessageBox.Show($"Du har valt: {valdLogi.LogiID} \n\nTvårumslägenhet \nKök \nSex bäddar \n70m² (35 st totalt)");
                            break;
                        case "Camping":
                            MessageBox.Show($"Du har valt: {valdLogi.LogiID} \n\nFinns ingen specifik information!");
                            break;
                        case "Konferens stor":
                            MessageBox.Show($"Du har valt: {valdLogi.LogiID} \n\nAvsedd för max 50 personer \n(Tre st totalt)");
                            break;
                        case "Konferens liten":
                            MessageBox.Show($"Du har valt: {valdLogi.LogiID} \n\nAvsedd för max 20 personer \n(Fem st totalt)");
                            break;
                        default:
                            Console.WriteLine("Finns ingen specifik information!");
                            break;
                    }
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

        private void btnTotalSumma_Click(object sender, EventArgs e)
        {
            decimal totalSumma = 0;

            foreach (DataGridViewRow row in gridRader.Rows)
            {
                if (row.Tag is Bokningsrad bokningsrad)
                {
                    // Call your method on the Bokningsrad object
                    Logi ettLogi = kontroller.HittaLogi(bokningsrad.LogiID);


                    //Något gör så att det blir en extra dag, därför tar jag bort den här
                    DateTime newDate = bokningsrad.Till.AddDays(-1);
                    decimal pris = kontroller.KollaPris(bokningsrad.Från, newDate, ettLogi.Typ);
                    totalSumma += pris;
                }
            }
            MessageBox.Show($"Totalpris för bokning är: {totalSumma}");
        }

    }
}