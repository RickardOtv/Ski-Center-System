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
            this.SuspendLayout();
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(115, 8);
            this.txtAnvandarnamn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(14, 20);
            this.txtAnvandarnamn.TabIndex = 9;
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(13, 9);
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
            this.label1.Location = new System.Drawing.Point(284, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adminmeny";
            // 
            // btnHanteraAnställd
            // 
            this.btnHanteraAnställd.Location = new System.Drawing.Point(204, 142);
            this.btnHanteraAnställd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHanteraAnställd.Name = "btnHanteraAnställd";
            this.btnHanteraAnställd.Size = new System.Drawing.Size(364, 34);
            this.btnHanteraAnställd.TabIndex = 11;
            this.btnHanteraAnställd.Text = "Hantera anställda";
            this.btnHanteraAnställd.UseVisualStyleBackColor = true;
            this.btnHanteraAnställd.Click += new System.EventHandler(this.btnHanteraAnställd_Click);
            // 
            // btnSkapaAnställd
            // 
            this.btnSkapaAnställd.Location = new System.Drawing.Point(204, 214);
            this.btnSkapaAnställd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSkapaAnställd.Name = "btnSkapaAnställd";
            this.btnSkapaAnställd.Size = new System.Drawing.Size(364, 34);
            this.btnSkapaAnställd.TabIndex = 12;
            this.btnSkapaAnställd.Text = "Skapa Anställd";
            this.btnSkapaAnställd.UseVisualStyleBackColor = true;
            this.btnSkapaAnställd.Click += new System.EventHandler(this.btnSkapaAnställd_Click);
            // 
            // AdminMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSkapaAnställd);
            this.Controls.Add(this.btnHanteraAnställd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.lblAnstNr);
            this.Name = "AdminMeny";
            this.Text = "AdminMeny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Label lblAnstNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHanteraAnställd;
        private System.Windows.Forms.Button btnSkapaAnställd;
    }
}