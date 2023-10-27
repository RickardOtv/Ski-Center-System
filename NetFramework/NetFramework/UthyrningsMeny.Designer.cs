namespace NetFramework
{
    partial class UthyrningsMeny
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
            this.gradientPanel1 = new NetFramework.GradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnÅterlämning = new System.Windows.Forms.Button();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.btnVisaUthyrningar = new System.Windows.Forms.Button();
            this.btnSkapaUthyrning = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.gradientPanel1.BottomColor = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.btnÅterlämning);
            this.gradientPanel1.Controls.Add(this.btnTillbaka);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1705, 994);
            this.gradientPanel1.TabIndex = 19;
            this.gradientPanel1.TopColor = System.Drawing.SystemColors.HotTrack;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(740, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 48);
            this.label3.TabIndex = 17;
            this.label3.Text = "Uthyrning";
            // 
            // btnÅterlämning
            // 
            this.btnÅterlämning.Location = new System.Drawing.Point(635, 508);
            this.btnÅterlämning.Margin = new System.Windows.Forms.Padding(4);
            this.btnÅterlämning.Name = "btnÅterlämning";
            this.btnÅterlämning.Size = new System.Drawing.Size(440, 64);
            this.btnÅterlämning.TabIndex = 14;
            this.btnÅterlämning.Text = "Återlämning";
            this.btnÅterlämning.UseVisualStyleBackColor = true;
            this.btnÅterlämning.Click += new System.EventHandler(this.btnÅterlämning_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(19, 945);
            this.btnTillbaka.Margin = new System.Windows.Forms.Padding(4);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(147, 34);
            this.btnTillbaka.TabIndex = 16;
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
            this.label1.TabIndex = 0;
            this.label1.Text = "Anställningsnummer:";
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(164, 10);
            this.txtAnvandarnamn.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.ReadOnly = true;
            this.txtAnvandarnamn.Size = new System.Drawing.Size(17, 22);
            this.txtAnvandarnamn.TabIndex = 18;
            // 
            // btnVisaUthyrningar
            // 
            this.btnVisaUthyrningar.Location = new System.Drawing.Point(635, 332);
            this.btnVisaUthyrningar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisaUthyrningar.Name = "btnVisaUthyrningar";
            this.btnVisaUthyrningar.Size = new System.Drawing.Size(440, 64);
            this.btnVisaUthyrningar.TabIndex = 11;
            this.btnVisaUthyrningar.Text = "Visa Uthyrningar";
            this.btnVisaUthyrningar.UseVisualStyleBackColor = true;
            this.btnVisaUthyrningar.Click += new System.EventHandler(this.btnVisaUthyrningar_Click);
            // 
            // btnSkapaUthyrning
            // 
            this.btnSkapaUthyrning.Location = new System.Drawing.Point(635, 420);
            this.btnSkapaUthyrning.Margin = new System.Windows.Forms.Padding(4);
            this.btnSkapaUthyrning.Name = "btnSkapaUthyrning";
            this.btnSkapaUthyrning.Size = new System.Drawing.Size(440, 71);
            this.btnSkapaUthyrning.TabIndex = 12;
            this.btnSkapaUthyrning.Text = "Skapa Uthyrning";
            this.btnSkapaUthyrning.UseVisualStyleBackColor = true;
            this.btnSkapaUthyrning.Click += new System.EventHandler(this.btnSkapaUthyrning_Click);
            // 
            // UthyrningsMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1705, 994);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.btnSkapaUthyrning);
            this.Controls.Add(this.btnVisaUthyrningar);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UthyrningsMeny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UthyrningsMeny";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Button btnVisaUthyrningar;
        private System.Windows.Forms.Button btnSkapaUthyrning;
        private System.Windows.Forms.Button btnÅterlämning;
    }
}