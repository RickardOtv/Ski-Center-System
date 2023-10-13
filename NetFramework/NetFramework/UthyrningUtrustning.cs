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
    public partial class UthyrningUtrustning : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        private Bokningsrad bokningar;
        private Utrustning utrustning;
        public UthyrningUtrustning(LoggaIn loggain, Kontroller kontroller)
        {
            InitializeComponent();
            this.loggaIn = loggain;
            this.kontroller = kontroller;
            RefreshUtrustning();

        }
        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }

        internal void RefreshUtrustning()
        {
            var utrustning = kontroller.HämtaUtrustning();
            gridUtrustning.DataSource = utrustning;
            gridUtrustning.AutoGenerateColumns = false;
            gridUtrustning.Columns["UtrustningsID"].DisplayIndex = 0;
            gridUtrustning.Columns["Typ"].DisplayIndex = 1;
            gridUtrustning.Columns["Storlek"].DisplayIndex = 2;
        }

        public void UthyrningUtrustning_Load(object sender, EventArgs e)
        {
            RefreshUtrustning();
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
