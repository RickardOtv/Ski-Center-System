using System;
using Affärslager;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        internal void RefreshBokningar()
        {
            var bokningar = kontroller.HämtaBokningar();
            gridBokningar.DataSource = bokningar;
            gridBokningar.AutoGenerateColumns = false;
            gridBokningar.Columns["BokningsID"].DisplayIndex = 0;
            gridBokningar.Columns["KundID"].DisplayIndex = 1;
            gridBokningar.Columns["Kund"].Visible = false;
        
        }
        public void SkapaUthyrning_Load(object sender, EventArgs e)
        {
            RefreshBokningar();
        }

        /// <summary>
        /// Metoden hanterar händelsen när användaren klickar på en knapp och skapar en uthyrning baserat på den valda bokningen. Om det finns en vald rad i griden skapas en uthyrning med informationen från den valda bokningen och ett meddelande visas med informationen om den skapade uthyrningen. En nytt fönster för uthyrning av utrustning öppnas med den valda bokningen och den skapade uthyrningen, annars visas ett meddelande som uppmanar användaren att först välja en bokning.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VäljBtn_Click(object sender, EventArgs e)
        {
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

        private void btnTillbaka_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metoden hanterar händelsen när användaren klickar på en knapp och söker efter matchande bokningsnummer i en databas. Om ett matchande bokningsnummer hittas, uppdateras griden med de matchande bokningarna, annars visas ett meddelande som uppmanar användaren att försöka igen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BokningsnummerBtn_Click(object sender, EventArgs e)
        {
            int matadBokningsID = int.Parse(txtBoxBokningsID.Text);
            var matchadeBokningar = unitOfWork.bokningar.Where(b => b.BokningsID == matadBokningsID).ToList();

            if (matchadeBokningar.Count > 0)
            {
                gridBokningar.DataSource = matchadeBokningar;
            }
            else
            {
                MessageBox.Show("Inget matchande bokningsID hittades, försök igen");
            }
        }
        /// <summary>
        /// Metoden hanterar händelsen när användaren klickar på en knapp och söker efter matchande kund-ID i en databas. Om matchande kund-ID hittas, uppdateras griden med de matchande bokningarna, annars visas ett meddelande som uppmanar användaren att försöka igen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KundSokBtn_Click(object sender, EventArgs e)
        {
            int matadKundID = int.Parse(txtBoxKundID.Text);
            var matchadeBokningar = unitOfWork.bokningar.Where(b => b.KundID == matadKundID).ToList();

            if (matchadeBokningar.Count > 0)
            {
                gridBokningar.DataSource = matchadeBokningar;
            }
            else
            {
                MessageBox.Show("Inget matchande kundID hittades, försök igen");
            }
        }
    }
}
