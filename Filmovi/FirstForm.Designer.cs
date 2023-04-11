namespace Filmovi
{
    partial class FirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.buttonRegistracija = new System.Windows.Forms.Button();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegistracija
            // 
            this.buttonRegistracija.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonRegistracija.FlatAppearance.BorderSize = 0;
            this.buttonRegistracija.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistracija.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonRegistracija.Location = new System.Drawing.Point(152, 500);
            this.buttonRegistracija.Name = "buttonRegistracija";
            this.buttonRegistracija.Size = new System.Drawing.Size(150, 60);
            this.buttonRegistracija.TabIndex = 0;
            this.buttonRegistracija.Text = "Registracija";
            this.buttonRegistracija.UseVisualStyleBackColor = false;
            this.buttonRegistracija.Click += new System.EventHandler(this.buttonRegistracija_Click_1);
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonPrijava.FlatAppearance.BorderSize = 0;
            this.buttonPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrijava.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.buttonPrijava.Location = new System.Drawing.Point(453, 500);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(150, 60);
            this.buttonPrijava.TabIndex = 1;
            this.buttonPrijava.Text = "Prijava";
            this.buttonPrijava.UseVisualStyleBackColor = false;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click_1);
            // 
            // FirstForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(741, 628);
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.buttonRegistracija);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieWeek";
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Button buttonRegistracija;
        private System.Windows.Forms.Button buttonPrijava;
    }
}