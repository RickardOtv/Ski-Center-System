namespace NetFramework
{
    partial class BokningBefintligKund
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
            this.gridKunder = new System.Windows.Forms.DataGridView();
            this.gridLogi = new System.Windows.Forms.DataGridView();
            this.lblKund = new System.Windows.Forms.Label();
            this.lblLogi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSök = new System.Windows.Forms.Button();
            this.lblFrån = new System.Windows.Forms.Label();
            this.lblTill = new System.Windows.Forms.Label();
            this.dateFrån = new System.Windows.Forms.DateTimePicker();
            this.dateTill = new System.Windows.Forms.DateTimePicker();
            this.btnSkapaBokning = new System.Windows.Forms.Button();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.btnKollaPris = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridKunder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLogi)).BeginInit();
            this.SuspendLayout();
            // 
            // gridKunder
            // 
            this.gridKunder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKunder.Location = new System.Drawing.Point(188, 651);
            this.gridKunder.MultiSelect = false;
            this.gridKunder.Name = "gridKunder";
            this.gridKunder.ReadOnly = true;
            this.gridKunder.RowHeadersWidth = 72;
            this.gridKunder.RowTemplate.Height = 31;
            this.gridKunder.Size = new System.Drawing.Size(986, 339);
            this.gridKunder.TabIndex = 0;
            // 
            // gridLogi
            // 
            this.gridLogi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLogi.Location = new System.Drawing.Point(588, 207);
            this.gridLogi.Name = "gridLogi";
            this.gridLogi.ReadOnly = true;
            this.gridLogi.RowHeadersWidth = 72;
            this.gridLogi.RowTemplate.Height = 31;
            this.gridLogi.Size = new System.Drawing.Size(586, 249);
            this.gridLogi.TabIndex = 1;
            // 
            // lblKund
            // 
            this.lblKund.AutoSize = true;
            this.lblKund.BackColor = System.Drawing.Color.Transparent;
            this.lblKund.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKund.Location = new System.Drawing.Point(536, 510);
            this.lblKund.Name = "lblKund";
            this.lblKund.Size = new System.Drawing.Size(250, 63);
            this.lblKund.TabIndex = 2;
            this.lblKund.Text = "Välj kund";
            // 
            // lblLogi
            // 
            this.lblLogi.AutoSize = true;
            this.lblLogi.BackColor = System.Drawing.Color.Transparent;
            this.lblLogi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogi.Location = new System.Drawing.Point(446, 69);
            this.lblLogi.Name = "lblLogi";
            this.lblLogi.Size = new System.Drawing.Size(410, 63);
            this.lblLogi.TabIndex = 3;
            this.lblLogi.Text = "Välj logialterativ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Personnummer:";
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(487, 593);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(78, 38);
            this.btnSök.TabIndex = 6;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            this.btnSök.Click += new System.EventHandler(this.btnSök_Click);
            // 
            // lblFrån
            // 
            this.lblFrån.AutoSize = true;
            this.lblFrån.BackColor = System.Drawing.Color.Transparent;
            this.lblFrån.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrån.Location = new System.Drawing.Point(185, 192);
            this.lblFrån.Name = "lblFrån";
            this.lblFrån.Size = new System.Drawing.Size(67, 25);
            this.lblFrån.TabIndex = 7;
            this.lblFrån.Text = "Från:";
            // 
            // lblTill
            // 
            this.lblTill.AutoSize = true;
            this.lblTill.BackColor = System.Drawing.Color.Transparent;
            this.lblTill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTill.Location = new System.Drawing.Point(185, 285);
            this.lblTill.Name = "lblTill";
            this.lblTill.Size = new System.Drawing.Size(51, 25);
            this.lblTill.TabIndex = 10;
            this.lblTill.Text = "Till:";
            // 
            // dateFrån
            // 
            this.dateFrån.Location = new System.Drawing.Point(190, 220);
            this.dateFrån.Name = "dateFrån";
            this.dateFrån.Size = new System.Drawing.Size(265, 31);
            this.dateFrån.TabIndex = 11;
            // 
            // dateTill
            // 
            this.dateTill.Location = new System.Drawing.Point(188, 313);
            this.dateTill.Name = "dateTill";
            this.dateTill.Size = new System.Drawing.Size(266, 31);
            this.dateTill.TabIndex = 12;
            // 
            // btnSkapaBokning
            // 
            this.btnSkapaBokning.Location = new System.Drawing.Point(1103, 1009);
            this.btnSkapaBokning.Name = "btnSkapaBokning";
            this.btnSkapaBokning.Size = new System.Drawing.Size(213, 49);
            this.btnSkapaBokning.TabIndex = 13;
            this.btnSkapaBokning.Text = "Skapa Bokning";
            this.btnSkapaBokning.UseVisualStyleBackColor = true;
            this.btnSkapaBokning.Click += new System.EventHandler(this.btnSkapaBokning_Click);
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(27, 1017);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(100, 41);
            this.btnAvbryt.TabIndex = 14;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // btnKollaPris
            // 
            this.btnKollaPris.Location = new System.Drawing.Point(188, 392);
            this.btnKollaPris.Name = "btnKollaPris";
            this.btnKollaPris.Size = new System.Drawing.Size(267, 49);
            this.btnKollaPris.TabIndex = 15;
            this.btnKollaPris.Text = "Kolla Pris";
            this.btnKollaPris.UseVisualStyleBackColor = true;
            this.btnKollaPris.Click += new System.EventHandler(this.btnKollaPris_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(190, 597);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(264, 31);
            this.txtFilter.TabIndex = 4;
            // 
            // BokningBefintligKund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1369, 1083);
            this.Controls.Add(this.btnKollaPris);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.btnSkapaBokning);
            this.Controls.Add(this.dateTill);
            this.Controls.Add(this.dateFrån);
            this.Controls.Add(this.lblTill);
            this.Controls.Add(this.lblFrån);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblLogi);
            this.Controls.Add(this.lblKund);
            this.Controls.Add(this.gridLogi);
            this.Controls.Add(this.gridKunder);
            this.Name = "BokningBefintligKund";
            this.Text = "Befintlig Kund";
            this.Load += new System.EventHandler(this.BokningBefintligKund_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKunder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLogi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridKunder;
        private System.Windows.Forms.DataGridView gridLogi;
        private System.Windows.Forms.Label lblKund;
        private System.Windows.Forms.Label lblLogi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.Label lblFrån;
        private System.Windows.Forms.Label lblTill;
        private System.Windows.Forms.DateTimePicker dateFrån;
        private System.Windows.Forms.DateTimePicker dateTill;
        private System.Windows.Forms.Button btnSkapaBokning;
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Button btnKollaPris;
        private System.Windows.Forms.TextBox txtFilter;
    }
}