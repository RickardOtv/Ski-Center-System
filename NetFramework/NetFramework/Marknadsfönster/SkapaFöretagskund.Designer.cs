namespace NetFramework.Marknadsfönster
{
    partial class SkapaFöretagskund
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.lblKund = new System.Windows.Forms.Label();
            this.txtBoxPersonNr = new System.Windows.Forms.TextBox();
            this.txtBoxKredit = new System.Windows.Forms.TextBox();
            this.txtBoxOrt = new System.Windows.Forms.TextBox();
            this.txtBoxPostNr = new System.Windows.Forms.TextBox();
            this.txtboxNamn = new System.Windows.Forms.TextBox();
            this.txtBoxTelefonNr = new System.Windows.Forms.TextBox();
            this.txtBoxAdress = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.btnGaVidare = new System.Windows.Forms.Button();
            this.gradientPanel1 = new NetFramework.GradientPanel();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anställningsnummer:";
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(123, 8);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(14, 20);
            this.txtAnvandarnamn.TabIndex = 19;
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(12, 768);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(110, 28);
            this.btnTillbaka.TabIndex = 20;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // lblKund
            // 
            this.lblKund.AutoSize = true;
            this.lblKund.BackColor = System.Drawing.Color.Transparent;
            this.lblKund.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKund.Location = new System.Drawing.Point(456, 253);
            this.lblKund.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblKund.Name = "lblKund";
            this.lblKund.Size = new System.Drawing.Size(314, 31);
            this.lblKund.TabIndex = 21;
            this.lblKund.Text = "Registrera Företagskund";
            // 
            // txtBoxPersonNr
            // 
            this.txtBoxPersonNr.Location = new System.Drawing.Point(472, 307);
            this.txtBoxPersonNr.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxPersonNr.Name = "txtBoxPersonNr";
            this.txtBoxPersonNr.Size = new System.Drawing.Size(279, 20);
            this.txtBoxPersonNr.TabIndex = 22;
            this.txtBoxPersonNr.Text = "Personnummer: (YYYYMMDDXXXX)";
            this.txtBoxPersonNr.Enter += new System.EventHandler(this.txtboxPersonNr_Enter);
            this.txtBoxPersonNr.Leave += new System.EventHandler(this.txtboxPersonNr_Leave);
            // 
            // txtBoxKredit
            // 
            this.txtBoxKredit.Location = new System.Drawing.Point(620, 425);
            this.txtBoxKredit.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxKredit.Name = "txtBoxKredit";
            this.txtBoxKredit.Size = new System.Drawing.Size(131, 20);
            this.txtBoxKredit.TabIndex = 31;
            this.txtBoxKredit.Text = "Kreditgräns:";
            this.txtBoxKredit.Enter += new System.EventHandler(this.txtBoxKredit_Enter);
            this.txtBoxKredit.Leave += new System.EventHandler(this.txtBoxKredit_Leave);
            // 
            // txtBoxOrt
            // 
            this.txtBoxOrt.Location = new System.Drawing.Point(620, 394);
            this.txtBoxOrt.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxOrt.Name = "txtBoxOrt";
            this.txtBoxOrt.Size = new System.Drawing.Size(131, 20);
            this.txtBoxOrt.TabIndex = 30;
            this.txtBoxOrt.Text = "Postort:";
            this.txtBoxOrt.Enter += new System.EventHandler(this.txtBoxOrt_Enter);
            this.txtBoxOrt.Leave += new System.EventHandler(this.txtBoxOrt_Leave);
            // 
            // txtBoxPostNr
            // 
            this.txtBoxPostNr.Location = new System.Drawing.Point(472, 394);
            this.txtBoxPostNr.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxPostNr.Name = "txtBoxPostNr";
            this.txtBoxPostNr.Size = new System.Drawing.Size(131, 20);
            this.txtBoxPostNr.TabIndex = 29;
            this.txtBoxPostNr.Text = "Postnummer:";
            this.txtBoxPostNr.Enter += new System.EventHandler(this.txtBoxPostNr_Enter);
            this.txtBoxPostNr.Leave += new System.EventHandler(this.textBoxPostNr_Leave);
            // 
            // txtboxNamn
            // 
            this.txtboxNamn.Location = new System.Drawing.Point(472, 341);
            this.txtboxNamn.Margin = new System.Windows.Forms.Padding(1);
            this.txtboxNamn.Name = "txtboxNamn";
            this.txtboxNamn.Size = new System.Drawing.Size(131, 20);
            this.txtboxNamn.TabIndex = 28;
            this.txtboxNamn.Text = "Namn:";
            this.txtboxNamn.Enter += new System.EventHandler(this.textBoxNamn_Enter);
            this.txtboxNamn.Leave += new System.EventHandler(this.textBoxNamn_Leave);
            // 
            // txtBoxTelefonNr
            // 
            this.txtBoxTelefonNr.Location = new System.Drawing.Point(620, 341);
            this.txtBoxTelefonNr.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxTelefonNr.Name = "txtBoxTelefonNr";
            this.txtBoxTelefonNr.Size = new System.Drawing.Size(131, 20);
            this.txtBoxTelefonNr.TabIndex = 27;
            this.txtBoxTelefonNr.Text = "Telefonnummer:";
            this.txtBoxTelefonNr.Enter += new System.EventHandler(this.txtBoxTelefonNr_Enter);
            this.txtBoxTelefonNr.Leave += new System.EventHandler(this.txtBoxTelefonNr_Leave);
            // 
            // txtBoxAdress
            // 
            this.txtBoxAdress.Location = new System.Drawing.Point(620, 368);
            this.txtBoxAdress.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxAdress.Name = "txtBoxAdress";
            this.txtBoxAdress.Size = new System.Drawing.Size(131, 20);
            this.txtBoxAdress.TabIndex = 26;
            this.txtBoxAdress.Text = "Adress:";
            this.txtBoxAdress.Enter += new System.EventHandler(this.txtBoxAdress_Enter);
            this.txtBoxAdress.Leave += new System.EventHandler(this.txtBoxAdress_Leave);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(472, 368);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(131, 20);
            this.txtBoxEmail.TabIndex = 25;
            this.txtBoxEmail.Text = "Email:";
            this.txtBoxEmail.Enter += new System.EventHandler(this.txtBoxEmail_Enter);
            this.txtBoxEmail.Leave += new System.EventHandler(this.txtBoxEmail_Leave);
            // 
            // btnGaVidare
            // 
            this.btnGaVidare.Location = new System.Drawing.Point(648, 475);
            this.btnGaVidare.Name = "btnGaVidare";
            this.btnGaVidare.Size = new System.Drawing.Size(103, 26);
            this.btnGaVidare.TabIndex = 24;
            this.btnGaVidare.Text = "Spara";
            this.btnGaVidare.UseVisualStyleBackColor = true;
            this.btnGaVidare.Click += new System.EventHandler(this.btnGaVidare_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.gradientPanel1.BottomColor = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.lblKund);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.btnTillbaka);
            this.gradientPanel1.Controls.Add(this.btnGaVidare);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1279, 808);
            this.gradientPanel1.TabIndex = 32;
            this.gradientPanel1.TopColor = System.Drawing.SystemColors.HotTrack;
            // 
            // SkapaFöretagskund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1279, 808);
            this.Controls.Add(this.txtBoxKredit);
            this.Controls.Add(this.txtBoxOrt);
            this.Controls.Add(this.txtBoxPostNr);
            this.Controls.Add(this.txtboxNamn);
            this.Controls.Add(this.txtBoxTelefonNr);
            this.Controls.Add(this.txtBoxAdress);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxPersonNr);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SkapaFöretagskund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkapaFöretagskund";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Label lblKund;
        private System.Windows.Forms.TextBox txtBoxPersonNr;
        private System.Windows.Forms.TextBox txtBoxKredit;
        private System.Windows.Forms.TextBox txtBoxOrt;
        private System.Windows.Forms.TextBox txtBoxPostNr;
        private System.Windows.Forms.TextBox txtboxNamn;
        private System.Windows.Forms.TextBox txtBoxTelefonNr;
        private System.Windows.Forms.TextBox txtBoxAdress;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Button btnGaVidare;
        private GradientPanel gradientPanel1;
    }
}