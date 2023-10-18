namespace NetFramework
{
    partial class SkapaUthyrning
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
            this.gridBokningar = new System.Windows.Forms.DataGridView();
            this.txtBoxKundID = new System.Windows.Forms.TextBox();
            this.txtBoxBokningsID = new System.Windows.Forms.TextBox();
            this.Personnummerlbl = new System.Windows.Forms.Label();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.Anställningsnummerlbl = new System.Windows.Forms.Label();
            this.Bokningsnummer = new System.Windows.Forms.Label();
            this.KundSokBtn = new System.Windows.Forms.Button();
            this.BokningsnummerBtn = new System.Windows.Forms.Button();
            this.VäljBtn = new System.Windows.Forms.Button();
            this.btnTillbaka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridBokningar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBokningar
            // 
            this.gridBokningar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBokningar.Location = new System.Drawing.Point(248, 217);
            this.gridBokningar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gridBokningar.Name = "gridBokningar";
            this.gridBokningar.RowHeadersWidth = 82;
            this.gridBokningar.Size = new System.Drawing.Size(1112, 510);
            this.gridBokningar.TabIndex = 0;
            // 
            // txtBoxKundID
            // 
            this.txtBoxKundID.Location = new System.Drawing.Point(436, 117);
            this.txtBoxKundID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBoxKundID.Name = "txtBoxKundID";
            this.txtBoxKundID.Size = new System.Drawing.Size(196, 31);
            this.txtBoxKundID.TabIndex = 1;
            // 
            // txtBoxBokningsID
            // 
            this.txtBoxBokningsID.Location = new System.Drawing.Point(436, 167);
            this.txtBoxBokningsID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBoxBokningsID.Name = "txtBoxBokningsID";
            this.txtBoxBokningsID.Size = new System.Drawing.Size(196, 31);
            this.txtBoxBokningsID.TabIndex = 2;
            // 
            // Personnummerlbl
            // 
            this.Personnummerlbl.AutoSize = true;
            this.Personnummerlbl.BackColor = System.Drawing.Color.Transparent;
            this.Personnummerlbl.Location = new System.Drawing.Point(242, 123);
            this.Personnummerlbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Personnummerlbl.Name = "Personnummerlbl";
            this.Personnummerlbl.Size = new System.Drawing.Size(88, 25);
            this.Personnummerlbl.TabIndex = 3;
            this.Personnummerlbl.Text = "KundID:";
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(236, 8);
            this.txtAnvandarnamn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(34, 31);
            this.txtAnvandarnamn.TabIndex = 4;
            // 
            // Anställningsnummerlbl
            // 
            this.Anställningsnummerlbl.AutoSize = true;
            this.Anställningsnummerlbl.BackColor = System.Drawing.Color.Transparent;
            this.Anställningsnummerlbl.Location = new System.Drawing.Point(24, 13);
            this.Anställningsnummerlbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Anställningsnummerlbl.Name = "Anställningsnummerlbl";
            this.Anställningsnummerlbl.Size = new System.Drawing.Size(206, 25);
            this.Anställningsnummerlbl.TabIndex = 5;
            this.Anställningsnummerlbl.Text = "Anställningsnummer";
            this.Anställningsnummerlbl.Click += new System.EventHandler(this.Anställningsnummerlbl_Click);
            // 
            // Bokningsnummer
            // 
            this.Bokningsnummer.AutoSize = true;
            this.Bokningsnummer.BackColor = System.Drawing.Color.Transparent;
            this.Bokningsnummer.Location = new System.Drawing.Point(242, 167);
            this.Bokningsnummer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Bokningsnummer.Name = "Bokningsnummer";
            this.Bokningsnummer.Size = new System.Drawing.Size(184, 25);
            this.Bokningsnummer.TabIndex = 6;
            this.Bokningsnummer.Text = "Bokningsnummer:";
            // 
            // KundSokBtn
            // 
            this.KundSokBtn.Location = new System.Drawing.Point(648, 115);
            this.KundSokBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KundSokBtn.Name = "KundSokBtn";
            this.KundSokBtn.Size = new System.Drawing.Size(150, 40);
            this.KundSokBtn.TabIndex = 7;
            this.KundSokBtn.Text = "Sök Personnummer";
            this.KundSokBtn.UseVisualStyleBackColor = true;
            this.KundSokBtn.Click += new System.EventHandler(this.KundSokBtn_Click);
            // 
            // BokningsnummerBtn
            // 
            this.BokningsnummerBtn.Location = new System.Drawing.Point(648, 163);
            this.BokningsnummerBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BokningsnummerBtn.Name = "BokningsnummerBtn";
            this.BokningsnummerBtn.Size = new System.Drawing.Size(150, 44);
            this.BokningsnummerBtn.TabIndex = 8;
            this.BokningsnummerBtn.Text = "Sök Bokningsnummer";
            this.BokningsnummerBtn.UseVisualStyleBackColor = true;
            this.BokningsnummerBtn.Click += new System.EventHandler(this.BokningsnummerBtn_Click);
            // 
            // VäljBtn
            // 
            this.VäljBtn.Location = new System.Drawing.Point(1210, 738);
            this.VäljBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.VäljBtn.Name = "VäljBtn";
            this.VäljBtn.Size = new System.Drawing.Size(150, 44);
            this.VäljBtn.TabIndex = 9;
            this.VäljBtn.Text = "Välj";
            this.VäljBtn.UseVisualStyleBackColor = true;
            this.VäljBtn.Click += new System.EventHandler(this.VäljBtn_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(58, 798);
            this.btnTillbaka.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(150, 44);
            this.btnTillbaka.TabIndex = 10;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click_1);
            // 
            // SkapaUthyrning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.ClientSize = new System.Drawing.Size(1532, 865);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.VäljBtn);
            this.Controls.Add(this.BokningsnummerBtn);
            this.Controls.Add(this.KundSokBtn);
            this.Controls.Add(this.Bokningsnummer);
            this.Controls.Add(this.Anställningsnummerlbl);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.Personnummerlbl);
            this.Controls.Add(this.txtBoxBokningsID);
            this.Controls.Add(this.txtBoxKundID);
            this.Controls.Add(this.gridBokningar);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SkapaUthyrning";
            this.Text = "SkapaUthyrning";
            ((System.ComponentModel.ISupportInitialize)(this.gridBokningar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBokningar;
        private System.Windows.Forms.TextBox txtBoxKundID;
        private System.Windows.Forms.TextBox txtBoxBokningsID;
        private System.Windows.Forms.Label Personnummerlbl;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Label Anställningsnummerlbl;
        private System.Windows.Forms.Label Bokningsnummer;
        private System.Windows.Forms.Button KundSokBtn;
        private System.Windows.Forms.Button BokningsnummerBtn;
        private System.Windows.Forms.Button VäljBtn;
        private System.Windows.Forms.Button btnTillbaka;
    }
}