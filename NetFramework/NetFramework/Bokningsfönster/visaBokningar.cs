using Affärslager;
using Datalager;
using Entitetslager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class VisaBokningar : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private LoggaIn loggaIn;
        private Kontroller kontroller;
        private Bokning valdBokning;
        private Bokningsrad valdRad;

        public VisaBokningar(LoggaIn loggaIn, Kontroller kontroller)
        {
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
            InitializeComponent();
        }

        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }

        //Hämta bokningar
        internal void RefreshBokningar()
        {
            var bokningar = kontroller.HämtaBokningar();
            gridBokningar.DataSource = bokningar;
            gridBokningar.AutoGenerateColumns = false;
            gridBokningar.Columns["BokningsID"].DisplayIndex = 0;
            gridBokningar.Columns["KundID"].DisplayIndex = 1;
            gridBokningar.Columns["Kund"].Visible = false;

        }

        //Hämta Logi
        internal void RefreshRader(Bokning valdBokning)
        {
            var rader = kontroller.HämtaRader(valdBokning.BokningsID);
            gridBokningar.AutoGenerateColumns = false;
            logiGrid.DataSource = rader;
            logiGrid.AutoGenerateColumns = false;
            logiGrid.Columns["Bokning"].Visible = false;
            logiGrid.Columns["Logi"].Visible = false;
            logiGrid.Columns["BokningsradID"].DisplayIndex = 0;
            logiGrid.Columns["LogiID"].DisplayIndex = 1;
            logiGrid.Columns["Från"].DisplayIndex = 2;
            logiGrid.Columns["Till"].DisplayIndex = 3;
            logiGrid.Columns["BokningsID"].DisplayIndex = 4;
        }

        //Load så att data visas på datagrids
        public void VisaBokningar_Load(object sender, EventArgs e)
        {
            RefreshBokningar();
        }

        //Knapp för att gå tillbaka
        private void btn_tillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //knapp för att få upp meny för att kunna ändra en bokning
        private void btnÄndra_Click(object sender, EventArgs e)
        {
            //Kollar så att minst en rad är vald
            if (logiGrid.SelectedRows.Count > 0)
            {
                valdRad = logiGrid.SelectedRows[0].DataBoundItem as Bokningsrad;
                ÄndraBokning ändraBokning = new ÄndraBokning(loggaIn, kontroller, valdRad);
                ändraBokning.Show();
                ändraBokning.InloggadAnvandare = txtAnvandarnamn.Text;
            }
            else
            {
                MessageBox.Show("Välj först en rad.", "Ingen rad vald", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Tar bort en bokning
        private void btnTaBort_Click(object sender, EventArgs e)
        {
            valdBokning = gridBokningar.SelectedRows[0].DataBoundItem as Bokning;
            DialogResult result = MessageBox.Show("Are you sure you want to remove this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (gridBokningar.SelectedRows != null)
                {
                    kontroller.TaBortBokning(valdBokning);
                    RefreshBokningar();
                }
            }
            else if (result == DialogResult.No)
            {

            }

        }


        //Knapp för att söka efter en specifik bokning på bokningsNr
        private void btnSökBokNr_Click(object sender, EventArgs e)
        {
            Bokning matchadBokning;
            String söktBokningsNummer = txtFilter.Text;
            if (kontroller.IsDigitsOnly(söktBokningsNummer) && !string.IsNullOrEmpty(söktBokningsNummer))
            {
                matchadBokning = kontroller.HittaBokning(söktBokningsNummer);
                if (matchadBokning != null)
                {
                    gridBokningar.DataSource = new List<Bokning> { matchadBokning };
                }
                else
                {
                    MessageBox.Show("Bokning ej hittad, försök igen");
                }
            }
            else
            {
                MessageBox.Show("Bokning ej hittad, försök igen");
            }
        }


        //Knapp för att söka efter en specifik bokning på personNr
        private void btnSökPersonNr_Click(object sender, EventArgs e)
        {
            string matadPersonNr = textBox_personNr.Text;
            var matchadeBokningar = kontroller.HämtaBokningPåPersonNr(matadPersonNr);

            if (matchadeBokningar.Count > 0)
            {
                gridBokningar.DataSource = matchadeBokningar;
            }
            else
            {
                MessageBox.Show("Inget matchande personnummer hittades, försök igen");
            }
        }

        //Knapp för att visa logi (rader) som tillhör en bokning
        private void btnVisaRader_Click(object sender, EventArgs e)
        {
            valdBokning = gridBokningar.SelectedRows[0].DataBoundItem as Bokning;
            RefreshRader(valdBokning);
        }

        //Knapp för att ladda om datagrid så att man får uppdateringar
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            valdBokning = gridBokningar.SelectedRows[0].DataBoundItem as Bokning;
            RefreshBokningar();
            RefreshRader(valdBokning);
        }
        
        //Knapp för att kunna ta bort ett logi (rad) från en bokning
        private void btnTaBortRad_Click(object sender, EventArgs e)
        {
            //Kollar så att minst en rad är vald
            if (logiGrid.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Är du säker att du vill ta bort detta logi?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    valdRad = logiGrid.SelectedRows[0].DataBoundItem as Bokningsrad;
                    valdBokning = gridBokningar.SelectedRows[0].DataBoundItem as Bokning;
                    kontroller.TaBortLogi(valdRad);
                    RefreshRader(valdBokning);
                }
                else if (result == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Välj först en rad.", "Ingen rad vald", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
