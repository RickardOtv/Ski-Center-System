﻿namespace NetFramework
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
            this.lblUthyrning = new System.Windows.Forms.Label();
            this.lblPersNr = new System.Windows.Forms.Label();
            this.txtBoxUthyrningsID = new System.Windows.Forms.TextBox();
            this.btnSök = new System.Windows.Forms.Button();
            this.btnVäljUthyrning = new System.Windows.Forms.Button();
            this.lblRader = new System.Windows.Forms.Label();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.Anställningsnummerlbl = new System.Windows.Forms.Label();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.gradientPanel1 = new NetFramework.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridUthyrning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUthyrningsRader)).BeginInit();
            this.gradientPanel1.SuspendLayout();
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
            // lblUthyrning
            // 
            this.lblUthyrning.AutoSize = true;
            this.lblUthyrning.BackColor = System.Drawing.Color.Transparent;
            this.lblUthyrning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUthyrning.Location = new System.Drawing.Point(260, 159);
            this.lblUthyrning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUthyrning.Name = "lblUthyrning";
            this.lblUthyrning.Size = new System.Drawing.Size(130, 25);
            this.lblUthyrning.TabIndex = 3;
            this.lblUthyrning.Text = "Välj uthyrning";
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
            // 
            // txtBoxUthyrningsID
            // 
            this.txtBoxUthyrningsID.Location = new System.Drawing.Point(253, 209);
            this.txtBoxUthyrningsID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxUthyrningsID.Name = "txtBoxUthyrningsID";
            this.txtBoxUthyrningsID.Size = new System.Drawing.Size(75, 20);
            this.txtBoxUthyrningsID.TabIndex = 5;
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
            this.btnVäljUthyrning.Location = new System.Drawing.Point(325, 413);
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
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(223, 413);
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
            this.Anställningsnummerlbl.Location = new System.Drawing.Point(12, 11);
            this.Anställningsnummerlbl.Name = "Anställningsnummerlbl";
            this.Anställningsnummerlbl.Size = new System.Drawing.Size(100, 13);
            this.Anställningsnummerlbl.TabIndex = 12;
            this.Anställningsnummerlbl.Text = "Anställningsnummer";
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(123, 8);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.ReadOnly = true;
            this.txtAnvandarnamn.Size = new System.Drawing.Size(14, 20);
            this.txtAnvandarnamn.TabIndex = 11;
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(14, 768);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(110, 28);
            this.btnTillbaka.TabIndex = 13;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.gradientPanel1.BottomColor = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.btnTillbaka);
            this.gradientPanel1.Controls.Add(this.btnVäljUthyrning);
            this.gradientPanel1.Controls.Add(this.btnTaBort);
            this.gradientPanel1.Controls.Add(this.lblUthyrning);
            this.gradientPanel1.Controls.Add(this.Anställningsnummerlbl);
            this.gradientPanel1.Controls.Add(this.lblPersNr);
            this.gradientPanel1.Controls.Add(this.lblRader);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1279, 808);
            this.gradientPanel1.TabIndex = 16;
            this.gradientPanel1.TopColor = System.Drawing.SystemColors.HotTrack;
            // 
            // VisaUthyrningar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 808);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.txtBoxUthyrningsID);
            this.Controls.Add(this.gridUthyrningsRader);
            this.Controls.Add(this.gridUthyrning);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VisaUthyrningar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisaUthyrningar";
            this.Load += new System.EventHandler(this.VisaUthyrningar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUthyrning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUthyrningsRader)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUthyrning;
        private System.Windows.Forms.DataGridView gridUthyrningsRader;
        private System.Windows.Forms.Label lblUthyrning;
        private System.Windows.Forms.Label lblPersNr;
        private System.Windows.Forms.TextBox txtBoxUthyrningsID;
        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.Button btnVäljUthyrning;
        private System.Windows.Forms.Label lblRader;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Label Anställningsnummerlbl;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Button btnTillbaka;
        private GradientPanel gradientPanel1;
    }
}