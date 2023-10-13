namespace NetFramework
{
    partial class VisaUthyrningar
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
            this.gridUthyrning = new System.Windows.Forms.DataGridView();
            this.gridUthyrningsRader = new System.Windows.Forms.DataGridView();
            this.lblKund = new System.Windows.Forms.Label();
            this.lblRader = new System.Windows.Forms.Label();
            this.btnVäljUthyrning = new System.Windows.Forms.Button();
            this.btnTillbaka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridUthyrning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUthyrningsRader)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUthyrning
            // 
            this.gridUthyrning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUthyrning.Location = new System.Drawing.Point(8, 78);
            this.gridUthyrning.Name = "gridUthyrning";
            this.gridUthyrning.ReadOnly = true;
            this.gridUthyrning.RowHeadersVisible = false;
            this.gridUthyrning.RowHeadersWidth = 82;
            this.gridUthyrning.RowTemplate.Height = 33;
            this.gridUthyrning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUthyrning.Size = new System.Drawing.Size(540, 312);
            this.gridUthyrning.TabIndex = 0;
            // 
            // gridUthyrningsRader
            // 
            this.gridUthyrningsRader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUthyrningsRader.Location = new System.Drawing.Point(636, 78);
            this.gridUthyrningsRader.Name = "gridUthyrningsRader";
            this.gridUthyrningsRader.ReadOnly = true;
            this.gridUthyrningsRader.RowHeadersVisible = false;
            this.gridUthyrningsRader.RowHeadersWidth = 82;
            this.gridUthyrningsRader.RowTemplate.Height = 33;
            this.gridUthyrningsRader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUthyrningsRader.Size = new System.Drawing.Size(914, 468);
            this.gridUthyrningsRader.TabIndex = 1;
            // 
            // lblKund
            // 
            this.lblKund.AutoSize = true;
            this.lblKund.BackColor = System.Drawing.Color.Transparent;
            this.lblKund.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKund.Location = new System.Drawing.Point(139, 29);
            this.lblKund.Name = "lblKund";
            this.lblKund.Size = new System.Drawing.Size(273, 46);
            this.lblKund.TabIndex = 2;
            this.lblKund.Text = "Välj uthyrning:";
            // 
            // lblRader
            // 
            this.lblRader.AutoSize = true;
            this.lblRader.BackColor = System.Drawing.Color.Transparent;
            this.lblRader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRader.Location = new System.Drawing.Point(845, 29);
            this.lblRader.Name = "lblRader";
            this.lblRader.Size = new System.Drawing.Size(551, 46);
            this.lblRader.TabIndex = 3;
            this.lblRader.Text = "Uthyrningens uthyrningsrader:";
            // 
            // btnVäljUthyrning
            // 
            this.btnVäljUthyrning.Location = new System.Drawing.Point(395, 407);
            this.btnVäljUthyrning.Name = "btnVäljUthyrning";
            this.btnVäljUthyrning.Size = new System.Drawing.Size(153, 44);
            this.btnVäljUthyrning.TabIndex = 4;
            this.btnVäljUthyrning.Text = "Välj uthyrning";
            this.btnVäljUthyrning.UseVisualStyleBackColor = true;
            this.btnVäljUthyrning.Click += new System.EventHandler(this.btnVäljUthyrning_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(8, 765);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(109, 37);
            this.btnTillbaka.TabIndex = 5;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // VisaUthyrningar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1588, 804);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.btnVäljUthyrning);
            this.Controls.Add(this.lblRader);
            this.Controls.Add(this.lblKund);
            this.Controls.Add(this.gridUthyrningsRader);
            this.Controls.Add(this.gridUthyrning);
            this.Name = "VisaUthyrningar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisaUthyrningar";
            this.Load += new System.EventHandler(this.VisaUthyrningar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUthyrning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUthyrningsRader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUthyrning;
        private System.Windows.Forms.DataGridView gridUthyrningsRader;
        private System.Windows.Forms.Label lblKund;
        private System.Windows.Forms.Label lblRader;
        private System.Windows.Forms.Button btnVäljUthyrning;
        private System.Windows.Forms.Button btnTillbaka;
    }
}