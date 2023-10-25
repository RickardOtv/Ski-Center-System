namespace NetFramework.Marknadsfönster
{
    partial class VisaFakturor
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
            this.gridFakturor = new System.Windows.Forms.DataGridView();
            this.lblAnstNr = new System.Windows.Forms.Label();
            this.lblPersonNr = new System.Windows.Forms.Label();
            this.txtBoxBokningsID = new System.Windows.Forms.TextBox();
            this.btnSökAnställningsNr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnÄndra = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.btn_ÄndraMoms = new System.Windows.Forms.Button();
            this.btn_totalPris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridFakturor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(13, 559);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(63, 25);
            this.btnTillbaka.TabIndex = 18;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // gridFakturor
            // 
            this.gridFakturor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFakturor.Location = new System.Drawing.Point(112, 319);
            this.gridFakturor.Name = "gridFakturor";
            this.gridFakturor.ReadOnly = true;
            this.gridFakturor.RowHeadersVisible = false;
            this.gridFakturor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFakturor.Size = new System.Drawing.Size(513, 208);
            this.gridFakturor.TabIndex = 17;
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(10, 7);
            this.lblAnstNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(103, 13);
            this.lblAnstNr.TabIndex = 15;
            this.lblAnstNr.Text = "Anställningsnummer:";
            // 
            // lblPersonNr
            // 
            this.lblPersonNr.AutoSize = true;
            this.lblPersonNr.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonNr.Location = new System.Drawing.Point(113, 275);
            this.lblPersonNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonNr.Name = "lblPersonNr";
            this.lblPersonNr.Size = new System.Drawing.Size(62, 13);
            this.lblPersonNr.TabIndex = 31;
            this.lblPersonNr.Text = "BokningsID";
            // 
            // txtBoxBokningsID
            // 
            this.txtBoxBokningsID.Location = new System.Drawing.Point(116, 290);
            this.txtBoxBokningsID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxBokningsID.Name = "txtBoxBokningsID";
            this.txtBoxBokningsID.Size = new System.Drawing.Size(171, 20);
            this.txtBoxBokningsID.TabIndex = 30;
            // 
            // btnSökAnställningsNr
            // 
            this.btnSökAnställningsNr.Location = new System.Drawing.Point(290, 285);
            this.btnSökAnställningsNr.Margin = new System.Windows.Forms.Padding(2);
            this.btnSökAnställningsNr.Name = "btnSökAnställningsNr";
            this.btnSökAnställningsNr.Size = new System.Drawing.Size(61, 27);
            this.btnSökAnställningsNr.TabIndex = 29;
            this.btnSökAnställningsNr.Text = "Sök";
            this.btnSökAnställningsNr.UseVisualStyleBackColor = true;
            this.btnSökAnställningsNr.Click += new System.EventHandler(this.btnSökBokningsNr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 39);
            this.label1.TabIndex = 28;
            this.label1.Text = "Visa Fakturor";
            // 
            // btnÄndra
            // 
            this.btnÄndra.Location = new System.Drawing.Point(456, 533);
            this.btnÄndra.Name = "btnÄndra";
            this.btnÄndra.Size = new System.Drawing.Size(85, 37);
            this.btnÄndra.TabIndex = 33;
            this.btnÄndra.Text = "Ändra Rabatt";
            this.btnÄndra.UseVisualStyleBackColor = true;
            this.btnÄndra.Click += new System.EventHandler(this.btnÄndraRabatt_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(547, 533);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(78, 37);
            this.btnTaBort.TabIndex = 32;
            this.btnTaBort.Text = "Ta bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(112, 4);
            this.txtAnvandarnamn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.ReadOnly = true;
            this.txtAnvandarnamn.Size = new System.Drawing.Size(14, 20);
            this.txtAnvandarnamn.TabIndex = 34;
            // 
            // btn_ÄndraMoms
            // 
            this.btn_ÄndraMoms.Location = new System.Drawing.Point(365, 533);
            this.btn_ÄndraMoms.Name = "btn_ÄndraMoms";
            this.btn_ÄndraMoms.Size = new System.Drawing.Size(85, 37);
            this.btn_ÄndraMoms.TabIndex = 35;
            this.btn_ÄndraMoms.Text = "Ändra Moms";
            this.btn_ÄndraMoms.UseVisualStyleBackColor = true;
            this.btn_ÄndraMoms.Click += new System.EventHandler(this.btn_ÄndraMoms_Click);
            // 
            // btn_totalPris
            // 
            this.btn_totalPris.Location = new System.Drawing.Point(274, 533);
            this.btn_totalPris.Name = "btn_totalPris";
            this.btn_totalPris.Size = new System.Drawing.Size(85, 37);
            this.btn_totalPris.TabIndex = 36;
            this.btn_totalPris.Text = "Totalpris";
            this.btn_totalPris.UseVisualStyleBackColor = true;
            this.btn_totalPris.Click += new System.EventHandler(this.btn_totalPris_Click);
            // 
            // VisaFakturor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 596);
            this.Controls.Add(this.btn_totalPris);
            this.Controls.Add(this.btn_ÄndraMoms);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.btnÄndra);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.lblPersonNr);
            this.Controls.Add(this.txtBoxBokningsID);
            this.Controls.Add(this.btnSökAnställningsNr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.gridFakturor);
            this.Controls.Add(this.lblAnstNr);
            this.Name = "VisaFakturor";
            this.Text = "VisaFakturor";
            this.Load += new System.EventHandler(this.FakturaRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFakturor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.DataGridView gridFakturor;
        private System.Windows.Forms.Label lblAnstNr;
        private System.Windows.Forms.Label lblPersonNr;
        private System.Windows.Forms.TextBox txtBoxBokningsID;
        private System.Windows.Forms.Button btnSökAnställningsNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnÄndra;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Button btn_ÄndraMoms;
        private System.Windows.Forms.Button btn_totalPris;
    }
}