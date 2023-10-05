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
            this.btnKundregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 96);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(546, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bokning";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUthyrning
            // 
            this.btnUthyrning.Location = new System.Drawing.Point(141, 193);
            this.btnUthyrning.Margin = new System.Windows.Forms.Padding(5);
            this.btnUthyrning.Name = "btnUthyrning";
            this.btnUthyrning.Size = new System.Drawing.Size(546, 50);
            this.btnUthyrning.TabIndex = 1;
            this.btnUthyrning.Text = "Uthyrning";
            this.btnUthyrning.UseVisualStyleBackColor = true;
            this.btnUthyrning.Click += new System.EventHandler(this.btnUthyrning_Click);
            // 
            // btnMarknad
            // 
            this.btnMarknad.Location = new System.Drawing.Point(141, 281);
            this.btnMarknad.Margin = new System.Windows.Forms.Padding(5);
            this.btnMarknad.Name = "btnMarknad";
            this.btnMarknad.Size = new System.Drawing.Size(546, 50);
            this.btnMarknad.TabIndex = 2;
            this.btnMarknad.Text = "Marknadsvy";
            this.btnMarknad.UseVisualStyleBackColor = true;
            this.btnMarknad.Click += new System.EventHandler(this.btnMarknad_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(141, 364);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(546, 45);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Adminvy";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Huvudmeny";
            // 
            // lblAnstNr
            // 
            this.lblAnstNr.AutoSize = true;
            this.lblAnstNr.BackColor = System.Drawing.Color.Transparent;
            this.lblAnstNr.Location = new System.Drawing.Point(11, 10);
            this.lblAnstNr.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnstNr.Name = "lblAnstNr";
            this.lblAnstNr.Size = new System.Drawing.Size(157, 20);
            this.lblAnstNr.TabIndex = 6;
            this.lblAnstNr.Text = "Anställningsnummer:";
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(165, 8);
            this.txtAnvandarnamn.Margin = new System.Windows.Forms.Padding(5);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(19, 26);
            this.txtAnvandarnamn.TabIndex = 7;
            // 
            // btnKundregister
            // 
            this.btnKundregister.Location = new System.Drawing.Point(141, 444);
            this.btnKundregister.Margin = new System.Windows.Forms.Padding(5);
            this.btnKundregister.Name = "btnKundregister";
            this.btnKundregister.Size = new System.Drawing.Size(546, 45);
            this.btnKundregister.TabIndex = 8;
            this.btnKundregister.Text = "Kundregister";
            this.btnKundregister.UseVisualStyleBackColor = true;
            this.btnKundregister.Click += new System.EventHandler(this.btnKundregister_Click);
            // 
            // HuvudMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::NetFramework.Properties.Resources.v1_txt2img_77f610f8_523e_4179_b8c4_568ee1e75053;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 576);
            this.Controls.Add(this.btnKundregister);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.lblAnstNr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnMarknad);
            this.Controls.Add(this.btnUthyrning);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button btnKundregister;
    }
}