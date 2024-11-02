using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Store
{
    public partial class UserForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-8RR688H;Initial Catalog=ComputerStore;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            DisplayProductsData();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit Computer Store?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void DisplayProductsData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM PC_PRODUCTS";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Products_DGV.DataSource = dt;
            }
        }

        private void DisplayProductsData(string orderByClause)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM PC_PRODUCTS";
                if (!string.IsNullOrEmpty(orderByClause))
                {
                    query += " ORDER BY " + orderByClause;
                }
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Products_DGV.DataSource = dt;
            }
        }

        private void HighestPrice_button_Click(object sender, EventArgs e)
        {
            DisplayProductsData("Price DESC");
        }

        private void LowestPrice_button_Click(object sender, EventArgs e)
        {
            DisplayProductsData("Price ASC");
        }


        private void DisplayAMDProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM PC_PRODUCTS WHERE Processor LIKE '%AMD%'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Products_DGV.DataSource = dt;
            }
        }

        private void DisplayIntelProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM PC_PRODUCTS WHERE Processor LIKE '%Intel%'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Products_DGV.DataSource = dt;
            }
        }

        private void AMDonly_Computers_Click(object sender, EventArgs e)
        {
            DisplayAMDProducts();
        }

        private void IntelOnly_button_Click(object sender, EventArgs e)
        {
            DisplayIntelProducts();
        }

    }
}
