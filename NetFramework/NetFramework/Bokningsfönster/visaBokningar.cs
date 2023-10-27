using Affärslager;
using Datalager;
using Entitetslager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class VisaBokningar : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private LoggaIn loggaIn;
        private Kontroller kontroller;
        private Bokning valdBokning;
        private Logi valdLogi;
        private Bokningsrad valdRad;

        public VisaBokningar(LoggaIn loggaIn, Kontroller kontroller)
        {
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
            InitializeComponent();
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
        internal void RefreshRader(Bokning valdBokning)
        {
            //Logi
            var rader = kontroller.HämtaRader(valdBokning.BokningsID);
            gridBokningar.AutoGenerateColumns = false;
            logiGrid.DataSource = rader;
            logiGrid.AutoGenerateColumns = false;
            logiGrid.Columns["Bokning"].Visible = false;
            logiGrid.Columns["Logi"].Visible = false;
            logiGrid.Columns["BokningsradID"].DisplayIndex = 0;
            logiGrid.Columns["LogiID"].DisplayIndex = 1;
            logiGrid.Columns["Från"].DisplayIndex = 2;
            logiGrid.Columns["Till"].DisplayIndex = 3;
            logiGrid.Columns["BokningsID"].DisplayIndex = 4;
        }


        public void VisaBokningar_Load(object sender, EventArgs e)
        {
            RefreshBokningar();
        }

        private void btn_tillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metoden btn_ändra_Click hanterar händelsen när användaren klickar på en knapp för att ändra en bokning. Den kontrollerar om någon rad är markerad i griden för bokningsrader. Om minst en rad är markerad öppnas fönstret för att ändra bokningen med informationen om den valda raden. Om ingen rad är markerad visas ett meddelande som uppmanar användaren att välja en rad för att redigera.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ändra_Click(object sender, EventArgs e)
        {
            if (logiGrid.SelectedRows.Count > 0)
            {
                // At least one row is selected.
                valdRad = logiGrid.SelectedRows[0].DataBoundItem as Bokningsrad;
                ÄndraBokning ändraBokning = new ÄndraBokning(loggaIn, kontroller, valdRad);
                ändraBokning.Show();
                ändraBokning.InloggadAnvandare = txtAnvandarnamn.Text;
            }
            else
            {
                // No row is selected. Show a message or handle it as needed.
                MessageBox.Show("Please select a row to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Ej Klar
        private void btn_taBort_Click(object sender, EventArgs e)
        {
            valdBokning = gridBokningar.SelectedRows[0].DataBoundItem as Bokning;
            DialogResult result = MessageBox.Show("Are you sure you want to remove this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (gridBokningar.SelectedRows != null)
                {
                    kontroller.TaBortBokning(valdBokning);
                    RefreshBokningar();
                }
            }
            else if (result == DialogResult.No)
            {

            }

        }


        /// <summary>
        /// Metoden btnSökBokNr_Click hanterar händelsen när användaren klickar på en knapp för att söka efter en bokning med hjälp av bokningsnummer. Den kontrollerar om det inmatade bokningsnumret enbart innehåller siffror och inte är tomt. Om detta är fallet används det inmatade bokningsnumret för att söka efter en matchande bokning i systemet. Om en matchande bokning hittas visas den i griden för bokningar. Om ingen matchning hittas visas ett meddelande som uppmanar användaren att försöka igen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSökBokNr_Click(object sender, EventArgs e)
        {
            Bokning matchadBokning;
            String söktBokningsNummer = txtFilter.Text;
            if (kontroller.IsDigitsOnly(söktBokningsNummer) && !string.IsNullOrEmpty(söktBokningsNummer))
            {
                matchadBokning = kontroller.HittaBokning(söktBokningsNummer);
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


        /// <summary>
        /// Metoden btn_sökPersonNr_Click hanterar händelsen när användaren klickar på en knapp för att söka efter bokningar baserat på personnummer. Den tar in det inmatade personnumret och använder det för att söka efter matchande bokningar i databasen. Om det finns matchande bokningar visas de i griden för bokningar. Om inga matchningar hittas visas ett meddelande som uppmanar användaren att försöka igen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sökPersonNr_Click(object sender, EventArgs e)
        {
            string matadPersonNr = textBox_personNr.Text;
            var matchadeBokningar = unitOfWork.bokningar.Where(b => b.Kund.Personnummer == matadPersonNr).ToList();

            if (matchadeBokningar.Count > 0)
            {
                gridBokningar.DataSource = matchadeBokningar;
            }
            else
            {
                MessageBox.Show("Inget matchande personnummer hittades, försök igen");
            }
        }



        private void btn_visaRader_Click(object sender, EventArgs e)
        {
            valdBokning = gridBokningar.SelectedRows[0].DataBoundItem as Bokning;
            RefreshRader(valdBokning);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            valdBokning = gridBokningar.SelectedRows[0].DataBoundItem as Bokning;
            RefreshBokningar();
            RefreshRader(valdBokning);
        }
        /// <summary>
        /// Metoden btn_TaBortRad_Click hanterar händelsen när användaren klickar på en knapp för att ta bort en bokningsrad. Den kontrollerar om någon rad är markerad i griden för bokningsrader. Om minst en rad är markerad visas en bekräftelsedialogruta för att säkerställa att användaren vill ta bort den valda raden. Om användaren bekräftar borttagningen tas den valda bokningsraden bort från systemet och rutorna för bokningsrader uppdateras. Om ingen rad är markerad visas ett meddelande som uppmanar användaren att välja en rad för att ta bort.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TaBortRad_Click(object sender, EventArgs e)
        {
            if (logiGrid.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    valdRad = logiGrid.SelectedRows[0].DataBoundItem as Bokningsrad;
                    valdBokning = gridBokningar.SelectedRows[0].DataBoundItem as Bokning;
                    kontroller.TaBortLogi(valdRad);
                    RefreshRader(valdBokning);
                }
                else if (result == DialogResult.No)
                {

                }
            }
            else
            {
                // No row is selected. Show a message or handle it as needed.
                MessageBox.Show("Please select a row to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
