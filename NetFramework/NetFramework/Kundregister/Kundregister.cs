using Affärslager;
using Datalager;
using Entitetslager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class Kundregister : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private LoggaIn loggaIn;
        private Kontroller kontroller;
        private Kund valdKund;

        

        public Kundregister(LoggaIn loggaIn, Kontroller kontroller)
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

        internal void RefreshKunder()
        {
            
            var kunder = kontroller.HämtaKunder();
            gridKunder.DataSource = kunder;
            gridKunder.AutoGenerateColumns = false;
            gridKunder.Columns["Maxbeloppskreditgräns"].Visible = false;
            gridKunder.Columns["Adress"].Visible = false;
            gridKunder.Columns["PostOrt"].Visible = false;
            gridKunder.Columns["PostNr"].Visible = false;
            gridKunder.Columns["KundID"].DisplayIndex = 0;
            gridKunder.Columns["Typ"].DisplayIndex = 1;
            gridKunder.Columns["Personnummer"].DisplayIndex = 2;
            gridKunder.Columns["Namn"].DisplayIndex = 3;
            gridKunder.Columns["Telefonnummer"].DisplayIndex = 4;
            gridKunder.Columns["Email"].DisplayIndex = 5;
            
        }
        private void Kundregister_Load(object sender, EventArgs e)
        {
            RefreshKunder();
        }
        /// <summary>
        /// Denna metod btnTaBort_Click hämtar den valda kunden från den valda raden i kundrutfältet och tar sedan bort kunden genom att använda kontroller.TaBortKund-metoden. Efter borttagningen uppdateras kundlistan och en dialogruta visas som bekräftar borttagningen av den specifika kunden med hjälp av kundens ID, personnummer och namn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTaBort_Click(object sender, EventArgs e)
        {
            valdKund = gridKunder.SelectedRows[0].DataBoundItem as Kund;

            DialogResult result = MessageBox.Show("Är du säker att du vill ta bort kund?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (gridKunder.SelectedRows != null)
                {
                    valdKund = kontroller.HittaKund(valdKund.KundID);
                    kontroller.TaBortKund(valdKund);
                    RefreshKunder();
                    MessageBox.Show($"Tog Bort Kund: {valdKund.KundID} \nMed personnummer: {valdKund.Personnummer} \n Namn: {valdKund.Namn}");

                } else
                {
                    MessageBox.Show("Välj först en kund, tack!", "Confirmation");
                }
            }
            else if (result == DialogResult.No)
            {

            }

        }
        /// <summary>
        /// Denna metod btnAndra_Click hanterar händelsen när användaren klickar på knappen "Ändra". Den börjar med att hämta den valda kunden från den valda raden i kundrutfältet och sedan kontrollera behörigheten för inloggad användare. Beroende på kundtyp och behörighet öppnas antingen formuläret för att ändra företagskund eller privatkund. Dialogrutan "Du har ej rätt behörighet" visas om användaren inte har tillräckliga behörigheter för att ändra företagskunden. Efter att ha öppnat formuläret för ändring av kund, visas det med information om inloggad användare.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAndra_Click(object sender, EventArgs e)
        {
            valdKund = gridKunder.SelectedRows[0].DataBoundItem as Kund;
            string inmatning = kontroller.HittaBehörighet(int.Parse(txtAnvandarnamn.Text));

            if (gridKunder.SelectedRows != null)
            {
                if(valdKund.Typ == "Företag")
                {
                    if (inmatning == "Admin" || inmatning == "Marknad")
                    {
                        ÄndraFöretagsKund ändraFöretagsKund = new ÄndraFöretagsKund(loggaIn, kontroller, valdKund);
                        ändraFöretagsKund.Show();
                        ändraFöretagsKund.InloggadAnvandare = txtAnvandarnamn.Text;
                    }
                    else
                        MessageBox.Show("Du har ej rätt behörighet.");
                } else
                {
                    ÄndraKund ändraKund = new ÄndraKund(loggaIn, kontroller, valdKund);
                    ändraKund.Show();
                    ändraKund.InloggadAnvandare = txtAnvandarnamn.Text;
                }
            }
           
        }

       

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            HuvudMeny huvudMeny = new HuvudMeny(loggaIn, kontroller);
            huvudMeny.Show();
            huvudMeny.InloggadAnvandare = txtAnvandarnamn.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshKunder();
        }
        /// <summary>
        /// Denna metoden btnSokNamn_Click hanterar händelsen när användaren klickar på knappen "Sök" baserat på namn. Den tar in det inmatade namnet från textfältet och söker efter matchande kunder i databasen. Om det finns matchande kunder visas de i data grid-vyn, annars visas ett meddelande om att inga matchningar hittades.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSokNamn_Click(object sender, EventArgs e)
        {
            
            string matadNamn = txtBoxNamn.Text;
            var matchadeKunder = unitOfWork.kunder.Where(k => k.Namn == matadNamn).ToList();

            if (matchadeKunder.Count > 0)
            {
                gridKunder.DataSource = matchadeKunder;
            }
            else
            {
                MessageBox.Show("Inget matchande personnummer hittades, försök igen");
            }
            
        }
        /// <summary>
        /// Denna metod btnSokPersonNr_Click hanterar händelsen när användaren klickar på knappen "Sök" baserat på personnummer. Den tar in det inmatade personnumret från textfältet och söker efter matchande kunder i databasen. Om det finns matchande kunder visas de i data grid-vyn, annars visas ett meddelande om att inga matchningar hittades.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSokPersonNr_Click(object sender, EventArgs e)
        {
            
            string matadPeronNr = txtBoxPersonNr.Text;
            var matchadeKunder = unitOfWork.kunder.Where(k => k.Personnummer == matadPeronNr).ToList();

            if (matchadeKunder.Count > 0)
            {
                gridKunder.DataSource = matchadeKunder;
            }
            else
            {
                MessageBox.Show("Inget matchande personnummer hittades, försök igen");
            }
            

        }

        private void lblPersonNr_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxPersonNr_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void lblNamn_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxNamn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
