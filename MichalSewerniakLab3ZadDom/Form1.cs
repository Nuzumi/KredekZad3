using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalSewerniakLab3ZadDom
{
    public partial class FormCinemas : Form
    {
        SqlConnection sqlConnection;

        /// <summary>
        /// laczenie sie z baza
        /// </summary>
        public FormCinemas()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=MICHAŁ-KOMPUTER\\SQLEXPRESS; database=Cinemas;Trusted_Connection=yes");
        }

        private void buttonShowAllFilms_Click(object sender, EventArgs e)
        {
            Film.ShowAllFilms(sqlConnection, dataGridView);
        }

        private void buttonShowAllHalls_Click(object sender, EventArgs e)
        {
            Hall.ShowAllHalls(sqlConnection, dataGridView);
        }

        private void buttonShowAllCinemas_Click(object sender, EventArgs e)
        {
            Cinema.ShowAllCinemas(sqlConnection, dataGridView);
        }

        private void buttonShowAllEmployy_Click(object sender, EventArgs e)
        {
            Employy.ShowAllEmployy(sqlConnection, dataGridView);
        }

        private void buttonShowAllProgramme_Click(object sender, EventArgs e)
        {
            Programme.ShowAllProgramme(sqlConnection, dataGridView);
        }

        private void buttonShowAllHallsOfCinema_Click(object sender, EventArgs e)
        {
            HallsOfCinema.ShowAllHallsOfCinema(sqlConnection, dataGridView);
        }

        private void buttonAddFilm_Click(object sender, EventArgs e)
        {
            Film.AddFilm(sqlConnection, dataGridView, textBoxTitle.Text,textBoxDirector.Text, Int32.Parse(textBoxLength.Text));
        }

        private void buttonDeleteFilm_Click(object sender, EventArgs e)
        {
            Film.DeleteFilm(sqlConnection, dataGridView, textBoxTitle.Text);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Film.UpdateFilm(sqlConnection, dataGridView, Int32.Parse(textBoxID.Text), textBoxTitle.Text, textBoxDirector.Text, Int32.Parse(textBoxLength.Text));
        }

        private void textBoxSearchByTitle_TextChanged(object sender, EventArgs e)
        {
            Film.FindByName(sqlConnection, dataGridView, textBoxSearchByTitle.Text);
        }

        private void buttonSortByTitle_Click(object sender, EventArgs e)
        {
            Film.ShowAllFilmsSortByTitle(sqlConnection, dataGridView);
        }

        private void buttonShowTop_Click(object sender, EventArgs e)
        {
            Film.ShowAllFilmsTopX(sqlConnection, dataGridView, Int32.Parse(textBoxTopX.Text));
        }

        private void buttonMean_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Średnia długość filmu: " + Film.ShowMean(sqlConnection));
        }
    }
}
