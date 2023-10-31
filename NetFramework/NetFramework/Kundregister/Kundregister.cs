using Affärslager;
using Datalager;
using Entitetslager;
using System;
using System.Windows.Forms;

namespace NetFramework
{
    public partial class Kundregister : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        private LoggaIn loggaIn;
        private Kontroller kontroller;
        private Kund valdKund;

        public Kundregister(LoggaIn loggaIn, Kontroller kontroller)
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

        //Hämtar alla kunder till grid
        internal void RefreshKunder()
        {
            var kunder = kontroller.HämtaKunder();
            gridKunder.DataSource = kunder;
            gridKunder.AutoGenerateColumns = false;
            gridKunder.Columns["Maxbeloppskreditgräns"].Visible = false;
            gridKunder.Columns["Adress"].Visible = false;
            gridKunder.Columns["PostOrt"].Visible = false;
            gridKunder.Columns["PostNr"].Visible = false;
            gridKunder.Columns["KundID"].DisplayIndex = 0;
            gridKunder.Columns["Typ"].DisplayIndex = 1;
            gridKunder.Columns["Personnummer"].DisplayIndex = 2;
            gridKunder.Columns["Namn"].DisplayIndex = 3;
            gridKunder.Columns["Telefonnummer"].DisplayIndex = 4;
            gridKunder.Columns["Email"].DisplayIndex = 5;

        }

        //Hämtar alla kunder till grid när form öppnas
        private void Kundregister_Load(object sender, EventArgs e)
        {
            RefreshKunder();
        }
        
        //Knapp för att ta bort en kund
        private void btnTaBort_Click(object sender, EventArgs e)
        {
            valdKund = gridKunder.SelectedRows[0].DataBoundItem as Kund;

            DialogResult result = MessageBox.Show("Är du säker att du vill ta bort kund?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (gridKunder.SelectedRows != null)
                {
                    valdKund = kontroller.HittaKund(valdKund.KundID);
                    kontroller.TaBortKund(valdKund);
                    RefreshKunder();
                    MessageBox.Show($"Tog Bort Kund: {valdKund.KundID} \nMed personnummer: {valdKund.Personnummer} \n Namn: {valdKund.Namn}");
                }
                else
                {
                    MessageBox.Show("Välj först en kund, tack!", "Confirmation");
                }
            }
            else if (result == DialogResult.No)
            {

            }
        }

        //Knapp för att kunna få upp meny för att ändra kund
        private void btnAndra_Click(object sender, EventArgs e)
        {
            valdKund = gridKunder.SelectedRows[0].DataBoundItem as Kund;
            string inmatning = kontroller.HittaBehörighet(int.Parse(txtAnvandarnamn.Text));

            //Kollar så att kund är vald
            if (gridKunder.SelectedRows != null)
            {
                //Öppnar rätt "Ändra Form" till rätt kund typ
                if (valdKund.Typ == "Företag")
                {
                    if (inmatning == "Admin" || inmatning == "Marknad")
                    {
                        ÄndraFöretagsKund ändraFöretagsKund = new ÄndraFöretagsKund(loggaIn, kontroller, valdKund);
                        ändraFöretagsKund.Show();
                        ändraFöretagsKund.InloggadAnvandare = txtAnvandarnamn.Text;
                    }
                    else
                        MessageBox.Show("Du har ej rätt behörighet.");
                }
                else
                {
                    ÄndraKund ändraKund = new ÄndraKund(loggaIn, kontroller, valdKund);
                    ändraKund.Show();
                    ändraKund.InloggadAnvandare = txtAnvandarnamn.Text;
                }
            }

        }

        //Knapp för att gå tillbaka till huvudmeny
        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            HuvudMeny huvudMeny = new HuvudMeny(loggaIn, kontroller);
            huvudMeny.Show();
            huvudMeny.InloggadAnvandare = txtAnvandarnamn.Text;
            this.Close();
        }

        //Refresh knapp för att uppdatera kund grid med ändringar som gjorts på kunder
        private void button1_Click(object sender, EventArgs e)
        {
            RefreshKunder();
        }
        
        //Knapp för att söka på en specifik kund genom namn
        private void btnSokNamn_Click(object sender, EventArgs e)
        {
            string matadNamn = txtBoxNamn.Text;
            var matchadeKunder = kontroller.HittaKunderPåNamn(matadNamn);

            //Kollar ifall kund hittades eller inte
            if (matchadeKunder.Count > 0)
            {
                gridKunder.DataSource = matchadeKunder;
            }
            else
            {
                MessageBox.Show("Inget matchande namn hittades, försök igen");
            }
        }

        //Knapp för att söka på specifik kund genom personNr
        private void btnSokPersonNr_Click(object sender, EventArgs e)
        {
            string matadPeronNr = txtBoxPersonNr.Text;
            var matchadeKunder = kontroller.HittaKunderPåPersonNr(matadPeronNr);

            //Kollar om specifik kund hittades eller inte
            if (matchadeKunder.Count > 0)
            {
                gridKunder.DataSource = matchadeKunder;
            }
            else
            {
                MessageBox.Show("Inget matchande personnummer hittades, försök igen");
            }
        }
    }
}
