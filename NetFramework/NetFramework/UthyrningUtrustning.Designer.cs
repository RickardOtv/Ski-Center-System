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
            this.btnKollaPris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridUtrustning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRader)).BeginInit();
            this.SuspendLayout();
            // 
            // Anställningsnummerlbl
            // 
            this.Anställningsnummerlbl.AutoSize = true;
            this.Anställningsnummerlbl.BackColor = System.Drawing.Color.Transparent;
            this.Anställningsnummerlbl.Location = new System.Drawing.Point(12, 9);
            this.Anställningsnummerlbl.Name = "Anställningsnummerlbl";
            this.Anställningsnummerlbl.Size = new System.Drawing.Size(100, 13);
            this.Anställningsnummerlbl.TabIndex = 7;
            this.Anställningsnummerlbl.Text = "Anställningsnummer";
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(118, 6);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.ReadOnly = true;
            this.txtAnvandarnamn.Size = new System.Drawing.Size(19, 20);
            this.txtAnvandarnamn.TabIndex = 6;
            // 
            // gridUtrustning
            // 
            this.gridUtrustning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUtrustning.Location = new System.Drawing.Point(265, 364);
            this.gridUtrustning.Name = "gridUtrustning";
            this.gridUtrustning.ReadOnly = true;
            this.gridUtrustning.RowHeadersVisible = false;
            this.gridUtrustning.RowHeadersWidth = 62;
            this.gridUtrustning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUtrustning.Size = new System.Drawing.Size(349, 153);
            this.gridUtrustning.TabIndex = 8;
            // 
            // gridRader
            // 
            this.gridRader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRader.Location = new System.Drawing.Point(650, 364);
            this.gridRader.Name = "gridRader";
            this.gridRader.ReadOnly = true;
            this.gridRader.RowHeadersVisible = false;
            this.gridRader.RowHeadersWidth = 62;
            this.gridRader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRader.Size = new System.Drawing.Size(349, 153);
            this.gridRader.TabIndex = 9;
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(539, 523);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(75, 23);
            this.btnLäggTill.TabIndex = 11;
            this.btnLäggTill.Text = "Lägg till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            this.btnLäggTill.Click += new System.EventHandler(this.btnLäggTill_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(247, 573);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(75, 23);
            this.btnTillbaka.TabIndex = 12;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(877, 523);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(75, 23);
            this.btnTaBort.TabIndex = 13;
            this.btnTaBort.Text = "Ta Bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            // 
            // btnKlar
            // 
            this.btnKlar.Location = new System.Drawing.Point(948, 573);
            this.btnKlar.Name = "btnKlar";
            this.btnKlar.Size = new System.Drawing.Size(75, 23);
            this.btnKlar.TabIndex = 14;
            this.btnKlar.Text = "Klar";
            this.btnKlar.UseVisualStyleBackColor = true;
            this.btnKlar.Click += new System.EventHandler(this.btnKlar_Click);
            // 
            // txtBoxValdKund
            // 
            this.txtBoxValdKund.Location = new System.Drawing.Point(265, 277);
            this.txtBoxValdKund.Name = "txtBoxValdKund";
            this.txtBoxValdKund.Size = new System.Drawing.Size(120, 20);
            this.txtBoxValdKund.TabIndex = 18;
            this.txtBoxValdKund.Text = "Vald kund:";
            this.txtBoxValdKund.TextChanged += new System.EventHandler(this.txtBoxValdKund_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(650, 347);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = "Vald utrustning";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 39);
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
            "Snowboardskor",
            "Alpintpaket",
            "Längdpaket",
            "Snowboardpaket"});
            this.cmbTyp.Location = new System.Drawing.Point(265, 338);
            this.cmbTyp.Name = "cmbTyp";
            this.cmbTyp.Size = new System.Drawing.Size(149, 21);
            this.cmbTyp.TabIndex = 42;
            this.cmbTyp.Text = "Typ:";
            this.cmbTyp.SelectedIndexChanged += new System.EventHandler(this.cmbTyp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(440, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
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
            this.cmbStorlek.Location = new System.Drawing.Point(420, 338);
            this.cmbStorlek.Name = "cmbStorlek";
            this.cmbStorlek.Size = new System.Drawing.Size(149, 21);
            this.cmbStorlek.TabIndex = 44;
            this.cmbStorlek.Text = "Storlek:";
            this.cmbStorlek.SelectedIndexChanged += new System.EventHandler(this.cmbStorlek_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(608, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 43;
            // 
            // dateFrån
            // 
            this.dateFrån.Location = new System.Drawing.Point(265, 312);
            this.dateFrån.Name = "dateFrån";
            this.dateFrån.Size = new System.Drawing.Size(149, 20);
            this.dateFrån.TabIndex = 45;
            // 
            // dateTill
            // 
            this.dateTill.Location = new System.Drawing.Point(420, 312);
            this.dateTill.Name = "dateTill";
            this.dateTill.Size = new System.Drawing.Size(149, 20);
            this.dateTill.TabIndex = 46;
            // 
            // btnKollaPris
            // 
            this.btnKollaPris.Location = new System.Drawing.Point(470, 523);
            this.btnKollaPris.Margin = new System.Windows.Forms.Padding(2);
            this.btnKollaPris.Name = "btnKollaPris";
            this.btnKollaPris.Size = new System.Drawing.Size(64, 25);
            this.btnKollaPris.TabIndex = 47;
            this.btnKollaPris.Text = "Kolla Pris";
            this.btnKollaPris.UseVisualStyleBackColor = true;
            this.btnKollaPris.Click += new System.EventHandler(this.btnKollaPris_Click);
            // 
            // UthyrningUtrustning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 808);
            this.Controls.Add(this.btnKollaPris);
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
            this.Name = "UthyrningUtrustning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnKollaPris;
    }
}