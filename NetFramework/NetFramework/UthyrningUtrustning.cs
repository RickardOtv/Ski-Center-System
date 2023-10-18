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
        private Bokning valdBokning;
        public UthyrningUtrustning(LoggaIn loggain, Kontroller kontroller, Bokning valdBokning)
        {
            InitializeComponent();
            this.loggaIn = loggain;
            this.kontroller = kontroller;
            this.valdBokning = valdBokning;
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
            txtBoxValdKund.Text = $"Vald Bokning: {valdBokning.BokningsID.ToString()}";

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
            var valdStorlek = (string)cmbStorlek.SelectedItem; // Om du också vill filtrera på storlek

            var filtreradData = kontroller.HämtaUtrustning()
                .Where(u => (valdTyp == null || u.Typ == valdTyp) &&
                            (valdStorlek == null || (u.Storlek) == int.Parse(valdStorlek)))
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
    }
}
