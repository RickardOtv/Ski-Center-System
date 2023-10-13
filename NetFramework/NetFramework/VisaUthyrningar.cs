using Affärslager;
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
    public partial class VisaUthyrningar : Form
    {
        private Kontroller kontroller;
        private LoggaIn loggaIn;
        public VisaUthyrningar(LoggaIn loggaIn, Kontroller kontroller)
        {
            InitializeComponent();
            this.loggaIn = loggaIn;
            this.kontroller = kontroller;
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {

        }

        private void btnVäljKund_Click(object sender, EventArgs e)
        {

        }
    }
}
