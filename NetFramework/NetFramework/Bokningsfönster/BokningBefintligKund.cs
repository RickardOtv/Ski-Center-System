using Affärslager;
using Datalager;
using Entitetslager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public BokningBefintligKund(LoggaIn loggaInMeny, Kontroller kontroller)
        {
            this.loggaInMeny = loggaInMeny;
            this.kontroller = kontroller;
            InitializeComponent();
        }
        
        internal void RefreshLogi()
        {
            var logier = kontroller.HämtaTillgängligLogi();
            gridLogi.DataSource = logier;
            gridLogi.AutoGenerateColumns = false;
            gridLogi.Columns["LogiID"].DisplayIndex = 0;
            gridLogi.Columns["Typ"].DisplayIndex = 1;
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
            RefreshLogi();
            RefreshKunder();
        }

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

        private void btnKollaPris_Click(object sender, EventArgs e)
        {
            valdLogi = gridLogi.SelectedRows[0].DataBoundItem as Logi;
            DateTime från = dateFrån.Value;
            DateTime till = dateTill.Value;
            decimal pris = kontroller.KollaPris(från, till, valdLogi.Typ);
            MessageBox.Show($"Totalpris för valda datum:{pris}");
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            valdLogi = gridLogi.SelectedRows[0].DataBoundItem as Logi;
            DateTime från = dateFrån.Value;
            DateTime till = dateTill.Value;
            Bokningsrad nyBokningsrad = kontroller.SkapaBokningsRad(från, till, valdLogi, nyBokning.BokningsID);
            RefreshRader();
            MessageBox.Show($"Ny bokningsrad har skapats med Logi:{valdLogi.LogiID}\nBokningsID:{nyBokning.BokningsID}\nBokningsradID som genererats: {nyBokningsrad.BokningsradID}");
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            valdRad = gridRader.SelectedRows[0].DataBoundItem as Bokningsrad;
            kontroller.TaBortBokningsRad(valdRad);
            RefreshRader();
        }

        private void btnVäljKund_Click(object sender, EventArgs e)
        {
            valdKund = gridKunder.SelectedRows[0].DataBoundItem as Kund;
            nyBokning = kontroller.SkapaBokning(valdKund);
            MessageBox.Show($"Bokning har skapats med ID:{nyBokning.BokningsID} för kund:{valdKund.Namn}");
        }

        private void btnKlar_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}