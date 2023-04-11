namespace Filmovi
{
    partial class PrijavaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrijavaForma));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrijavaPrijava = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.inptLozinkaPrijava = new System.Windows.Forms.TextBox();
            this.inptKorisnickoImePrijava = new System.Windows.Forms.TextBox();
            this.btnPrijavaNatrag = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(236, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prijavite se";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(40, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korisničko ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(104, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lozinka:";
            // 
            // btnPrijavaPrijava
            // 
            this.btnPrijavaPrijava.BackColor = System.Drawing.Color.GreenYellow;
            this.btnPrijavaPrijava.FlatAppearance.BorderSize = 0;
            this.btnPrijavaPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrijavaPrijava.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnPrijavaPrijava.Location = new System.Drawing.Point(407, 466);
            this.btnPrijavaPrijava.Name = "btnPrijavaPrijava";
            this.btnPrijavaPrijava.Size = new System.Drawing.Size(150, 60);
            this.btnPrijavaPrijava.TabIndex = 3;
            this.btnPrijavaPrijava.Text = "Prijava";
            this.btnPrijavaPrijava.UseVisualStyleBackColor = false;
            this.btnPrijavaPrijava.Click += new System.EventHandler(this.btnPrijavaPrijava_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxPassword);
            this.panel1.Controls.Add(this.inptLozinkaPrijava);
            this.panel1.Controls.Add(this.inptKorisnickoImePrijava);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(100, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 300);
            this.panel1.TabIndex = 4;
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPassword.ForeColor = System.Drawing.Color.GreenYellow;
            this.checkBoxPassword.Location = new System.Drawing.Point(374, 210);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(82, 24);
            this.checkBoxPassword.TabIndex = 5;
            this.checkBoxPassword.Text = "Prikaži";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            // 
            // inptLozinkaPrijava
            // 
            this.inptLozinkaPrijava.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.inptLozinkaPrijava.Location = new System.Drawing.Point(223, 176);
            this.inptLozinkaPrijava.Name = "inptLozinkaPrijava";
            this.inptLozinkaPrijava.Size = new System.Drawing.Size(233, 28);
            this.inptLozinkaPrijava.TabIndex = 4;
            this.inptLozinkaPrijava.UseSystemPasswordChar = true;
            // 
            // inptKorisnickoImePrijava
            // 
            this.inptKorisnickoImePrijava.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.inptKorisnickoImePrijava.Location = new System.Drawing.Point(223, 87);
            this.inptKorisnickoImePrijava.Name = "inptKorisnickoImePrijava";
            this.inptKorisnickoImePrijava.Size = new System.Drawing.Size(233, 28);
            this.inptKorisnickoImePrijava.TabIndex = 3;
            // 
            // btnPrijavaNatrag
            // 
            this.btnPrijavaNatrag.BackColor = System.Drawing.Color.GreenYellow;
            this.btnPrijavaNatrag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrijavaNatrag.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnPrijavaNatrag.Location = new System.Drawing.Point(145, 466);
            this.btnPrijavaNatrag.Name = "btnPrijavaNatrag";
            this.btnPrijavaNatrag.Size = new System.Drawing.Size(150, 60);
            this.btnPrijavaNatrag.TabIndex = 5;
            this.btnPrijavaNatrag.Text = "Natrag";
            this.btnPrijavaNatrag.UseVisualStyleBackColor = false;
            this.btnPrijavaNatrag.Click += new System.EventHandler(this.btnPrijavaNatrag_Click);
            // 
            // PrijavaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(692, 553);
            this.Controls.Add(this.btnPrijavaNatrag);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrijavaPrijava);
            this.Controls.Add(this.label1);
            this.Name = "PrijavaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrijavaPrijava;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inptLozinkaPrijava;
        private System.Windows.Forms.TextBox inptKorisnickoImePrijava;
        private System.Windows.Forms.Button btnPrijavaNatrag;
        private System.Windows.Forms.CheckBox checkBoxPassword;
    }
}