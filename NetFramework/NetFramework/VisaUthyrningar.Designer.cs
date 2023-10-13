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
            this.gridLektioner = new System.Windows.Forms.DataGridView();
            this.lblUthyrning = new System.Windows.Forms.Label();
            this.lblPersNr = new System.Windows.Forms.Label();
            this.txtPersNr = new System.Windows.Forms.TextBox();
            this.btnSök = new System.Windows.Forms.Button();
            this.btnVäljUthyrning = new System.Windows.Forms.Button();
            this.lblRader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridUthyrning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUthyrningsRader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLektioner)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUthyrning
            // 
            this.gridUthyrning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUthyrning.Location = new System.Drawing.Point(4, 109);
            this.gridUthyrning.Name = "gridUthyrning";
            this.gridUthyrning.RowHeadersWidth = 82;
            this.gridUthyrning.RowTemplate.Height = 33;
            this.gridUthyrning.Size = new System.Drawing.Size(549, 338);
            this.gridUthyrning.TabIndex = 0;
            // 
            // gridUthyrningsRader
            // 
            this.gridUthyrningsRader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUthyrningsRader.Location = new System.Drawing.Point(839, 109);
            this.gridUthyrningsRader.Name = "gridUthyrningsRader";
            this.gridUthyrningsRader.RowHeadersWidth = 82;
            this.gridUthyrningsRader.RowTemplate.Height = 33;
            this.gridUthyrningsRader.Size = new System.Drawing.Size(772, 466);
            this.gridUthyrningsRader.TabIndex = 1;
            // 
            // gridLektioner
            // 
            this.gridLektioner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLektioner.Location = new System.Drawing.Point(839, 732);
            this.gridLektioner.Name = "gridLektioner";
            this.gridLektioner.RowHeadersWidth = 82;
            this.gridLektioner.RowTemplate.Height = 33;
            this.gridLektioner.Size = new System.Drawing.Size(772, 402);
            this.gridLektioner.TabIndex = 2;
            // 
            // lblUthyrning
            // 
            this.lblUthyrning.AutoSize = true;
            this.lblUthyrning.BackColor = System.Drawing.Color.Transparent;
            this.lblUthyrning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUthyrning.Location = new System.Drawing.Point(12, 60);
            this.lblUthyrning.Name = "lblUthyrning";
            this.lblUthyrning.Size = new System.Drawing.Size(262, 46);
            this.lblUthyrning.TabIndex = 3;
            this.lblUthyrning.Text = "Välj uthyrning";
            // 
            // lblPersNr
            // 
            this.lblPersNr.AutoSize = true;
            this.lblPersNr.BackColor = System.Drawing.Color.Transparent;
            this.lblPersNr.Location = new System.Drawing.Point(263, 81);
            this.lblPersNr.Name = "lblPersNr";
            this.lblPersNr.Size = new System.Drawing.Size(84, 25);
            this.lblPersNr.TabIndex = 4;
            this.lblPersNr.Text = "PersNr:";
            // 
            // txtPersNr
            // 
            this.txtPersNr.Location = new System.Drawing.Point(343, 75);
            this.txtPersNr.Name = "txtPersNr";
            this.txtPersNr.Size = new System.Drawing.Size(146, 31);
            this.txtPersNr.TabIndex = 5;
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(495, 68);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(58, 35);
            this.btnSök.TabIndex = 6;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            this.btnSök.Click += new System.EventHandler(this.btnSök_Click);
            // 
            // btnVäljUthyrning
            // 
            this.btnVäljUthyrning.Location = new System.Drawing.Point(400, 453);
            this.btnVäljUthyrning.Name = "btnVäljUthyrning";
            this.btnVäljUthyrning.Size = new System.Drawing.Size(153, 33);
            this.btnVäljUthyrning.TabIndex = 7;
            this.btnVäljUthyrning.Text = "Välj uthyrning";
            this.btnVäljUthyrning.UseVisualStyleBackColor = true;
            this.btnVäljUthyrning.Click += new System.EventHandler(this.btnVäljUthyrning_Click);
            // 
            // lblRader
            // 
            this.lblRader.AutoSize = true;
            this.lblRader.BackColor = System.Drawing.Color.Transparent;
            this.lblRader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRader.Location = new System.Drawing.Point(1079, 60);
            this.lblRader.Name = "lblRader";
            this.lblRader.Size = new System.Drawing.Size(302, 46);
            this.lblRader.TabIndex = 8;
            this.lblRader.Text = "Uthyrningsrader";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1117, 683);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "Skidlektioner";
            // 
            // VisaUthyrningar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1666, 1148);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRader);
            this.Controls.Add(this.btnVäljUthyrning);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.txtPersNr);
            this.Controls.Add(this.lblPersNr);
            this.Controls.Add(this.lblUthyrning);
            this.Controls.Add(this.gridLektioner);
            this.Controls.Add(this.gridUthyrningsRader);
            this.Controls.Add(this.gridUthyrning);
            this.Name = "VisaUthyrningar";
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
        private System.Windows.Forms.DataGridView gridLektioner;
        private System.Windows.Forms.Label lblUthyrning;
        private System.Windows.Forms.Label lblPersNr;
        private System.Windows.Forms.TextBox txtPersNr;
        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.Button btnVäljUthyrning;
        private System.Windows.Forms.Label lblRader;
        private System.Windows.Forms.Label label2;
    }
}