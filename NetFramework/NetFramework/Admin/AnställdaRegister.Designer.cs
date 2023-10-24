namespace NetFramework
{
    partial class AnställdaRegister
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
            this.gridAnställda = new System.Windows.Forms.DataGridView();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.btnÄndra = new System.Windows.Forms.Button();
            this.lblPersonNr = new System.Windows.Forms.Label();
            this.txtBoxAnställningsNr = new System.Windows.Forms.TextBox();
            this.btnSökAnställningsNr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnställda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(115, 8);
            this.txtAnvandarnamn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(14, 20);
            this.txtAnvandarnamn.TabIndex = 11;
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(13, 9);
            this.lblAnstNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(103, 13);
            this.lblAnstNr.TabIndex = 10;
            this.lblAnstNr.Text = "Anställningsnummer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hantera anställda";
            // 
            // gridAnställda
            // 
            this.gridAnställda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAnställda.Location = new System.Drawing.Point(341, 319);
            this.gridAnställda.Name = "gridAnställda";
            this.gridAnställda.RowHeadersVisible = false;
            this.gridAnställda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAnställda.Size = new System.Drawing.Size(594, 208);
            this.gridAnställda.TabIndex = 13;
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(267, 562);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(63, 25);
            this.btnTillbaka.TabIndex = 14;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(872, 533);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(63, 25);
            this.btnTaBort.TabIndex = 16;
            this.btnTaBort.Text = "Ta bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // btnÄndra
            // 
            this.btnÄndra.Location = new System.Drawing.Point(793, 533);
            this.btnÄndra.Name = "btnÄndra";
            this.btnÄndra.Size = new System.Drawing.Size(63, 25);
            this.btnÄndra.TabIndex = 17;
            this.btnÄndra.Text = "Ändra";
            this.btnÄndra.UseVisualStyleBackColor = true;
            this.btnÄndra.Click += new System.EventHandler(this.btnÄndra_Click);
            // 
            // lblPersonNr
            // 
            this.lblPersonNr.AutoSize = true;
            this.lblPersonNr.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonNr.Location = new System.Drawing.Point(338, 277);
            this.lblPersonNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonNr.Name = "lblPersonNr";
            this.lblPersonNr.Size = new System.Drawing.Size(103, 13);
            this.lblPersonNr.TabIndex = 27;
            this.lblPersonNr.Text = "Anställningsnummer:";
            // 
            // txtBoxAnställningsNr
            // 
            this.txtBoxAnställningsNr.Location = new System.Drawing.Point(341, 292);
            this.txtBoxAnställningsNr.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAnställningsNr.Name = "txtBoxAnställningsNr";
            this.txtBoxAnställningsNr.Size = new System.Drawing.Size(171, 20);
            this.txtBoxAnställningsNr.TabIndex = 26;
            // 
            // btnSökAnställningsNr
            // 
            this.btnSökAnställningsNr.Location = new System.Drawing.Point(515, 287);
            this.btnSökAnställningsNr.Margin = new System.Windows.Forms.Padding(2);
            this.btnSökAnställningsNr.Name = "btnSökAnställningsNr";
            this.btnSökAnställningsNr.Size = new System.Drawing.Size(61, 27);
            this.btnSökAnställningsNr.TabIndex = 23;
            this.btnSökAnställningsNr.Text = "Sök";
            this.btnSökAnställningsNr.UseVisualStyleBackColor = true;
            this.btnSökAnställningsNr.Click += new System.EventHandler(this.btnSökAnställningsNr_Click);
            // 
            // AnställdaRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 808);
            this.Controls.Add(this.lblPersonNr);
            this.Controls.Add(this.txtBoxAnställningsNr);
            this.Controls.Add(this.btnSökAnställningsNr);
            this.Controls.Add(this.btnÄndra);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.gridAnställda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.lblAnstNr);
            this.Name = "AnställdaRegister";
            this.Text = "AnställdaRegister";
            this.Load += new System.EventHandler(this.AnställdaRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAnställda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.Label lblAnstNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridAnställda;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Button btnÄndra;
        private System.Windows.Forms.Label lblPersonNr;
        private System.Windows.Forms.TextBox txtBoxAnställningsNr;
        private System.Windows.Forms.Button btnSökAnställningsNr;
    }
}