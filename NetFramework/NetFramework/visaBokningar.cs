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
    public partial class visaBokningar : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private LoggaIn loggaInMeny;
        private Kontroller kontroller;
        private Bokning valdBokning;

        public visaBokningar(LoggaIn loggaInMeny, Kontroller kontroller)
        {
            this.loggaInMeny = loggaInMeny;
            this.kontroller = kontroller;
            InitializeComponent();
        }

        // Fixa attributen!!!
        internal void RefreshBokningar()
        {
            var bokningar = kontroller.HämtaBokningar();
            gridBokningar.DataSource = bokningar;
            gridBokningar.AutoGenerateColumns = false;
            gridBokningar.Columns["Maxbeloppskreditgräns"].Visible = false;
            gridBokningar.Columns["Adress"].Visible = false;
            gridBokningar.Columns["PostOrt"].Visible = false;
            gridBokningar.Columns["PostNr"].Visible = false;
            gridBokningar.Columns["Telefonnummer"].Visible = false;
            gridBokningar.Columns["Email"].Visible = false;
            gridBokningar.Columns["KundID"].DisplayIndex = 0;
            gridBokningar.Columns["Namn"].DisplayIndex = 1;
            gridBokningar.Columns["Typ"].DisplayIndex = 2;
            gridBokningar.Columns["Personnummer"].DisplayIndex = 3;
        }

        private void visaBokningar_Load(object sender, EventArgs e)
        {
            RefreshBokningar();
        }

        private void btn_tillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSök_Click(object sender, EventArgs e)
        {
            int matadBokningsNr = Int32.Parse(txtFilter.Text);
            var matchadBokning = unitOfWork.bokningar.FirstOrDefault(b => b.BokningsID == matadBokningsNr);
            if (matchadBokning != null)
            {
                gridBokningar.DataSource = new List<Bokning> { matchadBokning };
            }
            else
            {
                MessageBox.Show("Bokning ej hittad, försök igen");
            }
        }

        private void btn_ändra_Click(object sender, EventArgs e)
        {

        }

        private void btn_taBort_Click(object sender, EventArgs e)
        {

        }
    }
}
