using Affärslager;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NetFramework
{
    public partial class ÅterlämningUthyrning : Form
    {
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        private Uthyrningsrad valdRad;
        public ÅterlämningUthyrning(LoggaIn loggaIn, Kontroller kontroller)
        {
            InitializeComponent();
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
        }

        private void Tillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void RefreshBokningar()
        {
            var bokningar = kontroller.HämtaBokningar();
            GridÅterlämning.DataSource = bokningar;
            GridÅterlämning.AutoGenerateColumns = false;
            GridÅterlämning.Columns["BokningsID"].DisplayIndex = 0;
            GridÅterlämning.Columns["KundID"].DisplayIndex = 1;
            GridÅterlämning.Columns["Kund"].Visible = false;

        }

        internal void RefreshRader(int id)
        {
            var rader = kontroller.HämtaUthyrningsRad(id);
            GridÅterlämning.DataSource = rader;
            GridÅterlämning.AutoGenerateColumns = false;
            GridÅterlämning.Columns["Uthyrning"].Visible = false;
            GridÅterlämning.Columns["Utrustning"].Visible = false;
            GridÅterlämning.Columns["UthyrningsradID"].DisplayIndex = 0;
            GridÅterlämning.Columns["UtrustningsID"].DisplayIndex = 1;
            GridÅterlämning.Columns["Från"].DisplayIndex = 2;
            GridÅterlämning.Columns["Till"].DisplayIndex = 3;
            GridÅterlämning.Columns["UthyrningsID"].DisplayIndex = 4;
        }

        private void HittaRättUthyrningsID()
        {
            if (int.TryParse(TextBoxUthyrningsID.Text, out int angivetID))
            {
                RefreshRader(angivetID);
            }
            else
            {
                MessageBox.Show("Felaktigt ID, måste vara siffror.");
            }
        }

        private void SökBtn_Click(object sender, EventArgs e)
        {
            HittaRättUthyrningsID();
        }

        private void ÅterlämnaBtn_Click(object sender, EventArgs e)
        {
            if (GridÅterlämning.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Är du säker på att denna vara ska återlämnas?", "Godkännande", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    valdRad = GridÅterlämning.SelectedRows[0].DataBoundItem as Uthyrningsrad;
                    kontroller.TaBortUthyrningsRad(valdRad);
                    HittaRättUthyrningsID();
                }
                else if (result == DialogResult.No)
                {

                }
            }
            else
            {
                // Felhanterare när val saknas
                MessageBox.Show("Välj en hel rad att ta bort", "Saknas val av rad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
