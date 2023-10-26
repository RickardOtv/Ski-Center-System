using Affärslager;
using Datalager;
using Entitetslager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
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
            InitializeComponent();
            this.loggaInMeny = loggaInMeny;
            this.kontroller = kontroller;
        }

        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }
        /// <summary>
        /// Metoden RefreshLogi ansluter till en databas och hämtar lediga logier baserat på de specificerade datumen. Den använder en LEFT JOIN-fråga för att hitta lediga logier som inte är bokade under den angivna tidsperioden. Den fyller sedan en datagrid med den resulterande datan och anger rubriker för kolumnerna. Om det uppstår ett undantag stängs anslutningen till databasen.
        /// </summary>
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
        /// <summary>
        /// Metoden btnAvbryt_Click hanterar händelsen när användaren klickar på en knapp för att avbryta en bokning. Om en ny bokning har påbörjats, uppmanas användaren att bekräfta avbrytandet av bokningen. Om användaren bekräftar avbrytandet tas bokningen bort och fönstret stängs. Om användaren väljer att inte avbryta eller om ingen bokning pågår, stängs fönstret utan att några ändringar görs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Metoden hanterar händelsen när användaren klickar på en knapp för att söka efter en kund med det angivna personnumret. Den söker i databasen efter en kund som matchar det angivna personnumret och uppdaterar griden med den matchade kunden om den hittas, annars visas ett meddelande som uppmanar användaren att försöka igen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Metoden btnKollaPris_Click hanterar händelsen när användaren klickar på en knapp för att kontrollera priset för logi. Den kontrollerar om en logi är markerad i griden och hämtar information om den valda logien från listan över tillgängliga logier. Den beräknar priset för logien baserat på de valda datumen och logitypen och visar det beräknade priset i ett meddelande. Om ingen logi är vald eller om en ogiltig logi har valts visas ett felmeddelande.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKollaPris_Click(object sender, EventArgs e)
        {
            int moms;
            float slutPrisInkMoms;
            if (nyBokning != null)
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
                        if(valdKund.Typ == "Företag"){
                            moms = 12; 
                        } else
                        {
                            moms = 0;
                        }
                        slutPrisInkMoms = (float)pris - ((float)pris * ((float)moms / 100));
                        MessageBox.Show($"Original Pris: {pris}kr\nPris Ink Moms:{slutPrisInkMoms}kr\nMoms: {moms} %");
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
            } else
            {
                MessageBox.Show("Välj först en kund.");
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Metoden hanterar händelsen när användaren klickar på en knapp för att lägga till en ny bokningsrad. Den kontrollerar om en kund har valts och om en logi är markerad i griden. Om en kund är vald och en logi är markerad hämtas information om den valda logien från listan över tillgängliga logier. En ny bokningsrad skapas med informationen om de valda datumen, den valda logien och det aktuella boknings-ID:t. Ett meddelande visas med information om den skapade bokningsraden innan rutorna för bokningsraderna och logierna uppdateras. Om ingen logi är vald eller om en ogiltig logi har valts visas ett felmeddelande. Om ingen kund har valts visas ett meddelande som uppmanar användaren att först välja en kund.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        if(dateFrån.Text != dateTill.Text)
                        {
                            if(DateTime.Parse(dateFrån.Text) < DateTime.Parse(dateTill.Text))
                            {
                                var valdLogi = ledigaLogier[rowIndex];
                                DateTime startDate = DateTime.Parse(dateFrån.Text);
                                DateTime endDate = DateTime.Parse(dateTill.Text);
                                Bokningsrad nyBokningsrad = kontroller.SkapaBokningsRad(startDate, endDate, valdLogi, nyBokning.BokningsID);
                                MessageBox.Show($"Ny bokningsrad har skapats med Logi:{valdLogi.LogiID}\nBokningsID:{nyBokning.BokningsID}\nBokningsradID som genererats: {nyBokningsrad.BokningsradID}");
                                RefreshRader();
                                RefreshLogi();
                            } else
                            {
                                MessageBox.Show("Från datum måste vara större än Till datum.");
                            }

                        } else
                        {
                            MessageBox.Show("Kan inte ha samma Från och Till datum.");
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
            MessageBox.Show($"Vald kund:{valdKund.Namn}");
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
                float slutPrisInkMoms;
                DateTime minDatum = new DateTime(3008, 1, 1);
                DateTime maxDatum = new DateTime(2008, 1, 1);

                foreach (DataGridViewRow row in gridRader.Rows)
                {
                    if (row.Tag is Bokningsrad bokningsrad)
                    {
                        // Call your method on the Bokningsrad object
                        Logi ettLogi = kontroller.HittaLogi(bokningsrad.LogiID);

                        //Något gör så att det blir en extra dag, därför tar jag bort den här
                        DateTime newTillDate = bokningsrad.Till.AddDays(-1);
                        decimal pris = kontroller.KollaPris(bokningsrad.Från, newTillDate, ettLogi.Typ);
                        totalSumma += pris;
                            if(minDatum > bokningsrad.Från)
                        {
                            minDatum = bokningsrad.Från;
                        }
                        if (maxDatum < bokningsrad.Till)
                        {
                            maxDatum = bokningsrad.Till;
                        }
                    }
                }

                if (valdKund.Typ == "Företag")
                {
                    momsSatts = 12;
                }
                Faktura nyFaktura = kontroller.SkapaFaktura(nyBokning.BokningsID, momsSatts, rabattsatts, (float)totalSumma);
                slutPrisInkMoms = (float)nyFaktura.TotalPris - ((float)nyFaktura.TotalPris * ((float)nyFaktura.Momsats / 100));
                MessageBox.Show($"Bokning skapad: \nBokningsID: {nyBokning.BokningsID} \nFrån {minDatum.ToShortDateString()} \nTill: {maxDatum.ToShortDateString()}  \n\nTillhörande Faktura:\nFakturaID: {nyFaktura.FakturaID} \nRabatt: {nyFaktura.Rabattsats}% \nMoms: {nyFaktura.Momsats}%\nTotalPris: {slutPrisInkMoms}kr", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show($"Välj först ett Logi, tack!");
            }
            }
            else
            {
                MessageBox.Show($"Välj först en Kund, tack!");
            }
        }

        private void btn_sökLogi_Click(object sender, EventArgs e)
        {
            RefreshLogi();
        }
        /// <summary>
        /// Metoden btnLogiInfo_Click hanterar händelsen när användaren klickar på en knapp för att visa information om den valda logien. Den kontrollerar om en logi är markerad i griden och hämtar information om den valda logien från listan över tillgängliga logier. Beroende på logitypen visas specifik information om logien i en dialogruta. Om ingen logi är vald eller om en ogiltig logi har valts visas ett felmeddelande.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Metoden btnTotalSumma_Click hanterar händelsen när användaren klickar på en knapp för att beräkna den totala summan för bokningen. Den itererar över varje rad i griden och hämtar information om bokningsraden. Genom att använda kontrollermetoder hämtar den information om logitypen och beräknar priset för varje bokningsrad baserat på uthyrningsperioden och logitypen. Den kumulativa summan för varje bokningsrad läggs sedan till för att få den totala summan för bokningen, som sedan visas i ett meddelande.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTotalSumma_Click(object sender, EventArgs e)
        {
            decimal totalSumma = 0;
            float slutPrisInkMoms;
            int moms;
            
                if (gridRader.SelectedRows.Count > 0)
                {
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
                    if (valdKund.Typ == "Företag")
                    {
                        moms = 12;
                    }
                    else
                    {
                        moms = 0;
                    }
                    slutPrisInkMoms = (float)totalSumma - ((float)totalSumma * ((float)moms / 100));
                    MessageBox.Show($"Original Pris: {totalSumma}kr\nPris Ink Moms:{slutPrisInkMoms}kr\nMoms: {moms} %");
                } else
            {
                MessageBox.Show("Ingen logi vald.");
            }
            
        }

    }
}