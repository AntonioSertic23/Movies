namespace Filmovi
{
    partial class FormAboutMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutMovie));
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProdukcija = new System.Windows.Forms.Label();
            this.lblNagrade = new System.Windows.Forms.Label();
            this.lblPremijera = new System.Windows.Forms.Label();
            this.lblGlumci = new System.Windows.Forms.Label();
            this.lblScenarist = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.movieTitle = new System.Windows.Forms.Label();
            this.lblimdb = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.movieYear = new System.Windows.Forms.Label();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSpremi = new System.Windows.Forms.Button();
            this.textBoxOcjena = new System.Windows.Forms.TextBox();
            this.movieMyVote = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label5.ForeColor = System.Drawing.Color.GreenYellow;
            this.label5.Location = new System.Drawing.Point(262, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(354, 49);
            this.label5.TabIndex = 10;
            this.label5.Text = "Odabrali ste film:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonSpremi);
            this.panel2.Controls.Add(this.textBoxOcjena);
            this.panel2.Controls.Add(this.movieMyVote);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.panel2.ForeColor = System.Drawing.Color.GreenYellow;
            this.panel2.Location = new System.Drawing.Point(28, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 635);
            this.panel2.TabIndex = 11;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(27, 494);
            this.buttonDelete.MinimumSize = new System.Drawing.Size(60, 60);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(60, 60);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "/10";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblProdukcija);
            this.panel1.Controls.Add(this.lblNagrade);
            this.panel1.Controls.Add(this.lblPremijera);
            this.panel1.Controls.Add(this.lblGlumci);
            this.panel1.Controls.Add(this.lblScenarist);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
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
            this.panel1.Size = new System.Drawing.Size(462, 579);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblProdukcija
            // 
            this.lblProdukcija.AutoSize = true;
            this.lblProdukcija.Location = new System.Drawing.Point(138, 485);
            this.lblProdukcija.MaximumSize = new System.Drawing.Size(320, 60);
            this.lblProdukcija.Name = "lblProdukcija";
            this.lblProdukcija.Size = new System.Drawing.Size(115, 23);
            this.lblProdukcija.TabIndex = 27;
            this.lblProdukcija.Text = "Production";
            // 
            // lblNagrade
            // 
            this.lblNagrade.AutoSize = true;
            this.lblNagrade.Location = new System.Drawing.Point(127, 424);
            this.lblNagrade.MaximumSize = new System.Drawing.Size(320, 60);
            this.lblNagrade.Name = "lblNagrade";
            this.lblNagrade.Size = new System.Drawing.Size(85, 23);
            this.lblNagrade.TabIndex = 26;
            this.lblNagrade.Text = "Awards";
            // 
            // lblPremijera
            // 
            this.lblPremijera.AutoSize = true;
            this.lblPremijera.Location = new System.Drawing.Point(127, 326);
            this.lblPremijera.Name = "lblPremijera";
            this.lblPremijera.Size = new System.Drawing.Size(102, 23);
            this.lblPremijera.TabIndex = 25;
            this.lblPremijera.Text = "Released";
            // 
            // lblGlumci
            // 
            this.lblGlumci.AutoSize = true;
            this.lblGlumci.Location = new System.Drawing.Point(107, 228);
            this.lblGlumci.MaximumSize = new System.Drawing.Size(330, 60);
            this.lblGlumci.Name = "lblGlumci";
            this.lblGlumci.Size = new System.Drawing.Size(72, 23);
            this.lblGlumci.TabIndex = 24;
            this.lblGlumci.Text = "Actors";
            // 
            // lblScenarist
            // 
            this.lblScenarist.AutoSize = true;
            this.lblScenarist.Location = new System.Drawing.Point(124, 177);
            this.lblScenarist.MaximumSize = new System.Drawing.Size(320, 60);
            this.lblScenarist.Name = "lblScenarist";
            this.lblScenarist.Size = new System.Drawing.Size(62, 23);
            this.lblScenarist.TabIndex = 23;
            this.lblScenarist.Text = "Writer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(17, 485);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Produkcija:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(17, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nagrade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(17, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Glumci:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(17, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Scenarist:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(17, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Premijera:";
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
            // lblimdb
            // 
            this.lblimdb.AutoSize = true;
            this.lblimdb.Location = new System.Drawing.Point(86, 527);
            this.lblimdb.Name = "lblimdb";
            this.lblimdb.Size = new System.Drawing.Size(58, 23);
            this.lblimdb.TabIndex = 17;
            this.lblimdb.Text = "IMDB";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.ForeColor = System.Drawing.Color.Lime;
            this.lbl4.Location = new System.Drawing.Point(17, 527);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(63, 23);
            this.lbl4.TabIndex = 13;
            this.lbl4.Text = "IMDB:";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(119, 135);
            this.lblDirector.MaximumSize = new System.Drawing.Size(320, 26);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(86, 23);
            this.lblDirector.TabIndex = 16;
            this.lblDirector.Text = "Director";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(17, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Godina:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(81, 76);
            this.lblGenre.MaximumSize = new System.Drawing.Size(360, 60);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(71, 23);
            this.lblGenre.TabIndex = 15;
            this.lblGenre.Text = "Genre";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.ForeColor = System.Drawing.Color.Lime;
            this.lbl3.Location = new System.Drawing.Point(17, 135);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(96, 23);
            this.lbl3.TabIndex = 12;
            this.lbl3.Text = "Redatelj:";
            // 
            // movieYear
            // 
            this.movieYear.AutoSize = true;
            this.movieYear.Location = new System.Drawing.Point(110, 284);
            this.movieYear.Name = "movieYear";
            this.movieYear.Size = new System.Drawing.Size(56, 23);
            this.movieYear.TabIndex = 1;
            this.movieYear.Text = "Year";
            // 
            // lblRuntime
            // 
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Location = new System.Drawing.Point(110, 374);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(88, 23);
            this.lblRuntime.TabIndex = 14;
            this.lblRuntime.Text = "Runtime";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.Color.Lime;
            this.lbl1.Location = new System.Drawing.Point(17, 374);
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
            // buttonSpremi
            // 
            this.buttonSpremi.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonSpremi.FlatAppearance.BorderSize = 0;
            this.buttonSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSpremi.ForeColor = System.Drawing.Color.Black;
            this.buttonSpremi.Location = new System.Drawing.Point(147, 494);
            this.buttonSpremi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(149, 60);
            this.buttonSpremi.TabIndex = 3;
            this.buttonSpremi.Text = "Spremi";
            this.buttonSpremi.UseVisualStyleBackColor = false;
            this.buttonSpremi.Click += new System.EventHandler(this.buttonSpremi_Click);
            // 
            // textBoxOcjena
            // 
            this.textBoxOcjena.Location = new System.Drawing.Point(190, 421);
            this.textBoxOcjena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOcjena.Name = "textBoxOcjena";
            this.textBoxOcjena.Size = new System.Drawing.Size(51, 32);
            this.textBoxOcjena.TabIndex = 4;
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
            // FormAboutMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(865, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAboutMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAboutMovie";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label movieTitle;
        public System.Windows.Forms.Label lblimdb;
        private System.Windows.Forms.Label lbl4;
        public System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lbl3;
        public System.Windows.Forms.Label movieYear;
        public System.Windows.Forms.Label lblRuntime;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSpremi;
        private System.Windows.Forms.Label movieMyVote;
        public System.Windows.Forms.Label lblProdukcija;
        public System.Windows.Forms.Label lblNagrade;
        public System.Windows.Forms.Label lblPremijera;
        public System.Windows.Forms.Label lblGlumci;
        public System.Windows.Forms.Label lblScenarist;
        public System.Windows.Forms.TextBox textBoxOcjena;
        public System.Windows.Forms.Button buttonDelete;
    }
}