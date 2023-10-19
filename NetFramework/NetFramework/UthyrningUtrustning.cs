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
        private Utrustning valdUtrustning;
        private IList<Utrustning> tillgängligUtrustning;
        private Uthyrningsrad valdRad;
        private Bokning valdBokning;
        DateTime från;
        DateTime till;
        Uthyrning nyUthyrning;
        public UthyrningUtrustning(LoggaIn loggain, Kontroller kontroller, Bokning valdBokning, Uthyrning nyUthyrning)
        {
            InitializeComponent();
            this.loggaIn = loggain;
            this.kontroller = kontroller;
            this.valdBokning = valdBokning;
            this.nyUthyrning = nyUthyrning;
            RefreshUtrustning();
        }

        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }

        internal void RefreshUtrustning()
        {
            var allUtrustning = kontroller.HämtaUtrustning();
            var uthyrdaUtrustningar = kontroller.HämtaUthyrningsRad(nyUthyrning.UthyrningsID).Select(u => u.UtrustningsID).ToList();

            tillgängligUtrustning = allUtrustning.Where(u => !uthyrdaUtrustningar.Contains(u.UtrustningsID)).ToList();

            gridUtrustning.DataSource = tillgängligUtrustning;
            gridUtrustning.AutoGenerateColumns = false;
            gridUtrustning.Columns["UtrustningsID"].DisplayIndex = 0;
            gridUtrustning.Columns["Typ"].DisplayIndex = 1;
            gridUtrustning.Columns["Storlek"].DisplayIndex = 2;
        }

        internal void RefreshRader()
        {
            var rader = kontroller.HämtaUthyrningsRad(nyUthyrning.UthyrningsID);
            gridRader.DataSource = rader;
            gridRader.AutoGenerateColumns = false;
            gridRader.Columns["Uthyrning"].Visible = false;
            gridRader.Columns["Utrustning"].Visible = false;
            gridRader.Columns["UthyrningsradID"].DisplayIndex = 0;
            gridRader.Columns["UtrustningsID"].DisplayIndex = 1;
            gridRader.Columns["Från"].DisplayIndex = 2;
            gridRader.Columns["Till"].DisplayIndex = 3;
            gridRader.Columns["UthyrningsID"].DisplayIndex = 4;
        }

        public void UthyrningUtrustning_Load(object sender, EventArgs e)
        {
            cmbTyp.SelectedIndexChanged += cmbTyp_SelectedIndexChanged;

            RefreshUtrustning();
            txtBoxValdKund.Text = $"Vald Bokning: {valdBokning.BokningsID.ToString()}";

        }


        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            valdUtrustning = gridUtrustning.SelectedRows[0].DataBoundItem as Utrustning;
            DateTime från = DateTime.Parse(dateFrån.Text);
            DateTime till = DateTime.Parse(dateTill.Text);
           
            Uthyrningsrad nyUthyrningsRad = kontroller.SkapaUthyrningsRad(från, till, valdUtrustning, nyUthyrning.UthyrningsID);
            RefreshRader();
            RefreshUtrustning();
        }

        #region filtrering typ/storlek

        private void cmbTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            UppdateraStorlekar();
            FiltreraData();
        }
        private void UppdateraStorlekar()
        {
            var valdTyp = (string)cmbTyp.SelectedItem;

            cmbStorlek.Items.Clear();

            if (valdTyp != null)
            {
                var tillgangligaStorlekar = kontroller.HamtaStorlekarForTyp(valdTyp);
                foreach (var storlek in tillgangligaStorlekar)
                {
                    cmbStorlek.Items.Add(storlek);
                }
            }
        }
        private void cmbStorlek_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltreraData();
        }

        private void FiltreraData()
        {
            var valdTyp = (string)cmbTyp.SelectedItem;
            int? valdStorlek = cmbStorlek.SelectedItem as int?; // Använd 'as' för att försöka göra en säker typomvandling

            var filtreradData = kontroller.HämtaUtrustning()
                .Where(u => (valdTyp == null || u.Typ == valdTyp) &&
                            (!valdStorlek.HasValue || u.Storlek == valdStorlek.Value))
                .ToList();

            gridUtrustning.DataSource = filtreradData;
        }



        #endregion


        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        private void txtBoxValdKund_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKlar_Click(object sender, EventArgs e)
        {
            /*
            DateTime från = DateTime.Parse(dateFrån.Text);
            DateTime till = DateTime.Parse(dateTill.Text);

            decimal totalpris = 0;
            foreach (DataGridViewRow row in gridRader.Rows)
            {
                if (row.DataBoundItem != null && row.DataBoundItem is Uthyrningsrad rad)
                {
                    string typ = kontroller.HämtaUthyrningsTyp(rad.UtrustningsID);
                    totalpris += kontroller.KollaUthyrningsPris(från, till, typ);
                }
            }
            MessageBox.Show($"Totalpris för hela uthyrningen: {totalpris}kr");
            //this.Close();
            */

            decimal totalpris = 0;
            foreach (DataGridViewRow row in gridRader.Rows)
            {
                if (row.DataBoundItem != null && row.DataBoundItem is Uthyrningsrad rad)
                {
                    DateTime från = rad.Från; // Antag att DateFrån är en egenskap som innehåller startdatumet för varje rad
                    DateTime till = rad.Till; // Antag att DateTill är en egenskap som innehåller slutdatumet för varje rad
                    string typ = kontroller.HämtaUthyrningsTyp(rad.UtrustningsID);
                    totalpris += kontroller.KollaUthyrningsPris(från, till, typ);
                }
            }
            MessageBox.Show($"Totalpris för hela uthyrningen: {totalpris}kr");
            //this.Close();
        }

        private void btnKollaPris_Click(object sender, EventArgs e)
        {
            DateTime från = DateTime.Parse(dateFrån.Text);
            DateTime till = DateTime.Parse(dateTill.Text);
            valdUtrustning = gridUtrustning.SelectedRows[0].DataBoundItem as Utrustning;
            if (gridUtrustning.SelectedRows.Count > 0)
            {
                var valdRad = gridUtrustning.SelectedRows[0];
                var rowIndex = valdRad.Index;
                if (rowIndex >= 0 && rowIndex < tillgängligUtrustning.Count)
                {

                    DateTime startDate = dateFrån.Value;
                    DateTime endDate = dateTill.Value;
                    decimal pris = kontroller.KollaUthyrningsPris(från, till, valdUtrustning.Typ);
                    MessageBox.Show($"Totalpris för valda datum: {pris}");
                }
                else
                {
                    MessageBox.Show("Felaktig utrustning vald.");
                }
            }
            else
            {
                MessageBox.Show("Ingen logi vald.");
            }
        }
        
    }
}
