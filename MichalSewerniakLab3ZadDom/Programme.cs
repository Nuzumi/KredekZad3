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
    class Programme
    {

        /// <summary>
        /// zwraca dane ze wszystkich tabeli Programme
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowAllProgramme(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Programme.ID ,Film.Title AS 'tytuł filmu', Date AS data, Time AS godzina,Hall.Number AS 'numer sali' FROM Programme JOIN Hall ON Hall.ID = Programme.HallID JOIN Film ON Film.ID = Programme.FilmID", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        /// <summary>
        /// wyswietla przekazane dane do gridView
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
