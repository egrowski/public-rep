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
using BartoszEgrowskiLab3.Controller;

namespace BartoszEgrowskiLab3
{
    public partial class FormMain : Form
    {
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        public FormMain()
        {
            //SqlDataAdapter sqlDataAdapter;
            InitializeComponent();
            sqlConnection = new SqlConnection("Server = EGR; Database = BartoszEgrowskiComputerService; Trusted_Connection = Yes");
        }

        private void buttonGetAllEmployees_Click(object sender, EventArgs e)
        {
            Employee.GetAllEmployees(sqlConnection, sqlDataAdapter, dataGridViewComputerService);
        }

        private void buttonGetAllComputers_Click(object sender, EventArgs e)
        {
            Computer.GetAllComputers(sqlConnection, sqlDataAdapter, dataGridViewComputerService);
        }

        private void buttonGetAllClients_Click(object sender, EventArgs e)
        {
            Client.GetAllClients(sqlConnection, sqlDataAdapter, dataGridViewComputerService);
        }

        private void buttonGetAllServices_Click(object sender, EventArgs e)
        {
            Service.GetAllServices(sqlConnection, sqlDataAdapter, dataGridViewComputerService);
        }

        private void buttonGetHighCostServices_Click(object sender, EventArgs e)
        {
            Service.GetHighCostServices(sqlConnection, sqlDataAdapter, dataGridViewComputerService, textBoxPrice);
        }
    }
}
