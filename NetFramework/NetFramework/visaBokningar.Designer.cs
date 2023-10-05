﻿namespace NetFramework
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
            ((System.ComponentModel.ISupportInitialize)(this.gridBokningar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSökBokNr
            // 
            this.btnSökBokNr.Location = new System.Drawing.Point(406, 98);
            this.btnSökBokNr.Name = "btnSökBokNr";
            this.btnSökBokNr.Size = new System.Drawing.Size(86, 31);
            this.btnSökBokNr.TabIndex = 10;
            this.btnSökBokNr.Text = "Sök";
            this.btnSökBokNr.UseVisualStyleBackColor = true;
            this.btnSökBokNr.Click += new System.EventHandler(this.btnSökBokNr_Click);
            // 
            // label_BokningsNr
            // 
            this.label_BokningsNr.AutoSize = true;
            this.label_BokningsNr.BackColor = System.Drawing.Color.Transparent;
            this.label_BokningsNr.Location = new System.Drawing.Point(108, 75);
            this.label_BokningsNr.Name = "label_BokningsNr";
            this.label_BokningsNr.Size = new System.Drawing.Size(95, 20);
            this.label_BokningsNr.TabIndex = 9;
            this.label_BokningsNr.Text = "BokningsNr:";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(112, 100);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(286, 26);
            this.txtFilter.TabIndex = 8;

            // 
            // gridBokningar
            // 
            this.gridBokningar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBokningar.Location = new System.Drawing.Point(112, 206);
            this.gridBokningar.MultiSelect = false;
            this.gridBokningar.Name = "gridBokningar";
            this.gridBokningar.ReadOnly = true;
            this.gridBokningar.RowHeadersVisible = false;
            this.gridBokningar.RowHeadersWidth = 72;
            this.gridBokningar.RowTemplate.Height = 31;
            this.gridBokningar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBokningar.Size = new System.Drawing.Size(981, 320);
            this.gridBokningar.TabIndex = 7;
            // 
            // btn_tillbaka
            // 
            this.btn_tillbaka.Location = new System.Drawing.Point(18, 625);
            this.btn_tillbaka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_tillbaka.Name = "btn_tillbaka";
            this.btn_tillbaka.Size = new System.Drawing.Size(128, 49);
            this.btn_tillbaka.TabIndex = 11;
            this.btn_tillbaka.Text = "Tillbaka";
            this.btn_tillbaka.UseVisualStyleBackColor = true;
            this.btn_tillbaka.Click += new System.EventHandler(this.btn_tillbaka_Click);
            // 
            // btn_ändra
            // 
            this.btn_ändra.Location = new System.Drawing.Point(826, 535);
            this.btn_ändra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ändra.Name = "btn_ändra";
            this.btn_ändra.Size = new System.Drawing.Size(129, 58);
            this.btn_ändra.TabIndex = 12;
            this.btn_ändra.Text = "Ändra";
            this.btn_ändra.UseVisualStyleBackColor = true;
            this.btn_ändra.Click += new System.EventHandler(this.btn_ändra_Click);
            // 
            // btn_taBort
            // 
            this.btn_taBort.Location = new System.Drawing.Point(964, 534);
            this.btn_taBort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_taBort.Name = "btn_taBort";
            this.btn_taBort.Size = new System.Drawing.Size(129, 60);
            this.btn_taBort.TabIndex = 13;
            this.btn_taBort.Text = "Ta Bort";
            this.btn_taBort.UseVisualStyleBackColor = true;
            this.btn_taBort.Click += new System.EventHandler(this.btn_taBort_Click);
            // 
            // textBox_personNr
            // 
            this.textBox_personNr.Location = new System.Drawing.Point(112, 169);
            this.textBox_personNr.Name = "textBox_personNr";
            this.textBox_personNr.Size = new System.Drawing.Size(286, 26);
            this.textBox_personNr.TabIndex = 14;
            // 
            // btn_sökPersonNr
            // 
            this.btn_sökPersonNr.Location = new System.Drawing.Point(406, 168);
            this.btn_sökPersonNr.Name = "btn_sökPersonNr";
            this.btn_sökPersonNr.Size = new System.Drawing.Size(86, 31);
            this.btn_sökPersonNr.TabIndex = 15;
            this.btn_sökPersonNr.Text = "Sök";
            this.btn_sökPersonNr.UseVisualStyleBackColor = true;
            this.btn_sökPersonNr.Click += new System.EventHandler(this.btn_sökPersonNr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(108, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "PersonNr:";
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(14, 14);
            this.lblAnstNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(157, 20);
            this.lblAnstNr.TabIndex = 17;
            this.lblAnstNr.Text = "Anställningsnummer:";
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(168, 9);
            this.txtAnvandarnamn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(19, 26);
            this.txtAnvandarnamn.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(1028, 135);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 63);
            this.button1.TabIndex = 19;
            this.button1.Text = "↻ ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VisaBokningar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1149, 692);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VisaBokningar";
            this.Text = "visaBokningar";
            this.Load += new System.EventHandler(this.VisaBokningar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBokningar)).EndInit();
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
    }
}