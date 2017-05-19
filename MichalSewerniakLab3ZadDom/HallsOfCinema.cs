using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalSewerniakLab3ZadDom
{
    class HallsOfCinema
    {
        /// <summary>
        /// przekazuje wszystkie tabele z hallsOfCinemas
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowAllHallsOfCinema(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Cinema.Name AS 'nazwa kina' ,Hall.ID AS 'ID sali' FROM HallsOfCinema JOIN Hall ON Hall.ID = HallsOfCinema.HallID JOIN Cinema ON Cinema.ID = HallsOfCinema.CinemaID", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        /// <summary>
        /// wyswietla dane w gridView
        /// </summary>
        /// <param name="sqlDataAdapter"></param>
        /// <param name="dataGridView"></param>
        private static void FillDataGridView(SqlDataAdapter sqlDataAdapter, DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
    }
}
