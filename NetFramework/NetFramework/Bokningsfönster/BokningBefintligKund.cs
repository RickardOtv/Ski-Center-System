using Affärslager;
using Datalager;
using Entitetslager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class BokningBefintligKund : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private LoggaIn loggaInMeny;
        private Kontroller kontroller;
        private Kund valdKund;
        Bokningsrad valdRad;
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

        internal void RefreshLogi()
        {
            try
            {
                DateTime startDate = dateFrån.Value;
                DateTime endDate = dateTill.Value;

                
                var ledigaLogier = kontroller.HämtaLedigaLogier(startDate, endDate);

                // You may need to adjust gridLogi for data binding
                gridLogi.DataSource = ledigaLogier;

                // Assuming gridLogi is a DataGridView
                gridLogi.Columns["LogiID"].HeaderText = "LogiID för boende";
                gridLogi.Columns["Typ"].HeaderText = "Typ av boende";
            }
            catch (Exception ex)
            {
                // Handle exceptions here
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
            RefreshKunder();
        }

        //Hanterar avbryt av en bokning
        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            // Kontrollera om det finns en ny bokning
            if (nyBokning != null)
            {
                DialogResult result = MessageBox.Show("Om du går tillbaka så avbryter du bokningen", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    kontroller.TaBortBokning(nyBokning);

                    BokningsTyp bokningsTyp = new BokningsTyp(loggaInMeny, kontroller);
                    bokningsTyp.Show();
                    bokningsTyp.InloggadAnvandare = txtAnvandarnamn.Text;
                    this.Close();
                }
                // Om användaren väljer att inte avbryta, gör inget
                else if (result == DialogResult.No)
                {

                }
            }
            else
            {
                // Om det inte finns någon ny bokning, öppna bara BokningsTyp-formuläret
                BokningsTyp bokningsTyp = new BokningsTyp(loggaInMeny, kontroller);
                bokningsTyp.Show();
                bokningsTyp.InloggadAnvandare = txtAnvandarnamn.Text;
                this.Close();
            }
        }

        //Söker upp kund på deras personNr
        private void btnSök_Click(object sender, EventArgs e)
        {
            string matatPersNr = txtFilter.Text;
            var matchadKund = kontroller.HittaKund(matatPersNr);
            if (matchadKund != null)
            {
                gridKunder.DataSource = new List<Kund> { matchadKund };
            }
            else
            {
                MessageBox.Show("Kund ej hittad, försök igen");
            }
        }

        //Kollar pris på ett logi för ett specifikt interavall 
        private void btnKollaPris_Click(object sender, EventArgs e)
        {
            int moms;
            float PrisInkMoms;
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

                        //Hämtar datumen för bokning
                        DateTime startDate = dateFrån.Value;
                        DateTime endDate = dateTill.Value;
                        decimal pris = kontroller.KollaPris(startDate, endDate, valdLogi.Typ);
                        if (valdKund.Typ == "Företag")
                        {
                            moms = 12;
                        }
                        else
                        {
                            moms = 0;
                        }
                        PrisInkMoms = (float)pris * ((float)moms / 100);
                        MessageBox.Show($"Pris Ink Moms: {pris}kr\nMoms: {PrisInkMoms}kr\nMoms: {moms}%");
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
            else
            {
                MessageBox.Show("Välj först en kund.");
            }
        }


        //Knappen lägger till ett logi till bokningen
        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            // Kontrollera om en kund är vald
            if (valdKund != null)
            {
                // Kontrollera om några rader är markerade i gridLogi
                if (gridLogi.SelectedRows.Count > 0)
                {
                    // Hämta den första markerade raden från listan av lediga logier
                    var selectedRow = gridLogi.SelectedRows[0];
                    var rowIndex = selectedRow.Index;

                    // Kontrollera att rowIndex är inom korrekta gränser
                    if (rowIndex >= 0 && rowIndex < ledigaLogier.Count)
                    {
                        // Kontrollera att Från-datumet inte är samma som Till-datumet
                        if (dateFrån.Text != dateTill.Text)
                        {
                            // Kontrollera att Från-datumet är före Till-datumet
                            if (DateTime.Parse(dateFrån.Text) < DateTime.Parse(dateTill.Text))
                            {
                                // Hämta den valda logien
                                var valdLogi = ledigaLogier[rowIndex];

                                DateTime startDate = DateTime.Parse(dateFrån.Text);
                                DateTime endDate = DateTime.Parse(dateTill.Text);
                                Bokningsrad nyBokningsrad = kontroller.SkapaBokningsRad(startDate, endDate, valdLogi, nyBokning.BokningsID);
                                MessageBox.Show($"Ny bokningsrad har skapats med Logi: {valdLogi.LogiID}\nBokningsID: {nyBokning.BokningsID}\nBokningsradID som genererats: {nyBokningsrad.BokningsradID}");
                                RefreshRader();
                                RefreshLogi();
                            }
                            else
                            {
                                MessageBox.Show("Från datum måste vara större än Till datum.");
                            }
                        }
                        else
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
            }
            else
            {
                MessageBox.Show("Välj först en kund.");
            }
        }

        //Knapp för att ta bort valt logi från bokning
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
            MessageBox.Show($"Vald kund: {valdKund.Namn}");
        }

        //Knapp för att väl skapa bokning när man är klar
        private void btnKlar_Click(object sender, EventArgs e)
        {
            // Kontrollera om en ny bokning finns
            if (nyBokning != null)
            {
                // Kontrollera om några rader är markerade i gridRader
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
                            Logi ettLogi = kontroller.HittaLogi(bokningsrad.LogiID);

                            // Justera Till-datum så att det inte finns en extra dag
                            DateTime newTillDate = bokningsrad.Till.AddDays(-1);

                            // Hämta priset för bokningsraden och lägg till i den totala kostnaden
                            decimal pris = kontroller.KollaPris(bokningsrad.Från, newTillDate, ettLogi.Typ);
                            totalSumma += pris;

                            // Uppdatera minDatum om det finns en tidigare starttid
                            if (minDatum > bokningsrad.Från)
                            {
                                minDatum = bokningsrad.Från;
                            }

                            // Uppdatera maxDatum om det finns en senare sluttid
                            if (maxDatum < bokningsrad.Till)
                            {
                                maxDatum = bokningsrad.Till;
                            }
                        }
                    }

                    // Om kunden är av typen "Företag," sätt momsSatts till 12%
                    if (valdKund.Typ == "Företag")
                    {
                        momsSatts = 12;
                    }

                    // Skapa en faktura och räkna ut slutpriset inklusive moms
                    Faktura nyFaktura = kontroller.SkapaFaktura(nyBokning.BokningsID, momsSatts, rabattsatts, (float)totalSumma);
                    slutPrisInkMoms = (float)nyFaktura.TotalPris * ((float)nyFaktura.Momsats / 100);

                    MessageBox.Show($"Bokning skapad: \nBokningsID: {nyBokning.BokningsID} \nFrån {minDatum.ToShortDateString()} \nTill: {maxDatum.ToShortDateString()}  \n\nTillhörande Faktura:\nFakturaID: {nyFaktura.FakturaID} \nRabatt: {nyFaktura.Rabattsats}% \nMoms: {slutPrisInkMoms}kr\nMoms: {nyFaktura.Momsats}%\nTotalPris (Ink Moms): {nyFaktura.TotalPris}kr", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HuvudMeny huvudMeny = new HuvudMeny(loggaInMeny, kontroller);
                    huvudMeny.Show();
                    huvudMeny.InloggadAnvandare = txtAnvandarnamn.Text;
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

        //Knapp för att visa information om valt logi
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
                    //Visar olika information beroende på typen av logi
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

        //Knapp för att räkna ut den totala summan för bokningen
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
                        // Hämta den valda bokningsraden och tillhörande Logi-objekt
                        Logi ettLogi = kontroller.HittaLogi(bokningsrad.LogiID);

                        // Ta bort en dag från Till-datum, så det räknas rätt
                        DateTime newDate = bokningsrad.Till.AddDays(-1);

                        // Hämta priset för bokningsraden och lägg till i den totala kostnaden
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
                slutPrisInkMoms = (float)totalSumma * ((float)moms / 100);
                MessageBox.Show($"Pris Ink Moms: {totalSumma}kr\nMoms: {slutPrisInkMoms}kr\nMoms: {moms}%");
            }
            else
            {
                MessageBox.Show("Ingen logi vald.");
            }
        }
    }
}