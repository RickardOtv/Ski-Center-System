namespace NetFramework
{
    partial class VisaBokningar
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
            this.btnSök = new System.Windows.Forms.Button();
            this.label_BokningsNr = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.gridBokningar = new System.Windows.Forms.DataGridView();
            this.btn_tillbaka = new System.Windows.Forms.Button();
            this.btn_ändra = new System.Windows.Forms.Button();
            this.btn_taBort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridBokningar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(271, 64);
            this.btnSök.Margin = new System.Windows.Forms.Padding(2);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(57, 20);
            this.btnSök.TabIndex = 10;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            this.btnSök.Click += new System.EventHandler(this.btnSök_Click);
            // 
            // label_BokningsNr
            // 
            this.label_BokningsNr.AutoSize = true;
            this.label_BokningsNr.BackColor = System.Drawing.Color.Transparent;
            this.label_BokningsNr.Location = new System.Drawing.Point(72, 49);
            this.label_BokningsNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_BokningsNr.Name = "label_BokningsNr";
            this.label_BokningsNr.Size = new System.Drawing.Size(65, 13);
            this.label_BokningsNr.TabIndex = 9;
            this.label_BokningsNr.Text = "BokningsNr:";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(75, 65);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(192, 20);
            this.txtFilter.TabIndex = 8;
            // 
            // gridBokningar
            // 
            this.gridBokningar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBokningar.Location = new System.Drawing.Point(75, 93);
            this.gridBokningar.Margin = new System.Windows.Forms.Padding(2);
            this.gridBokningar.MultiSelect = false;
            this.gridBokningar.Name = "gridBokningar";
            this.gridBokningar.ReadOnly = true;
            this.gridBokningar.RowHeadersWidth = 72;
            this.gridBokningar.RowTemplate.Height = 31;
            this.gridBokningar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBokningar.Size = new System.Drawing.Size(654, 249);
            this.gridBokningar.TabIndex = 7;
            // 
            // btn_tillbaka
            // 
            this.btn_tillbaka.Location = new System.Drawing.Point(12, 406);
            this.btn_tillbaka.Name = "btn_tillbaka";
            this.btn_tillbaka.Size = new System.Drawing.Size(85, 32);
            this.btn_tillbaka.TabIndex = 11;
            this.btn_tillbaka.Text = "Tillbaka";
            this.btn_tillbaka.UseVisualStyleBackColor = true;
            this.btn_tillbaka.Click += new System.EventHandler(this.btn_tillbaka_Click);
            // 
            // btn_ändra
            // 
            this.btn_ändra.Location = new System.Drawing.Point(551, 348);
            this.btn_ändra.Name = "btn_ändra";
            this.btn_ändra.Size = new System.Drawing.Size(86, 38);
            this.btn_ändra.TabIndex = 12;
            this.btn_ändra.Text = "Ändra";
            this.btn_ändra.UseVisualStyleBackColor = true;
            this.btn_ändra.Click += new System.EventHandler(this.btn_ändra_Click);
            // 
            // btn_taBort
            // 
            this.btn_taBort.Location = new System.Drawing.Point(643, 347);
            this.btn_taBort.Name = "btn_taBort";
            this.btn_taBort.Size = new System.Drawing.Size(86, 39);
            this.btn_taBort.TabIndex = 13;
            this.btn_taBort.Text = "Ta Bort";
            this.btn_taBort.UseVisualStyleBackColor = true;
            this.btn_taBort.Click += new System.EventHandler(this.btn_taBort_Click);
            // 
            // VisaBokningar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.btn_taBort);
            this.Controls.Add(this.btn_ändra);
            this.Controls.Add(this.btn_tillbaka);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.label_BokningsNr);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.gridBokningar);
            this.Name = "VisaBokningar";
            this.Text = "visaBokningar";
            this.Load += new System.EventHandler(this.VisaBokningar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBokningar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.Label label_BokningsNr;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridView gridBokningar;
        private System.Windows.Forms.Button btn_tillbaka;
        private System.Windows.Forms.Button btn_ändra;
        private System.Windows.Forms.Button btn_taBort;
    }
}