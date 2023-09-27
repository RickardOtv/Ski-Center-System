namespace NetFramework
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
            this.btnAvbryt.Location = new System.Drawing.Point(342, 244);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(81, 29);
            this.btnAvbryt.TabIndex = 13;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // btnLoggaIn
            // 
            this.btnLoggaIn.Location = new System.Drawing.Point(153, 244);
            this.btnLoggaIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoggaIn.Name = "btnLoggaIn";
            this.btnLoggaIn.Size = new System.Drawing.Size(84, 29);
            this.btnLoggaIn.TabIndex = 12;
            this.btnLoggaIn.Text = "Logga In";
            this.btnLoggaIn.UseVisualStyleBackColor = true;
            this.btnLoggaIn.Click += new System.EventHandler(this.btnLoggaIn_Click);
            // 
            // txtLösen
            // 
            this.txtLösen.Location = new System.Drawing.Point(301, 133);
            this.txtLösen.Margin = new System.Windows.Forms.Padding(2);
            this.txtLösen.Name = "txtLösen";
            this.txtLösen.Size = new System.Drawing.Size(145, 26);
            this.txtLösen.TabIndex = 11;
            // 
            // txtAnstNr
            // 
            this.txtAnstNr.Location = new System.Drawing.Point(301, 102);
            this.txtAnstNr.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnstNr.Name = "txtAnstNr";
            this.txtAnstNr.Size = new System.Drawing.Size(145, 26);
            this.txtAnstNr.TabIndex = 10;
            // 
            // lblLösenord
            // 
            this.lblLösenord.AutoSize = true;
            this.lblLösenord.Location = new System.Drawing.Point(119, 133);
            this.lblLösenord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLösenord.Name = "lblLösenord";
            this.lblLösenord.Size = new System.Drawing.Size(76, 20);
            this.lblLösenord.TabIndex = 9;
            this.lblLösenord.Text = "Lösenord";
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.Location = new System.Drawing.Point(119, 102);
            this.lblAnstNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(155, 20);
            this.lblAnstNr.TabIndex = 8;
            this.lblAnstNr.Text = "AnställningsNummer";
            // 
            // lblLoggaIn
            // 
            this.lblLoggaIn.AutoSize = true;
            this.lblLoggaIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggaIn.Location = new System.Drawing.Point(232, 31);
            this.lblLoggaIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoggaIn.Name = "lblLoggaIn";
            this.lblLoggaIn.Size = new System.Drawing.Size(142, 37);
            this.lblLoggaIn.TabIndex = 7;
            this.lblLoggaIn.Text = "Logga In";
            // 
            // LoggaIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.btnLoggaIn);
            this.Controls.Add(this.txtLösen);
            this.Controls.Add(this.txtAnstNr);
            this.Controls.Add(this.lblLösenord);
            this.Controls.Add(this.lblAnstNr);
            this.Controls.Add(this.lblLoggaIn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoggaIn";
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

