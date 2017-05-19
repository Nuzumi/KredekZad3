
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MichalSewerniakLab3ZadDom
{
    class Film
    {
        private static SqlCommand sqlCommand;

        /// <summary>
        /// zwraca wszystkie dane z tabeli film
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowAllFilms(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT ID,Title AS Tytul, Director AS Reżyser, Length AS długość FROM Film", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        /// <summary>
        /// dodaje film
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="title"></param>
        /// <param name="director"></param>
        /// <param name="length"></param>
        public static void AddFilm(SqlConnection sqlConnection, DataGridView dataGridView, string title,string director, int length)
        {
            try
            {
                sqlConnection.Open();
                string command = $"INSERT INTO Film (Title,Director,Length) values ('{title}','{director}','{length}')";
                sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Dodano");
                ShowAllFilms(sqlConnection, dataGridView);
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Błąd");
            }
        }


        /// <summary>
        /// usuwa film po tytule
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="title"></param>
        public static void DeleteFilm(SqlConnection sqlConnection, DataGridView dataGridView, string title)
        {
            try
            {
                sqlConnection.Open();
                string command = $"DELETE FROM Film WHERE Title = '{title}'";
                sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Usunieto");
                ShowAllFilms(sqlConnection, dataGridView);
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Błąd");
            }
        }


        /// <summary>
        /// robi update danego filmu
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="director"></param>
        /// <param name="length"></param>
        public static void UpdateFilm(SqlConnection sqlConnection, DataGridView dataGridView,int id,string title, string director, int length)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"UPDATE Film SET Title = '{title}' , Director = '{director}' , Length = '{length}' WHERE ID = '{id}'", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
            ShowAllFilms(sqlConnection, dataGridView);
        }

        /// <summary>
        /// wyswietla dane w GridView
        /// </summary>
        /// <param name="sqlDataAdapter"></param>
        /// <param name="dataGridView"></param>
        private static void FillDataGridView(SqlDataAdapter sqlDataAdapter, DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }

        /// <summary>
        /// zwraca film szukany po tytule
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="title"></param>
        public static void FindByName(SqlConnection sqlConnection, DataGridView dataGridView, string title)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT* FROM Film WHERE Title LIKE '%{title}%'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
        
        /// <summary>
        /// zwraca filmy posortowane po tytule
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowAllFilmsSortByTitle(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT ID,Title AS Tytul, Director AS Reżyser, Length AS długość FROM Film ORDER BY Title, Director", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        /// <summary>
        /// zwraca {top} pierwszych wierszy tabeli Film
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="top"></param>
        public static void ShowAllFilmsTopX(SqlConnection sqlConnection, DataGridView dataGridView,int top)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT TOP {top} ID,Title AS Tytul, Director AS Reżyser, Length AS długość FROM Film", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        /// <summary>
        /// zwraca średnią długość filmu
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <returns></returns>
        public static string ShowMean(SqlConnection sqlConnection)
        {
            int avg;
                var sql = $"SELECT AVG(Length) FROM Film";
                using (var cmd = new SqlCommand(sql, sqlConnection))
                {
                    sqlConnection.Open();
                    avg = (int)cmd.ExecuteScalar();
                }
            return avg.ToString();
        }
    }
}
