namespace NetFramework
{
    partial class VisaLedigLogi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.lblAnstNr = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TillbakaKnapp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(117, 76);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(550, 229);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sök ledig logi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(117, 53);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startDatePicker.TabIndex = 6;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(467, 53);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatePicker.TabIndex = 7;
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(117, 9);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(14, 20);
            this.txtAnvandarnamn.TabIndex = 11;
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(9, 13);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(103, 13);
            this.lblAnstNr.TabIndex = 10;
            this.lblAnstNr.Text = "Anställningsnummer:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Kolla pris";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TillbakaKnapp
            // 
            this.TillbakaKnapp.Location = new System.Drawing.Point(13, 410);
            this.TillbakaKnapp.Name = "TillbakaKnapp";
            this.TillbakaKnapp.Size = new System.Drawing.Size(99, 28);
            this.TillbakaKnapp.TabIndex = 14;
            this.TillbakaKnapp.Text = "Tillbaka";
            this.TillbakaKnapp.UseVisualStyleBackColor = true;
            this.TillbakaKnapp.Click += new System.EventHandler(this.TillbakaKnapp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Välj Startdatum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "Välj Slutdatum:";
            // 
            // VisaLedigLogi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TillbakaKnapp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.lblAnstNr);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "VisaLedigLogi";
            this.Text = "Lediga logialternativ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Label lblAnstNr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button TillbakaKnapp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}