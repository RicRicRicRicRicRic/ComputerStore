using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Computer_Store
{
    public partial class Confirm_button : Form
    {
        private string connectionString = @"Data Source=DESKTOP-8RR688H;Initial Catalog=ComputerStore;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        private int selectedProductID = -1;

        public Confirm_button()
        {
            InitializeComponent();
        }
        private void Confirm_button_Load(object sender, EventArgs e)
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



        private void confirmation_button_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(NewPrice_textbox.Text, out decimal newPrice))
            {
                MessageBox.Show("Please enter a valid numeric value for the new price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE PC_PRODUCTS SET Price = @NewPrice WHERE ProductID = @ProductID";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@NewPrice", newPrice);
                cmd.Parameters.AddWithValue("@ProductID", selectedProductID);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Price updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayProductsData();
                    Name_textBox.Clear();
                    NewPrice_textbox.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to update price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Products_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Products_DGV.Rows.Count - 1)
            {
                DataGridViewRow row = Products_DGV.Rows[e.RowIndex];
                selectedProductID = Convert.ToInt32(row.Cells["ProductID"].Value);
                string productName = Convert.ToString(row.Cells["Model_Description"].Value);
                decimal productPrice = Convert.ToDecimal(row.Cells["Price"].Value);

                Name_textBox.Text = productName;
                NewPrice_textbox.Text = productPrice.ToString();
            }
        }
    }
}
