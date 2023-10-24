namespace NetFramework
{
    partial class SkapaAnställd
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
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.cmbBehörighet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxLösenord = new System.Windows.Forms.TextBox();
            this.txtBoxEfternamn = new System.Windows.Forms.TextBox();
            this.txtBoxFörnamn = new System.Windows.Forms.TextBox();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.lblAnstNr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 39);
            this.label1.TabIndex = 60;
            this.label1.Text = "Lägg till anställd";
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(452, 468);
            this.btnTillbaka.Margin = new System.Windows.Forms.Padding(2);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(71, 25);
            this.btnTillbaka.TabIndex = 61;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(711, 468);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(71, 25);
            this.btnSpara.TabIndex = 62;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // cmbBehörighet
            // 
            this.cmbBehörighet.FormattingEnabled = true;
            this.cmbBehörighet.Items.AddRange(new object[] {
            "Bokare",
            "Uthyrare",
            "Admin",
            "Marknad"});
            this.cmbBehörighet.Location = new System.Drawing.Point(636, 408);
            this.cmbBehörighet.Name = "cmbBehörighet";
            this.cmbBehörighet.Size = new System.Drawing.Size(199, 21);
            this.cmbBehörighet.TabIndex = 68;
            this.cmbBehörighet.Text = "Behörighet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(633, 408);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(633, 377);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 66;
            // 
            // txtBoxLösenord
            // 
            this.txtBoxLösenord.Location = new System.Drawing.Point(413, 408);
            this.txtBoxLösenord.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxLösenord.Name = "txtBoxLösenord";
            this.txtBoxLösenord.Size = new System.Drawing.Size(199, 20);
            this.txtBoxLösenord.TabIndex = 65;
            this.txtBoxLösenord.Text = "Lösenord:";
            this.txtBoxLösenord.Enter += new System.EventHandler(this.txtBoxLösenord_Enter);
            this.txtBoxLösenord.Leave += new System.EventHandler(this.txtBoxLösenord_Leave);
            // 
            // txtBoxEfternamn
            // 
            this.txtBoxEfternamn.Location = new System.Drawing.Point(636, 374);
            this.txtBoxEfternamn.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxEfternamn.Name = "txtBoxEfternamn";
            this.txtBoxEfternamn.Size = new System.Drawing.Size(199, 20);
            this.txtBoxEfternamn.TabIndex = 64;
            this.txtBoxEfternamn.Text = "Efternamn:";
            this.txtBoxEfternamn.Enter += new System.EventHandler(this.txtBoxEfternamn_Enter);
            this.txtBoxEfternamn.Leave += new System.EventHandler(this.txtBoxEfternamn_Leave);
            // 
            // txtBoxFörnamn
            // 
            this.txtBoxFörnamn.Location = new System.Drawing.Point(413, 375);
            this.txtBoxFörnamn.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxFörnamn.Name = "txtBoxFörnamn";
            this.txtBoxFörnamn.Size = new System.Drawing.Size(199, 20);
            this.txtBoxFörnamn.TabIndex = 63;
            this.txtBoxFörnamn.Text = "Förnamn:";
            this.txtBoxFörnamn.Enter += new System.EventHandler(this.txtBoxFörnamn_Enter);
            this.txtBoxFörnamn.Leave += new System.EventHandler(this.txtBoxFörnamn_Leave);
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(115, 8);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.ReadOnly = true;
            this.txtAnvandarnamn.Size = new System.Drawing.Size(14, 20);
            this.txtAnvandarnamn.TabIndex = 70;
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(12, 9);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(103, 13);
            this.lblAnstNr.TabIndex = 69;
            this.lblAnstNr.Text = "Anställningsnummer:";
            // 
            // SkapaAnställd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 808);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.lblAnstNr);
            this.Controls.Add(this.cmbBehörighet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxLösenord);
            this.Controls.Add(this.txtBoxEfternamn);
            this.Controls.Add(this.txtBoxFörnamn);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.label1);
            this.Name = "SkapaAnställd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkapaAnställd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.ComboBox cmbBehörighet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxLösenord;
        private System.Windows.Forms.TextBox txtBoxEfternamn;
        private System.Windows.Forms.TextBox txtBoxFörnamn;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Label lblAnstNr;
    }
}