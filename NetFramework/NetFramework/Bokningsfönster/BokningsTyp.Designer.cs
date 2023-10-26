namespace NetFramework
{
    partial class BokningsTyp
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
            this.btnBefintlig = new System.Windows.Forms.Button();
            this.btnNyKund = new System.Windows.Forms.Button();
            this.lblTyp = new System.Windows.Forms.Label();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.lblAnstNr = new System.Windows.Forms.Label();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.gradientPanel1 = new NetFramework.GradientPanel();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBefintlig
            // 
            this.btnBefintlig.Location = new System.Drawing.Point(525, 310);
            this.btnBefintlig.Margin = new System.Windows.Forms.Padding(2);
            this.btnBefintlig.Name = "btnBefintlig";
            this.btnBefintlig.Size = new System.Drawing.Size(186, 42);
            this.btnBefintlig.TabIndex = 0;
            this.btnBefintlig.Text = "Befintlig kund";
            this.btnBefintlig.UseVisualStyleBackColor = true;
            this.btnBefintlig.Click += new System.EventHandler(this.btnBefintlig_Click);
            // 
            // btnNyKund
            // 
            this.btnNyKund.Location = new System.Drawing.Point(525, 370);
            this.btnNyKund.Margin = new System.Windows.Forms.Padding(2);
            this.btnNyKund.Name = "btnNyKund";
            this.btnNyKund.Size = new System.Drawing.Size(186, 42);
            this.btnNyKund.TabIndex = 1;
            this.btnNyKund.Text = "Ny Kund";
            this.btnNyKund.UseVisualStyleBackColor = true;
            this.btnNyKund.Click += new System.EventHandler(this.btnNyKund_Click);
            // 
            // lblTyp
            // 
            this.lblTyp.AutoSize = true;
            this.lblTyp.BackColor = System.Drawing.Color.Transparent;
            this.lblTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTyp.Location = new System.Drawing.Point(519, 248);
            this.lblTyp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTyp.Name = "lblTyp";
            this.lblTyp.Size = new System.Drawing.Size(213, 31);
            this.lblTyp.TabIndex = 2;
            this.lblTyp.Text = "Välj typ av kund:";
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(14, 768);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(110, 28);
            this.btnTillbaka.TabIndex = 3;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(12, 11);
            this.lblAnstNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(103, 13);
            this.lblAnstNr.TabIndex = 9;
            this.lblAnstNr.Text = "Anställningsnummer:";
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(123, 8);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.ReadOnly = true;
            this.txtAnvandarnamn.Size = new System.Drawing.Size(14, 20);
            this.txtAnvandarnamn.TabIndex = 27;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.gradientPanel1.BottomColor = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.lblTyp);
            this.gradientPanel1.Controls.Add(this.btnBefintlig);
            this.gradientPanel1.Controls.Add(this.btnNyKund);
            this.gradientPanel1.Controls.Add(this.btnTillbaka);
            this.gradientPanel1.Controls.Add(this.lblAnstNr);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1279, 808);
            this.gradientPanel1.TabIndex = 28;
            this.gradientPanel1.TopColor = System.Drawing.SystemColors.HotTrack;
            // 
            // BokningsTyp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 808);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BokningsTyp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BokningsTyp";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBefintlig;
        private System.Windows.Forms.Button btnNyKund;
        private System.Windows.Forms.Label lblTyp;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Label lblAnstNr;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private GradientPanel gradientPanel1;
    }
}