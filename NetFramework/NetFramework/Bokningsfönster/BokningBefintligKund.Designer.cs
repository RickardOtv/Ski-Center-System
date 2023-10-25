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
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.btn_sök = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.gridRader = new System.Windows.Forms.DataGridView();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.btnVäljKund = new System.Windows.Forms.Button();
            this.lblRader = new System.Windows.Forms.Label();
            this.btn_Vidare = new System.Windows.Forms.Button();
            this.btnKollaPris = new System.Windows.Forms.Button();
            this.btn_kollaLogiInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridKunder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLogi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRader)).BeginInit();
            this.SuspendLayout();
            // 
            // gridKunder
            // 
            this.gridKunder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKunder.Location = new System.Drawing.Point(253, 146);
            this.gridKunder.Margin = new System.Windows.Forms.Padding(2);
            this.gridKunder.MultiSelect = false;
            this.gridKunder.Name = "gridKunder";
            this.gridKunder.ReadOnly = true;
            this.gridKunder.RowHeadersVisible = false;
            this.gridKunder.RowHeadersWidth = 72;
            this.gridKunder.RowTemplate.Height = 31;
            this.gridKunder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKunder.Size = new System.Drawing.Size(420, 176);
            this.gridKunder.TabIndex = 0;
            // 
            // gridLogi
            // 
            this.gridLogi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLogi.Location = new System.Drawing.Point(400, 413);
            this.gridLogi.Margin = new System.Windows.Forms.Padding(2);
            this.gridLogi.Name = "gridLogi";
            this.gridLogi.ReadOnly = true;
            this.gridLogi.RowHeadersVisible = false;
            this.gridLogi.RowHeadersWidth = 72;
            this.gridLogi.RowTemplate.Height = 31;
            this.gridLogi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLogi.Size = new System.Drawing.Size(316, 129);
            this.gridLogi.TabIndex = 1;
            // 
            // lblKund
            // 
            this.lblKund.AutoSize = true;
            this.lblKund.BackColor = System.Drawing.Color.Transparent;
            this.lblKund.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKund.Location = new System.Drawing.Point(481, 112);
            this.lblKund.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKund.Name = "lblKund";
            this.lblKund.Size = new System.Drawing.Size(125, 31);
            this.lblKund.TabIndex = 2;
            this.lblKund.Text = "Välj kund";
            // 
            // lblLogi
            // 
            this.lblLogi.AutoSize = true;
            this.lblLogi.BackColor = System.Drawing.Color.Transparent;
            this.lblLogi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogi.Location = new System.Drawing.Point(455, 378);
            this.lblLogi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogi.Name = "lblLogi";
            this.lblLogi.Size = new System.Drawing.Size(204, 31);
            this.lblLogi.TabIndex = 3;
            this.lblLogi.Text = "Välj logialterativ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Personnummer:";
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(403, 115);
            this.btnSök.Margin = new System.Windows.Forms.Padding(2);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(39, 20);
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
            this.lblFrån.Location = new System.Drawing.Point(260, 404);
            this.lblFrån.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrån.Name = "lblFrån";
            this.lblFrån.Size = new System.Drawing.Size(36, 13);
            this.lblFrån.TabIndex = 7;
            this.lblFrån.Text = "Från:";
            // 
            // lblTill
            // 
            this.lblTill.AutoSize = true;
            this.lblTill.BackColor = System.Drawing.Color.Transparent;
            this.lblTill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTill.Location = new System.Drawing.Point(260, 453);
            this.lblTill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTill.Name = "lblTill";
            this.lblTill.Size = new System.Drawing.Size(28, 13);
            this.lblTill.TabIndex = 10;
            this.lblTill.Text = "Till:";
            // 
            // dateFrån
            // 
            this.dateFrån.Location = new System.Drawing.Point(263, 418);
            this.dateFrån.Margin = new System.Windows.Forms.Padding(2);
            this.dateFrån.Name = "dateFrån";
            this.dateFrån.Size = new System.Drawing.Size(134, 20);
            this.dateFrån.TabIndex = 11;
            // 
            // dateTill
            // 
            this.dateTill.Location = new System.Drawing.Point(262, 467);
            this.dateTill.Margin = new System.Windows.Forms.Padding(2);
            this.dateTill.Name = "dateTill";
            this.dateTill.Size = new System.Drawing.Size(135, 20);
            this.dateTill.TabIndex = 12;
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(253, 621);
            this.btnAvbryt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(70, 21);
            this.btnAvbryt.TabIndex = 14;
            this.btnAvbryt.Text = "Tillbaka";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // btn_sök
            // 
            this.btn_sök.Location = new System.Drawing.Point(262, 508);
            this.btn_sök.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sök.Name = "btn_sök";
            this.btn_sök.Size = new System.Drawing.Size(134, 25);
            this.btn_sök.TabIndex = 15;
            this.btn_sök.Text = "Sök";
            this.btn_sök.UseVisualStyleBackColor = true;
            this.btn_sök.Click += new System.EventHandler(this.btn_sökLogi_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(254, 117);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(134, 20);
            this.txtFilter.TabIndex = 4;
            // 
            // gridRader
            // 
            this.gridRader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRader.Location = new System.Drawing.Point(720, 413);
            this.gridRader.Margin = new System.Windows.Forms.Padding(2);
            this.gridRader.Name = "gridRader";
            this.gridRader.ReadOnly = true;
            this.gridRader.RowHeadersVisible = false;
            this.gridRader.RowHeadersWidth = 82;
            this.gridRader.RowTemplate.Height = 33;
            this.gridRader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRader.Size = new System.Drawing.Size(319, 129);
            this.gridRader.TabIndex = 16;
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(637, 546);
            this.btnLäggTill.Margin = new System.Windows.Forms.Padding(2);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(79, 28);
            this.btnLäggTill.TabIndex = 17;
            this.btnLäggTill.Text = "Lägg Till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            this.btnLäggTill.Click += new System.EventHandler(this.btnLäggTill_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(968, 545);
            this.btnTaBort.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(70, 29);
            this.btnTaBort.TabIndex = 18;
            this.btnTaBort.Text = "Ta Bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // btnVäljKund
            // 
            this.btnVäljKund.Location = new System.Drawing.Point(432, 326);
            this.btnVäljKund.Margin = new System.Windows.Forms.Padding(2);
            this.btnVäljKund.Name = "btnVäljKund";
            this.btnVäljKund.Size = new System.Drawing.Size(66, 22);
            this.btnVäljKund.TabIndex = 19;
            this.btnVäljKund.Text = "Välj kund";
            this.btnVäljKund.UseVisualStyleBackColor = true;
            this.btnVäljKund.Click += new System.EventHandler(this.btnVäljKund_Click);
            // 
            // lblRader
            // 
            this.lblRader.AutoSize = true;
            this.lblRader.BackColor = System.Drawing.Color.Transparent;
            this.lblRader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRader.Location = new System.Drawing.Point(755, 378);
            this.lblRader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRader.Name = "lblRader";
            this.lblRader.Size = new System.Drawing.Size(257, 31);
            this.lblRader.TabIndex = 20;
            this.lblRader.Text = "Dina bokningsrader:";
            // 
            // btn_Vidare
            // 
            this.btn_Vidare.Location = new System.Drawing.Point(990, 621);
            this.btn_Vidare.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Vidare.Name = "btn_Vidare";
            this.btn_Vidare.Size = new System.Drawing.Size(70, 21);
            this.btn_Vidare.TabIndex = 21;
            this.btn_Vidare.Text = "Klar";
            this.btn_Vidare.UseVisualStyleBackColor = true;
            this.btn_Vidare.Click += new System.EventHandler(this.btnKlar_Click);
            // 
            // btnKollaPris
            // 
            this.btnKollaPris.Location = new System.Drawing.Point(568, 546);
            this.btnKollaPris.Margin = new System.Windows.Forms.Padding(2);
            this.btnKollaPris.Name = "btnKollaPris";
            this.btnKollaPris.Size = new System.Drawing.Size(65, 28);
            this.btnKollaPris.TabIndex = 22;
            this.btnKollaPris.Text = "Kolla Pris";
            this.btnKollaPris.UseVisualStyleBackColor = true;
            this.btnKollaPris.Click += new System.EventHandler(this.btnKollaPris_Click);
            // 
            // btn_kollaLogiInfo
            // 
            this.btn_kollaLogiInfo.Location = new System.Drawing.Point(499, 545);
            this.btn_kollaLogiInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kollaLogiInfo.Name = "btn_kollaLogiInfo";
            this.btn_kollaLogiInfo.Size = new System.Drawing.Size(65, 28);
            this.btn_kollaLogiInfo.TabIndex = 23;
            this.btn_kollaLogiInfo.Text = "Kolla Info";
            this.btn_kollaLogiInfo.UseVisualStyleBackColor = true;
            this.btn_kollaLogiInfo.Click += new System.EventHandler(this.btnLogiInfo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(867, 546);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "Kolla Pris För Alla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTotalSumma_Click);
            // 
            // BokningBefintligKund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 808);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_kollaLogiInfo);
            this.Controls.Add(this.btnKollaPris);
            this.Controls.Add(this.btn_Vidare);
            this.Controls.Add(this.lblRader);
            this.Controls.Add(this.btnVäljKund);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnLäggTill);
            this.Controls.Add(this.gridRader);
            this.Controls.Add(this.btn_sök);
            this.Controls.Add(this.btnAvbryt);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BokningBefintligKund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Befintlig Kund";
            this.Load += new System.EventHandler(this.BokningBefintligKund_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKunder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLogi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRader)).EndInit();
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
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.Button btn_sök;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridView gridRader;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Button btnVäljKund;
        private System.Windows.Forms.Label lblRader;
        private System.Windows.Forms.Button btn_Vidare;
        private System.Windows.Forms.Button btnKollaPris;
        private System.Windows.Forms.Button btn_kollaLogiInfo;
        private System.Windows.Forms.Button button1;
    }
}