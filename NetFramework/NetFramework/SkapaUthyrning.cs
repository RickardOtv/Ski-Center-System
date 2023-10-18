using System;
using Affärslager;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entitetslager;
using Datalager;

namespace NetFramework
{
    public partial class SkapaUthyrning : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        private Bokningsrad bokningar;
        private LoggaIn loggaInMeny;
        public SkapaUthyrning(LoggaIn loggain, Kontroller kontroller)
        {
            InitializeComponent();
            this.loggaIn = loggain;
            this.kontroller = kontroller;
            RefreshBokningar();
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
        public void SkapaUthyrning_Load(object sender, EventArgs e)
        {
            RefreshBokningar();
        }


        private void VäljBtn_Click(object sender, EventArgs e)
        {
            UthyrningUtrustning uthyrningUtrustning = new UthyrningUtrustning(loggaInMeny, kontroller);
            uthyrningUtrustning.InloggadAnvandare = txtAnvandarnamn.Text;
            uthyrningUtrustning.Show();
        }


        private void btnTillbaka_Click_1(object sender, EventArgs e)
        {

            this.Close();

        }

        

        private void BokningsnummerBtn_Click(object sender, EventArgs e)
        {
            int matadBokningsID = int.Parse(txtBoxBokningsID.Text);
            var matchadeBokningar = unitOfWork.bokningar.Where(b => b.BokningsID == matadBokningsID).ToList();

            if (matchadeBokningar.Count > 0)
            {
                gridBokningar.DataSource = matchadeBokningar;
            }
            else
            {
                MessageBox.Show("Inget matchande bokningsID hittades, försök igen");
            }
        }

        private void KundSokBtn_Click(object sender, EventArgs e)
        {
            int matadKundID = int.Parse(txtBoxKundID.Text);
            var matchadeBokningar = unitOfWork.bokningar.Where(b => b.KundID == matadKundID).ToList();

            if (matchadeBokningar.Count > 0)
            {
                gridBokningar.DataSource = matchadeBokningar;
            }
            else
            {
                MessageBox.Show("Inget matchande kundID hittades, försök igen");
            }
        }

        private void Anställningsnummerlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
