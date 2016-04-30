using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BartoszEgrowskiLab3.Controller
{
    public class Computer
    {
        public static void GetAllComputers(SqlConnection sqlConnection, SqlDataAdapter sqlDataAdapter, DataGridView dataGridViewComputerService)
        {
            sqlDataAdapter = new SqlDataAdapter("Select * from Computers", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewComputerService.DataSource = dataTable;
        }
    }
}
