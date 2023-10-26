namespace NetFramework
{
    partial class AdminMeny
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
            this.lblAnstNr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHanteraAnställd = new System.Windows.Forms.Button();
            this.btnSkapaAnställd = new System.Windows.Forms.Button();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.gradientPanel1 = new NetFramework.GradientPanel();
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
            this.txtAnvandarnamn.TabIndex = 9;
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(13, 11);
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
            this.label1.Location = new System.Drawing.Point(539, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adminmeny";
            // 
            // btnHanteraAnställd
            // 
            this.btnHanteraAnställd.Location = new System.Drawing.Point(476, 372);
            this.btnHanteraAnställd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHanteraAnställd.Name = "btnHanteraAnställd";
            this.btnHanteraAnställd.Size = new System.Drawing.Size(330, 52);
            this.btnHanteraAnställd.TabIndex = 11;
            this.btnHanteraAnställd.Text = "Hantera anställda";
            this.btnHanteraAnställd.UseVisualStyleBackColor = true;
            this.btnHanteraAnställd.Click += new System.EventHandler(this.btnHanteraAnställd_Click);
            // 
            // btnSkapaAnställd
            // 
            this.btnSkapaAnställd.Location = new System.Drawing.Point(476, 450);
            this.btnSkapaAnställd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSkapaAnställd.Name = "btnSkapaAnställd";
            this.btnSkapaAnställd.Size = new System.Drawing.Size(330, 52);
            this.btnSkapaAnställd.TabIndex = 12;
            this.btnSkapaAnställd.Text = "Skapa Anställd";
            this.btnSkapaAnställd.UseVisualStyleBackColor = true;
            this.btnSkapaAnställd.Click += new System.EventHandler(this.btnSkapaAnställd_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(14, 768);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(110, 28);
            this.btnTillbaka.TabIndex = 15;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.gradientPanel1.BottomColor = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.lblAnstNr);
            this.gradientPanel1.Controls.Add(this.btnSkapaAnställd);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.btnHanteraAnställd);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1279, 808);
            this.gradientPanel1.TabIndex = 16;
            this.gradientPanel1.TopColor = System.Drawing.SystemColors.HotTrack;
            // 
            // AdminMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 808);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMeny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMeny";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Label lblAnstNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHanteraAnställd;
        private System.Windows.Forms.Button btnSkapaAnställd;
        private System.Windows.Forms.Button btnTillbaka;
        private GradientPanel gradientPanel1;
    }
}