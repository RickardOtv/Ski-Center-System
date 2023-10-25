namespace NetFramework
{
    partial class UthyrningsMeny
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisaUthyrningar = new System.Windows.Forms.Button();
            this.btnSkapaUthyrning = new System.Windows.Forms.Button();
            this.btnBokaSkidlektion = new System.Windows.Forms.Button();
            this.btnÅterlämning = new System.Windows.Forms.Button();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnvandarnamn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Antällningsnummer:";
            // 
            // btnVisaUthyrningar
            // 
            this.btnVisaUthyrningar.Location = new System.Drawing.Point(462, 274);
            this.btnVisaUthyrningar.Name = "btnVisaUthyrningar";
            this.btnVisaUthyrningar.Size = new System.Drawing.Size(330, 52);
            this.btnVisaUthyrningar.TabIndex = 11;
            this.btnVisaUthyrningar.Text = "Visa Uthyrningar";
            this.btnVisaUthyrningar.UseVisualStyleBackColor = true;
            this.btnVisaUthyrningar.Click += new System.EventHandler(this.btnVisaUthyrningar_Click);
            // 
            // btnSkapaUthyrning
            // 
            this.btnSkapaUthyrning.Location = new System.Drawing.Point(462, 357);
            this.btnSkapaUthyrning.Name = "btnSkapaUthyrning";
            this.btnSkapaUthyrning.Size = new System.Drawing.Size(330, 58);
            this.btnSkapaUthyrning.TabIndex = 12;
            this.btnSkapaUthyrning.Text = "Skapa Uthyrning";
            this.btnSkapaUthyrning.UseVisualStyleBackColor = true;
            this.btnSkapaUthyrning.Click += new System.EventHandler(this.btnSkapaUthyrning_Click);
            // 
            // btnBokaSkidlektion
            // 
            this.btnBokaSkidlektion.Location = new System.Drawing.Point(462, 451);
            this.btnBokaSkidlektion.Name = "btnBokaSkidlektion";
            this.btnBokaSkidlektion.Size = new System.Drawing.Size(330, 54);
            this.btnBokaSkidlektion.TabIndex = 13;
            this.btnBokaSkidlektion.Text = "Boka Skidlektion";
            this.btnBokaSkidlektion.UseVisualStyleBackColor = true;
            this.btnBokaSkidlektion.Click += new System.EventHandler(this.btnBokaSkidlektion_Click);
            // 
            // btnÅterlämning
            // 
            this.btnÅterlämning.Location = new System.Drawing.Point(462, 538);
            this.btnÅterlämning.Name = "btnÅterlämning";
            this.btnÅterlämning.Size = new System.Drawing.Size(330, 48);
            this.btnÅterlämning.TabIndex = 14;
            this.btnÅterlämning.Text = "Återlämning";
            this.btnÅterlämning.UseVisualStyleBackColor = true;
            this.btnÅterlämning.Click += new System.EventHandler(this.btnÅterlämning_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(305, 606);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(75, 23);
            this.btnTillbaka.TabIndex = 16;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 39);
            this.label3.TabIndex = 17;
            this.label3.Text = "Uthyrning";
            // 
            // txtAnvandarnamn
            // 
            this.txtAnvandarnamn.Location = new System.Drawing.Point(98, 2);
            this.txtAnvandarnamn.Name = "txtAnvandarnamn";
            this.txtAnvandarnamn.Size = new System.Drawing.Size(18, 20);
            this.txtAnvandarnamn.TabIndex = 18;
            // 
            // UthyrningsMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 808);
            this.Controls.Add(this.txtAnvandarnamn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.btnÅterlämning);
            this.Controls.Add(this.btnBokaSkidlektion);
            this.Controls.Add(this.btnSkapaUthyrning);
            this.Controls.Add(this.btnVisaUthyrningar);
            this.Controls.Add(this.label1);
            this.Name = "UthyrningsMeny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UthyrningsMeny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVisaUthyrningar;
        private System.Windows.Forms.Button btnSkapaUthyrning;
        private System.Windows.Forms.Button btnBokaSkidlektion;
        private System.Windows.Forms.Button btnÅterlämning;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnvandarnamn;
    }
}