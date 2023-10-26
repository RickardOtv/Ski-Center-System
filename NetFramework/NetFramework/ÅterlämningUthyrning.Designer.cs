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
            this.gradientPanel1 = new NetFramework.GradientPanel();
            this.Anställningsnummerlbl = new System.Windows.Forms.Label();
            this.SökBtn = new System.Windows.Forms.Button();
            this.TextBoxUthyrningsID = new System.Windows.Forms.TextBox();
            this.Tillbaka = new System.Windows.Forms.Button();
            this.ÅterlämnaBtn = new System.Windows.Forms.Button();
            this.UthyrningsIDlbl = new System.Windows.Forms.Label();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.GridÅterlämning = new System.Windows.Forms.DataGridView();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridÅterlämning)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.gradientPanel1.BottomColor = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.Anställningsnummerlbl);
            this.gradientPanel1.Controls.Add(this.SökBtn);
            this.gradientPanel1.Controls.Add(this.TextBoxUthyrningsID);
            this.gradientPanel1.Controls.Add(this.Tillbaka);
            this.gradientPanel1.Controls.Add(this.ÅterlämnaBtn);
            this.gradientPanel1.Controls.Add(this.UthyrningsIDlbl);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1279, 808);
            this.gradientPanel1.TabIndex = 15;
            this.gradientPanel1.TopColor = System.Drawing.SystemColors.HotTrack;
            // 
            // Anställningsnummerlbl
            // 
            this.Anställningsnummerlbl.AutoSize = true;
            this.Anställningsnummerlbl.BackColor = System.Drawing.Color.Transparent;
            this.Anställningsnummerlbl.Location = new System.Drawing.Point(12, 9);
            this.Anställningsnummerlbl.Name = "Anställningsnummerlbl";
            this.Anställningsnummerlbl.Size = new System.Drawing.Size(100, 13);
            this.Anställningsnummerlbl.TabIndex = 14;
            this.Anställningsnummerlbl.Text = "Anställningsnummer";
            // 
            // SökBtn
            // 
            this.SökBtn.Location = new System.Drawing.Point(540, 190);
            this.SökBtn.Name = "SökBtn";
            this.SökBtn.Size = new System.Drawing.Size(62, 23);
            this.SökBtn.TabIndex = 1;
            this.SökBtn.Text = "Sök";
            this.SökBtn.UseVisualStyleBackColor = true;
            this.SökBtn.Click += new System.EventHandler(this.SökBtn_Click);
            // 
            // TextBoxUthyrningsID
            // 
            this.TextBoxUthyrningsID.Location = new System.Drawing.Point(422, 190);
            this.TextBoxUthyrningsID.Name = "TextBoxUthyrningsID";
            this.TextBoxUthyrningsID.Size = new System.Drawing.Size(112, 20);
            this.TextBoxUthyrningsID.TabIndex = 3;
            // 
            // Tillbaka
            // 
            this.Tillbaka.Location = new System.Drawing.Point(14, 768);
            this.Tillbaka.Name = "Tillbaka";
            this.Tillbaka.Size = new System.Drawing.Size(110, 28);
            this.Tillbaka.TabIndex = 4;
            this.Tillbaka.Text = "Tillbaka";
            this.Tillbaka.UseVisualStyleBackColor = true;
            this.Tillbaka.Click += new System.EventHandler(this.Tillbaka_Click);
            // 
            // ÅterlämnaBtn
            // 
            this.ÅterlämnaBtn.Location = new System.Drawing.Point(849, 540);
            this.ÅterlämnaBtn.Name = "ÅterlämnaBtn";
            this.ÅterlämnaBtn.Size = new System.Drawing.Size(87, 35);
            this.ÅterlämnaBtn.TabIndex = 2;
            this.ÅterlämnaBtn.Text = "Återlämna";
            this.ÅterlämnaBtn.UseVisualStyleBackColor = true;
            this.ÅterlämnaBtn.Click += new System.EventHandler(this.ÅterlämnaBtn_Click);
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
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(118, 6);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.ReadOnly = true;
            this.txtAnvandarnamn.Size = new System.Drawing.Size(19, 20);
            this.txtAnvandarnamn.TabIndex = 13;
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
            // ÅterlämningUthyrning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1279, 808);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.GridÅterlämning);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ÅterlämningUthyrning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÅterlämningUthyrning";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridÅterlämning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label Anställningsnummerlbl;
        private System.Windows.Forms.Button Tillbaka;
        private System.Windows.Forms.Label UthyrningsIDlbl;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
        private System.Windows.Forms.TextBox TextBoxUthyrningsID;
        private System.Windows.Forms.Button SökBtn;
        private System.Windows.Forms.DataGridView GridÅterlämning;
        private System.Windows.Forms.Button ÅterlämnaBtn;
    }
}