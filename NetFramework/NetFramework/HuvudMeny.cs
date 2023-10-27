using Affärslager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class HuvudMeny : Form
    {
        private LoggaIn loggaInMeny;
        private Kontroller kontroller;
        public HuvudMeny(LoggaIn loggaInMeny, Kontroller kontroller)
        {
            this.loggaInMeny = loggaInMeny;
            this.kontroller = kontroller;
            InitializeComponent();
        }
        public string InloggadAnvandare
        {
            get { return txtAnvandarnamn.Text; }
            set { txtAnvandarnamn.Text = value; }
        }
        /// <summary>
        /// Klickeventet öppnar ett nytt fönster för kundregister
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKundregister_Click(object sender, EventArgs e)
        {
            Kundregister kundregister = new Kundregister(loggaInMeny, kontroller);
            kundregister.InloggadAnvandare = txtAnvandarnamn.Text;
            kundregister.Show();
            this.Close();
        }
        /// <summary>
        /// Metoden kontrollerar användarens behörighet genom att hitta behörigheten för det angivna användarnamnet och öppnar en marknads-meny om användaren har antingen "Admin" eller "Marknad" behörighet, annars visas ett meddelande som indikerar att användaren saknar rätt behörighet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMarknad_Click(object sender, EventArgs e)
        {
            string inmatning = kontroller.HittaBehörighet(int.Parse(txtAnvandarnamn.Text));
            if (inmatning == "Admin" || inmatning == "Marknad")
            {
                MarknadsMeny marknadsMeny = new MarknadsMeny(loggaInMeny, kontroller);
                marknadsMeny.InloggadAnvandare = txtAnvandarnamn.Text;
                marknadsMeny.Show();
            }
            else
                MessageBox.Show("Du har ej rätt behörighet.");
        }
        /// <summary>
        /// Metoden kontrollerar användarens behörighet genom att hitta behörigheten för det angivna användarnamnet och öppnar en administratörsmeny om användaren har behörigheten "Admin", annars visas ett meddelande som indikerar att användaren saknar rätt behörighet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string inmatning = kontroller.HittaBehörighet(int.Parse(txtAnvandarnamn.Text));
            if (inmatning == "Admin")
            {
                AdminMeny adminMeny = new AdminMeny(loggaInMeny, kontroller);
                adminMeny.InloggadAnvandare = txtAnvandarnamn.Text;
                adminMeny.Show();
                this.Close();

            }
            else
                MessageBox.Show("Du har ej rätt behörighet.");
        }
        /// <summary>
        /// Metoden kontrollerar användarens behörighet genom att hitta behörigheten för det angivna användarnamnet och öppnar en uthyrningsmeny om användaren har behörigheten "Uthyrare", "Bokare" eller "Admin", annars visas ett meddelande som indikerar att användaren saknar rätt behörighet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUthyrning_Click(object sender, EventArgs e)
        {
            string inmatning = kontroller.HittaBehörighet(int.Parse(txtAnvandarnamn.Text));
            if (inmatning == "Uthyrare" || inmatning == "Bokare" || inmatning == "Admin")
            {
                UthyrningsMeny uthyrningsMeny = new UthyrningsMeny(loggaInMeny, kontroller);
                uthyrningsMeny.InloggadAnvandare = txtAnvandarnamn.Text;
                uthyrningsMeny.Show();
                this.Close();
            }
            else
                MessageBox.Show("Du har ej rätt behörighet.");
        }
        /// <summary>
        /// Metoden kontrollerar användarens behörighet genom att hitta behörigheten för det angivna användarnamnet och öppnar en bokningsmeny om användaren har behörigheten "Bokare" eller "Admin", annars visas ett meddelande som indikerar att användaren saknar rätt behörighet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string inmatning = kontroller.HittaBehörighet(int.Parse(txtAnvandarnamn.Text));
            if (inmatning == "Bokare" || inmatning == "Admin")
            {
                BokningsMeny bokningsMeny = new BokningsMeny(loggaInMeny, kontroller);
                bokningsMeny.InloggadAnvandare = txtAnvandarnamn.Text;
                bokningsMeny.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Du har ej rätt behörighet.");
            }
        }
        /// <summary>
        /// Stänger ner huvudmenyn och öppnar ett nytt inloggningsfönster
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoggaUt_Click(object sender, EventArgs e)
        {
            this.Close();
            LoggaIn loggaIn = new LoggaIn();
            loggaIn.Show();
        }
    }
}
