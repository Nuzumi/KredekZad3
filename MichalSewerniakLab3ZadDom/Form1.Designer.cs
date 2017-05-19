namespace MichalSewerniakLab3ZadDom
{
    partial class FormCinemas
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonShowAllFilms = new System.Windows.Forms.Button();
            this.buttonShowAllHalls = new System.Windows.Forms.Button();
            this.buttonShowAllCinemas = new System.Windows.Forms.Button();
            this.buttonShowAllEmployy = new System.Windows.Forms.Button();
            this.buttonShowAllProgramme = new System.Windows.Forms.Button();
            this.buttonShowAllHallsOfCinema = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.buttonAddFilm = new System.Windows.Forms.Button();
            this.labelDirector = new System.Windows.Forms.Label();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.buttonDeleteFilm = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelSearchByTitle = new System.Windows.Forms.Label();
            this.textBoxSearchByTitle = new System.Windows.Forms.TextBox();
            this.buttonSortByTitle = new System.Windows.Forms.Button();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelRecords = new System.Windows.Forms.Label();
            this.textBoxTopX = new System.Windows.Forms.TextBox();
            this.buttonShowTop = new System.Windows.Forms.Button();
            this.buttonMean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(631, 306);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonShowAllFilms
            // 
            this.buttonShowAllFilms.Location = new System.Drawing.Point(649, 12);
            this.buttonShowAllFilms.Name = "buttonShowAllFilms";
            this.buttonShowAllFilms.Size = new System.Drawing.Size(78, 46);
            this.buttonShowAllFilms.TabIndex = 1;
            this.buttonShowAllFilms.Text = "wyświetl filmy";
            this.buttonShowAllFilms.UseVisualStyleBackColor = true;
            this.buttonShowAllFilms.Click += new System.EventHandler(this.buttonShowAllFilms_Click);
            // 
            // buttonShowAllHalls
            // 
            this.buttonShowAllHalls.Location = new System.Drawing.Point(649, 64);
            this.buttonShowAllHalls.Name = "buttonShowAllHalls";
            this.buttonShowAllHalls.Size = new System.Drawing.Size(78, 46);
            this.buttonShowAllHalls.TabIndex = 2;
            this.buttonShowAllHalls.Text = "wyświetl sale";
            this.buttonShowAllHalls.UseVisualStyleBackColor = true;
            this.buttonShowAllHalls.Click += new System.EventHandler(this.buttonShowAllHalls_Click);
            // 
            // buttonShowAllCinemas
            // 
            this.buttonShowAllCinemas.Location = new System.Drawing.Point(649, 116);
            this.buttonShowAllCinemas.Name = "buttonShowAllCinemas";
            this.buttonShowAllCinemas.Size = new System.Drawing.Size(78, 46);
            this.buttonShowAllCinemas.TabIndex = 3;
            this.buttonShowAllCinemas.Text = "wyświetl kina";
            this.buttonShowAllCinemas.UseVisualStyleBackColor = true;
            this.buttonShowAllCinemas.Click += new System.EventHandler(this.buttonShowAllCinemas_Click);
            // 
            // buttonShowAllEmployy
            // 
            this.buttonShowAllEmployy.Location = new System.Drawing.Point(649, 168);
            this.buttonShowAllEmployy.Name = "buttonShowAllEmployy";
            this.buttonShowAllEmployy.Size = new System.Drawing.Size(78, 46);
            this.buttonShowAllEmployy.TabIndex = 4;
            this.buttonShowAllEmployy.Text = "wyświetl pracowników";
            this.buttonShowAllEmployy.UseVisualStyleBackColor = true;
            this.buttonShowAllEmployy.Click += new System.EventHandler(this.buttonShowAllEmployy_Click);
            // 
            // buttonShowAllProgramme
            // 
            this.buttonShowAllProgramme.Location = new System.Drawing.Point(649, 220);
            this.buttonShowAllProgramme.Name = "buttonShowAllProgramme";
            this.buttonShowAllProgramme.Size = new System.Drawing.Size(78, 46);
            this.buttonShowAllProgramme.TabIndex = 5;
            this.buttonShowAllProgramme.Text = "wyświetl program";
            this.buttonShowAllProgramme.UseVisualStyleBackColor = true;
            this.buttonShowAllProgramme.Click += new System.EventHandler(this.buttonShowAllProgramme_Click);
            // 
            // buttonShowAllHallsOfCinema
            // 
            this.buttonShowAllHallsOfCinema.Location = new System.Drawing.Point(649, 272);
            this.buttonShowAllHallsOfCinema.Name = "buttonShowAllHallsOfCinema";
            this.buttonShowAllHallsOfCinema.Size = new System.Drawing.Size(78, 46);
            this.buttonShowAllHallsOfCinema.TabIndex = 6;
            this.buttonShowAllHallsOfCinema.Text = "wyświetl sale kin";
            this.buttonShowAllHallsOfCinema.UseVisualStyleBackColor = true;
            this.buttonShowAllHallsOfCinema.Click += new System.EventHandler(this.buttonShowAllHallsOfCinema_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(9, 334);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(28, 13);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "tytuł";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(9, 390);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(46, 13);
            this.labelLength.TabIndex = 8;
            this.labelLength.Text = "długość";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(61, 334);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 9;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(61, 387);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxLength.TabIndex = 10;
            // 
            // buttonAddFilm
            // 
            this.buttonAddFilm.Location = new System.Drawing.Point(186, 331);
            this.buttonAddFilm.Name = "buttonAddFilm";
            this.buttonAddFilm.Size = new System.Drawing.Size(75, 76);
            this.buttonAddFilm.TabIndex = 11;
            this.buttonAddFilm.Text = "dodaj film";
            this.buttonAddFilm.UseVisualStyleBackColor = true;
            this.buttonAddFilm.Click += new System.EventHandler(this.buttonAddFilm_Click);
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(9, 361);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(40, 13);
            this.labelDirector.TabIndex = 12;
            this.labelDirector.Text = "reżyser";
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(61, 361);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(100, 20);
            this.textBoxDirector.TabIndex = 13;
            // 
            // buttonDeleteFilm
            // 
            this.buttonDeleteFilm.Location = new System.Drawing.Point(268, 331);
            this.buttonDeleteFilm.Name = "buttonDeleteFilm";
            this.buttonDeleteFilm.Size = new System.Drawing.Size(75, 76);
            this.buttonDeleteFilm.TabIndex = 14;
            this.buttonDeleteFilm.Text = "usuń film";
            this.buttonDeleteFilm.UseVisualStyleBackColor = true;
            this.buttonDeleteFilm.Click += new System.EventHandler(this.buttonDeleteFilm_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(374, 337);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 15;
            this.labelID.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(401, 333);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(28, 20);
            this.textBoxID.TabIndex = 16;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(367, 361);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(62, 46);
            this.buttonUpdate.TabIndex = 17;
            this.buttonUpdate.Text = "aktualizuj";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelSearchByTitle
            // 
            this.labelSearchByTitle.AutoSize = true;
            this.labelSearchByTitle.Location = new System.Drawing.Point(474, 334);
            this.labelSearchByTitle.Name = "labelSearchByTitle";
            this.labelSearchByTitle.Size = new System.Drawing.Size(99, 13);
            this.labelSearchByTitle.TabIndex = 18;
            this.labelSearchByTitle.Text = "tytul do wyszukania";
            // 
            // textBoxSearchByTitle
            // 
            this.textBoxSearchByTitle.Location = new System.Drawing.Point(473, 361);
            this.textBoxSearchByTitle.Name = "textBoxSearchByTitle";
            this.textBoxSearchByTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchByTitle.TabIndex = 19;
            this.textBoxSearchByTitle.TextChanged += new System.EventHandler(this.textBoxSearchByTitle_TextChanged);
            // 
            // buttonSortByTitle
            // 
            this.buttonSortByTitle.Location = new System.Drawing.Point(649, 361);
            this.buttonSortByTitle.Name = "buttonSortByTitle";
            this.buttonSortByTitle.Size = new System.Drawing.Size(75, 23);
            this.buttonSortByTitle.TabIndex = 20;
            this.buttonSortByTitle.Text = "sortuj filmy";
            this.buttonSortByTitle.UseVisualStyleBackColor = true;
            this.buttonSortByTitle.Click += new System.EventHandler(this.buttonSortByTitle_Click);
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Location = new System.Drawing.Point(12, 441);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(48, 13);
            this.labelTop.TabIndex = 21;
            this.labelTop.Text = "pierwsze";
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Location = new System.Drawing.Point(101, 441);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(41, 13);
            this.labelRecords.TabIndex = 22;
            this.labelRecords.Text = "wierszy";
            // 
            // textBoxTopX
            // 
            this.textBoxTopX.Location = new System.Drawing.Point(64, 438);
            this.textBoxTopX.Name = "textBoxTopX";
            this.textBoxTopX.Size = new System.Drawing.Size(31, 20);
            this.textBoxTopX.TabIndex = 23;
            // 
            // buttonShowTop
            // 
            this.buttonShowTop.Location = new System.Drawing.Point(148, 438);
            this.buttonShowTop.Name = "buttonShowTop";
            this.buttonShowTop.Size = new System.Drawing.Size(75, 23);
            this.buttonShowTop.TabIndex = 24;
            this.buttonShowTop.Text = "pokaz";
            this.buttonShowTop.UseVisualStyleBackColor = true;
            this.buttonShowTop.Click += new System.EventHandler(this.buttonShowTop_Click);
            // 
            // buttonMean
            // 
            this.buttonMean.Location = new System.Drawing.Point(259, 438);
            this.buttonMean.Name = "buttonMean";
            this.buttonMean.Size = new System.Drawing.Size(118, 23);
            this.buttonMean.TabIndex = 25;
            this.buttonMean.Text = "srednia dlugosc filmu";
            this.buttonMean.UseVisualStyleBackColor = true;
            this.buttonMean.Click += new System.EventHandler(this.buttonMean_Click);
            // 
            // FormCinemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 470);
            this.Controls.Add(this.buttonMean);
            this.Controls.Add(this.buttonShowTop);
            this.Controls.Add(this.textBoxTopX);
            this.Controls.Add(this.labelRecords);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.buttonSortByTitle);
            this.Controls.Add(this.textBoxSearchByTitle);
            this.Controls.Add(this.labelSearchByTitle);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonDeleteFilm);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.buttonAddFilm);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonShowAllHallsOfCinema);
            this.Controls.Add(this.buttonShowAllProgramme);
            this.Controls.Add(this.buttonShowAllEmployy);
            this.Controls.Add(this.buttonShowAllCinemas);
            this.Controls.Add(this.buttonShowAllHalls);
            this.Controls.Add(this.buttonShowAllFilms);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormCinemas";
            this.Text = "Cinemas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonShowAllFilms;
        private System.Windows.Forms.Button buttonShowAllHalls;
        private System.Windows.Forms.Button buttonShowAllCinemas;
        private System.Windows.Forms.Button buttonShowAllEmployy;
        private System.Windows.Forms.Button buttonShowAllProgramme;
        private System.Windows.Forms.Button buttonShowAllHallsOfCinema;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Button buttonAddFilm;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.Button buttonDeleteFilm;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelSearchByTitle;
        private System.Windows.Forms.TextBox textBoxSearchByTitle;
        private System.Windows.Forms.Button buttonSortByTitle;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labelRecords;
        private System.Windows.Forms.TextBox textBoxTopX;
        private System.Windows.Forms.Button buttonShowTop;
        private System.Windows.Forms.Button buttonMean;
    }
}

