namespace NetFramework
{
    partial class BokningNyKund
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
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.btnGaVidare = new System.Windows.Forms.Button();
            this.lblKund = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxAdress = new System.Windows.Forms.TextBox();
            this.txtBoxTelefonNr = new System.Windows.Forms.TextBox();
            this.txtboxNamn = new System.Windows.Forms.TextBox();
            this.txtBoxPersonNr = new System.Windows.Forms.TextBox();
            this.txtBoxPostNr = new System.Windows.Forms.TextBox();
            this.txtBoxOrt = new System.Windows.Forms.TextBox();
            this.lblLösenord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(393, 479);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(103, 19);
            this.btnTillbaka.TabIndex = 3;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // btnGaVidare
            // 
            this.btnGaVidare.Location = new System.Drawing.Point(739, 479);
            this.btnGaVidare.Name = "btnGaVidare";
            this.btnGaVidare.Size = new System.Drawing.Size(103, 19);
            this.btnGaVidare.TabIndex = 4;
            this.btnGaVidare.Text = "Gå vidare";
            this.btnGaVidare.UseVisualStyleBackColor = true;
            this.btnGaVidare.Click += new System.EventHandler(this.btnGaVidare_Click);
            // 
            // lblKund
            // 
            this.lblKund.AutoSize = true;
            this.lblKund.BackColor = System.Drawing.Color.Transparent;
            this.lblKund.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKund.Location = new System.Drawing.Point(558, 253);
            this.lblKund.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblKund.Name = "lblKund";
            this.lblKund.Size = new System.Drawing.Size(125, 31);
            this.lblKund.TabIndex = 5;
            this.lblKund.Text = "Välj kund";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(481, 369);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(131, 20);
            this.txtBoxEmail.TabIndex = 6;
            this.txtBoxEmail.Text = "Email:";
            this.txtBoxEmail.Enter += new System.EventHandler(this.txtBoxEmail_Enter);
            this.txtBoxEmail.Leave += new System.EventHandler(this.txtBoxEmail_Leave);
            // 
            // txtBoxAdress
            // 
            this.txtBoxAdress.Location = new System.Drawing.Point(629, 369);
            this.txtBoxAdress.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxAdress.Name = "txtBoxAdress";
            this.txtBoxAdress.Size = new System.Drawing.Size(131, 20);
            this.txtBoxAdress.TabIndex = 7;
            this.txtBoxAdress.Text = "Adress:";
            this.txtBoxAdress.Enter += new System.EventHandler(this.txtBoxAdress_Enter);
            this.txtBoxAdress.Leave += new System.EventHandler(this.txtBoxAdress_Leave);
            // 
            // txtBoxTelefonNr
            // 
            this.txtBoxTelefonNr.Location = new System.Drawing.Point(629, 342);
            this.txtBoxTelefonNr.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxTelefonNr.Name = "txtBoxTelefonNr";
            this.txtBoxTelefonNr.Size = new System.Drawing.Size(131, 20);
            this.txtBoxTelefonNr.TabIndex = 8;
            this.txtBoxTelefonNr.Text = "Telefonnummer:";
            this.txtBoxTelefonNr.Enter += new System.EventHandler(this.txtBoxTelefonNr_Enter);
            this.txtBoxTelefonNr.Leave += new System.EventHandler(this.txtBoxTelefonNr_Leave);
            // 
            // txtboxNamn
            // 
            this.txtboxNamn.Location = new System.Drawing.Point(481, 342);
            this.txtboxNamn.Margin = new System.Windows.Forms.Padding(1);
            this.txtboxNamn.Name = "txtboxNamn";
            this.txtboxNamn.Size = new System.Drawing.Size(131, 20);
            this.txtboxNamn.TabIndex = 9;
            this.txtboxNamn.Text = "Namn:";
            this.txtboxNamn.Enter += new System.EventHandler(this.textBoxNamn_Enter);
            this.txtboxNamn.Leave += new System.EventHandler(this.textBoxNamn_Leave);
            // 
            // txtBoxPersonNr
            // 
            this.txtBoxPersonNr.Location = new System.Drawing.Point(481, 302);
            this.txtBoxPersonNr.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxPersonNr.Name = "txtBoxPersonNr";
            this.txtBoxPersonNr.Size = new System.Drawing.Size(279, 20);
            this.txtBoxPersonNr.TabIndex = 10;
            this.txtBoxPersonNr.Text = "Personnummer: (YYYYMMDDXXXX)";
            this.txtBoxPersonNr.Enter += new System.EventHandler(this.txtboxPersonNr_Enter);
            this.txtBoxPersonNr.Leave += new System.EventHandler(this.txtboxPersonNr_Leave);
            // 
            // txtBoxPostNr
            // 
            this.txtBoxPostNr.Location = new System.Drawing.Point(481, 395);
            this.txtBoxPostNr.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxPostNr.Name = "txtBoxPostNr";
            this.txtBoxPostNr.Size = new System.Drawing.Size(131, 20);
            this.txtBoxPostNr.TabIndex = 11;
            this.txtBoxPostNr.Text = "Postnummer:";
            this.txtBoxPostNr.Enter += new System.EventHandler(this.txtBoxPostNr_Enter);
            this.txtBoxPostNr.Leave += new System.EventHandler(this.textBoxPostNr_Leave);
            // 
            // txtBoxOrt
            // 
            this.txtBoxOrt.Location = new System.Drawing.Point(629, 395);
            this.txtBoxOrt.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxOrt.Name = "txtBoxOrt";
            this.txtBoxOrt.Size = new System.Drawing.Size(131, 20);
            this.txtBoxOrt.TabIndex = 12;
            this.txtBoxOrt.Text = "Postort:";
            this.txtBoxOrt.Enter += new System.EventHandler(this.txtBoxOrt_Enter);
            this.txtBoxOrt.Leave += new System.EventHandler(this.txtBoxOrt_Leave);
            // 
            // lblLösenord
            // 
            this.lblLösenord.AutoSize = true;
            this.lblLösenord.BackColor = System.Drawing.Color.Transparent;
            this.lblLösenord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLösenord.Location = new System.Drawing.Point(483, 344);
            this.lblLösenord.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblLösenord.Name = "lblLösenord";
            this.lblLösenord.Size = new System.Drawing.Size(0, 13);
            this.lblLösenord.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(483, 371);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(633, 371);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(633, 397);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(633, 428);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(483, 428);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(483, 397);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(617, 344);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 22;
            // 
            // BokningNyKund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 808);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLösenord);
            this.Controls.Add(this.txtBoxOrt);
            this.Controls.Add(this.txtBoxPostNr);
            this.Controls.Add(this.txtBoxPersonNr);
            this.Controls.Add(this.txtboxNamn);
            this.Controls.Add(this.txtBoxTelefonNr);
            this.Controls.Add(this.txtBoxAdress);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblKund);
            this.Controls.Add(this.btnGaVidare);
            this.Controls.Add(this.btnTillbaka);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "BokningNyKund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ny Kund";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Button btnGaVidare;
        private System.Windows.Forms.Label lblKund;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxAdress;
        private System.Windows.Forms.TextBox txtBoxTelefonNr;
        private System.Windows.Forms.TextBox txtboxNamn;
        private System.Windows.Forms.TextBox txtBoxPersonNr;
        private System.Windows.Forms.TextBox txtBoxPostNr;
        private System.Windows.Forms.TextBox txtBoxOrt;
        private System.Windows.Forms.Label lblLösenord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}