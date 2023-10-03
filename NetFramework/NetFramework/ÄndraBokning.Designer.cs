namespace NetFramework
{
    partial class ÄndraBokning
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
            this.btn_Tillbaka = new System.Windows.Forms.Button();
            this.btn_Spara = new System.Windows.Forms.Button();
            this.label_FrånDatumNamn = new System.Windows.Forms.Label();
            this.label_FrånDatum = new System.Windows.Forms.Label();
            this.label_TillDatumNamn = new System.Windows.Forms.Label();
            this.label_TillDatum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAnstNr = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Tillbaka
            // 
            this.btn_Tillbaka.Location = new System.Drawing.Point(13, 213);
            this.btn_Tillbaka.Name = "btn_Tillbaka";
            this.btn_Tillbaka.Size = new System.Drawing.Size(75, 23);
            this.btn_Tillbaka.TabIndex = 0;
            this.btn_Tillbaka.Text = "Tillbaka";
            this.btn_Tillbaka.UseVisualStyleBackColor = true;
            this.btn_Tillbaka.Click += new System.EventHandler(this.btn_Tillbaka_Click);
            // 
            // btn_Spara
            // 
            this.btn_Spara.Location = new System.Drawing.Point(183, 213);
            this.btn_Spara.Name = "btn_Spara";
            this.btn_Spara.Size = new System.Drawing.Size(75, 23);
            this.btn_Spara.TabIndex = 1;
            this.btn_Spara.Text = "Spara";
            this.btn_Spara.UseVisualStyleBackColor = true;
            this.btn_Spara.Click += new System.EventHandler(this.btn_Spara_Click);
            // 
            // label_FrånDatumNamn
            // 
            this.label_FrånDatumNamn.AutoSize = true;
            this.label_FrånDatumNamn.BackColor = System.Drawing.Color.Transparent;
            this.label_FrånDatumNamn.Location = new System.Drawing.Point(23, 52);
            this.label_FrånDatumNamn.Name = "label_FrånDatumNamn";
            this.label_FrånDatumNamn.Size = new System.Drawing.Size(65, 13);
            this.label_FrånDatumNamn.TabIndex = 3;
            this.label_FrånDatumNamn.Text = "Från Datum:";
            // 
            // label_FrånDatum
            // 
            this.label_FrånDatum.AutoSize = true;
            this.label_FrånDatum.BackColor = System.Drawing.Color.White;
            this.label_FrånDatum.Location = new System.Drawing.Point(86, 52);
            this.label_FrånDatum.Name = "label_FrånDatum";
            this.label_FrånDatum.Size = new System.Drawing.Size(86, 13);
            this.label_FrånDatum.TabIndex = 4;
            this.label_FrånDatum.Text = "Inget datum kom";
            // 
            // label_TillDatumNamn
            // 
            this.label_TillDatumNamn.AutoSize = true;
            this.label_TillDatumNamn.BackColor = System.Drawing.Color.Transparent;
            this.label_TillDatumNamn.Location = new System.Drawing.Point(23, 71);
            this.label_TillDatumNamn.Name = "label_TillDatumNamn";
            this.label_TillDatumNamn.Size = new System.Drawing.Size(57, 13);
            this.label_TillDatumNamn.TabIndex = 5;
            this.label_TillDatumNamn.Text = "Till Datum:";
            // 
            // label_TillDatum
            // 
            this.label_TillDatum.AutoSize = true;
            this.label_TillDatum.BackColor = System.Drawing.Color.White;
            this.label_TillDatum.Location = new System.Drawing.Point(86, 71);
            this.label_TillDatum.Name = "label_TillDatum";
            this.label_TillDatum.Size = new System.Drawing.Size(86, 13);
            this.label_TillDatum.TabIndex = 6;
            this.label_TillDatum.Text = "Inget datum kom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(21, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nytt Från Datum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(21, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nytt Till Datum:";
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(10, 9);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(103, 13);
            this.lblAnstNr.TabIndex = 10;
            this.lblAnstNr.Text = "Anställningsnummer:";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(110, 119);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(132, 20);
            this.startDatePicker.TabIndex = 13;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(110, 155);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(132, 20);
            this.endDatePicker.TabIndex = 14;
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(110, 6);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(14, 20);
            this.txtAnvandarnamn.TabIndex = 16;
            // 
            // ÄndraBokning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.ClientSize = new System.Drawing.Size(270, 248);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.lblAnstNr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_TillDatum);
            this.Controls.Add(this.label_TillDatumNamn);
            this.Controls.Add(this.label_FrånDatum);
            this.Controls.Add(this.label_FrånDatumNamn);
            this.Controls.Add(this.btn_Spara);
            this.Controls.Add(this.btn_Tillbaka);
            this.Name = "ÄndraBokning";
            this.Text = "ÄndraBokning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Tillbaka;
        private System.Windows.Forms.Button btn_Spara;
        private System.Windows.Forms.Label label_FrånDatumNamn;
        private System.Windows.Forms.Label label_FrånDatum;
        private System.Windows.Forms.Label label_TillDatumNamn;
        private System.Windows.Forms.Label label_TillDatum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAnstNr;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
    }
}