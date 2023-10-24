namespace NetFramework
{
    partial class ÅterlämningUthyrning
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
            this.GridÅterlämning = new System.Windows.Forms.DataGridView();
            this.SökBtn = new System.Windows.Forms.Button();
            this.ÅterlämnaBtn = new System.Windows.Forms.Button();
            this.TextBoxUthyrningsID = new System.Windows.Forms.TextBox();
            this.Tillbaka = new System.Windows.Forms.Button();
            this.UthyrningsIDlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridÅterlämning)).BeginInit();
            this.SuspendLayout();
            // 
            // GridÅterlämning
            // 
            this.GridÅterlämning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridÅterlämning.Location = new System.Drawing.Point(320, 219);
            this.GridÅterlämning.Name = "GridÅterlämning";
            this.GridÅterlämning.ReadOnly = true;
            this.GridÅterlämning.RowHeadersVisible = false;
            this.GridÅterlämning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridÅterlämning.Size = new System.Drawing.Size(616, 315);
            this.GridÅterlämning.TabIndex = 0;
            // 
            // SökBtn
            // 
            this.SökBtn.Location = new System.Drawing.Point(564, 188);
            this.SökBtn.Name = "SökBtn";
            this.SökBtn.Size = new System.Drawing.Size(75, 23);
            this.SökBtn.TabIndex = 1;
            this.SökBtn.Text = "Sök";
            this.SökBtn.UseVisualStyleBackColor = true;
            this.SökBtn.Click += new System.EventHandler(this.SökBtn_Click);
            // 
            // ÅterlämnaBtn
            // 
            this.ÅterlämnaBtn.Location = new System.Drawing.Point(926, 557);
            this.ÅterlämnaBtn.Name = "ÅterlämnaBtn";
            this.ÅterlämnaBtn.Size = new System.Drawing.Size(75, 23);
            this.ÅterlämnaBtn.TabIndex = 2;
            this.ÅterlämnaBtn.Text = "Återlämna";
            this.ÅterlämnaBtn.UseVisualStyleBackColor = true;
            this.ÅterlämnaBtn.Click += new System.EventHandler(this.ÅterlämnaBtn_Click);
            // 
            // TextBoxUthyrningsID
            // 
            this.TextBoxUthyrningsID.Location = new System.Drawing.Point(446, 190);
            this.TextBoxUthyrningsID.Name = "TextBoxUthyrningsID";
            this.TextBoxUthyrningsID.Size = new System.Drawing.Size(100, 20);
            this.TextBoxUthyrningsID.TabIndex = 3;
            // 
            // Tillbaka
            // 
            this.Tillbaka.Location = new System.Drawing.Point(254, 557);
            this.Tillbaka.Name = "Tillbaka";
            this.Tillbaka.Size = new System.Drawing.Size(75, 23);
            this.Tillbaka.TabIndex = 4;
            this.Tillbaka.Text = "Tillbaka";
            this.Tillbaka.UseVisualStyleBackColor = true;
            this.Tillbaka.Click += new System.EventHandler(this.Tillbaka_Click);
            // 
            // UthyrningsIDlbl
            // 
            this.UthyrningsIDlbl.AutoSize = true;
            this.UthyrningsIDlbl.BackColor = System.Drawing.Color.Transparent;
            this.UthyrningsIDlbl.Location = new System.Drawing.Point(317, 193);
            this.UthyrningsIDlbl.Name = "UthyrningsIDlbl";
            this.UthyrningsIDlbl.Size = new System.Drawing.Size(99, 13);
            this.UthyrningsIDlbl.TabIndex = 5;
            this.UthyrningsIDlbl.Text = "Ange UthyrningsID:";
            // 
            // ÅterlämningUthyrning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1279, 808);
            this.Controls.Add(this.UthyrningsIDlbl);
            this.Controls.Add(this.Tillbaka);
            this.Controls.Add(this.TextBoxUthyrningsID);
            this.Controls.Add(this.ÅterlämnaBtn);
            this.Controls.Add(this.SökBtn);
            this.Controls.Add(this.GridÅterlämning);
            this.Name = "ÅterlämningUthyrning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÅterlämningUthyrning";
            ((System.ComponentModel.ISupportInitialize)(this.GridÅterlämning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridÅterlämning;
        private System.Windows.Forms.Button SökBtn;
        private System.Windows.Forms.Button ÅterlämnaBtn;
        private System.Windows.Forms.TextBox TextBoxUthyrningsID;
        private System.Windows.Forms.Button Tillbaka;
        private System.Windows.Forms.Label UthyrningsIDlbl;
    }
}