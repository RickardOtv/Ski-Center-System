using Affärslager;
using Entitetslager;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class ÅterlämningUthyrning : Form
    {
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        private Uthyrningsrad valdRad;

        public ÅterlämningUthyrning(LoggaIn loggaIn, Kontroller kontroller)
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

        //Knapp för att gå tillbaka
        private void Tillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Uppdaterar GridÅterlämning med bokningar
        internal void RefreshBokningar()
        {
            var bokningar = kontroller.HämtaBokningar();
            GridÅterlämning.DataSource = bokningar;
            GridÅterlämning.AutoGenerateColumns = false;
            GridÅterlämning.Columns["BokningsID"].DisplayIndex = 0;
            GridÅterlämning.Columns["KundID"].DisplayIndex = 1;
            GridÅterlämning.Columns["Kund"].Visible = false;
        }

        //Uppdaterar GridÅterlämning med Utrustning som tillhör en specifik uthyrning
        internal void RefreshRader(int id)
        {
            var rader = kontroller.HämtaUthyrningsRad(id);
            GridÅterlämning.DataSource = rader;
            GridÅterlämning.AutoGenerateColumns = false;
            GridÅterlämning.Columns["Uthyrning"].Visible = false;
            GridÅterlämning.Columns["Utrustning"].Visible = false;
            GridÅterlämning.Columns["UthyrningsradID"].DisplayIndex = 0;
            GridÅterlämning.Columns["UtrustningsID"].DisplayIndex = 1;
            GridÅterlämning.Columns["Från"].DisplayIndex = 2;
            GridÅterlämning.Columns["Till"].DisplayIndex = 3;
            GridÅterlämning.Columns["UthyrningsID"].DisplayIndex = 4;
        }

        //Söker och uppdaterar GridÅterlämning med utrusningar så som matchar ett specifikt uthyrningsID
        private void HittaRättUthyrningsID()
        {
            if (int.TryParse(TextBoxUthyrningsID.Text, out int angivetID))
            {
                RefreshRader(angivetID);
            }
            else
            {
                MessageBox.Show("Felaktigt ID, måste vara siffror.");
            }
        }

        //Knapp för att söka efter Utrustning som tillhör en specifik uthyrning
        private void btnSök_Click(object sender, EventArgs e)
        {
            int.TryParse(TextBoxUthyrningsID.Text, out int angivetID);

            var rader = kontroller.HämtaUthyrningsRad(angivetID);
            bool isEmpty = !rader.Any();
            //Kollar om det finns någon sån utrustning uthyrd
            if (!isEmpty)
            {
                HittaRättUthyrningsID();
            }
            else
            {
                MessageBox.Show("Inga rader hittade.");
            }
        }

        //Knapp för att återlämna en vald utrusning
        private void btnÅterlämna_Click(object sender, EventArgs e)
        {
            //Kollar om nån utrustning är vald
            if (GridÅterlämning.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Är du säker på att denna vara ska återlämnas?", "Godkännande", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    valdRad = GridÅterlämning.SelectedRows[0].DataBoundItem as Uthyrningsrad;

                    //Hämtar rätt info för återlämning
                    Uthyrning valdUthyrning = kontroller.HittaUthyrningFrånRad(valdRad.UthyrningsID);
                    Faktura valdFaktura = kontroller.HittaFaktura(valdUthyrning.BokningsID);
                    string typ = kontroller.HämtaUthyrningsTyp(valdRad.UtrustningsID);
                    decimal pris = kontroller.KollaUthyrningsPris(valdRad.Från, valdRad.Till, typ);
                    valdFaktura.TotalPris = valdFaktura.TotalPris + (float)pris;

                    //Visar klar faktura osv
                    MessageBox.Show($"Faktura med ID: {valdFaktura.BokningsID} \nHar nytt totalpris på: {valdFaktura.TotalPris}kr \nRabatt: {valdFaktura.Rabattsats}% \nMoms: {valdFaktura.Momsats}%\n\nUthyrning Återlämnad med ID: {valdRad.UthyrningsID}\nRadID: {valdRad.UthyrningsradID}\nFrån {valdRad.Från.ToShortDateString()} \nTill: {valdRad.Till.ToShortDateString()}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kontroller.TaBortUthyrningsRad(valdRad);
                    HittaRättUthyrningsID();
                }
                else if (result == DialogResult.No)
                {

                }
            }
            else
            {
                // Felhanterare när val saknas
                MessageBox.Show("Välj en hel rad att ta bort", "Saknas val av rad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
