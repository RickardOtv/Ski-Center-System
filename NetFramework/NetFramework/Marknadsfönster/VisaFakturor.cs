using Affärslager;
using Datalager;
using Entitetslager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.Marknadsfönster
{
    public partial class VisaFakturor : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        private Faktura valdFaktura;
        public VisaFakturor(LoggaIn loggaIn, Kontroller kontroller)
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

        internal void RefreshFakturor()
        {
            var fakturor = kontroller.HämtaFakturor();
            gridFakturor.DataSource = fakturor;
            gridFakturor.AutoGenerateColumns = false;
            gridFakturor.Columns["Bokning"].Visible = false;
            gridFakturor.Columns["Totalpris"].Visible = false;
            gridFakturor.Columns["BokningsID"].DisplayIndex = 0;
            gridFakturor.Columns["FakturaID"].DisplayIndex = 1;
            gridFakturor.Columns["Momsats"].DisplayIndex = 2;
            gridFakturor.Columns["Rabattsats"].DisplayIndex = 3;

        }
        private void FakturaRegister_Load(object sender, EventArgs e)
        {
            RefreshFakturor();
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnÄndraRabatt_Click(object sender, EventArgs e)
        {
            valdFaktura = gridFakturor.SelectedRows[0].DataBoundItem as Faktura;
            if (gridFakturor.SelectedRows != null)
            {
                ÄndraFakturaRabatt ändraFaktura = new ÄndraFakturaRabatt(loggaIn, kontroller, valdFaktura);
                ändraFaktura.FormClosed += ÄndraFaktura_FormClosed;
                ändraFaktura.Show();
                ändraFaktura.InloggadAnvandare = txtAnvandarnamn.Text;
            }
        }


        private void btnTaBort_Click(object sender, EventArgs e)
        {
            valdFaktura = gridFakturor.SelectedRows[0].DataBoundItem as Faktura;

            DialogResult result = MessageBox.Show("Är du säker att du vill ta bort faktura?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (gridFakturor.SelectedRows != null)
                {
                    //valdFaktura = kontroller.HittaFaktura(valdFaktura.FakturaID);
                    kontroller.TaBortFaktura(valdFaktura);
                    RefreshFakturor();
                    MessageBox.Show($"Tog Bort Faktura: {valdFaktura.FakturaID} \nTillhörande BokningsID: {valdFaktura.BokningsID}");
                }
                else
                {
                    MessageBox.Show("Välj först en faktura, tack!", "Confirmation");
                }
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void btnSökBokningsNr_Click(object sender, EventArgs e)
        {
            if (kontroller.IsDigitsOnly(txtBoxBokningsID.Text) && !string.IsNullOrEmpty(txtBoxBokningsID.Text))
            {
                RefreshFakturor();
                int matadBokningsNr = int.Parse(txtBoxBokningsID.Text);
                var matchadeFakturor = unitOfWork.fakturor.Where(a => a.BokningsID == matadBokningsNr).ToList();

                if (matchadeFakturor.Count > 0)
                {
                    gridFakturor.DataSource = matchadeFakturor;
                }
                else
                {
                    MessageBox.Show("Inget matchande anställningsnummer hittades, försök igen");
                }
            }
            else
            {
                MessageBox.Show("Inget matchande anställningsnummer hittades, försök igen");
            }
        }

        private void btn_ÄndraMoms_Click(object sender, EventArgs e)
        {
            valdFaktura = gridFakturor.SelectedRows[0].DataBoundItem as Faktura;
            if (gridFakturor.SelectedRows != null)
            {
                ÄndraFakturaMoms ändraFaktura = new ÄndraFakturaMoms(loggaIn, kontroller, valdFaktura);
                ändraFaktura.FormClosed += ÄndraFaktura_FormClosed;
                ändraFaktura.Show();
                ändraFaktura.InloggadAnvandare = txtAnvandarnamn.Text;
            }
        }

        private void ÄndraFaktura_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshFakturor();
        }

        private void btn_totalPris_Click(object sender, EventArgs e)
        {
            float totalPris;
            float rabattPris;
            float momsPris;
            valdFaktura = gridFakturor.SelectedRows[0].DataBoundItem as Faktura;
            //Lägger till rabatt
            rabattPris = (float)valdFaktura.TotalPris - ((float)valdFaktura.TotalPris * ((float)valdFaktura.Rabattsats / 100));
            float slutRabattPris = (float)valdFaktura.TotalPris - rabattPris;
            //Lägger till moms
            momsPris = rabattPris - ((float)valdFaktura.TotalPris * ((float)valdFaktura.Momsats / 100));
            float slutMomsPris = rabattPris - momsPris;

            MessageBox.Show($"Vald Faktura: {valdFaktura.FakturaID} \nOriginalpris: {valdFaktura.TotalPris}kr \nRabattpris: -{slutRabattPris}kr\nMomspris: -{slutMomsPris}kr\n\nTotalpris: {momsPris}kr");
        }
    }
}
