using Affärslager;
using Datalager;
using Entitetslager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class UthyrningUtrustning : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        private Utrustning valdUtrustning;
        private IList<Utrustning> tillgängligUtrustning;
        private Bokning valdBokning;
        Uthyrning nyUthyrning;
        
        public UthyrningUtrustning(LoggaIn loggain, Kontroller kontroller, Bokning valdBokning, Uthyrning nyUthyrning)
        {
            InitializeComponent();
            this.loggaIn = loggain;
            this.kontroller = kontroller;
            this.valdBokning = valdBokning;
            this.nyUthyrning = nyUthyrning;
            RefreshUtrustning();
        }

        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }

        //Hämtar data om tillgänglig utrustning till gridUtrustning
        internal void RefreshUtrustning()
        {
            var allUtrustning = kontroller.HämtaUtrustning();
            var uthyrdaUtrustningar = kontroller.HämtaUthyrningsRad(nyUthyrning.UthyrningsID).Select(u => u.UtrustningsID).ToList();
            tillgängligUtrustning = allUtrustning.Where(u => !uthyrdaUtrustningar.Contains(u.UtrustningsID)).ToList();

            gridUtrustning.DataSource = tillgängligUtrustning;
            gridUtrustning.AutoGenerateColumns = false;
            gridUtrustning.Columns["UtrustningsID"].DisplayIndex = 0;
            gridUtrustning.Columns["Typ"].DisplayIndex = 1;
            gridUtrustning.Columns["Storlek"].DisplayIndex = 2;
        }

        //Hämtar data om uthyrd utrustning till gridUtrustning
        internal void RefreshRader()
        {
            var rader = kontroller.HämtaUthyrningsRad(nyUthyrning.UthyrningsID);
            gridRader.DataSource = rader;
            gridRader.AutoGenerateColumns = false;
            gridRader.Columns["Uthyrning"].Visible = false;
            gridRader.Columns["Utrustning"].Visible = false;
            gridRader.Columns["UthyrningsradID"].DisplayIndex = 0;
            gridRader.Columns["UtrustningsID"].DisplayIndex = 1;
            gridRader.Columns["Från"].DisplayIndex = 2;
            gridRader.Columns["Till"].DisplayIndex = 3;
            gridRader.Columns["UthyrningsID"].DisplayIndex = 4;
        }
        
        //Load för att uppdatera grids när form öppnas
        public void UthyrningUtrustning_Load(object sender, EventArgs e)
        {
            cmbTyp.SelectedIndexChanged += cmbTyp_SelectedIndexChanged;

            RefreshUtrustning();
            txtBoxValdKund.Text = $"Vald Bokning: {valdBokning.BokningsID.ToString()}";
        }

        //Knapp för att lägga till utrusning till uthyrning
        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            valdUtrustning = gridUtrustning.SelectedRows[0].DataBoundItem as Utrustning;
            DateTime från = DateTime.Parse(dateFrån.Text);
            DateTime till = DateTime.Parse(dateTill.Text);
            int totalDays = (int)(till - från).TotalDays + 1;
            
            //Kollar så att uthyrning inte blir över max dagar
            if (totalDays > 5)
            {
                MessageBox.Show("Spannet får inte vara längre än fem dagar.");
            }
            else if ((valdUtrustning.Typ == "SkoterLynx" || valdUtrustning.Typ == "SkoterViking") && (totalDays == 2 || totalDays == 4))
            {
                MessageBox.Show("Skoter kan inte hyras i två eller fyra dagar. Vänligen välj en, tre eller fem dagar.");
            }
            else //Skapar uthyrnings rad om det inte överstiger max dagar
            {
                Uthyrningsrad nyUthyrningsRad = kontroller.SkapaUthyrningsRad(från, till, valdUtrustning, nyUthyrning.UthyrningsID);
                RefreshRader();
                RefreshUtrustning();
            }
        }

        //Knapp för att gå tillbaka
        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            if (nyUthyrning != null)
            {
                DialogResult result = MessageBox.Show("Om du går tillbaka så avbryter du Uthyrningen", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    kontroller.TaBortUthyrning(nyUthyrning);
                    this.Close();
                }
                else if (result == DialogResult.No)
                {

                }
            }
            else
            {
                this.Close();
            }
        }

        //skapar uthyrningen
        private void btnKlar_Click(object sender, EventArgs e)
        {
            //Kollar så att man har lagt till något i uthyrningen
            if (gridRader.SelectedRows.Count > 0)
            {
                float slutPrisInkMoms;
                int moms;
                float prisInkRabatt = 0;
                float momsPris;
                decimal totalpris = 0;
                //Går igenom varje rad i uthyrningen
                foreach (DataGridViewRow row in gridRader.Rows)
                {
                    if (row.DataBoundItem != null && row.DataBoundItem is Uthyrningsrad rad)
                    {
                        DateTime från = rad.Från;
                        DateTime till = rad.Till; // Assuming you have 'Till' property in your Uthyrningsrad
                        string typ = kontroller.HämtaUthyrningsTyp(rad.UtrustningsID);
                        int totalDays = (int)(till - från).TotalDays + 1; // Including both from and to dates

                        if (totalDays > 5)
                        {
                            MessageBox.Show("Spannet får inte vara längre än fem dagar.");
                        }
                        else if ((typ == "SkoterLynx" || typ == "SkoterViking") && (totalDays == 2 || totalDays == 4))
                        {
                            MessageBox.Show("Skoter kan inte hyras i två eller fyra dagar. Vänligen välj en, tre eller fem dagar.");
                        }
                        else
                        {
                            totalpris += kontroller.KollaUthyrningsPris(från, till, typ);
                        }
                    }
                }
                Faktura valdFaktura = kontroller.HittaFaktura(valdBokning.BokningsID);
                // Om rabatten är mer än 0%
                if (valdFaktura.Rabattsats != 0)
                {
                    prisInkRabatt = (float)totalpris - ((float)totalpris * ((float)valdFaktura.Rabattsats / 100));
                }
                else
                {
                    // Totalpris - priset av rabatten = totalpriset inklusive rabatt på sig 
                    prisInkRabatt = (float)totalpris - prisInkRabatt;
                }
                //Lägger till moms
                momsPris = prisInkRabatt - ((float)totalpris * ((float)valdFaktura.Momsats / 100));
                //float slutMomsPris = prisInkRabatt - momsPris;

                Kund valdKund = kontroller.HittaKund(valdBokning.KundID);

                //Kollar så att maxbelopp inte överstigs
                if ((prisInkRabatt + valdFaktura.TotalPris) <= valdKund.Maxbeloppskreditgräns)
                {
                    MessageBox.Show($"Rabatt: {valdFaktura.Rabattsats}%\nRabatt: -{(float)totalpris * ((float)valdFaktura.Rabattsats / 100)}kr\nMoms: {valdFaktura.Momsats}%\nMoms: {(float)totalpris * ((float)valdFaktura.Momsats / 100)}kr \n\nTotalpris (Ink Moms): {prisInkRabatt}kr");
                    //MessageBox.Show($"Totalpris för hela uthyrningen: {totalpris}kr");
                    kontroller.ÄndraFakturaTotalPris(valdFaktura, momsPris);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Det överstiger Maxbeloppkreditgräns:{valdKund.Maxbeloppskreditgräns}kr \nTotalpris (Ink Moms) för uthyrning är: {prisInkRabatt}kr");
                }
            }
            else
            {
                MessageBox.Show($"Välj först ett Logi, tack!");
            }
        }

        //Knapp för att kolla pris på specifik utrustning
        private void btnKollaPris_Click(object sender, EventArgs e)
        {
            float slutPrisInkMoms;
            int moms;
            float prisInkrabattPris;
            float prisInkMomOchRabatt;
            DateTime från = DateTime.Parse(dateFrån.Text);
            DateTime till = DateTime.Parse(dateTill.Text);

            //Kollar så att från datum inte är mer än till datum
            if (DateTime.Parse(dateFrån.Text) < DateTime.Parse(dateTill.Text))
            {
                valdUtrustning = gridUtrustning.SelectedRows[0].DataBoundItem as Utrustning;
                if (gridUtrustning.SelectedRows.Count > 0)
                {
                    var valdRad = gridUtrustning.SelectedRows[0];
                    var rowIndex = valdRad.Index;
                    if (rowIndex >= 0 && rowIndex < tillgängligUtrustning.Count)
                    {
                        Faktura valdFaktura = kontroller.HittaFaktura(valdBokning.BokningsID);
                        decimal pris = kontroller.KollaUthyrningsPris(från, till, valdUtrustning.Typ);

                        //Uträkning av pris inklusive rabatt
                        prisInkrabattPris = (float)pris - ((float)pris * ((float)valdFaktura.Rabattsats / 100));
                        MessageBox.Show($"Rabatt: {valdFaktura.Rabattsats}%\nMoms: {valdFaktura.Momsats}%\nMoms: {(float)pris * ((float)valdFaktura.Momsats / 100)}kr \n\nTotalpris (Ink Moms & Rabatt): {prisInkrabattPris}kr");
                    }
                    else
                    {
                        MessageBox.Show("Felaktig utrustning vald.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingen logi vald.");
                }
            }
            else
            {
                MessageBox.Show("Från datum måste vara större än Till datum.");
            }
        }


        //Knapp för att ta bort utrustning från lista på valda utrustningar
        private void btnTaBort_Click(object sender, EventArgs e)
        {
            // Kontrollera om det finns minst en rad vald
            if (gridRader.SelectedRows.Count > 0)
            {
                // Få den valda radens data
                Uthyrningsrad valdRad = gridRader.SelectedRows[0].DataBoundItem as Uthyrningsrad;

                // Anropa en funktion för att ta bort den valda raden (implementera den separat)
                TaBortUthyrningsRad(valdRad);

                // Uppdatera datagridview efter borttagning
                RefreshRader();
                RefreshUtrustning();
            }
            else
            {
                MessageBox.Show("Ingen rad är vald att ta bort.");
            }
        }

        //HJälper ta bort knappen att ta bort en specifik utrustning från uthyrning
        private void TaBortUthyrningsRad(Uthyrningsrad radAttTaBort)
        {
            // Implementera ditt borttagningslogik här. Till exempel:
            kontroller.TaBortUthyrningsRad(radAttTaBort);
        }

        #region filtrering typ/storlek

        //Combobox för att välja typ på utrustning
        private void cmbTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            UppdateraStorlekar();
            FiltreraData();
        }
        
        //Metod som hjälper till att filtrera storlek på utrustning
        private void UppdateraStorlekar()
        {
            var valdTyp = (string)cmbTyp.SelectedItem;
            cmbStorlek.Items.Clear();

            if (valdTyp != null)
            {
                var tillgangligaStorlekar = kontroller.HamtaStorlekarForTyp(valdTyp);
                foreach (var storlek in tillgangligaStorlekar)
                {
                    cmbStorlek.Items.Add(storlek);
                }
            }
        }

        //combobox för att välja storlekar
        private void cmbStorlek_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltreraData();
        }

        //Metod för att filtrera på utrusningar
        private void FiltreraData()
        {
            var valdTyp = (string)cmbTyp.SelectedItem;
            int? valdStorlek = cmbStorlek.SelectedItem as int?; // Använd 'as' för att försöka göra en säker typomvandling

            var filtreradData = kontroller.HämtaUtrustning()
                .Where(u => (valdTyp == null || u.Typ == valdTyp) &&
                            (!valdStorlek.HasValue || u.Storlek == valdStorlek.Value))
                .ToList();

            gridUtrustning.DataSource = filtreradData;
        }

        #endregion
    }
}
