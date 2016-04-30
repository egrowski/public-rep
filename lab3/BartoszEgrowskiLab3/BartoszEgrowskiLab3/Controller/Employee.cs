using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace BartoszEgrowskiLab3.Controller
{
    public class Employee
    {
        public static void GetAllEmployees(SqlConnection sqlConnection, SqlDataAdapter sqlDataAdapter, DataGridView dataGridViewComputerService)
        {         
            sqlDataAdapter = new SqlDataAdapter("Select * from Employees", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewComputerService.DataSource = dataTable;   
        }
    }
}
