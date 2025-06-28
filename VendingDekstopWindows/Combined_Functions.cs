using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace VendingDekstopWindows
{
    public partial class Combined_Functions : Form
    {
        private string connectionString = "Data Source=LAPTOP-K9BIE3M3\\SQLEXPRESS;Initial Catalog=VendingMachineDB;Integrated Security=True;Encrypt=False;";
        private string selectedItem = "";
        private Form previousForm;


        public Combined_Functions(Form prevForm)
        {
            InitializeComponent();
            previousForm = prevForm;
            LoadInventory();
        }
        private void txbItem_TextChanged(object sender, EventArgs e)
        {

        }
        private void txbPrice_TextChanged(object sender, EventArgs e)
        {

        }
        private void txbQty_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnItem_Click(object sender, EventArgs e)
        {

        }
        private void btnPrice_Click(object sender, EventArgs e)
        {

        }
        private void btnQty_Click(object sender, EventArgs e)
        {

        }

        private void LoadInventory()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Inventory", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvInventory.DataSource = table;
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbSearch.Text))
            {
                LoadInventory();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txbSearch.Text.Trim();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Inventory WHERE ItemName LIKE @search", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvInventory.DataSource = table;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string item = txbItem.Text.Trim();
            bool validQty = int.TryParse(txbQty.Text.Trim(), out int qty);
            bool validPrice = decimal.TryParse(txbPrice.Text.Trim(), out decimal price);

            if (string.IsNullOrEmpty(item) || !validQty || !validPrice)
            {
                MessageBox.Show("Please enter a valid item name, price, and quantity.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Inventory WHERE ItemName = @item", conn);
                checkCmd.Parameters.AddWithValue("@item", item);
                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("Item already exists.");
                    return;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Inventory (ItemName, Price, Quantity) VALUES (@item, @price, @qty)", conn);
                cmd.Parameters.AddWithValue("@item", item);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Item added successfully.");
            LoadInventory();
            txbItem.Clear(); txbPrice.Clear(); txbQty.Clear();
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInventory.Rows[e.RowIndex];
                selectedItem = row.Cells["ItemName"].Value.ToString();
                txbItem.Text = selectedItem;
                txbPrice.Text = row.Cells["Price"].Value.ToString();
                txbQty.Text = row.Cells["Quantity"].Value.ToString();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedItem))
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Inventory WHERE ItemName = @item", conn);
                cmd.Parameters.AddWithValue("@item", selectedItem);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Item deleted successfully.");
            LoadInventory();
            txbItem.Clear(); txbPrice.Clear(); txbQty.Clear();
            selectedItem = "";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {

        }
    }
}