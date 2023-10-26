namespace NetFramework.Marknadsfönster
{
    partial class ÄndraMaxbelopp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_GammalMaxbelopp = new System.Windows.Forms.TextBox();
            this.lblKund = new System.Windows.Forms.Label();
            this.textBox_nyttMaxbelopp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new NetFramework.GradientPanel();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(12, 768);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(110, 28);
            this.btnTillbaka.TabIndex = 17;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Anställningsnummer:";
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(123, 8);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(14, 20);
            this.txtAnvandarnamn.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Spara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // textBox_GammalMaxbelopp
            // 
            this.textBox_GammalMaxbelopp.Location = new System.Drawing.Point(506, 370);
            this.textBox_GammalMaxbelopp.Name = "textBox_GammalMaxbelopp";
            this.textBox_GammalMaxbelopp.Size = new System.Drawing.Size(184, 20);
            this.textBox_GammalMaxbelopp.TabIndex = 21;
            // 
            // lblKund
            // 
            this.lblKund.AutoSize = true;
            this.lblKund.BackColor = System.Drawing.Color.Transparent;
            this.lblKund.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKund.Location = new System.Drawing.Point(440, 298);
            this.lblKund.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblKund.Name = "lblKund";
            this.lblKund.Size = new System.Drawing.Size(340, 31);
            this.lblKund.TabIndex = 22;
            this.lblKund.Text = "Maxbelopp För Privat Kund";
            // 
            // textBox_nyttMaxbelopp
            // 
            this.textBox_nyttMaxbelopp.Location = new System.Drawing.Point(506, 416);
            this.textBox_nyttMaxbelopp.Name = "textBox_nyttMaxbelopp";
            this.textBox_nyttMaxbelopp.Size = new System.Drawing.Size(184, 20);
            this.textBox_nyttMaxbelopp.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(503, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nuvarande Maxbelopp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(503, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nytt Maxbelopp";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.gradientPanel1.BottomColor = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.lblKund);
            this.gradientPanel1.Controls.Add(this.button1);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.btnTillbaka);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1279, 808);
            this.gradientPanel1.TabIndex = 26;
            this.gradientPanel1.TopColor = System.Drawing.SystemColors.HotTrack;
            // 
            // ÄndraMaxbelopp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1279, 808);
            this.Controls.Add(this.textBox_nyttMaxbelopp);
            this.Controls.Add(this.textBox_GammalMaxbelopp);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ÄndraMaxbelopp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÄndraMaxbelopp";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_GammalMaxbelopp;
        private System.Windows.Forms.Label lblKund;
        private System.Windows.Forms.TextBox textBox_nyttMaxbelopp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private GradientPanel gradientPanel1;
    }
}