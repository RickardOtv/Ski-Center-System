namespace NetFramework
{
    partial class VisaUthyrningar
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
            this.gridUthyrning = new System.Windows.Forms.DataGridView();
            this.gridUthyrningsRader = new System.Windows.Forms.DataGridView();
            this.gridLektioner = new System.Windows.Forms.DataGridView();
            this.lblUthyrning = new System.Windows.Forms.Label();
            this.lblPersNr = new System.Windows.Forms.Label();
            this.txtBoxUthyrningsID = new System.Windows.Forms.TextBox();
            this.btnSök = new System.Windows.Forms.Button();
            this.btnVäljUthyrning = new System.Windows.Forms.Button();
            this.lblRader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.Anställningsnummerlbl = new System.Windows.Forms.Label();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridUthyrning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUthyrningsRader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLektioner)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUthyrning
            // 
            this.gridUthyrning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUthyrning.Location = new System.Drawing.Point(212, 233);
            this.gridUthyrning.Margin = new System.Windows.Forms.Padding(2);
            this.gridUthyrning.Name = "gridUthyrning";
            this.gridUthyrning.ReadOnly = true;
            this.gridUthyrning.RowHeadersVisible = false;
            this.gridUthyrning.RowHeadersWidth = 82;
            this.gridUthyrning.RowTemplate.Height = 33;
            this.gridUthyrning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUthyrning.Size = new System.Drawing.Size(229, 176);
            this.gridUthyrning.TabIndex = 0;
            this.gridUthyrning.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUthyrning_CellContentClick);
            // 
            // gridUthyrningsRader
            // 
            this.gridUthyrningsRader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUthyrningsRader.Location = new System.Drawing.Point(524, 175);
            this.gridUthyrningsRader.Margin = new System.Windows.Forms.Padding(2);
            this.gridUthyrningsRader.Name = "gridUthyrningsRader";
            this.gridUthyrningsRader.ReadOnly = true;
            this.gridUthyrningsRader.RowHeadersVisible = false;
            this.gridUthyrningsRader.RowHeadersWidth = 82;
            this.gridUthyrningsRader.RowTemplate.Height = 33;
            this.gridUthyrningsRader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUthyrningsRader.Size = new System.Drawing.Size(482, 242);
            this.gridUthyrningsRader.TabIndex = 1;
            // 
            // gridLektioner
            // 
            this.gridLektioner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLektioner.Location = new System.Drawing.Point(524, 474);
            this.gridLektioner.Margin = new System.Windows.Forms.Padding(2);
            this.gridLektioner.Name = "gridLektioner";
            this.gridLektioner.RowHeadersWidth = 82;
            this.gridLektioner.RowTemplate.Height = 33;
            this.gridLektioner.Size = new System.Drawing.Size(482, 163);
            this.gridLektioner.TabIndex = 2;
            // 
            // lblUthyrning
            // 
            this.lblUthyrning.AutoSize = true;
            this.lblUthyrning.BackColor = System.Drawing.Color.Transparent;
            this.lblUthyrning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUthyrning.Location = new System.Drawing.Point(258, 162);
            this.lblUthyrning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUthyrning.Name = "lblUthyrning";
            this.lblUthyrning.Size = new System.Drawing.Size(130, 25);
            this.lblUthyrning.TabIndex = 3;
            this.lblUthyrning.Text = "Välj uthyrning";
            this.lblUthyrning.Click += new System.EventHandler(this.lblUthyrning_Click);
            // 
            // lblPersNr
            // 
            this.lblPersNr.AutoSize = true;
            this.lblPersNr.BackColor = System.Drawing.Color.Transparent;
            this.lblPersNr.Location = new System.Drawing.Point(250, 194);
            this.lblPersNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersNr.Name = "lblPersNr";
            this.lblPersNr.Size = new System.Drawing.Size(71, 13);
            this.lblPersNr.TabIndex = 4;
            this.lblPersNr.Text = "UthyrningsID:";
            this.lblPersNr.Click += new System.EventHandler(this.lblPersNr_Click);
            // 
            // txtBoxUthyrningsID
            // 
            this.txtBoxUthyrningsID.Location = new System.Drawing.Point(253, 209);
            this.txtBoxUthyrningsID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxUthyrningsID.Name = "txtBoxUthyrningsID";
            this.txtBoxUthyrningsID.Size = new System.Drawing.Size(75, 20);
            this.txtBoxUthyrningsID.TabIndex = 5;
            this.txtBoxUthyrningsID.TextChanged += new System.EventHandler(this.txtBoxUthyrningsID_TextChanged);
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(332, 209);
            this.btnSök.Margin = new System.Windows.Forms.Padding(2);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(49, 20);
            this.btnSök.TabIndex = 6;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            this.btnSök.Click += new System.EventHandler(this.btnSök_Click);
            // 
            // btnVäljUthyrning
            // 
            this.btnVäljUthyrning.Location = new System.Drawing.Point(346, 413);
            this.btnVäljUthyrning.Margin = new System.Windows.Forms.Padding(2);
            this.btnVäljUthyrning.Name = "btnVäljUthyrning";
            this.btnVäljUthyrning.Size = new System.Drawing.Size(98, 22);
            this.btnVäljUthyrning.TabIndex = 7;
            this.btnVäljUthyrning.Text = "Visa info";
            this.btnVäljUthyrning.UseVisualStyleBackColor = true;
            this.btnVäljUthyrning.Click += new System.EventHandler(this.btnVäljUthyrning_Click);
            // 
            // lblRader
            // 
            this.lblRader.AutoSize = true;
            this.lblRader.BackColor = System.Drawing.Color.Transparent;
            this.lblRader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRader.Location = new System.Drawing.Point(708, 148);
            this.lblRader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRader.Name = "lblRader";
            this.lblRader.Size = new System.Drawing.Size(150, 25);
            this.lblRader.TabIndex = 8;
            this.lblRader.Text = "Uthyrningsrader";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(708, 447);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Skidlektioner";
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(236, 413);
            this.btnTaBort.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(98, 22);
            this.btnTaBort.TabIndex = 10;
            this.btnTaBort.Text = "Ta bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // Anställningsnummerlbl
            // 
            this.Anställningsnummerlbl.AutoSize = true;
            this.Anställningsnummerlbl.BackColor = System.Drawing.Color.Transparent;
            this.Anställningsnummerlbl.Location = new System.Drawing.Point(9, 9);
            this.Anställningsnummerlbl.Name = "Anställningsnummerlbl";
            this.Anställningsnummerlbl.Size = new System.Drawing.Size(100, 13);
            this.Anställningsnummerlbl.TabIndex = 12;
            this.Anställningsnummerlbl.Text = "Anställningsnummer";
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(115, 6);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(19, 20);
            this.txtAnvandarnamn.TabIndex = 11;
            // 
            // VisaUthyrningar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 808);
            this.Controls.Add(this.Anställningsnummerlbl);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRader);
            this.Controls.Add(this.btnVäljUthyrning);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.txtBoxUthyrningsID);
            this.Controls.Add(this.lblPersNr);
            this.Controls.Add(this.lblUthyrning);
            this.Controls.Add(this.gridLektioner);
            this.Controls.Add(this.gridUthyrningsRader);
            this.Controls.Add(this.gridUthyrning);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VisaUthyrningar";
            this.Text = "VisaUthyrningar";
            this.Load += new System.EventHandler(this.VisaUthyrningar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUthyrning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUthyrningsRader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLektioner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUthyrning;
        private System.Windows.Forms.DataGridView gridUthyrningsRader;
        private System.Windows.Forms.DataGridView gridLektioner;
        private System.Windows.Forms.Label lblUthyrning;
        private System.Windows.Forms.Label lblPersNr;
        private System.Windows.Forms.TextBox txtBoxUthyrningsID;
        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.Button btnVäljUthyrning;
        private System.Windows.Forms.Label lblRader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Label Anställningsnummerlbl;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
    }
}