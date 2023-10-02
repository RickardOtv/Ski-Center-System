﻿using Affärslager;
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
    public partial class VisaBokningar : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private LoggaIn loggaInMeny;
        private Kontroller kontroller;
        private Bokning valdBokning;

        public VisaBokningar(LoggaIn loggaInMeny, Kontroller kontroller)
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
            gridBokningar.Columns["Uthyrning"].Visible = false;
            gridBokningar.Columns["Logi"].Visible = false;
            gridBokningar.Columns["Kund"].Visible = false;
            gridBokningar.Columns["Skidlektion"].Visible = false;
            gridBokningar.Columns["BokningsID"].DisplayIndex = 0;
            gridBokningar.Columns["KundID"].DisplayIndex = 1;
            gridBokningar.Columns["LogiID"].DisplayIndex = 2;
            gridBokningar.Columns["UthyrningsID"].DisplayIndex = 3;
            gridBokningar.Columns["Från"].DisplayIndex = 4;
            gridBokningar.Columns["Till"].DisplayIndex = 5;
            
        }


        private void VisaBokningar_Load(object sender, EventArgs e)
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
            valdBokning = gridBokningar.SelectedRows[0].DataBoundItem as Bokning;

            if (gridBokningar.SelectedRows != null)
            {
                kontroller.TaBortBokning(valdBokning, valdBokning.Logi);
                RefreshBokningar();
                MessageBox.Show($"Tog Bort Bokning: {valdBokning.BokningsID} \nSom Tillhörde KundID: {valdBokning.KundID} \n Från: {valdBokning.Från.ToShortDateString()} \nTill: {valdBokning.Till.ToShortDateString()}");
                this.Close();
            }
        }
    }
}