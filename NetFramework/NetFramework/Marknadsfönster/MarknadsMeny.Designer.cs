namespace NetFramework
{
    partial class MarknadsMeny
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegFöretagsKund = new System.Windows.Forms.Button();
            this.btnÄndraMaxbelopp = new System.Windows.Forms.Button();
            this.btn_visaFaktura = new System.Windows.Forms.Button();
            this.gradientPanel1 = new NetFramework.GradientPanel();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(16, 945);
            this.btnTillbaka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(147, 34);
            this.btnTillbaka.TabIndex = 17;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Anställningsnummer:";
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.BackColor = System.Drawing.SystemColors.Control;
            this.txtAnvandarnamn.Location = new System.Drawing.Point(164, 10);
            this.txtAnvandarnamn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(17, 22);
            this.txtAnvandarnamn.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(689, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 48);
            this.label3.TabIndex = 20;
            this.label3.Text = "Marknadsmeny";
            // 
            // btnRegFöretagsKund
            // 
            this.btnRegFöretagsKund.Location = new System.Drawing.Point(635, 404);
            this.btnRegFöretagsKund.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegFöretagsKund.Name = "btnRegFöretagsKund";
            this.btnRegFöretagsKund.Size = new System.Drawing.Size(440, 71);
            this.btnRegFöretagsKund.TabIndex = 22;
            this.btnRegFöretagsKund.Text = "Registrera företagskund ";
            this.btnRegFöretagsKund.UseVisualStyleBackColor = true;
            this.btnRegFöretagsKund.Click += new System.EventHandler(this.btnRegFöretagsKund_Click);
            // 
            // btnÄndraMaxbelopp
            // 
            this.btnÄndraMaxbelopp.Location = new System.Drawing.Point(635, 507);
            this.btnÄndraMaxbelopp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnÄndraMaxbelopp.Name = "btnÄndraMaxbelopp";
            this.btnÄndraMaxbelopp.Size = new System.Drawing.Size(440, 66);
            this.btnÄndraMaxbelopp.TabIndex = 23;
            this.btnÄndraMaxbelopp.Text = "Maxbelopp";
            this.btnÄndraMaxbelopp.UseVisualStyleBackColor = true;
            this.btnÄndraMaxbelopp.Click += new System.EventHandler(this.btnÄndraMaxbelopp_Click);
            // 
            // btn_visaFaktura
            // 
            this.btn_visaFaktura.Location = new System.Drawing.Point(635, 601);
            this.btn_visaFaktura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_visaFaktura.Name = "btn_visaFaktura";
            this.btn_visaFaktura.Size = new System.Drawing.Size(440, 66);
            this.btn_visaFaktura.TabIndex = 24;
            this.btn_visaFaktura.Text = "Visa Fakturor";
            this.btn_visaFaktura.UseVisualStyleBackColor = true;
            this.btn_visaFaktura.Click += new System.EventHandler(this.btn_visaFaktura_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.gradientPanel1.BottomColor = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.btnRegFöretagsKund);
            this.gradientPanel1.Controls.Add(this.btnTillbaka);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1705, 994);
            this.gradientPanel1.TabIndex = 25;
            this.gradientPanel1.TopColor = System.Drawing.SystemColors.HotTrack;
            // 
            // MarknadsMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1705, 994);
            this.Controls.Add(this.btn_visaFaktura);
            this.Controls.Add(this.btnÄndraMaxbelopp);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MarknadsMeny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarknadsMeny";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegFöretagsKund;
        private System.Windows.Forms.Button btnÄndraMaxbelopp;
        private System.Windows.Forms.Button btn_visaFaktura;
        private GradientPanel gradientPanel1;
    }
}