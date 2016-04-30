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
    public class Service
    {
        public static void GetAllServices(SqlConnection sqlConnection, SqlDataAdapter sqlDataAdapter, DataGridView dataGridViewComputerService)
        {
            sqlDataAdapter = new SqlDataAdapter("Select * from Services", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewComputerService.DataSource = dataTable;
        }

        public static void GetHighCostServices(SqlConnection sqlConnection, SqlDataAdapter sqlDataAdapter, DataGridView dataGridViewComputerService, TextBox textBoxPrice)
        {
            int price;
            price = int.Parse(textBoxPrice.Text);
            sqlDataAdapter = new SqlDataAdapter("Select * from Services where Cost> " + price, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewComputerService.DataSource = dataTable;
        }
    }
}
