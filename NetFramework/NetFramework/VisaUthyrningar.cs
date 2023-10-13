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
            gridUthyrning .DataSource = uthyrningar;
        }
        public void RefreshRader()
        {
            var rader = kontroller.HämtaUthyrningsRad(valdUthyrning.UthyrningsID);
            gridUthyrningsRader.DataSource = rader;
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {

        }

        private void btnVäljUthyrning_Click(object sender, EventArgs e)
        {

        }

        private void VisaUthyrningar_Load(object sender, EventArgs e)
        {
            RefreshUthyrningar();
        }
    }
}
