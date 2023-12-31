﻿namespace NetFramework
{
    partial class LoggaIn
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
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.btnLoggaIn = new System.Windows.Forms.Button();
            this.txtLösen = new System.Windows.Forms.TextBox();
            this.txtAnstNr = new System.Windows.Forms.TextBox();
            this.lblLösenord = new System.Windows.Forms.Label();
            this.lblAnstNr = new System.Windows.Forms.Label();
            this.lblLoggaIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAvbryt.Location = new System.Drawing.Point(837, 745);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(99, 54);
            this.btnAvbryt.TabIndex = 13;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = false;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // btnLoggaIn
            // 
            this.btnLoggaIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoggaIn.Location = new System.Drawing.Point(982, 745);
            this.btnLoggaIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoggaIn.Name = "btnLoggaIn";
            this.btnLoggaIn.Size = new System.Drawing.Size(99, 54);
            this.btnLoggaIn.TabIndex = 12;
            this.btnLoggaIn.Text = "Logga In";
            this.btnLoggaIn.UseVisualStyleBackColor = false;
            this.btnLoggaIn.Click += new System.EventHandler(this.btnLoggaIn_Click);
            // 
            // txtLösen
            // 
            this.txtLösen.Location = new System.Drawing.Point(891, 703);
            this.txtLösen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLösen.Name = "txtLösen";
            this.txtLösen.Size = new System.Drawing.Size(145, 26);
            this.txtLösen.TabIndex = 11;
            // 
            // txtAnstNr
            // 
            this.txtAnstNr.Location = new System.Drawing.Point(891, 646);
            this.txtAnstNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnstNr.Name = "txtAnstNr";
            this.txtAnstNr.Size = new System.Drawing.Size(145, 26);
            this.txtAnstNr.TabIndex = 10;
            // 
            // lblLösenord
            // 
            this.lblLösenord.AutoSize = true;
            this.lblLösenord.BackColor = System.Drawing.Color.Transparent;
            this.lblLösenord.Location = new System.Drawing.Point(888, 682);
            this.lblLösenord.Name = "lblLösenord";
            this.lblLösenord.Size = new System.Drawing.Size(76, 20);
            this.lblLösenord.TabIndex = 9;
            this.lblLösenord.Text = "Lösenord";
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(888, 625);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(153, 20);
            this.lblAnstNr.TabIndex = 8;
            this.lblAnstNr.Text = "Anställningsnummer";
            // 
            // lblLoggaIn
            // 
            this.lblLoggaIn.AutoSize = true;
            this.lblLoggaIn.BackColor = System.Drawing.Color.Transparent;
            this.lblLoggaIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoggaIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggaIn.ForeColor = System.Drawing.Color.Black;
            this.lblLoggaIn.Location = new System.Drawing.Point(760, 497);
            this.lblLoggaIn.Name = "lblLoggaIn";
            this.lblLoggaIn.Size = new System.Drawing.Size(423, 57);
            this.lblLoggaIn.TabIndex = 7;
            this.lblLoggaIn.Text = "Ski Center System";
            // 
            // LoggaIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources._1286ce2aae8bf42293dc770d573c0eb0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1918, 1106);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.btnLoggaIn);
            this.Controls.Add(this.txtLösen);
            this.Controls.Add(this.txtAnstNr);
            this.Controls.Add(this.lblLösenord);
            this.Controls.Add(this.lblAnstNr);
            this.Controls.Add(this.lblLoggaIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoggaIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Button btnLoggaIn;
        private System.Windows.Forms.TextBox txtLösen;
        private System.Windows.Forms.TextBox txtAnstNr;
        private System.Windows.Forms.Label lblLösenord;
        private System.Windows.Forms.Label lblAnstNr;
        private System.Windows.Forms.Label lblLoggaIn;
    }
}

