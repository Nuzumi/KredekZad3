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
    class Cinema
    {
        /// <summary>
        /// zwraca dane z tabeli Cinemas
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowAllCinemas(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT ID ,Name AS Nazwa, City AS Miasto FROM Cinema", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        /// <summary>
        /// wyswietla przekazana dane
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
