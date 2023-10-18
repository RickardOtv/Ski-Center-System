namespace NetFramework
{
    partial class Återlämning
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.KundSokBtn = new System.Windows.Forms.Button();
            this.Personnummerlbl = new System.Windows.Forms.Label();
            this.txtBoxKundID = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(147, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(513, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 76);
            this.label3.TabIndex = 18;
            this.label3.Text = "Återlämning";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 50);
            this.button1.TabIndex = 19;
            this.button1.Text = "Återlämna";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 594);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 50);
            this.button2.TabIndex = 20;
            this.button2.Text = "Tillbaka";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KundSokBtn
            // 
            this.KundSokBtn.Location = new System.Drawing.Point(355, 127);
            this.KundSokBtn.Margin = new System.Windows.Forms.Padding(6);
            this.KundSokBtn.Name = "KundSokBtn";
            this.KundSokBtn.Size = new System.Drawing.Size(80, 35);
            this.KundSokBtn.TabIndex = 23;
            this.KundSokBtn.Text = "Sök Personnummer";
            this.KundSokBtn.UseVisualStyleBackColor = true;
            this.KundSokBtn.Click += new System.EventHandler(this.KundSokBtn_Click);
            // 
            // Personnummerlbl
            // 
            this.Personnummerlbl.AutoSize = true;
            this.Personnummerlbl.BackColor = System.Drawing.Color.Transparent;
            this.Personnummerlbl.Location = new System.Drawing.Point(142, 98);
            this.Personnummerlbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Personnummerlbl.Name = "Personnummerlbl";
            this.Personnummerlbl.Size = new System.Drawing.Size(88, 25);
            this.Personnummerlbl.TabIndex = 22;
            this.Personnummerlbl.Text = "KundID:";
            this.Personnummerlbl.Click += new System.EventHandler(this.Personnummerlbl_Click);
            // 
            // txtBoxKundID
            // 
            this.txtBoxKundID.Location = new System.Drawing.Point(147, 129);
            this.txtBoxKundID.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxKundID.Name = "txtBoxKundID";
            this.txtBoxKundID.Size = new System.Drawing.Size(196, 31);
            this.txtBoxKundID.TabIndex = 21;
            this.txtBoxKundID.TextChanged += new System.EventHandler(this.txtBoxKundID_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(444, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 33);
            this.button3.TabIndex = 24;
            this.button3.Text = "Visa alla ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Återlämning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 667);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.KundSokBtn);
            this.Controls.Add(this.Personnummerlbl);
            this.Controls.Add(this.txtBoxKundID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Återlämning";
            this.Text = "Återlämning";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button KundSokBtn;
        private System.Windows.Forms.Label Personnummerlbl;
        private System.Windows.Forms.TextBox txtBoxKundID;
        private System.Windows.Forms.Button button3;
    }
}