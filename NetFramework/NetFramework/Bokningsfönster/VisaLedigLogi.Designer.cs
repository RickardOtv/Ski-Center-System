﻿namespace NetFramework
{
    partial class VisaLedigLogi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.lblAnstNr = new System.Windows.Forms.Label();
            this.TillbakaKnapp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new NetFramework.GradientPanel();
            this.sökLedigLogiKnapp = new System.Windows.Forms.Button();
            this.kollaPrisKnappen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 233);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(550, 229);
            this.dataGridView1.TabIndex = 5;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(371, 210);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startDatePicker.TabIndex = 6;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(721, 210);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatePicker.TabIndex = 7;
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(123, 8);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.ReadOnly = true;
            this.txtAnvandarnamn.Size = new System.Drawing.Size(14, 20);
            this.txtAnvandarnamn.TabIndex = 11;
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(12, 11);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(103, 13);
            this.lblAnstNr.TabIndex = 10;
            this.lblAnstNr.Text = "Anställningsnummer:";
            // 
            // TillbakaKnapp
            // 
            this.TillbakaKnapp.Location = new System.Drawing.Point(14, 768);
            this.TillbakaKnapp.Name = "TillbakaKnapp";
            this.TillbakaKnapp.Size = new System.Drawing.Size(110, 28);
            this.TillbakaKnapp.TabIndex = 14;
            this.TillbakaKnapp.Text = "Tillbaka";
            this.TillbakaKnapp.UseVisualStyleBackColor = true;
            this.TillbakaKnapp.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Välj Startdatum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(778, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "Välj Slutdatum:";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.gradientPanel1.BottomColor = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.kollaPrisKnappen);
            this.gradientPanel1.Controls.Add(this.sökLedigLogiKnapp);
            this.gradientPanel1.Controls.Add(this.TillbakaKnapp);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.lblAnstNr);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1279, 808);
            this.gradientPanel1.TabIndex = 17;
            this.gradientPanel1.TopColor = System.Drawing.SystemColors.HotTrack;
            // 
            // sökLedigLogiKnapp
            // 
            this.sökLedigLogiKnapp.Location = new System.Drawing.Point(371, 469);
            this.sökLedigLogiKnapp.Name = "sökLedigLogiKnapp";
            this.sökLedigLogiKnapp.Size = new System.Drawing.Size(144, 35);
            this.sökLedigLogiKnapp.TabIndex = 17;
            this.sökLedigLogiKnapp.Text = "Sök Ledig Logi";
            this.sökLedigLogiKnapp.UseVisualStyleBackColor = true;
            this.sökLedigLogiKnapp.Click += new System.EventHandler(this.btnSökLedigLogi_Click);
            // 
            // kollaPrisKnappen
            // 
            this.kollaPrisKnappen.Location = new System.Drawing.Point(371, 511);
            this.kollaPrisKnappen.Name = "kollaPrisKnappen";
            this.kollaPrisKnappen.Size = new System.Drawing.Size(144, 40);
            this.kollaPrisKnappen.TabIndex = 18;
            this.kollaPrisKnappen.Text = "Kolla Pris";
            this.kollaPrisKnappen.UseVisualStyleBackColor = true;
            this.kollaPrisKnappen.Click += new System.EventHandler(this.btnKollaPris_Click);
            // 
            // VisaLedigLogi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 808);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisaLedigLogi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lediga logialternativ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SökLedigLogi;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Label lblAnstNr;
        private System.Windows.Forms.Button kollaPrisKnapp;
        private System.Windows.Forms.Button TillbakaKnapp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button sökLedigLogiKnapp;
        private System.Windows.Forms.Button kollaPrisKnappen;
    }
}