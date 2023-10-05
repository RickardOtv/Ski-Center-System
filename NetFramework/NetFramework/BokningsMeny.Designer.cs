﻿namespace NetFramework
{
    partial class BokningsMeny
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
            this.btnSkapaBokning = new System.Windows.Forms.Button();
            this.btnLediga = new System.Windows.Forms.Button();
            this.btnVisaBokningar = new System.Windows.Forms.Button();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.lblAnstNr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSkapaBokning
            // 
            this.btnSkapaBokning.Location = new System.Drawing.Point(124, 121);
            this.btnSkapaBokning.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSkapaBokning.Name = "btnSkapaBokning";
            this.btnSkapaBokning.Size = new System.Drawing.Size(314, 44);
            this.btnSkapaBokning.TabIndex = 0;
            this.btnSkapaBokning.Text = "Bokning av Logi";
            this.btnSkapaBokning.UseVisualStyleBackColor = true;
            this.btnSkapaBokning.Click += new System.EventHandler(this.btnSkapaBokning_Click);
            // 
            // btnLediga
            // 
            this.btnLediga.Location = new System.Drawing.Point(124, 204);
            this.btnLediga.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLediga.Name = "btnLediga";
            this.btnLediga.Size = new System.Drawing.Size(314, 44);
            this.btnLediga.TabIndex = 1;
            this.btnLediga.Text = "Visa lediga logialternativ";
            this.btnLediga.UseVisualStyleBackColor = true;
            this.btnLediga.Click += new System.EventHandler(this.btnLediga_Click);
            // 
            // btnVisaBokningar
            // 
            this.btnVisaBokningar.Location = new System.Drawing.Point(124, 289);
            this.btnVisaBokningar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVisaBokningar.Name = "btnVisaBokningar";
            this.btnVisaBokningar.Size = new System.Drawing.Size(314, 44);
            this.btnVisaBokningar.TabIndex = 3;
            this.btnVisaBokningar.Text = "Visa bokningar";
            this.btnVisaBokningar.UseVisualStyleBackColor = true;
            this.btnVisaBokningar.Click += new System.EventHandler(this.btnVisaBokningar_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(8, 352);
            this.btnTillbaka.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(58, 22);
            this.btnTillbaka.TabIndex = 2;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(104, 3);
            this.txtAnvandarnamn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(14, 20);
            this.txtAnvandarnamn.TabIndex = 9;
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(-1, 5);
            this.lblAnstNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(103, 13);
            this.lblAnstNr.TabIndex = 8;
            this.lblAnstNr.Text = "Anställningsnummer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bokning";
            // 
            // BokningsMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.lblAnstNr);
            this.Controls.Add(this.btnVisaBokningar);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.btnLediga);
            this.Controls.Add(this.btnSkapaBokning);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BokningsMeny";
            this.Text = "BokningsMeny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSkapaBokning;
        private System.Windows.Forms.Button btnLediga;
        private System.Windows.Forms.Button btnVisaBokningar;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Label lblAnstNr;
        private System.Windows.Forms.Label label1;
    }
}