namespace Filmovi
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.ButtonPretrazi = new System.Windows.Forms.Button();
            this.DataGridViewFilmovi = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelBrojStranice = new System.Windows.Forms.Label();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelBrojStraniceBaza = new System.Windows.Forms.Label();
            this.buttonRightBaza = new System.Windows.Forms.Button();
            this.buttonLeftBaza = new System.Windows.Forms.Button();
            this.dataGridViewMojiFilmovi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxZanr = new System.Windows.Forms.TextBox();
            this.textBoxGodina = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonTrazi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Žanr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VasaOcjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImdbOcjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFilmovi)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMojiFilmovi)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(113, 22);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(200, 28);
            this.textBoxTitle.TabIndex = 0;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBoxYear.Location = new System.Drawing.Point(447, 23);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(200, 28);
            this.textBoxYear.TabIndex = 1;
            // 
            // ButtonPretrazi
            // 
            this.ButtonPretrazi.BackColor = System.Drawing.Color.GreenYellow;
            this.ButtonPretrazi.FlatAppearance.BorderSize = 0;
            this.ButtonPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonPretrazi.ForeColor = System.Drawing.Color.Black;
            this.ButtonPretrazi.Location = new System.Drawing.Point(703, 14);
            this.ButtonPretrazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonPretrazi.Name = "ButtonPretrazi";
            this.ButtonPretrazi.Size = new System.Drawing.Size(128, 43);
            this.ButtonPretrazi.TabIndex = 3;
            this.ButtonPretrazi.Text = "Pretraži";
            this.ButtonPretrazi.UseVisualStyleBackColor = false;
            this.ButtonPretrazi.Click += new System.EventHandler(this.ButtonPretrazi_Click);
            // 
            // DataGridViewFilmovi
            // 
            this.DataGridViewFilmovi.AllowUserToAddRows = false;
            this.DataGridViewFilmovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewFilmovi.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridViewFilmovi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewFilmovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Year});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewFilmovi.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewFilmovi.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DataGridViewFilmovi.Location = new System.Drawing.Point(100, 180);
            this.DataGridViewFilmovi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewFilmovi.Name = "DataGridViewFilmovi";
            this.DataGridViewFilmovi.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewFilmovi.RowTemplate.Height = 24;
            this.DataGridViewFilmovi.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewFilmovi.Size = new System.Drawing.Size(900, 331);
            this.DataGridViewFilmovi.TabIndex = 4;
            this.DataGridViewFilmovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewFilmovi_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 32);
            this.tabControl1.Location = new System.Drawing.Point(-3, 73);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 614);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.labelBrojStranice);
            this.tabPage1.Controls.Add(this.buttonRight);
            this.tabPage1.Controls.Add(this.buttonLeft);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.DataGridViewFilmovi);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tabPage1.ForeColor = System.Drawing.Color.GreenYellow;
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1078, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pretraži filmove";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // labelBrojStranice
            // 
            this.labelBrojStranice.AutoSize = true;
            this.labelBrojStranice.Location = new System.Drawing.Point(535, 526);
            this.labelBrojStranice.Name = "labelBrojStranice";
            this.labelBrojStranice.Size = new System.Drawing.Size(21, 23);
            this.labelBrojStranice.TabIndex = 11;
            this.labelBrojStranice.Text = "0";
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRight.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRight.ForeColor = System.Drawing.Color.Black;
            this.buttonRight.Location = new System.Drawing.Point(616, 526);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 30);
            this.buttonRight.TabIndex = 10;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonLeft.Enabled = false;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLeft.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeft.ForeColor = System.Drawing.Color.Black;
            this.buttonLeft.Location = new System.Drawing.Point(435, 526);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 30);
            this.buttonLeft.TabIndex = 9;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxTitle);
            this.panel1.Controls.Add(this.ButtonPretrazi);
            this.panel1.Controls.Add(this.textBoxYear);
            this.panel1.Location = new System.Drawing.Point(100, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 75);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Godina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pretraživanje filmova";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.labelBrojStraniceBaza);
            this.tabPage2.Controls.Add(this.buttonRightBaza);
            this.tabPage2.Controls.Add(this.buttonLeftBaza);
            this.tabPage2.Controls.Add(this.dataGridViewMojiFilmovi);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1078, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Moji filmovi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelBrojStraniceBaza
            // 
            this.labelBrojStraniceBaza.AutoSize = true;
            this.labelBrojStraniceBaza.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelBrojStraniceBaza.Location = new System.Drawing.Point(535, 526);
            this.labelBrojStraniceBaza.Name = "labelBrojStraniceBaza";
            this.labelBrojStraniceBaza.Size = new System.Drawing.Size(21, 23);
            this.labelBrojStraniceBaza.TabIndex = 12;
            this.labelBrojStraniceBaza.Text = "0";
            // 
            // buttonRightBaza
            // 
            this.buttonRightBaza.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonRightBaza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRightBaza.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRightBaza.ForeColor = System.Drawing.Color.Black;
            this.buttonRightBaza.Location = new System.Drawing.Point(616, 526);
            this.buttonRightBaza.Name = "buttonRightBaza";
            this.buttonRightBaza.Size = new System.Drawing.Size(75, 30);
            this.buttonRightBaza.TabIndex = 11;
            this.buttonRightBaza.Text = ">";
            this.buttonRightBaza.UseVisualStyleBackColor = false;
            this.buttonRightBaza.Click += new System.EventHandler(this.buttonRightBaza_Click);
            // 
            // buttonLeftBaza
            // 
            this.buttonLeftBaza.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonLeftBaza.Enabled = false;
            this.buttonLeftBaza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLeftBaza.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeftBaza.ForeColor = System.Drawing.Color.Black;
            this.buttonLeftBaza.Location = new System.Drawing.Point(435, 526);
            this.buttonLeftBaza.Name = "buttonLeftBaza";
            this.buttonLeftBaza.Size = new System.Drawing.Size(75, 30);
            this.buttonLeftBaza.TabIndex = 10;
            this.buttonLeftBaza.Text = "<";
            this.buttonLeftBaza.UseVisualStyleBackColor = false;
            this.buttonLeftBaza.Click += new System.EventHandler(this.buttonLeftBaza_Click);
            // 
            // dataGridViewMojiFilmovi
            // 
            this.dataGridViewMojiFilmovi.AllowUserToAddRows = false;
            this.dataGridViewMojiFilmovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMojiFilmovi.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewMojiFilmovi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMojiFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMojiFilmovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Žanr,
            this.Godina,
            this.VasaOcjena,
            this.ImdbOcjena});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMojiFilmovi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMojiFilmovi.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewMojiFilmovi.Location = new System.Drawing.Point(63, 174);
            this.dataGridViewMojiFilmovi.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMojiFilmovi.Name = "dataGridViewMojiFilmovi";
            this.dataGridViewMojiFilmovi.Size = new System.Drawing.Size(949, 332);
            this.dataGridViewMojiFilmovi.TabIndex = 4;
            this.dataGridViewMojiFilmovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMojiFilmovi_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxZanr);
            this.panel2.Controls.Add(this.textBoxGodina);
            this.panel2.Controls.Add(this.textBoxIme);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.buttonTrazi);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(37, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 75);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.GreenYellow;
            this.label9.Location = new System.Drawing.Point(456, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Žanr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(216, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Godina:";
            // 
            // textBoxZanr
            // 
            this.textBoxZanr.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBoxZanr.Location = new System.Drawing.Point(519, 26);
            this.textBoxZanr.Name = "textBoxZanr";
            this.textBoxZanr.Size = new System.Drawing.Size(140, 28);
            this.textBoxZanr.TabIndex = 8;
            // 
            // textBoxGodina
            // 
            this.textBoxGodina.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBoxGodina.Location = new System.Drawing.Point(310, 26);
            this.textBoxGodina.Name = "textBoxGodina";
            this.textBoxGodina.Size = new System.Drawing.Size(140, 28);
            this.textBoxGodina.TabIndex = 7;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBoxIme.Location = new System.Drawing.Point(70, 25);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(140, 28);
            this.textBoxIme.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.GreenYellow;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(851, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 43);
            this.button6.TabIndex = 5;
            this.button6.Text = "Ažuriraj ocjenu";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonTrazi
            // 
            this.buttonTrazi.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonTrazi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTrazi.Location = new System.Drawing.Point(692, 18);
            this.buttonTrazi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTrazi.Name = "buttonTrazi";
            this.buttonTrazi.Size = new System.Drawing.Size(128, 43);
            this.buttonTrazi.TabIndex = 1;
            this.buttonTrazi.Text = "Traži";
            this.buttonTrazi.UseVisualStyleBackColor = false;
            this.buttonTrazi.Click += new System.EventHandler(this.buttonTrazi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.GreenYellow;
            this.label8.Location = new System.Drawing.Point(12, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ime:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.label7.ForeColor = System.Drawing.Color.GreenYellow;
            this.label7.Location = new System.Drawing.Point(447, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "Moji filmovi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(32, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "MovieWeek";
            this.label2.UseWaitCursor = true;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button5.ForeColor = System.Drawing.Color.GreenYellow;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 45);
            this.button5.TabIndex = 8;
            this.button5.Text = "@Username";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnLogOut);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(916, 12);
            this.panel3.MaximumSize = new System.Drawing.Size(144, 91);
            this.panel3.MinimumSize = new System.Drawing.Size(144, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 45);
            this.panel3.TabIndex = 9;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnLogOut.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnLogOut.Location = new System.Drawing.Point(0, 45);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(144, 45);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Odjava";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "imeFilma";
            this.Ime.FillWeight = 212.0632F;
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Žanr
            // 
            this.Žanr.FillWeight = 126.9036F;
            this.Žanr.HeaderText = "Žanr";
            this.Žanr.Name = "Žanr";
            this.Žanr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Godina
            // 
            this.Godina.DataPropertyName = "godinaFilma";
            this.Godina.FillWeight = 58.83698F;
            this.Godina.HeaderText = "Godina";
            this.Godina.Name = "Godina";
            this.Godina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VasaOcjena
            // 
            this.VasaOcjena.FillWeight = 50.80568F;
            this.VasaOcjena.HeaderText = "Vaša ocjena";
            this.VasaOcjena.Name = "VasaOcjena";
            this.VasaOcjena.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ImdbOcjena
            // 
            this.ImdbOcjena.FillWeight = 51.39057F;
            this.ImdbOcjena.HeaderText = "IMDB ocjena";
            this.ImdbOcjena.Name = "ImdbOcjena";
            this.ImdbOcjena.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Ime";
            this.Title.Name = "Title";
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Godina";
            this.Year.Name = "Year";
            this.Year.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1081, 687);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieWeek";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFilmovi)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMojiFilmovi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button ButtonPretrazi;
        public System.Windows.Forms.DataGridView DataGridViewFilmovi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonTrazi;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogOut;
        public System.Windows.Forms.DataGridView dataGridViewMojiFilmovi;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBoxZanr;
        private System.Windows.Forms.TextBox textBoxGodina;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        public System.Windows.Forms.Label labelBrojStranice;
        public System.Windows.Forms.Label labelBrojStraniceBaza;
        private System.Windows.Forms.Button buttonRightBaza;
        private System.Windows.Forms.Button buttonLeftBaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Žanr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godina;
        private System.Windows.Forms.DataGridViewTextBoxColumn VasaOcjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImdbOcjena;
    }
}

