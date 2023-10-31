using Affärslager;
using Datalager;
using Entitetslager;
using System;
using System.Data;
using System.Linq;
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

        //Fyller gridFakturor med fakturor
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

        //Laddar faktura grid med fakturor när form öppnas
        private void FakturaRegister_Load(object sender, EventArgs e)
        {
            RefreshFakturor();
        }

        //Knapp för att gå tillbaka
        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            MarknadsMeny marknadsMeny = new MarknadsMeny(loggaIn, kontroller);
            marknadsMeny.Show();
            marknadsMeny.InloggadAnvandare = txtAnvandarnamn.Text;
            this.Close();
        }

        //Knapp för att ändra rabatt på specifik faktura
        private void btnÄndraRabatt_Click(object sender, EventArgs e)
        {
            valdFaktura = gridFakturor.SelectedRows[0].DataBoundItem as Faktura;
            //Kollar så att en faktura är vald
            if (gridFakturor.SelectedRows != null)
            {
                ÄndraFakturaRabatt ändraFaktura = new ÄndraFakturaRabatt(loggaIn, kontroller, valdFaktura);
                ändraFaktura.FormClosed += ÄndraFaktura_FormClosed;
                ändraFaktura.Show();
                ändraFaktura.InloggadAnvandare = txtAnvandarnamn.Text;
            } else
            {
                MessageBox.Show("Välj först en faktura, tack!", "Confirmation");
            }
        }

        //Knapp för att ta bort en faktura
        private void btnTaBort_Click(object sender, EventArgs e)
        {
            valdFaktura = gridFakturor.SelectedRows[0].DataBoundItem as Faktura;

            DialogResult result = MessageBox.Show("Är du säker att du vill ta bort faktura?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Kollar så att en faktura är vald
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

        //Knapp för att söka efter faktura på bokningsNr
        private void btnSökBokningsNr_Click(object sender, EventArgs e)
        {
            //Kollar så att inmatning matchar format
            if (kontroller.IsDigitsOnly(txtBoxBokningsID.Text) && !string.IsNullOrEmpty(txtBoxBokningsID.Text))
            {
                RefreshFakturor();
                int matadBokningsNr = int.Parse(txtBoxBokningsID.Text);
                var matchadeFakturor = unitOfWork.fakturor.Where(a => a.BokningsID == matadBokningsNr).ToList();

                //Kollar ifall nån faktura var hittad
                if (matchadeFakturor.Count > 0)
                {
                    gridFakturor.DataSource = matchadeFakturor;
                }
                else
                {
                    MessageBox.Show("Inget matchande bokningsnummer hittades, försök igen");
                }
            }
            else
            {
                MessageBox.Show("Inget matchande bokningsnummer hittades, försök igen");
            }
        }

        //Knapp för att kunna ändra moms för specifik faktura
        private void btnÄndraMoms_Click(object sender, EventArgs e)
        {
            valdFaktura = gridFakturor.SelectedRows[0].DataBoundItem as Faktura;
            //Kollar så att en faktura är vald
            if (gridFakturor.SelectedRows != null)
            {
                ÄndraFakturaMoms ändraFaktura = new ÄndraFakturaMoms(loggaIn, kontroller, valdFaktura);
                ändraFaktura.FormClosed += ÄndraFaktura_FormClosed;
                ändraFaktura.Show();
                ändraFaktura.InloggadAnvandare = txtAnvandarnamn.Text;
            }
        }

        //Knapp så att faktura grid uppdateras efter moms/rabatt är ändrar
        private void ÄndraFaktura_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshFakturor();
        }

        //Knapp för att se totalt pris på faktura
        private void btnTotalPris_Click(object sender, EventArgs e)
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
