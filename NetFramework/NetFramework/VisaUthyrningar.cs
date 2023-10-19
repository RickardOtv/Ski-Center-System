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
    public partial class VisaUthyrningar : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        Uthyrning valdUthyrning;
        Uthyrning hittadUthyrning;
        Kund hittadKund;
        Bokning matchadBokning;
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

        internal void RefreshUthyrningar()
        {
            var uthyrningar = kontroller.HämtaAllaUthyrningar();
            gridUthyrning.DataSource = uthyrningar;
            gridUthyrning.AutoGenerateColumns = false;
            gridUthyrning.Columns["Bokning"].Visible = false;
            gridUthyrning.Columns["UthyrningsID"].DisplayIndex = 0;
            gridUthyrning.Columns["BokningsID"].DisplayIndex = 1;
        }
        
        
        public void RefreshUthyrningarSpecifik(int uthyrningsID)
        {
            valdUthyrning = gridUthyrning.SelectedRows[0].DataBoundItem as Uthyrning;
            var uthyrningar = kontroller.HämtaUthyrningar(uthyrningsID);
            gridUthyrning.DataSource = uthyrningar;
        }
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
        public void RefreshLektioner()
        {
            var lektioner = kontroller.HämtaLektioner(valdUthyrning.BokningsID);
            gridLektioner.DataSource = lektioner;
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVäljUthyrning_Click(object sender, EventArgs e)
        {
            valdUthyrning = gridUthyrning.SelectedRows[0].DataBoundItem as Uthyrning;
            var rader = kontroller.HämtaUthyrningsRad(valdUthyrning.UthyrningsID);

            gridUthyrningsRader.DataSource = rader;
            RefreshRader();
           // RefreshLektioner();
        }

        private void VisaUthyrningar_Load(object sender, EventArgs e)
        {
            RefreshUthyrningar();
        }

        private void btnSök_Click(object sender, EventArgs e)
        {
            int matadUthyrningsID = int.Parse(txtBoxUthyrningsID.Text);
            var matchadeUthyrningar = unitOfWork.uthyrningar.Where(u => u.UthyrningsID == matadUthyrningsID).ToList();

            if (matchadeUthyrningar.Count > 0)
            {
                gridUthyrning.DataSource = matchadeUthyrningar;
            }
            else
            {
                MessageBox.Show("Inget matchande personnummer hittades, försök igen");
            }

        }

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

        

        private void txtBoxUthyrningsID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPersNr_Click(object sender, EventArgs e)
        {

        }

        private void lblUthyrning_Click(object sender, EventArgs e)
        {

        }

        private void gridUthyrning_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
