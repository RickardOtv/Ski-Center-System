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
            this.SuspendLayout();
            // 
            // btnBefintlig
            // 
            this.btnBefintlig.Location = new System.Drawing.Point(314, 173);
            this.btnBefintlig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBefintlig.Name = "btnBefintlig";
            this.btnBefintlig.Size = new System.Drawing.Size(182, 65);
            this.btnBefintlig.TabIndex = 0;
            this.btnBefintlig.Text = "Befintlig kund";
            this.btnBefintlig.UseVisualStyleBackColor = true;
            this.btnBefintlig.Click += new System.EventHandler(this.btnBefintlig_Click);
            // 
            // btnNyKund
            // 
            this.btnNyKund.Location = new System.Drawing.Point(314, 260);
            this.btnNyKund.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNyKund.Name = "btnNyKund";
            this.btnNyKund.Size = new System.Drawing.Size(182, 62);
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
            this.lblTyp.Location = new System.Drawing.Point(228, 96);
            this.lblTyp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTyp.Name = "lblTyp";
            this.lblTyp.Size = new System.Drawing.Size(422, 63);
            this.lblTyp.TabIndex = 2;
            this.lblTyp.Text = "Välj typ av kund:";
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(24, 390);
            this.btnTillbaka.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(172, 56);
            this.btnTillbaka.TabIndex = 3;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // BokningsTyp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 469);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.lblTyp);
            this.Controls.Add(this.btnNyKund);
            this.Controls.Add(this.btnBefintlig);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BokningsTyp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BokningsTyp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBefintlig;
        private System.Windows.Forms.Button btnNyKund;
        private System.Windows.Forms.Label lblTyp;
        private System.Windows.Forms.Button btnTillbaka;
    }
}