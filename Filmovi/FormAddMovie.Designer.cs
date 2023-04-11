namespace Filmovi
{
    partial class FormAddMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddMovie));
            this.movieTitle = new System.Windows.Forms.Label();
            this.movieYear = new System.Windows.Forms.Label();
            this.movieMyVote = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.textBoxOcjena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblimdb = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // movieTitle
            // 
            this.movieTitle.AutoSize = true;
            this.movieTitle.Location = new System.Drawing.Point(81, 20);
            this.movieTitle.MaximumSize = new System.Drawing.Size(373, 0);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(46, 23);
            this.movieTitle.TabIndex = 0;
            this.movieTitle.Text = "Title";
            this.movieTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieYear
            // 
            this.movieYear.AutoSize = true;
            this.movieYear.Location = new System.Drawing.Point(116, 186);
            this.movieYear.Name = "movieYear";
            this.movieYear.Size = new System.Drawing.Size(56, 23);
            this.movieYear.TabIndex = 1;
            this.movieYear.Text = "Year";
            // 
            // movieMyVote
            // 
            this.movieMyVote.AutoSize = true;
            this.movieMyVote.Location = new System.Drawing.Point(23, 426);
            this.movieMyVote.Name = "movieMyVote";
            this.movieMyVote.Size = new System.Drawing.Size(140, 23);
            this.movieMyVote.TabIndex = 2;
            this.movieMyVote.Text = "Vaša ocjena:";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonDodaj.FlatAppearance.BorderSize = 0;
            this.buttonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDodaj.ForeColor = System.Drawing.Color.Black;
            this.buttonDodaj.Location = new System.Drawing.Point(487, 407);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(149, 60);
            this.buttonDodaj.TabIndex = 3;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // textBoxOcjena
            // 
            this.textBoxOcjena.Location = new System.Drawing.Point(169, 421);
            this.textBoxOcjena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOcjena.Name = "textBoxOcjena";
            this.textBoxOcjena.Size = new System.Drawing.Size(51, 32);
            this.textBoxOcjena.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(17, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Godina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label5.ForeColor = System.Drawing.Color.GreenYellow;
            this.label5.Location = new System.Drawing.Point(250, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(354, 49);
            this.label5.TabIndex = 9;
            this.label5.Text = "Odabrali ste film:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonDodaj);
            this.panel2.Controls.Add(this.textBoxOcjena);
            this.panel2.Controls.Add(this.movieMyVote);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.panel2.ForeColor = System.Drawing.Color.GreenYellow;
            this.panel2.Location = new System.Drawing.Point(27, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 496);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "/10";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.movieTitle);
            this.panel1.Controls.Add(this.lblimdb);
            this.panel1.Controls.Add(this.lbl4);
            this.panel1.Controls.Add(this.lblDirector);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblGenre);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.movieYear);
            this.panel1.Controls.Add(this.lblRuntime);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Location = new System.Drawing.Point(319, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 350);
            this.panel1.TabIndex = 18;
            // 
            // lblimdb
            // 
            this.lblimdb.AutoSize = true;
            this.lblimdb.Location = new System.Drawing.Point(92, 304);
            this.lblimdb.Name = "lblimdb";
            this.lblimdb.Size = new System.Drawing.Size(58, 23);
            this.lblimdb.TabIndex = 17;
            this.lblimdb.Text = "IMDB";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.ForeColor = System.Drawing.Color.Lime;
            this.lbl4.Location = new System.Drawing.Point(17, 304);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(63, 23);
            this.lbl4.TabIndex = 13;
            this.lbl4.Text = "IMDB:";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(116, 128);
            this.lblDirector.MaximumSize = new System.Drawing.Size(320, 26);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(86, 23);
            this.lblDirector.TabIndex = 16;
            this.lblDirector.Text = "Director";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(81, 76);
            this.lblGenre.MaximumSize = new System.Drawing.Size(360, 26);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(71, 23);
            this.lblGenre.TabIndex = 15;
            this.lblGenre.Text = "Genre";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.ForeColor = System.Drawing.Color.Lime;
            this.lbl3.Location = new System.Drawing.Point(17, 128);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(91, 23);
            this.lbl3.TabIndex = 12;
            this.lbl3.Text = "Director:";
            // 
            // lblRuntime
            // 
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Location = new System.Drawing.Point(112, 242);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(88, 23);
            this.lblRuntime.TabIndex = 14;
            this.lblRuntime.Text = "Runtime";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.Color.Lime;
            this.lbl1.Location = new System.Drawing.Point(17, 242);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(87, 23);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "Vrijeme:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.ForeColor = System.Drawing.Color.Lime;
            this.lbl2.Location = new System.Drawing.Point(17, 76);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(57, 23);
            this.lbl2.TabIndex = 11;
            this.lbl2.Text = "Žanr:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 350);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // FormAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(865, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddMovie";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label movieMyVote;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.TextBox textBoxOcjena;
        public System.Windows.Forms.Label movieTitle;
        public System.Windows.Forms.Label movieYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Label lblimdb;
        public System.Windows.Forms.Label lblDirector;
        public System.Windows.Forms.Label lblGenre;
        public System.Windows.Forms.Label lblRuntime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}