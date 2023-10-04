namespace NetFramework
{
    partial class Kundregister
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
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.lblAnstNr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.btnAndra = new System.Windows.Forms.Button();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.gridKunder = new System.Windows.Forms.DataGridView();
            this.btnSokPersonNr = new System.Windows.Forms.Button();
            this.lblNamn = new System.Windows.Forms.Label();
            this.txtBoxNamn = new System.Windows.Forms.TextBox();
            this.txtBoxPersonNr = new System.Windows.Forms.TextBox();
            this.lblPersonNr = new System.Windows.Forms.Label();
            this.btnSokNamn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridKunder)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(168, 7);
            this.txtAnvandarnamn.Margin = new System.Windows.Forms.Padding(5);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(19, 26);
            this.txtAnvandarnamn.TabIndex = 9;
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(14, 9);
            this.lblAnstNr.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(157, 20);
            this.lblAnstNr.TabIndex = 8;
            this.lblAnstNr.Text = "Anställningsnummer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kundregister";
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(989, 557);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(95, 38);
            this.btnTaBort.TabIndex = 11;
            this.btnTaBort.Text = "Ta bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // btnAndra
            // 
            this.btnAndra.Location = new System.Drawing.Point(864, 557);
            this.btnAndra.Name = "btnAndra";
            this.btnAndra.Size = new System.Drawing.Size(95, 38);
            this.btnAndra.TabIndex = 12;
            this.btnAndra.Text = "Ändra";
            this.btnAndra.UseVisualStyleBackColor = true;
            this.btnAndra.Click += new System.EventHandler(this.btnAndra_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(18, 637);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(95, 38);
            this.btnTillbaka.TabIndex = 13;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // gridKunder
            // 
            this.gridKunder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKunder.Location = new System.Drawing.Point(132, 201);
            this.gridKunder.Name = "gridKunder";
            this.gridKunder.RowTemplate.Height = 28;
            this.gridKunder.Size = new System.Drawing.Size(952, 337);
            this.gridKunder.TabIndex = 14;
            // 
            // btnSokPersonNr
            // 
            this.btnSokPersonNr.Location = new System.Drawing.Point(393, 153);
            this.btnSokPersonNr.Name = "btnSokPersonNr";
            this.btnSokPersonNr.Size = new System.Drawing.Size(92, 41);
            this.btnSokPersonNr.TabIndex = 17;
            this.btnSokPersonNr.Text = "Sök";
            this.btnSokPersonNr.UseVisualStyleBackColor = true;
            this.btnSokPersonNr.Click += new System.EventHandler(this.btnSokPersonNr_Click);
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.BackColor = System.Drawing.Color.Transparent;
            this.lblNamn.Location = new System.Drawing.Point(128, 74);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(55, 20);
            this.lblNamn.TabIndex = 18;
            this.lblNamn.Text = "Namn:";
            // 
            // txtBoxNamn
            // 
            this.txtBoxNamn.Location = new System.Drawing.Point(132, 97);
            this.txtBoxNamn.Name = "txtBoxNamn";
            this.txtBoxNamn.Size = new System.Drawing.Size(255, 26);
            this.txtBoxNamn.TabIndex = 19;
            // 
            // txtBoxPersonNr
            // 
            this.txtBoxPersonNr.Location = new System.Drawing.Point(132, 160);
            this.txtBoxPersonNr.Name = "txtBoxPersonNr";
            this.txtBoxPersonNr.Size = new System.Drawing.Size(255, 26);
            this.txtBoxPersonNr.TabIndex = 20;
            // 
            // lblPersonNr
            // 
            this.lblPersonNr.AutoSize = true;
            this.lblPersonNr.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonNr.Location = new System.Drawing.Point(128, 137);
            this.lblPersonNr.Name = "lblPersonNr";
            this.lblPersonNr.Size = new System.Drawing.Size(121, 20);
            this.lblPersonNr.TabIndex = 21;
            this.lblPersonNr.Text = "Personnummer:";
            // 
            // btnSokNamn
            // 
            this.btnSokNamn.Location = new System.Drawing.Point(393, 90);
            this.btnSokNamn.Name = "btnSokNamn";
            this.btnSokNamn.Size = new System.Drawing.Size(92, 41);
            this.btnSokNamn.TabIndex = 22;
            this.btnSokNamn.Text = "Sök";
            this.btnSokNamn.UseVisualStyleBackColor = true;
            this.btnSokNamn.Click += new System.EventHandler(this.btnSokNamn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(1018, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 63);
            this.button1.TabIndex = 23;
            this.button1.Text = "↻ ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kundregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 687);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSokNamn);
            this.Controls.Add(this.lblPersonNr);
            this.Controls.Add(this.txtBoxPersonNr);
            this.Controls.Add(this.txtBoxNamn);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.btnSokPersonNr);
            this.Controls.Add(this.gridKunder);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.btnAndra);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.lblAnstNr);
            this.Name = "Kundregister";
            this.Text = "Kundregister";
            this.Load += new System.EventHandler(this.Kundregister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKunder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Label lblAnstNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Button btnAndra;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.DataGridView gridKunder;
        private System.Windows.Forms.Button btnSokPersonNr;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.TextBox txtBoxNamn;
        private System.Windows.Forms.TextBox txtBoxPersonNr;
        private System.Windows.Forms.Label lblPersonNr;
        private System.Windows.Forms.Button btnSokNamn;
        private System.Windows.Forms.Button button1;
    }
}