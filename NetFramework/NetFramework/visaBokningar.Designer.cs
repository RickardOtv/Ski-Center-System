namespace NetFramework
{
    partial class VisaBokningar
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
            this.btnSökBokNr = new System.Windows.Forms.Button();
            this.label_BokningsNr = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.gridBokningar = new System.Windows.Forms.DataGridView();
            this.btn_tillbaka = new System.Windows.Forms.Button();
            this.btn_ändra = new System.Windows.Forms.Button();
            this.btn_taBort = new System.Windows.Forms.Button();
            this.textBox_personNr = new System.Windows.Forms.TextBox();
            this.btn_sökPersonNr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnstNr = new System.Windows.Forms.Label();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_visaRader = new System.Windows.Forms.Button();
            this.logiGrid = new System.Windows.Forms.DataGridView();
            this.uthyrningGrid = new System.Windows.Forms.DataGridView();
            this.LektionGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridBokningar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logiGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uthyrningGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LektionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSökBokNr
            // 
            this.btnSökBokNr.Location = new System.Drawing.Point(271, 82);
            this.btnSökBokNr.Margin = new System.Windows.Forms.Padding(2);
            this.btnSökBokNr.Name = "btnSökBokNr";
            this.btnSökBokNr.Size = new System.Drawing.Size(57, 20);
            this.btnSökBokNr.TabIndex = 10;
            this.btnSökBokNr.Text = "Sök";
            this.btnSökBokNr.UseVisualStyleBackColor = true;
            this.btnSökBokNr.Click += new System.EventHandler(this.btnSökBokNr_Click);
            // 
            // label_BokningsNr
            // 
            this.label_BokningsNr.AutoSize = true;
            this.label_BokningsNr.BackColor = System.Drawing.Color.Transparent;
            this.label_BokningsNr.Location = new System.Drawing.Point(72, 67);
            this.label_BokningsNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_BokningsNr.Name = "label_BokningsNr";
            this.label_BokningsNr.Size = new System.Drawing.Size(65, 13);
            this.label_BokningsNr.TabIndex = 9;
            this.label_BokningsNr.Text = "BokningsNr:";
            this.label_BokningsNr.Click += new System.EventHandler(this.label_BokningsNr_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(75, 83);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(192, 20);
            this.txtFilter.TabIndex = 8;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // gridBokningar
            // 
            this.gridBokningar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBokningar.Location = new System.Drawing.Point(75, 152);
            this.gridBokningar.Margin = new System.Windows.Forms.Padding(2);
            this.gridBokningar.MultiSelect = false;
            this.gridBokningar.Name = "gridBokningar";
            this.gridBokningar.ReadOnly = true;
            this.gridBokningar.RowHeadersVisible = false;
            this.gridBokningar.RowHeadersWidth = 72;
            this.gridBokningar.RowTemplate.Height = 31;
            this.gridBokningar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBokningar.Size = new System.Drawing.Size(423, 208);
            this.gridBokningar.TabIndex = 7;
            this.gridBokningar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBokningar_CellContentClick);
            // 
            // btn_tillbaka
            // 
            this.btn_tillbaka.Location = new System.Drawing.Point(12, 467);
            this.btn_tillbaka.Name = "btn_tillbaka";
            this.btn_tillbaka.Size = new System.Drawing.Size(85, 32);
            this.btn_tillbaka.TabIndex = 11;
            this.btn_tillbaka.Text = "Tillbaka";
            this.btn_tillbaka.UseVisualStyleBackColor = true;
            this.btn_tillbaka.Click += new System.EventHandler(this.btn_tillbaka_Click);
            // 
            // btn_ändra
            // 
            this.btn_ändra.Location = new System.Drawing.Point(320, 367);
            this.btn_ändra.Name = "btn_ändra";
            this.btn_ändra.Size = new System.Drawing.Size(86, 38);
            this.btn_ändra.TabIndex = 12;
            this.btn_ändra.Text = "Ändra";
            this.btn_ändra.UseVisualStyleBackColor = true;
            this.btn_ändra.Click += new System.EventHandler(this.btn_ändra_Click);
            // 
            // btn_taBort
            // 
            this.btn_taBort.Location = new System.Drawing.Point(228, 367);
            this.btn_taBort.Name = "btn_taBort";
            this.btn_taBort.Size = new System.Drawing.Size(86, 39);
            this.btn_taBort.TabIndex = 13;
            this.btn_taBort.Text = "Ta Bort";
            this.btn_taBort.UseVisualStyleBackColor = true;
            this.btn_taBort.Click += new System.EventHandler(this.btn_taBort_Click);
            // 
            // textBox_personNr
            // 
            this.textBox_personNr.Location = new System.Drawing.Point(75, 128);
            this.textBox_personNr.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_personNr.Name = "textBox_personNr";
            this.textBox_personNr.Size = new System.Drawing.Size(192, 20);
            this.textBox_personNr.TabIndex = 14;
            this.textBox_personNr.TextChanged += new System.EventHandler(this.textBox_personNr_TextChanged);
            // 
            // btn_sökPersonNr
            // 
            this.btn_sökPersonNr.Location = new System.Drawing.Point(271, 127);
            this.btn_sökPersonNr.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sökPersonNr.Name = "btn_sökPersonNr";
            this.btn_sökPersonNr.Size = new System.Drawing.Size(57, 20);
            this.btn_sökPersonNr.TabIndex = 15;
            this.btn_sökPersonNr.Text = "Sök";
            this.btn_sökPersonNr.UseVisualStyleBackColor = true;
            this.btn_sökPersonNr.Click += new System.EventHandler(this.btn_sökPersonNr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(72, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "PersonNr:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(9, 9);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(103, 13);
            this.lblAnstNr.TabIndex = 17;
            this.lblAnstNr.Text = "Anställningsnummer:";
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(112, 6);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(14, 20);
            this.txtAnvandarnamn.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(454, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "↻ ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_visaRader
            // 
            this.btn_visaRader.Location = new System.Drawing.Point(412, 367);
            this.btn_visaRader.Name = "btn_visaRader";
            this.btn_visaRader.Size = new System.Drawing.Size(86, 38);
            this.btn_visaRader.TabIndex = 20;
            this.btn_visaRader.Text = "Visa Info";
            this.btn_visaRader.UseVisualStyleBackColor = true;
            this.btn_visaRader.Click += new System.EventHandler(this.btn_visaRader_Click);
            // 
            // logiGrid
            // 
            this.logiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logiGrid.Enabled = false;
            this.logiGrid.Location = new System.Drawing.Point(563, 52);
            this.logiGrid.Margin = new System.Windows.Forms.Padding(2);
            this.logiGrid.MultiSelect = false;
            this.logiGrid.Name = "logiGrid";
            this.logiGrid.ReadOnly = true;
            this.logiGrid.RowHeadersVisible = false;
            this.logiGrid.RowHeadersWidth = 72;
            this.logiGrid.RowTemplate.Height = 31;
            this.logiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.logiGrid.Size = new System.Drawing.Size(423, 119);
            this.logiGrid.TabIndex = 21;
            // 
            // uthyrningGrid
            // 
            this.uthyrningGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uthyrningGrid.Location = new System.Drawing.Point(563, 197);
            this.uthyrningGrid.Margin = new System.Windows.Forms.Padding(2);
            this.uthyrningGrid.MultiSelect = false;
            this.uthyrningGrid.Name = "uthyrningGrid";
            this.uthyrningGrid.ReadOnly = true;
            this.uthyrningGrid.RowHeadersVisible = false;
            this.uthyrningGrid.RowHeadersWidth = 72;
            this.uthyrningGrid.RowTemplate.Height = 31;
            this.uthyrningGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.uthyrningGrid.Size = new System.Drawing.Size(423, 123);
            this.uthyrningGrid.TabIndex = 22;
            // 
            // LektionGrid
            // 
            this.LektionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LektionGrid.Enabled = false;
            this.LektionGrid.Location = new System.Drawing.Point(563, 344);
            this.LektionGrid.Margin = new System.Windows.Forms.Padding(2);
            this.LektionGrid.MultiSelect = false;
            this.LektionGrid.Name = "LektionGrid";
            this.LektionGrid.ReadOnly = true;
            this.LektionGrid.RowHeadersVisible = false;
            this.LektionGrid.RowHeadersWidth = 72;
            this.LektionGrid.RowTemplate.Height = 31;
            this.LektionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.LektionGrid.Size = new System.Drawing.Size(423, 123);
            this.LektionGrid.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(560, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Logi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(560, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Uthyrningar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(560, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Lektioner:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(777, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "//Enable = True";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(777, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "//Enable = False";
            // 
            // VisaBokningar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 511);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LektionGrid);
            this.Controls.Add(this.uthyrningGrid);
            this.Controls.Add(this.logiGrid);
            this.Controls.Add(this.btn_visaRader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.lblAnstNr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sökPersonNr);
            this.Controls.Add(this.textBox_personNr);
            this.Controls.Add(this.btn_taBort);
            this.Controls.Add(this.btn_ändra);
            this.Controls.Add(this.btn_tillbaka);
            this.Controls.Add(this.btnSökBokNr);
            this.Controls.Add(this.label_BokningsNr);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.gridBokningar);
            this.Name = "VisaBokningar";
            this.Text = "visaBokningar";
            this.Load += new System.EventHandler(this.VisaBokningar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBokningar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logiGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uthyrningGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LektionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSökBokNr;
        private System.Windows.Forms.Label label_BokningsNr;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridView gridBokningar;
        private System.Windows.Forms.Button btn_tillbaka;
        private System.Windows.Forms.Button btn_ändra;
        private System.Windows.Forms.Button btn_taBort;
        private System.Windows.Forms.TextBox textBox_personNr;
        private System.Windows.Forms.Button btn_sökPersonNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnstNr;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_visaRader;
        private System.Windows.Forms.DataGridView logiGrid;
        private System.Windows.Forms.DataGridView uthyrningGrid;
        private System.Windows.Forms.DataGridView LektionGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}