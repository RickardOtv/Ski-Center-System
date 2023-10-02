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
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxTelefonNr = new System.Windows.Forms.TextBox();
            this.textBoxNamn = new System.Windows.Forms.TextBox();
            this.txtboxPersonNr = new System.Windows.Forms.TextBox();
            this.textBoxPostNr = new System.Windows.Forms.TextBox();
            this.textBoxOrt = new System.Windows.Forms.TextBox();
            this.textBoxTyp = new System.Windows.Forms.TextBox();
            this.textBoxKredit = new System.Windows.Forms.TextBox();
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
            this.btnTillbaka.Location = new System.Drawing.Point(19, 269);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(103, 19);
            this.btnTillbaka.TabIndex = 3;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // btnGaVidare
            // 
            this.btnGaVidare.Location = new System.Drawing.Point(365, 269);
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
            this.lblKund.Location = new System.Drawing.Point(194, 45);
            this.lblKund.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblKund.Name = "lblKund";
            this.lblKund.Size = new System.Drawing.Size(133, 31);
            this.lblKund.TabIndex = 5;
            this.lblKund.Text = "Välj kund:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(107, 159);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(131, 20);
            this.txtBoxEmail.TabIndex = 6;
            this.txtBoxEmail.Text = "Email:";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(255, 159);
            this.textBoxAdress.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(131, 20);
            this.textBoxAdress.TabIndex = 7;
            this.textBoxAdress.Text = "Adress:";
            // 
            // textBoxTelefonNr
            // 
            this.textBoxTelefonNr.Location = new System.Drawing.Point(255, 132);
            this.textBoxTelefonNr.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxTelefonNr.Name = "textBoxTelefonNr";
            this.textBoxTelefonNr.Size = new System.Drawing.Size(131, 20);
            this.textBoxTelefonNr.TabIndex = 8;
            this.textBoxTelefonNr.Text = "Telefonnummer:";
            // 
            // textBoxNamn
            // 
            this.textBoxNamn.Location = new System.Drawing.Point(107, 132);
            this.textBoxNamn.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxNamn.Name = "textBoxNamn";
            this.textBoxNamn.Size = new System.Drawing.Size(131, 20);
            this.textBoxNamn.TabIndex = 9;
            this.textBoxNamn.Text = "Namn:";
            // 
            // txtboxPersonNr
            // 
            this.txtboxPersonNr.Location = new System.Drawing.Point(107, 92);
            this.txtboxPersonNr.Margin = new System.Windows.Forms.Padding(1);
            this.txtboxPersonNr.Name = "txtboxPersonNr";
            this.txtboxPersonNr.Size = new System.Drawing.Size(279, 20);
            this.txtboxPersonNr.TabIndex = 10;
            this.txtboxPersonNr.Text = "Personnummer:";
            this.txtboxPersonNr.Enter += new System.EventHandler(this.TxtBox_EnterLeave);
            this.txtboxPersonNr.Leave += new System.EventHandler(this.TxtBox_EnterLeave);
            // 
            // textBoxPostNr
            // 
            this.textBoxPostNr.Location = new System.Drawing.Point(107, 185);
            this.textBoxPostNr.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxPostNr.Name = "textBoxPostNr";
            this.textBoxPostNr.Size = new System.Drawing.Size(131, 20);
            this.textBoxPostNr.TabIndex = 11;
            this.textBoxPostNr.Text = "Postnummer:";
            // 
            // textBoxOrt
            // 
            this.textBoxOrt.Location = new System.Drawing.Point(255, 185);
            this.textBoxOrt.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxOrt.Name = "textBoxOrt";
            this.textBoxOrt.Size = new System.Drawing.Size(131, 20);
            this.textBoxOrt.TabIndex = 12;
            this.textBoxOrt.Text = "Postort:";
            // 
            // textBoxTyp
            // 
            this.textBoxTyp.Location = new System.Drawing.Point(107, 216);
            this.textBoxTyp.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxTyp.Name = "textBoxTyp";
            this.textBoxTyp.Size = new System.Drawing.Size(131, 20);
            this.textBoxTyp.TabIndex = 13;
            this.textBoxTyp.Text = "Privat/företag:";
            // 
            // textBoxKredit
            // 
            this.textBoxKredit.Location = new System.Drawing.Point(255, 216);
            this.textBoxKredit.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxKredit.Name = "textBoxKredit";
            this.textBoxKredit.Size = new System.Drawing.Size(131, 20);
            this.textBoxKredit.TabIndex = 14;
            this.textBoxKredit.Text = "Kreditgräns:";
            // 
            // lblLösenord
            // 
            this.lblLösenord.AutoSize = true;
            this.lblLösenord.BackColor = System.Drawing.Color.Transparent;
            this.lblLösenord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLösenord.Location = new System.Drawing.Point(109, 134);
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
            this.label1.Location = new System.Drawing.Point(109, 161);
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
            this.label2.Location = new System.Drawing.Point(259, 161);
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
            this.label3.Location = new System.Drawing.Point(259, 187);
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
            this.label4.Location = new System.Drawing.Point(259, 218);
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
            this.label5.Location = new System.Drawing.Point(109, 218);
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
            this.label6.Location = new System.Drawing.Point(109, 187);
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
            this.label7.Location = new System.Drawing.Point(243, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 22;
            // 
            // BokningNyKund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 297);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLösenord);
            this.Controls.Add(this.textBoxKredit);
            this.Controls.Add(this.textBoxTyp);
            this.Controls.Add(this.textBoxOrt);
            this.Controls.Add(this.textBoxPostNr);
            this.Controls.Add(this.txtboxPersonNr);
            this.Controls.Add(this.textBoxNamn);
            this.Controls.Add(this.textBoxTelefonNr);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblKund);
            this.Controls.Add(this.btnGaVidare);
            this.Controls.Add(this.btnTillbaka);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "BokningNyKund";
            this.Text = "Ny Kund";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Button btnGaVidare;
        private System.Windows.Forms.Label lblKund;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxTelefonNr;
        private System.Windows.Forms.TextBox textBoxNamn;
        private System.Windows.Forms.TextBox txtboxPersonNr;
        private System.Windows.Forms.TextBox textBoxPostNr;
        private System.Windows.Forms.TextBox textBoxOrt;
        private System.Windows.Forms.TextBox textBoxTyp;
        private System.Windows.Forms.TextBox textBoxKredit;
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