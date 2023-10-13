namespace NetFramework
{
    partial class ÄndraKund
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
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.lblAnstNr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.txtBoxKundID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTyp = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLösenord = new System.Windows.Forms.Label();
            this.txtBoxKredit = new System.Windows.Forms.TextBox();
            this.txtBoxOrt = new System.Windows.Forms.TextBox();
            this.txtBoxPostNr = new System.Windows.Forms.TextBox();
            this.txtBoxPersonNr = new System.Windows.Forms.TextBox();
            this.txtboxNamn = new System.Windows.Forms.TextBox();
            this.txtBoxTelefonNr = new System.Windows.Forms.TextBox();
            this.txtBoxAdress = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(159, 7);
            this.txtAnvandarnamn.Margin = new System.Windows.Forms.Padding(5);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(19, 26);
            this.txtAnvandarnamn.TabIndex = 11;
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(5, 9);
            this.lblAnstNr.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(157, 20);
            this.lblAnstNr.TabIndex = 10;
            this.lblAnstNr.Text = "Anställningsnummer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ändra kund";
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(55, 386);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(107, 39);
            this.btnTillbaka.TabIndex = 13;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(649, 386);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(107, 39);
            this.btnSpara.TabIndex = 14;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // txtBoxKundID
            // 
            this.txtBoxKundID.Location = new System.Drawing.Point(159, 72);
            this.txtBoxKundID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxKundID.Multiline = true;
            this.txtBoxKundID.Name = "txtBoxKundID";
            this.txtBoxKundID.Size = new System.Drawing.Size(37, 29);
            this.txtBoxKundID.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(90, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "KundID:";
            // 
            // cmbTyp
            // 
            this.cmbTyp.FormattingEnabled = true;
            this.cmbTyp.Items.AddRange(new object[] {
            "Privat",
            "Företag"});
            this.cmbTyp.Location = new System.Drawing.Point(191, 314);
            this.cmbTyp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTyp.Name = "cmbTyp";
            this.cmbTyp.Size = new System.Drawing.Size(194, 28);
            this.cmbTyp.TabIndex = 40;
            this.cmbTyp.Text = "Typ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(395, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(195, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(195, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(419, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(419, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(419, 231);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(195, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 33;
            // 
            // lblLösenord
            // 
            this.lblLösenord.AutoSize = true;
            this.lblLösenord.BackColor = System.Drawing.Color.Transparent;
            this.lblLösenord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLösenord.Location = new System.Drawing.Point(195, 189);
            this.lblLösenord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLösenord.Name = "lblLösenord";
            this.lblLösenord.Size = new System.Drawing.Size(0, 20);
            this.lblLösenord.TabIndex = 32;
            // 
            // txtBoxKredit
            // 
            this.txtBoxKredit.Location = new System.Drawing.Point(413, 315);
            this.txtBoxKredit.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxKredit.Name = "txtBoxKredit";
            this.txtBoxKredit.Size = new System.Drawing.Size(194, 26);
            this.txtBoxKredit.TabIndex = 31;
            this.txtBoxKredit.Text = "Kreditgräns:";
            // 
            // txtBoxOrt
            // 
            this.txtBoxOrt.Location = new System.Drawing.Point(413, 268);
            this.txtBoxOrt.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxOrt.Name = "txtBoxOrt";
            this.txtBoxOrt.Size = new System.Drawing.Size(194, 26);
            this.txtBoxOrt.TabIndex = 30;
            this.txtBoxOrt.Text = "Postort:";
            // 
            // txtBoxPostNr
            // 
            this.txtBoxPostNr.Location = new System.Drawing.Point(191, 268);
            this.txtBoxPostNr.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPostNr.Name = "txtBoxPostNr";
            this.txtBoxPostNr.Size = new System.Drawing.Size(194, 26);
            this.txtBoxPostNr.TabIndex = 29;
            this.txtBoxPostNr.Text = "Postnummer:";
            // 
            // txtBoxPersonNr
            // 
            this.txtBoxPersonNr.Location = new System.Drawing.Point(191, 125);
            this.txtBoxPersonNr.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPersonNr.Name = "txtBoxPersonNr";
            this.txtBoxPersonNr.Size = new System.Drawing.Size(416, 26);
            this.txtBoxPersonNr.TabIndex = 28;
            this.txtBoxPersonNr.Text = "Personnummer:";
            // 
            // txtboxNamn
            // 
            this.txtboxNamn.Location = new System.Drawing.Point(191, 186);
            this.txtboxNamn.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxNamn.Name = "txtboxNamn";
            this.txtboxNamn.Size = new System.Drawing.Size(194, 26);
            this.txtboxNamn.TabIndex = 27;
            this.txtboxNamn.Text = "Namn:";
            // 
            // txtBoxTelefonNr
            // 
            this.txtBoxTelefonNr.Location = new System.Drawing.Point(413, 186);
            this.txtBoxTelefonNr.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTelefonNr.Name = "txtBoxTelefonNr";
            this.txtBoxTelefonNr.Size = new System.Drawing.Size(194, 26);
            this.txtBoxTelefonNr.TabIndex = 26;
            this.txtBoxTelefonNr.Text = "Telefonnummer:";
            // 
            // txtBoxAdress
            // 
            this.txtBoxAdress.Location = new System.Drawing.Point(413, 228);
            this.txtBoxAdress.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAdress.Name = "txtBoxAdress";
            this.txtBoxAdress.Size = new System.Drawing.Size(194, 26);
            this.txtBoxAdress.TabIndex = 25;
            this.txtBoxAdress.Text = "Adress:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(191, 228);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(194, 26);
            this.txtBoxEmail.TabIndex = 24;
            this.txtBoxEmail.Text = "Email:";
            // 
            // ÄndraKund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTyp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblLösenord);
            this.Controls.Add(this.txtBoxKredit);
            this.Controls.Add(this.txtBoxOrt);
            this.Controls.Add(this.txtBoxPostNr);
            this.Controls.Add(this.txtBoxPersonNr);
            this.Controls.Add(this.txtboxNamn);
            this.Controls.Add(this.txtBoxTelefonNr);
            this.Controls.Add(this.txtBoxAdress);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxKundID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.lblAnstNr);
            this.Name = "ÄndraKund";
            this.Text = "ÄndraKund";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Label lblAnstNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.TextBox txtBoxKundID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTyp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLösenord;
        private System.Windows.Forms.TextBox txtBoxKredit;
        private System.Windows.Forms.TextBox txtBoxOrt;
        private System.Windows.Forms.TextBox txtBoxPostNr;
        private System.Windows.Forms.TextBox txtBoxPersonNr;
        private System.Windows.Forms.TextBox txtboxNamn;
        private System.Windows.Forms.TextBox txtBoxTelefonNr;
        private System.Windows.Forms.TextBox txtBoxAdress;
        private System.Windows.Forms.TextBox txtBoxEmail;
    }
}