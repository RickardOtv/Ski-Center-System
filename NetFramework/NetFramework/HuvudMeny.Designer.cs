namespace NetFramework
{
    partial class HuvudMeny
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnUthyrning = new System.Windows.Forms.Button();
            this.btnMarknad = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnstNr = new System.Windows.Forms.Label();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(728, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bokning";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUthyrning
            // 
            this.btnUthyrning.Location = new System.Drawing.Point(188, 357);
            this.btnUthyrning.Margin = new System.Windows.Forms.Padding(6);
            this.btnUthyrning.Name = "btnUthyrning";
            this.btnUthyrning.Size = new System.Drawing.Size(728, 63);
            this.btnUthyrning.TabIndex = 1;
            this.btnUthyrning.Text = "Uthyrning";
            this.btnUthyrning.UseVisualStyleBackColor = true;
            // 
            // btnMarknad
            // 
            this.btnMarknad.Location = new System.Drawing.Point(188, 472);
            this.btnMarknad.Margin = new System.Windows.Forms.Padding(6);
            this.btnMarknad.Name = "btnMarknad";
            this.btnMarknad.Size = new System.Drawing.Size(728, 62);
            this.btnMarknad.TabIndex = 2;
            this.btnMarknad.Text = "Marknadsvy";
            this.btnMarknad.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(188, 587);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(728, 56);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Adminvy";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 76);
            this.label1.TabIndex = 4;
            this.label1.Text = "Huvudmeny";
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.Location = new System.Drawing.Point(15, 12);
            this.lblAnstNr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(212, 25);
            this.lblAnstNr.TabIndex = 6;
            this.lblAnstNr.Text = "Anställningsnummer:";
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(220, 9);
            this.txtAnvandarnamn.Margin = new System.Windows.Forms.Padding(6);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(24, 31);
            this.txtAnvandarnamn.TabIndex = 7;
            // 
            // HuvudMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1147, 743);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.lblAnstNr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnMarknad);
            this.Controls.Add(this.btnUthyrning);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HuvudMeny";
            this.Text = "HuvudMeny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUthyrning;
        private System.Windows.Forms.Button btnMarknad;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnstNr;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
    }
}