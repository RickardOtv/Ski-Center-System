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
            this.txtAnvandarnamn.Location = new System.Drawing.Point(112, 5);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(14, 20);
            this.txtAnvandarnamn.TabIndex = 9;
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(9, 6);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(103, 13);
            this.lblAnstNr.TabIndex = 8;
            this.lblAnstNr.Text = "Anställningsnummer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kundregister";
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(641, 362);
            this.btnTaBort.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(63, 25);
            this.btnTaBort.TabIndex = 11;
            this.btnTaBort.Text = "Ta bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // btnAndra
            // 
            this.btnAndra.Location = new System.Drawing.Point(563, 362);
            this.btnAndra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAndra.Name = "btnAndra";
            this.btnAndra.Size = new System.Drawing.Size(63, 25);
            this.btnAndra.TabIndex = 12;
            this.btnAndra.Text = "Ändra";
            this.btnAndra.UseVisualStyleBackColor = true;
            this.btnAndra.Click += new System.EventHandler(this.btnAndra_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(12, 414);
            this.btnTillbaka.Margin = new System.Windows.Forms.Padding(2);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(63, 25);
            this.btnTillbaka.TabIndex = 13;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // gridKunder
            // 
            this.gridKunder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKunder.Location = new System.Drawing.Point(88, 131);
            this.gridKunder.Margin = new System.Windows.Forms.Padding(2);
            this.gridKunder.MultiSelect = false;
            this.gridKunder.Name = "gridKunder";
            this.gridKunder.ReadOnly = true;
            this.gridKunder.RowHeadersVisible = false;
            this.gridKunder.RowTemplate.Height = 28;
            this.gridKunder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKunder.Size = new System.Drawing.Size(616, 219);
            this.gridKunder.TabIndex = 14;
            // 
            // btnSokPersonNr
            // 
            this.btnSokPersonNr.Location = new System.Drawing.Point(262, 99);
            this.btnSokPersonNr.Margin = new System.Windows.Forms.Padding(2);
            this.btnSokPersonNr.Name = "btnSokPersonNr";
            this.btnSokPersonNr.Size = new System.Drawing.Size(61, 27);
            this.btnSokPersonNr.TabIndex = 17;
            this.btnSokPersonNr.Text = "Sök";
            this.btnSokPersonNr.UseVisualStyleBackColor = true;
            this.btnSokPersonNr.Click += new System.EventHandler(this.btnSokPersonNr_Click);
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.BackColor = System.Drawing.Color.Transparent;
            this.lblNamn.Location = new System.Drawing.Point(85, 48);
            this.lblNamn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(38, 13);
            this.lblNamn.TabIndex = 18;
            this.lblNamn.Text = "Namn:";
            this.lblNamn.Click += new System.EventHandler(this.lblNamn_Click);
            // 
            // txtBoxNamn
            // 
            this.txtBoxNamn.Location = new System.Drawing.Point(88, 63);
            this.txtBoxNamn.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNamn.Name = "txtBoxNamn";
            this.txtBoxNamn.Size = new System.Drawing.Size(171, 20);
            this.txtBoxNamn.TabIndex = 19;
 
            // 
            // txtBoxPersonNr
            // 
            this.txtBoxPersonNr.Location = new System.Drawing.Point(88, 104);
            this.txtBoxPersonNr.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPersonNr.Name = "txtBoxPersonNr";
            this.txtBoxPersonNr.Size = new System.Drawing.Size(171, 20);
            this.txtBoxPersonNr.TabIndex = 20;
            this.txtBoxPersonNr.TextChanged += new System.EventHandler(this.txtBoxPersonNr_TextChanged);
            // 
            // lblPersonNr
            // 
            this.lblPersonNr.AutoSize = true;
            this.lblPersonNr.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonNr.Location = new System.Drawing.Point(85, 89);
            this.lblPersonNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonNr.Name = "lblPersonNr";
            this.lblPersonNr.Size = new System.Drawing.Size(80, 13);
            this.lblPersonNr.TabIndex = 21;
            this.lblPersonNr.Text = "Personnummer:";
            this.lblPersonNr.Click += new System.EventHandler(this.lblPersonNr_Click);
            // 
            // btnSokNamn
            // 
            this.btnSokNamn.Location = new System.Drawing.Point(262, 58);
            this.btnSokNamn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSokNamn.Name = "btnSokNamn";
            this.btnSokNamn.Size = new System.Drawing.Size(61, 27);
            this.btnSokNamn.TabIndex = 22;
            this.btnSokNamn.Text = "Sök";
            this.btnSokNamn.UseVisualStyleBackColor = true;
            this.btnSokNamn.Click += new System.EventHandler(this.btnSokNamn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(660, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 41);
            this.button1.TabIndex = 23;
            this.button1.Text = "↻ ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kundregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 447);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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