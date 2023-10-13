using Affärslager;
using Datalager;
using Entitetslager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class VisaBokningar : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private LoggaIn loggaIn;
        private Kontroller kontroller;
        private Bokning valdBokning;
        private Logi valdLogi;

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


        internal void RefreshBokningar()
        {
            var bokningar = kontroller.HämtaBokningar();
            gridBokningar.DataSource = bokningar;

            gridBokningar.AutoGenerateColumns = false;
            gridBokningar.Columns["BokningsID"].DisplayIndex = 0;
            gridBokningar.Columns["KundID"].DisplayIndex = 1;

        }
        internal void RefreshRader(Bokning valdBokning)
        {
            //Logi
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

            //Uthyrningar

            //Lektion
            var lektionsRader = kontroller.HämtaLektionsRader(valdBokning.BokningsID);
            LektionGrid.AutoGenerateColumns = false;
            LektionGrid.DataSource = lektionsRader;
            if (lektionsRader != null && lektionsRader.Count == 0)
            {
                
            } else {
                LektionGrid.Columns["LektionsradsID"].DisplayIndex = 0;
                LektionGrid.Columns["LektionsID"].DisplayIndex = 1;
                LektionGrid.Columns["Från"].DisplayIndex = 2;
                LektionGrid.Columns["Till"].DisplayIndex = 3;
                LektionGrid.Columns["BokningsID"].DisplayIndex = 4;
            }
        }


        public void VisaBokningar_Load(object sender, EventArgs e)
        {
            RefreshBokningar(); 
        }

        private void btn_tillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void btn_ändra_Click(object sender, EventArgs e)
        {

            valdBokning = gridBokningar.SelectedRows[0].DataBoundItem as Bokning;

            if (gridBokningar.SelectedRows != null)
            {
                /*
                //kontroller.TaBortBokning(valdBokning, valdBokning.Logi);
                //RefreshBokningar();
                //MessageBox.Show($"Tog Bort Bokning: {valdBokning.BokningsID} \nSom Tillhörde KundID: {valdBokning.KundID} \n Från: {valdBokning.Från.ToShortDateString()} \nTill: {valdBokning.Till.ToShortDateString()}");
                ÄndraBokning ändraBokning = new ÄndraBokning(loggaIn, kontroller, valdBokning);
                ändraBokning.Show();
                ändraBokning.InloggadAnvandare = txtAnvandarnamn.Text;
                */
            }
        }

        private void btn_taBort_Click(object sender, EventArgs e)
        {
            valdBokning = gridBokningar.SelectedRows[0].DataBoundItem as Bokning;

            if (gridBokningar.SelectedRows != null)
            {
                kontroller.TaBortBokning(valdBokning);
                RefreshBokningar();
                //MessageBox.Show($"Tog Bort Bokning: {valdBokning.BokningsID} \nSom Tillhörde KundID: {valdBokning.KundID} \n Från: {valdBokning.Från.ToShortDateString()} \nTill: {valdBokning.Till.ToShortDateString()}");
                //this.Close();
            }
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void btnSökBokNr_Click(object sender, EventArgs e)
        {
            Bokning matchadBokning;
            String söktBokningsNummer = txtFilter.Text;
            if (IsDigitsOnly(söktBokningsNummer) && !string.IsNullOrEmpty(söktBokningsNummer))
            {
                // Skapa metod av detta
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



        private void btn_sökPersonNr_Click(object sender, EventArgs e)
        {
            string matadPeronNr = textBox_personNr.Text;
            var matchadeBokningar = unitOfWork.bokningar.Where(b => b.Kund.Personnummer == matadPeronNr).ToList();

            if (matchadeBokningar.Count > 0)
            {
                gridBokningar.DataSource = matchadeBokningar;
            }
            else
            {
                MessageBox.Show("Inget matchande personnummer hittades, försök igen");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshBokningar();
        }

        private void btn_visaRader_Click(object sender, EventArgs e)
        {
            valdBokning = gridBokningar.SelectedRows[0].DataBoundItem as Bokning;
            RefreshRader(valdBokning);
        }


    }
}
