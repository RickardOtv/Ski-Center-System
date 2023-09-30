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
        Logi valdLogi = new Logi();
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
            gridLogi.Columns["IsAvailable"].Visible = false;
            gridLogi.Columns["LogiID"].DisplayIndex = 0;
            gridLogi.Columns["Typ"].DisplayIndex = 1;
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
            this.Close();
        }

        private void btnSkapaBokning_Click(object sender, EventArgs e)
        {
            DateTime från = DateTime.Parse(dateFrån.Text);
            DateTime till = DateTime.Parse(dateTill.Text);
            valdLogi = gridLogi.SelectedRows[0].DataBoundItem as Logi;
            valdKund = gridKunder.SelectedRows[0].DataBoundItem as Kund;

            if (gridLogi.SelectedRows != null && gridKunder.SelectedRows != null)
            {
                Bokning nyBokning = kontroller.SkapaBokning(från, till, valdLogi, valdKund);
                RefreshLogi();
                MessageBox.Show($"Från: {nyBokning.Från.ToShortDateString()} \nTill: {nyBokning.Till.ToShortDateString()} \n Vald logi: {nyBokning.Logi.LogiID} \nBokningsID: {nyBokning.BokningsID}");
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
    }
}
