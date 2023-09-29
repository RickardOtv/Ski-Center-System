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
    public partial class VisaLedigaLogi : Form
    {
        private BokningsMeny bokningsMeny;
        private Kontroller kontroller;
        
        public VisaLedigaLogi(BokningsMeny bokningsMeny, Kontroller kontroller)
        {
            InitializeComponent();
            this.bokningsMeny = bokningsMeny;
            this.kontroller = kontroller;
        }
    }
}
