namespace NetFramework
{
    partial class UthyrningUtrustning
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
            this.Anställningsnummerlbl = new System.Windows.Forms.Label();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.gridUtrustning = new System.Windows.Forms.DataGridView();
            this.gridRader = new System.Windows.Forms.DataGridView();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.btnKlar = new System.Windows.Forms.Button();
            this.txtBoxValdKund = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTyp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStorlek = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFrån = new System.Windows.Forms.DateTimePicker();
            this.dateTill = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gridUtrustning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRader)).BeginInit();
            this.SuspendLayout();
            // 
            // Anställningsnummerlbl
            // 
            this.Anställningsnummerlbl.AutoSize = true;
            this.Anställningsnummerlbl.BackColor = System.Drawing.Color.Transparent;
            this.Anställningsnummerlbl.Location = new System.Drawing.Point(24, 17);
            this.Anställningsnummerlbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Anställningsnummerlbl.Name = "Anställningsnummerlbl";
            this.Anställningsnummerlbl.Size = new System.Drawing.Size(206, 25);
            this.Anställningsnummerlbl.TabIndex = 7;
            this.Anställningsnummerlbl.Text = "Anställningsnummer";
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(236, 12);
            this.txtAnvandarnamn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(34, 31);
            this.txtAnvandarnamn.TabIndex = 6;
            // 
            // gridUtrustning
            // 
            this.gridUtrustning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUtrustning.Location = new System.Drawing.Point(60, 396);
            this.gridUtrustning.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gridUtrustning.Name = "gridUtrustning";
            this.gridUtrustning.ReadOnly = true;
            this.gridUtrustning.RowHeadersVisible = false;
            this.gridUtrustning.RowHeadersWidth = 62;
            this.gridUtrustning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUtrustning.Size = new System.Drawing.Size(698, 294);
            this.gridUtrustning.TabIndex = 8;
            // 
            // gridRader
            // 
            this.gridRader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRader.Location = new System.Drawing.Point(830, 396);
            this.gridRader.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gridRader.Name = "gridRader";
            this.gridRader.ReadOnly = true;
            this.gridRader.RowHeadersVisible = false;
            this.gridRader.RowHeadersWidth = 62;
            this.gridRader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRader.Size = new System.Drawing.Size(698, 294);
            this.gridRader.TabIndex = 9;
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(608, 702);
            this.btnLäggTill.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(150, 44);
            this.btnLäggTill.TabIndex = 11;
            this.btnLäggTill.Text = "Lägg till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            this.btnLäggTill.Click += new System.EventHandler(this.btnLäggTill_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(24, 798);
            this.btnTillbaka.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(150, 44);
            this.btnTillbaka.TabIndex = 12;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(1284, 702);
            this.btnTaBort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(150, 44);
            this.btnTaBort.TabIndex = 13;
            this.btnTaBort.Text = "Ta Bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            // 
            // btnKlar
            // 
            this.btnKlar.Location = new System.Drawing.Point(1426, 798);
            this.btnKlar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnKlar.Name = "btnKlar";
            this.btnKlar.Size = new System.Drawing.Size(150, 44);
            this.btnKlar.TabIndex = 14;
            this.btnKlar.Text = "Klar";
            this.btnKlar.UseVisualStyleBackColor = true;
            this.btnKlar.Click += new System.EventHandler(this.btnKlar_Click);
            // 
            // txtBoxValdKund
            // 
            this.txtBoxValdKund.Location = new System.Drawing.Point(60, 229);
            this.txtBoxValdKund.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBoxValdKund.Name = "txtBoxValdKund";
            this.txtBoxValdKund.Size = new System.Drawing.Size(236, 31);
            this.txtBoxValdKund.TabIndex = 18;
            this.txtBoxValdKund.Text = "Vald kund:";
            this.txtBoxValdKund.TextChanged += new System.EventHandler(this.txtBoxValdKund_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(830, 363);
            this.textBox6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(196, 31);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = "Vald utrustning";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 76);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lägg till utrustning";
            // 
            // cmbTyp
            // 
            this.cmbTyp.FormattingEnabled = true;
            this.cmbTyp.Items.AddRange(new object[] {
            "Alpintskida",
            "Längdskida",
            "Snowboard",
            "SkoterLynx",
            "SkoterViking",
            "Alpintpjäxa",
            "Längdpjäxa",
            "Snowboardskor"});
            this.cmbTyp.Location = new System.Drawing.Point(60, 346);
            this.cmbTyp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbTyp.Name = "cmbTyp";
            this.cmbTyp.Size = new System.Drawing.Size(294, 33);
            this.cmbTyp.TabIndex = 42;
            this.cmbTyp.Text = "Typ:";
            this.cmbTyp.SelectedIndexChanged += new System.EventHandler(this.cmbTyp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(410, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 41;
            // 
            // cmbStorlek
            // 
            this.cmbStorlek.FormattingEnabled = true;
            this.cmbStorlek.Items.AddRange(new object[] {
            "160",
            "170",
            "180",
            "190",
            "200"});
            this.cmbStorlek.Location = new System.Drawing.Point(370, 346);
            this.cmbStorlek.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbStorlek.Name = "cmbStorlek";
            this.cmbStorlek.Size = new System.Drawing.Size(294, 33);
            this.cmbStorlek.TabIndex = 44;
            this.cmbStorlek.Text = "Storlek:";
            this.cmbStorlek.SelectedIndexChanged += new System.EventHandler(this.cmbStorlek_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(746, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 43;
            // 
            // dateFrån
            // 
            this.dateFrån.Location = new System.Drawing.Point(60, 296);
            this.dateFrån.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateFrån.Name = "dateFrån";
            this.dateFrån.Size = new System.Drawing.Size(294, 31);
            this.dateFrån.TabIndex = 45;
            // 
            // dateTill
            // 
            this.dateTill.Location = new System.Drawing.Point(370, 296);
            this.dateTill.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTill.Name = "dateTill";
            this.dateTill.Size = new System.Drawing.Size(294, 31);
            this.dateTill.TabIndex = 46;
            // 
            // UthyrningUtrustning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.dateTill);
            this.Controls.Add(this.dateFrån);
            this.Controls.Add(this.cmbStorlek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTyp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtBoxValdKund);
            this.Controls.Add(this.btnKlar);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.btnLäggTill);
            this.Controls.Add(this.gridRader);
            this.Controls.Add(this.gridUtrustning);
            this.Controls.Add(this.Anställningsnummerlbl);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UthyrningUtrustning";
            this.Text = "UthyrningUtrustning";
            this.Load += new System.EventHandler(this.UthyrningUtrustning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUtrustning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Anställningsnummerlbl;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.DataGridView gridUtrustning;
        private System.Windows.Forms.DataGridView gridRader;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Button btnKlar;
        private System.Windows.Forms.TextBox txtBoxValdKund;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTyp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStorlek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFrån;
        private System.Windows.Forms.DateTimePicker dateTill;
    }
}