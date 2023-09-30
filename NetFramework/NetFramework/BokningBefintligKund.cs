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
    public partial class BokningBefintligKund : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private LoggaIn loggaInMeny;
        private Kontroller kontroller;
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
        }

        internal void RefreshKunder()
        {
            var kunder = kontroller.HämtaKunder();
            gridKunder.DataSource = kunder;
        }

        private void BokningBefintligKund_Load(object sender, EventArgs e)
        {
            RefreshLogi();
            RefreshKunder();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {

        }

        private void btnSkapaBokning_Click(object sender, EventArgs e)
        {

        }
    }
}
