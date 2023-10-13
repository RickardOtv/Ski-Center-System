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
            this.gridValdUtrustning = new System.Windows.Forms.DataGridView();
            this.btnSok = new System.Windows.Forms.Button();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.btnSkapa = new System.Windows.Forms.Button();
            this.txtBoxTill = new System.Windows.Forms.TextBox();
            this.txtBoxTyp = new System.Windows.Forms.TextBox();
            this.txtBoxFrån = new System.Windows.Forms.TextBox();
            this.txtBoxValdKund = new System.Windows.Forms.TextBox();
            this.txtBoxStorlek = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridUtrustning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridValdUtrustning)).BeginInit();
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
            this.txtAnvandarnamn.Size = new System.Drawing.Size(19, 20);
            this.txtAnvandarnamn.TabIndex = 6;
            // 
            // gridUtrustning
            // 
            this.gridUtrustning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUtrustning.Location = new System.Drawing.Point(30, 206);
            this.gridUtrustning.Name = "gridUtrustning";
            this.gridUtrustning.Size = new System.Drawing.Size(349, 153);
            this.gridUtrustning.TabIndex = 8;
            // 
            // gridValdUtrustning
            // 
            this.gridValdUtrustning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridValdUtrustning.Location = new System.Drawing.Point(415, 206);
            this.gridValdUtrustning.Name = "gridValdUtrustning";
            this.gridValdUtrustning.Size = new System.Drawing.Size(349, 153);
            this.gridValdUtrustning.TabIndex = 9;
            // 
            // btnSok
            // 
            this.btnSok.Location = new System.Drawing.Point(304, 151);
            this.btnSok.Name = "btnSok";
            this.btnSok.Size = new System.Drawing.Size(75, 23);
            this.btnSok.TabIndex = 10;
            this.btnSok.Text = "Sök";
            this.btnSok.UseVisualStyleBackColor = true;
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(304, 365);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(75, 23);
            this.btnLäggTill.TabIndex = 11;
            this.btnLäggTill.Text = "Lägg till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(12, 415);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(75, 23);
            this.btnTillbaka.TabIndex = 12;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(642, 365);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(75, 23);
            this.btnTaBort.TabIndex = 13;
            this.btnTaBort.Text = "Ta Bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            // 
            // btnSkapa
            // 
            this.btnSkapa.Location = new System.Drawing.Point(713, 415);
            this.btnSkapa.Name = "btnSkapa";
            this.btnSkapa.Size = new System.Drawing.Size(75, 23);
            this.btnSkapa.TabIndex = 14;
            this.btnSkapa.Text = "Skapa";
            this.btnSkapa.UseVisualStyleBackColor = true;
            // 
            // txtBoxTill
            // 
            this.txtBoxTill.Location = new System.Drawing.Point(130, 154);
            this.txtBoxTill.Name = "txtBoxTill";
            this.txtBoxTill.Size = new System.Drawing.Size(83, 20);
            this.txtBoxTill.TabIndex = 15;
            this.txtBoxTill.Text = "Till:";
            // 
            // txtBoxTyp
            // 
            this.txtBoxTyp.Location = new System.Drawing.Point(30, 180);
            this.txtBoxTyp.Name = "txtBoxTyp";
            this.txtBoxTyp.Size = new System.Drawing.Size(183, 20);
            this.txtBoxTyp.TabIndex = 16;
            this.txtBoxTyp.Text = "Typ:";
            // 
            // txtBoxFrån
            // 
            this.txtBoxFrån.Location = new System.Drawing.Point(30, 154);
            this.txtBoxFrån.Name = "txtBoxFrån";
            this.txtBoxFrån.Size = new System.Drawing.Size(83, 20);
            this.txtBoxFrån.TabIndex = 17;
            this.txtBoxFrån.Text = "Från:";
            // 
            // txtBoxValdKund
            // 
            this.txtBoxValdKund.Location = new System.Drawing.Point(30, 119);
            this.txtBoxValdKund.Name = "txtBoxValdKund";
            this.txtBoxValdKund.Size = new System.Drawing.Size(120, 20);
            this.txtBoxValdKund.TabIndex = 18;
            this.txtBoxValdKund.Text = "Vald Kund:";
            // 
            // txtBoxStorlek
            // 
            this.txtBoxStorlek.Location = new System.Drawing.Point(239, 180);
            this.txtBoxStorlek.Name = "txtBoxStorlek";
            this.txtBoxStorlek.Size = new System.Drawing.Size(140, 20);
            this.txtBoxStorlek.TabIndex = 19;
            this.txtBoxStorlek.Text = "Storlek:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(415, 189);
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
            this.label1.Location = new System.Drawing.Point(244, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 39);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lägg till utrustning";
            // 
            // UthyrningUtrustning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtBoxStorlek);
            this.Controls.Add(this.txtBoxValdKund);
            this.Controls.Add(this.txtBoxFrån);
            this.Controls.Add(this.txtBoxTyp);
            this.Controls.Add(this.txtBoxTill);
            this.Controls.Add(this.btnSkapa);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.btnLäggTill);
            this.Controls.Add(this.btnSok);
            this.Controls.Add(this.gridValdUtrustning);
            this.Controls.Add(this.gridUtrustning);
            this.Controls.Add(this.Anställningsnummerlbl);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Name = "UthyrningUtrustning";
            this.Text = "UthyrningUtrustning";
            ((System.ComponentModel.ISupportInitialize)(this.gridUtrustning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridValdUtrustning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Anställningsnummerlbl;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.DataGridView gridUtrustning;
        private System.Windows.Forms.DataGridView gridValdUtrustning;
        private System.Windows.Forms.Button btnSok;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Button btnSkapa;
        private System.Windows.Forms.TextBox txtBoxTill;
        private System.Windows.Forms.TextBox txtBoxTyp;
        private System.Windows.Forms.TextBox txtBoxFrån;
        private System.Windows.Forms.TextBox txtBoxValdKund;
        private System.Windows.Forms.TextBox txtBoxStorlek;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
    }
}