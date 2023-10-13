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
            this.gridLektioner = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSök = new System.Windows.Forms.Button();
            this.txtPersNr = new System.Windows.Forms.TextBox();
            this.lblPersNr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridUthyrning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUthyrningsRader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLektioner)).BeginInit();
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
            this.lblKund.Location = new System.Drawing.Point(0, 27);
            this.lblKund.Name = "lblKund";
            this.lblKund.Size = new System.Drawing.Size(262, 46);
            this.lblKund.TabIndex = 2;
            this.lblKund.Text = "Välj uthyrning";
            // 
            // lblRader
            // 
            this.lblRader.AutoSize = true;
            this.lblRader.BackColor = System.Drawing.Color.Transparent;
            this.lblRader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRader.Location = new System.Drawing.Point(845, 29);
            this.lblRader.Name = "lblRader";
            this.lblRader.Size = new System.Drawing.Size(540, 46);
            this.lblRader.TabIndex = 3;
            this.lblRader.Text = "Uthyrningens uthyrningsrader";
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
            this.btnTillbaka.Location = new System.Drawing.Point(12, 1183);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(109, 37);
            this.btnTillbaka.TabIndex = 5;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // gridLektioner
            // 
            this.gridLektioner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLektioner.Location = new System.Drawing.Point(636, 678);
            this.gridLektioner.Name = "gridLektioner";
            this.gridLektioner.RowHeadersWidth = 82;
            this.gridLektioner.RowTemplate.Height = 33;
            this.gridLektioner.Size = new System.Drawing.Size(914, 555);
            this.gridLektioner.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(877, 629);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Uthyrningens lektioner";
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(471, 44);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(77, 29);
            this.btnSök.TabIndex = 8;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            this.btnSök.Click += new System.EventHandler(this.btnSök_Click);
            // 
            // txtPersNr
            // 
            this.txtPersNr.Location = new System.Drawing.Point(365, 44);
            this.txtPersNr.Name = "txtPersNr";
            this.txtPersNr.Size = new System.Drawing.Size(100, 31);
            this.txtPersNr.TabIndex = 9;
            // 
            // lblPersNr
            // 
            this.lblPersNr.AutoSize = true;
            this.lblPersNr.BackColor = System.Drawing.Color.Transparent;
            this.lblPersNr.Location = new System.Drawing.Point(278, 50);
            this.lblPersNr.Name = "lblPersNr";
            this.lblPersNr.Size = new System.Drawing.Size(81, 25);
            this.lblPersNr.TabIndex = 10;
            this.lblPersNr.Text = "Persnr:";
            // 
            // VisaUthyrningar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 1232);
            this.Controls.Add(this.lblPersNr);
            this.Controls.Add(this.txtPersNr);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridLektioner);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridLektioner)).EndInit();
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
        private System.Windows.Forms.DataGridView gridLektioner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.TextBox txtPersNr;
        private System.Windows.Forms.Label lblPersNr;
    }
}