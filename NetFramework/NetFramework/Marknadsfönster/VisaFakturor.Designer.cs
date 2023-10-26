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
            this.gradientPanel1 = new NetFramework.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridFakturor)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(12, 768);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(110, 28);
            this.btnTillbaka.TabIndex = 18;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // gridFakturor
            // 
            this.gridFakturor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFakturor.Location = new System.Drawing.Point(378, 336);
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
            this.lblAnstNr.Location = new System.Drawing.Point(12, 11);
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
            this.lblPersonNr.Location = new System.Drawing.Point(379, 292);
            this.lblPersonNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonNr.Name = "lblPersonNr";
            this.lblPersonNr.Size = new System.Drawing.Size(62, 13);
            this.lblPersonNr.TabIndex = 31;
            this.lblPersonNr.Text = "BokningsID";
            // 
            // txtBoxBokningsID
            // 
            this.txtBoxBokningsID.Location = new System.Drawing.Point(382, 307);
            this.txtBoxBokningsID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxBokningsID.Name = "txtBoxBokningsID";
            this.txtBoxBokningsID.Size = new System.Drawing.Size(171, 20);
            this.txtBoxBokningsID.TabIndex = 30;
            // 
            // btnSökAnställningsNr
            // 
            this.btnSökAnställningsNr.Location = new System.Drawing.Point(556, 302);
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
            this.label1.Location = new System.Drawing.Point(511, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 39);
            this.label1.TabIndex = 28;
            this.label1.Text = "Visa Fakturor";
            // 
            // btnÄndra
            // 
            this.btnÄndra.Location = new System.Drawing.Point(722, 550);
            this.btnÄndra.Name = "btnÄndra";
            this.btnÄndra.Size = new System.Drawing.Size(85, 37);
            this.btnÄndra.TabIndex = 33;
            this.btnÄndra.Text = "Ändra Rabatt";
            this.btnÄndra.UseVisualStyleBackColor = true;
            this.btnÄndra.Click += new System.EventHandler(this.btnÄndraRabatt_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(813, 550);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(78, 37);
            this.btnTaBort.TabIndex = 32;
            this.btnTaBort.Text = "Ta bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(123, 8);
            this.txtAnvandarnamn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.ReadOnly = true;
            this.txtAnvandarnamn.Size = new System.Drawing.Size(14, 20);
            this.txtAnvandarnamn.TabIndex = 34;
            // 
            // btn_ÄndraMoms
            // 
            this.btn_ÄndraMoms.Location = new System.Drawing.Point(631, 550);
            this.btn_ÄndraMoms.Name = "btn_ÄndraMoms";
            this.btn_ÄndraMoms.Size = new System.Drawing.Size(85, 37);
            this.btn_ÄndraMoms.TabIndex = 35;
            this.btn_ÄndraMoms.Text = "Ändra Moms";
            this.btn_ÄndraMoms.UseVisualStyleBackColor = true;
            this.btn_ÄndraMoms.Click += new System.EventHandler(this.btn_ÄndraMoms_Click);
            // 
            // btn_totalPris
            // 
            this.btn_totalPris.Location = new System.Drawing.Point(540, 550);
            this.btn_totalPris.Name = "btn_totalPris";
            this.btn_totalPris.Size = new System.Drawing.Size(85, 37);
            this.btn_totalPris.TabIndex = 36;
            this.btn_totalPris.Text = "Totalpris";
            this.btn_totalPris.UseVisualStyleBackColor = true;
            this.btn_totalPris.Click += new System.EventHandler(this.btn_totalPris_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.gradientPanel1.BottomColor = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.btn_totalPris);
            this.gradientPanel1.Controls.Add(this.lblAnstNr);
            this.gradientPanel1.Controls.Add(this.btn_ÄndraMoms);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.btnTillbaka);
            this.gradientPanel1.Controls.Add(this.btnÄndra);
            this.gradientPanel1.Controls.Add(this.gridFakturor);
            this.gradientPanel1.Controls.Add(this.btnTaBort);
            this.gradientPanel1.Controls.Add(this.btnSökAnställningsNr);
            this.gradientPanel1.Controls.Add(this.lblPersonNr);
            this.gradientPanel1.Controls.Add(this.txtBoxBokningsID);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1279, 808);
            this.gradientPanel1.TabIndex = 37;
            this.gradientPanel1.TopColor = System.Drawing.SystemColors.HotTrack;
            // 
            // VisaFakturor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1279, 808);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisaFakturor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisaFakturor";
            this.Load += new System.EventHandler(this.FakturaRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFakturor)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
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
        private GradientPanel gradientPanel1;
    }
}