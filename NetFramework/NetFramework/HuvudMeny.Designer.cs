﻿namespace NetFramework
{
    partial class HuvudMeny
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
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.gradientPanel1 = new NetFramework.GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAnstNr = new System.Windows.Forms.Label();
            this.btnLoggaUt = new System.Windows.Forms.Button();
            this.btnKundregister = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btn_BokningsMeny = new System.Windows.Forms.Button();
            this.btnUthyrning = new System.Windows.Forms.Button();
            this.btnMarknad = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(123, 8);
            this.txtAnvandarnamn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.ReadOnly = true;
            this.txtAnvandarnamn.Size = new System.Drawing.Size(14, 20);
            this.txtAnvandarnamn.TabIndex = 17;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.gradientPanel1.BottomColor = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.txtAnvandarnamn);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.lblAnstNr);
            this.gradientPanel1.Controls.Add(this.btnLoggaUt);
            this.gradientPanel1.Controls.Add(this.btnKundregister);
            this.gradientPanel1.Controls.Add(this.btnAdmin);
            this.gradientPanel1.Controls.Add(this.btn_BokningsMeny);
            this.gradientPanel1.Controls.Add(this.btnUthyrning);
            this.gradientPanel1.Controls.Add(this.btnMarknad);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1279, 808);
            this.gradientPanel1.TabIndex = 10;
            this.gradientPanel1.TopColor = System.Drawing.SystemColors.HotTrack;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label2.Location = new System.Drawing.Point(507, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 54);
            this.label2.TabIndex = 19;
            this.label2.Text = "Huvudmeny";
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(12, 11);
            this.lblAnstNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(103, 13);
            this.lblAnstNr.TabIndex = 16;
            this.lblAnstNr.Text = "Anställningsnummer:";
            // 
            // btnLoggaUt
            // 
            this.btnLoggaUt.Location = new System.Drawing.Point(14, 768);
            this.btnLoggaUt.Name = "btnLoggaUt";
            this.btnLoggaUt.Size = new System.Drawing.Size(110, 28);
            this.btnLoggaUt.TabIndex = 9;
            this.btnLoggaUt.Text = "Logga ut";
            this.btnLoggaUt.UseVisualStyleBackColor = true;
            this.btnLoggaUt.Click += new System.EventHandler(this.btnLoggaUt_Click);
            // 
            // btnKundregister
            // 
            this.btnKundregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKundregister.Location = new System.Drawing.Point(476, 567);
            this.btnKundregister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnKundregister.Name = "btnKundregister";
            this.btnKundregister.Size = new System.Drawing.Size(330, 52);
            this.btnKundregister.TabIndex = 18;
            this.btnKundregister.Text = "Kundregister";
            this.btnKundregister.UseVisualStyleBackColor = true;
            this.btnKundregister.Click += new System.EventHandler(this.btnKundregister_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(476, 488);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(330, 52);
            this.btnAdmin.TabIndex = 14;
            this.btnAdmin.Text = "Adminvy";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btn_BokningsMeny
            // 
            this.btn_BokningsMeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BokningsMeny.Location = new System.Drawing.Point(476, 270);
            this.btn_BokningsMeny.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_BokningsMeny.Name = "btn_BokningsMeny";
            this.btn_BokningsMeny.Size = new System.Drawing.Size(330, 52);
            this.btn_BokningsMeny.TabIndex = 11;
            this.btn_BokningsMeny.Text = "Bokning";
            this.btn_BokningsMeny.UseVisualStyleBackColor = true;
            this.btn_BokningsMeny.Click += new System.EventHandler(this.btnBokningsMeny_Click);
            // 
            // btnUthyrning
            // 
            this.btnUthyrning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUthyrning.Location = new System.Drawing.Point(476, 341);
            this.btnUthyrning.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUthyrning.Name = "btnUthyrning";
            this.btnUthyrning.Size = new System.Drawing.Size(330, 52);
            this.btnUthyrning.TabIndex = 12;
            this.btnUthyrning.Text = "Uthyrning";
            this.btnUthyrning.UseVisualStyleBackColor = true;
            this.btnUthyrning.Click += new System.EventHandler(this.btnUthyrning_Click);
            // 
            // btnMarknad
            // 
            this.btnMarknad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarknad.Location = new System.Drawing.Point(476, 412);
            this.btnMarknad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMarknad.Name = "btnMarknad";
            this.btnMarknad.Size = new System.Drawing.Size(330, 52);
            this.btnMarknad.TabIndex = 13;
            this.btnMarknad.Text = "Marknadsvy";
            this.btnMarknad.UseVisualStyleBackColor = true;
            this.btnMarknad.Click += new System.EventHandler(this.btnMarknad_Click);
            // 
            // HuvudMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 808);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HuvudMeny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HuvudMeny";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Label lblAnstNr;
        private System.Windows.Forms.Button btnMarknad;
        private System.Windows.Forms.Button btnUthyrning;
        private System.Windows.Forms.Button btn_BokningsMeny;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnKundregister;
        private System.Windows.Forms.Button btnLoggaUt;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label2;
    }
}