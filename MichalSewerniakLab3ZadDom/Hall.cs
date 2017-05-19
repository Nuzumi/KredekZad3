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
    class Hall
    {

        /// <summary>
        /// zwraca wszystkie dane z tabeli Hall
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowAllHalls(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT ID ,Number AS Numer, CountOfSeat AS 'Ilość miejsc' FROM Hall", sqlConnection);
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
