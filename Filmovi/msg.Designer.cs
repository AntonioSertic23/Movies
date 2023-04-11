namespace Filmovi
{
    partial class msg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(msg));
            this.btnuredumessagebox = new System.Windows.Forms.Button();
            this.lbltextmessagebox = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnuredumessagebox
            // 
            this.btnuredumessagebox.BackColor = System.Drawing.Color.GreenYellow;
            this.btnuredumessagebox.FlatAppearance.BorderSize = 0;
            this.btnuredumessagebox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnuredumessagebox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuredumessagebox.ForeColor = System.Drawing.Color.Black;
            this.btnuredumessagebox.Location = new System.Drawing.Point(222, 163);
            this.btnuredumessagebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnuredumessagebox.Name = "btnuredumessagebox";
            this.btnuredumessagebox.Size = new System.Drawing.Size(128, 43);
            this.btnuredumessagebox.TabIndex = 4;
            this.btnuredumessagebox.Text = "Uredu";
            this.btnuredumessagebox.UseVisualStyleBackColor = false;
            this.btnuredumessagebox.Click += new System.EventHandler(this.btnuredumessagebox_Click);
            // 
            // lbltextmessagebox
            // 
            this.lbltextmessagebox.AutoSize = true;
            this.lbltextmessagebox.BackColor = System.Drawing.Color.Transparent;
            this.lbltextmessagebox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextmessagebox.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbltextmessagebox.Location = new System.Drawing.Point(42, 72);
            this.lbltextmessagebox.Name = "lbltextmessagebox";
            this.lbltextmessagebox.Size = new System.Drawing.Size(57, 23);
            this.lbltextmessagebox.TabIndex = 8;
            this.lbltextmessagebox.Text = "text..";
            this.lbltextmessagebox.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbltextmessagebox);
            this.panel1.Controls.Add(this.btnuredumessagebox);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 240);
            this.panel1.TabIndex = 9;
            // 
            // msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(573, 244);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "msg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "msg";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnuredumessagebox;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbltextmessagebox;
    }
}