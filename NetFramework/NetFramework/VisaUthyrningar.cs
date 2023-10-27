using Affärslager;
using Datalager;
using Entitetslager;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class VisaUthyrningar : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        Uthyrning valdUthyrning;

        public VisaUthyrningar(LoggaIn loggaIn, Kontroller kontroller)
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

        //Fyller på gridUthyrning med uthyrningar
        internal void RefreshUthyrningar()
        {
            var uthyrningar = kontroller.HämtaAllaUthyrningar();
            gridUthyrning.DataSource = uthyrningar;
            gridUthyrning.AutoGenerateColumns = false;
            gridUthyrning.Columns["Bokning"].Visible = false;
            gridUthyrning.Columns["UthyrningsID"].DisplayIndex = 0;
            gridUthyrning.Columns["BokningsID"].DisplayIndex = 1;
        }

        //Fyller på girduthyrning med specifik uthyrning
        public void RefreshUthyrningarSpecifik(int uthyrningsID)
        {
            valdUthyrning = gridUthyrning.SelectedRows[0].DataBoundItem as Uthyrning;
            var uthyrningar = kontroller.HämtaUthyrningar(uthyrningsID);
            gridUthyrning.DataSource = uthyrningar;
        }

        //Fyller på gridUthyrningsRader (utrusning) som matchar en uthyrning
        public void RefreshRader()
        {
            var rader = kontroller.HämtaUthyrningsRad(valdUthyrning.UthyrningsID);
            gridUthyrningsRader.DataSource = rader;
            gridUthyrningsRader.Columns["Från"].DefaultCellStyle.Format = "d";
            gridUthyrningsRader.Columns["Till"].DefaultCellStyle.Format = "d";
            gridUthyrningsRader.AutoGenerateColumns = false;
            gridUthyrningsRader.Columns["Uthyrning"].Visible = false;
            gridUthyrningsRader.Columns["Utrustning"].Visible = false;
            gridUthyrningsRader.Columns["UthyrningsradID"].DisplayIndex = 0;
            gridUthyrningsRader.Columns["UtrustningsID"].DisplayIndex = 1;
            gridUthyrningsRader.Columns["Från"].DisplayIndex = 2;
            gridUthyrningsRader.Columns["Till"].DisplayIndex = 3;
            gridUthyrningsRader.Columns["UthyrningsID"].DisplayIndex = 4;
        }

        //Knapp för att gå tillbaka
        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Knapp för att välja uthyrning som info ska visas om
        private void btnVäljUthyrning_Click(object sender, EventArgs e)
        {
            valdUthyrning = gridUthyrning.SelectedRows[0].DataBoundItem as Uthyrning;
            var rader = kontroller.HämtaUthyrningsRad(valdUthyrning.UthyrningsID);
            gridUthyrningsRader.DataSource = rader;
            RefreshRader();
        }

        //Load för att fylla på grid med uthyrningar när form öppnas
        private void VisaUthyrningar_Load(object sender, EventArgs e)
        {
            RefreshUthyrningar();
        }

        //söker efter uthyrningar baserat på matchande uthyrnings-ID
        private void btnSök_Click(object sender, EventArgs e)
        {
            String söktBokningsNummer = txtBoxUthyrningsID.Text;
            //Kollar så att inmatning har rätt format
            if (kontroller.IsDigitsOnly(söktBokningsNummer) && !string.IsNullOrEmpty(söktBokningsNummer))
            {
                int matadUthyrningsID = int.Parse(txtBoxUthyrningsID.Text);
                var matchadeUthyrningar = unitOfWork.uthyrningar.Where(u => u.UthyrningsID == matadUthyrningsID).ToList();

                //Kollar om det finns matchande uthyrningar
                if (matchadeUthyrningar.Count > 0)
                {
                    gridUthyrning.DataSource = matchadeUthyrningar;
                }
                else
                {
                    MessageBox.Show("Inget matchande UthyrningsID hittades, försök igen");
                }
            }
            else
            {
                MessageBox.Show("Mata in ett giltigt UthyrningsID, försök igen");
            }
        }

        //Knapp för att ta bort en uthyrning
        private void btnTaBort_Click(object sender, EventArgs e)
        {
            valdUthyrning = gridUthyrning.SelectedRows[0].DataBoundItem as Uthyrning;
            DialogResult result = MessageBox.Show("Är du säker att du vill ta bort uthyrningen?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (gridUthyrning.SelectedRows != null)
                {
                    kontroller.TaBortUthyrning(valdUthyrning);
                    RefreshUthyrningar();
                }
            }
            else if (result == DialogResult.No)
            {

            }
        }
    }
}
