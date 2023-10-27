using System;
using Affärslager;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Entitetslager;
using Datalager;

namespace NetFramework
{
    public partial class SkapaUthyrning : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        private Bokning valdBokning;
        private Uthyrning nyUthyrning;
        private LoggaIn loggaInMeny;

        public SkapaUthyrning(LoggaIn loggain, Kontroller kontroller)
        {
            InitializeComponent();
            this.loggaIn = loggain;
            this.kontroller = kontroller;
            RefreshBokningar();
        }

        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }

        //Hämtar bokningar till gridBokningar
        internal void RefreshBokningar()
        {
            var bokningar = kontroller.HämtaBokningar();
            gridBokningar.DataSource = bokningar;
            gridBokningar.AutoGenerateColumns = false;
            gridBokningar.Columns["BokningsID"].DisplayIndex = 0;
            gridBokningar.Columns["KundID"].DisplayIndex = 1;
            gridBokningar.Columns["Kund"].Visible = false;
        }
        
        //Load för att hämta bokningar när form öppnas
        public void SkapaUthyrning_Load(object sender, EventArgs e)
        {
            RefreshBokningar();
        }

        //knapp skapar en uthyrning baserat på den valda bokningen
        private void VäljBtn_Click(object sender, EventArgs e)
        {
            //Kollar om en bokning var vald
            if (gridBokningar.SelectedRows.Count > 0)
            {
                // Hämta den valda bokningen
                valdBokning = gridBokningar.SelectedRows[0].DataBoundItem as Bokning;
                nyUthyrning = kontroller.SkapaUthyrning(valdBokning);
                MessageBox.Show($"Uthyrning har skapats med ID:{nyUthyrning.UthyrningsID} med bokningsID:{valdBokning.BokningsID}");
                
                // Skapa nästa fönster och skicka med den valda bokningen
                UthyrningUtrustning uthyrningUtrustning = new UthyrningUtrustning(loggaInMeny, kontroller, valdBokning, nyUthyrning);
                uthyrningUtrustning.InloggadAnvandare = txtAnvandarnamn.Text;
                uthyrningUtrustning.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vänligen välj en bokning först.");
            }
        }

        //Knapp för att gå tillbaka
        private void btnTillbaka_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //Söker efter bokningar med matchande inmatat bokningsnummer
        private void BokningsnummerBtn_Click(object sender, EventArgs e)
        {
            Bokning matchadBokning;
            String söktBokningsNummer = txtBoxBokningsID.Text;

            //Kollar om inmatning matchar formatering
            if (kontroller.IsDigitsOnly(söktBokningsNummer) && !string.IsNullOrEmpty(söktBokningsNummer))
            {
                matchadBokning = kontroller.HittaBokning(söktBokningsNummer);
                //Om ingen bokning hittades
                if (matchadBokning != null)
                {
                    gridBokningar.DataSource = new List<Bokning> { matchadBokning };
                }
                else
                {
                    MessageBox.Show("Bokning ej hittad, försök igen");
                }
            }
            else
            {
                MessageBox.Show("Bokning ej hittad, försök igen");
            }
        }

        //Söker efter bokningar med matchande inmatat kundID
        private void KundSokBtn_Click(object sender, EventArgs e)
        {
            //Kollar så att inmatning rätt formaterad
            if (kontroller.IsDigitsOnly(txtBoxKundID.Text) && !string.IsNullOrEmpty(txtBoxKundID.Text))
            {
                int matadKundID = int.Parse(txtBoxKundID.Text);
                var matchadeBokningar = unitOfWork.bokningar.Where(b => b.KundID == matadKundID).ToList();

                //Kollar om nån bokning hittades
                if (matchadeBokningar.Count > 0)
                {
                    gridBokningar.DataSource = matchadeBokningar;
                }
                else
                {
                    MessageBox.Show("Inget matchande kundID hittades, försök igen");
                }
            }
            else
            {
                MessageBox.Show("Inget matchande kundID hittades, försök igen");
            }
        }
    }
}
