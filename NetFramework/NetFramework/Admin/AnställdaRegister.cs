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
    public partial class AnställdaRegister : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private LoggaIn loggaIn;
        private Kontroller kontroller;
        private Anställd valdAnställd;
        public AnställdaRegister(LoggaIn loggaInMeny, Kontroller kontroller)
        {
            this.loggaIn = loggaInMeny;
            this.kontroller = kontroller;
            InitializeComponent();
        }
        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }

        internal void RefreshAnställda()
        {
            var anställda = kontroller.HämtaAnställda();
            gridAnställda.DataSource = anställda;
            gridAnställda.AutoGenerateColumns = false;
            gridAnställda.Columns["Användarnamn"].Visible = false;
            gridAnställda.Columns["AnställningsNr"].DisplayIndex = 0;
            gridAnställda.Columns["Användarnamn"].DisplayIndex = 1;
            gridAnställda.Columns["Förnamn"].DisplayIndex = 2;
            gridAnställda.Columns["Efternamn"].DisplayIndex = 3;
            gridAnställda.Columns["Behörighet"].DisplayIndex = 4;

        }
        private void AnställdaRegister_Load(object sender, EventArgs e)
        {
            RefreshAnställda();
        }

        private void btnÄndra_Click(object sender, EventArgs e)
        {
            valdAnställd = gridAnställda.SelectedRows[0].DataBoundItem as Anställd;
            if (gridAnställda.SelectedRows != null)
            {
                ÄndraAnställd ändraAnställd = new ÄndraAnställd(loggaIn, kontroller, valdAnställd);
                ändraAnställd.FormClosed += ÄndraAnställd_FormClosed;
                ändraAnställd.Show();
                ändraAnställd.InloggadAnvandare = txtAnvandarnamn.Text;
            }
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            valdAnställd = gridAnställda.SelectedRows[0].DataBoundItem as Anställd;

            if (gridAnställda.SelectedRows != null)
            {
                valdAnställd = kontroller.HittaAnställd(valdAnställd.AnställningsNr);
                kontroller.TaBortAnställd(valdAnställd);
                RefreshAnställda();
                MessageBox.Show($"Tog Bort Anställd: {valdAnställd.AnställningsNr} \nMed behörighet: {valdAnställd.Behörighet} \n Namn: {valdAnställd.Förnamn} {valdAnställd.Efternamn}");

            }
        }
        private void btnSökAnställningsNr_Click(object sender, EventArgs e)
        {
            if (kontroller.IsDigitsOnly(txtBoxAnställningsNr.Text) && !string.IsNullOrEmpty(txtBoxAnställningsNr.Text))
            {
                RefreshAnställda();
                int matadAnställningsNr = int.Parse(txtBoxAnställningsNr.Text);
                var matchadeAnställda = unitOfWork.anställda.Where(a => a.AnställningsNr == matadAnställningsNr).ToList();

                if (matchadeAnställda.Count > 0)
                {
                    gridAnställda.DataSource = matchadeAnställda;
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
        private void ÄndraAnställd_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshAnställda();
        }

        private void SkapaAnställd_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshAnställda();
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
