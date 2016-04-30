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
    public class Client
    {
        public static void GetAllClients(SqlConnection sqlConnection, SqlDataAdapter sqlDataAdapter, DataGridView dataGridViewComputerService)
        {
            sqlDataAdapter = new SqlDataAdapter("Select * from Clients", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewComputerService.DataSource = dataTable;
        }
    }
}
