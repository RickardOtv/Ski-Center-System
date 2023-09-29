namespace NetFramework
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
            this.btnVisaBokning = new System.Windows.Forms.Button();
            this.btnLediga = new System.Windows.Forms.Button();
            this.btnBokning = new System.Windows.Forms.Button();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.lblAnstNr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVisaBokning
            // 
            this.btnVisaBokning.Location = new System.Drawing.Point(241, 87);
            this.btnVisaBokning.Name = "btnVisaBokning";
            this.btnVisaBokning.Size = new System.Drawing.Size(314, 44);
            this.btnVisaBokning.TabIndex = 0;
            this.btnVisaBokning.Text = "Visa bokningar";
            this.btnVisaBokning.UseVisualStyleBackColor = true;
            this.btnVisaBokning.Click += new System.EventHandler(this.btnVisaBokning_Click);
            // 
            // btnLediga
            // 
            this.btnLediga.Location = new System.Drawing.Point(241, 184);
            this.btnLediga.Name = "btnLediga";
            this.btnLediga.Size = new System.Drawing.Size(314, 44);
            this.btnLediga.TabIndex = 1;
            this.btnLediga.Text = "Visa lediga logialternativ";
            this.btnLediga.UseVisualStyleBackColor = true;
            this.btnLediga.Click += new System.EventHandler(this.btnLediga_Click);
            // 
            // btnBokning
            // 
            this.btnBokning.Location = new System.Drawing.Point(241, 292);
            this.btnBokning.Name = "btnBokning";
            this.btnBokning.Size = new System.Drawing.Size(314, 44);
            this.btnBokning.TabIndex = 3;
            this.btnBokning.Text = "Bokning av logi";
            this.btnBokning.UseVisualStyleBackColor = true;
            this.btnBokning.Click += new System.EventHandler(this.btnBokning_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(45, 381);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(149, 38);
            this.btnTillbaka.TabIndex = 2;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(112, 6);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(14, 20);
            this.txtAnvandarnamn.TabIndex = 9;
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.Location = new System.Drawing.Point(12, 9);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(103, 13);
            this.lblAnstNr.TabIndex = 8;
            this.lblAnstNr.Text = "Anställningsnummer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bokning";
            // 
            // BokningsMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.lblAnstNr);
            this.Controls.Add(this.btnBokning);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.btnLediga);
            this.Controls.Add(this.btnVisaBokning);
            this.Name = "BokningsMeny";
            this.Text = "BokningsMeny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisaBokning;
        private System.Windows.Forms.Button btnLediga;
        private System.Windows.Forms.Button btnBokning;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Label lblAnstNr;
        private System.Windows.Forms.Label label1;
    }
}