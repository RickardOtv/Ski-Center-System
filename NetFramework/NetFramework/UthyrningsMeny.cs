﻿using System;
using Affärslager;
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
  
    
    public partial class UthyrningsMeny : Form
    {
        private Kontroller kontroller;
        private LoggaIn loggaIn;

        public UthyrningsMeny(LoggaIn loggaIn, Kontroller kontroller)
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

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnSkapaUthyrning_Click(object sender, EventArgs e)
        {
            SkapaUthyrning skapaUthyrning = new SkapaUthyrning(loggaIn, kontroller);
            skapaUthyrning.Show();
            skapaUthyrning.InloggadAnvandare = txtAnvandarnamn.Text;
        }

        private void btnBokaSkidlektion_Click(object sender, EventArgs e)
        {

        }

        private void btnÅterlämning_Click(object sender, EventArgs e)
        {

        }

        private void btnVisaUthyrningar_Click(object sender, EventArgs e)
        {
            //VisaUthyrningar visaUthyrningar = new VisaUthyrningar(loggaIn, kontroller);
            //visaUthyrningar.Show();

        }
    }
}
