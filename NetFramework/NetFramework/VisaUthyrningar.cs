using Affärslager;
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
        public void RefreshUthyrningar()
        {
           valdUthyrning = gridUthyrning.SelectedRows[0].DataBoundItem as Uthyrning;
           var uthyrningar = kontroller.HämtaUthyrningar(valdUthyrning.UthyrningsID);
           gridUthyrning.DataSource = uthyrningar;
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
        }
        public void RefreshLektioner()
        {
            var lektioner = kontroller.HämtaLektioner(valdUthyrning.BokningsID);
            gridLektioner.DataSource = lektioner;
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {

        }

        private void btnVäljUthyrning_Click(object sender, EventArgs e)
        {
            RefreshRader();
            RefreshLektioner();
        }

        private void VisaUthyrningar_Load(object sender, EventArgs e)
        {
            RefreshUthyrningar();
        }

        private void btnSök_Click(object sender, EventArgs e)
        {
            hittadKund = kontroller.HittaKund(txtPersNr.Text);
            matchadBokning = kontroller.HittaBokning(hittadKund.KundID);
            hittadUthyrning = kontroller.HittaUthyrning(matchadBokning.BokningsID);
            RefreshUthyrningarSpecifik(hittadUthyrning.UthyrningsID);
        }
    }
}
