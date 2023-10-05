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
    public partial class Kundregister : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private LoggaIn loggaIn;
        private Kontroller kontroller;
        private Kund valdKund;

        

        public Kundregister(LoggaIn loggaIn, Kontroller kontroller)
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

        internal void RefreshKunder()
        {
            
            var kunder = kontroller.HämtaKunder();
            gridKunder.DataSource = kunder;
            gridKunder.AutoGenerateColumns = false;
            gridKunder.Columns["Maxbeloppskreditgräns"].Visible = false;
            gridKunder.Columns["Adress"].Visible = false;
            gridKunder.Columns["PostOrt"].Visible = false;
            gridKunder.Columns["PostNr"].Visible = false;
            gridKunder.Columns["KundID"].DisplayIndex = 0;
            gridKunder.Columns["Typ"].DisplayIndex = 1;
            gridKunder.Columns["Personnummer"].DisplayIndex = 2;
            gridKunder.Columns["Namn"].DisplayIndex = 3;
            gridKunder.Columns["Telefonnummer"].DisplayIndex = 4;
            gridKunder.Columns["Email"].DisplayIndex = 5;
            
        }
        private void Kundregister_Load(object sender, EventArgs e)
        {
            RefreshKunder();
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            valdKund = gridKunder.SelectedRows[0].DataBoundItem as Kund;

            if (gridKunder.SelectedRows != null)
            {
                valdKund = kontroller.HittaKund(valdKund.KundID);
                kontroller.TaBortKund(valdKund);
                RefreshKunder();
                MessageBox.Show($"Tog Bort Kund: {valdKund.KundID} \nMed personnummer: {valdKund.Personnummer} \n Namn: {valdKund.Namn}");
            
            }
        }

        private void btnAndra_Click(object sender, EventArgs e)
        {
            valdKund = gridKunder.SelectedRows[0].DataBoundItem as Kund;
            if(gridKunder.SelectedRows != null)
            {
               
                ÄndraKund ändraKund = new ÄndraKund(loggaIn, kontroller, valdKund);
                ändraKund.Show();
                ändraKund.InloggadAnvandare = txtAnvandarnamn.Text;

            }
           
        }

       

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshKunder();
        }

        private void btnSokNamn_Click(object sender, EventArgs e)
        {
            
            string matadNamn = txtBoxNamn.Text;
            var matchadeKunder = unitOfWork.kunder.Where(k => k.Namn == matadNamn).ToList();

            if (matchadeKunder.Count > 0)
            {
                gridKunder.DataSource = matchadeKunder;
            }
            else
            {
                MessageBox.Show("Inget matchande personnummer hittades, försök igen");
            }
            
        }

        private void btnSokPersonNr_Click(object sender, EventArgs e)
        {
            
            string matadPeronNr = txtBoxPersonNr.Text;
            var matchadeKunder = unitOfWork.kunder.Where(k => k.Personnummer == matadPeronNr).ToList();

            if (matchadeKunder.Count > 0)
            {
                gridKunder.DataSource = matchadeKunder;
            }
            else
            {
                MessageBox.Show("Inget matchande personnummer hittades, försök igen");
            }
            

        }
    }
}
