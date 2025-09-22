using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace VendingDekstopWindows
{
    public partial class RestockItem : Form
    {
        private string connectionString = "Data Source=Andrea\\SQLEXPRESS;Initial Catalog=VendingInventoryWindows;Integrated Security=True;Encrypt=False;";
        private Form previousForm;


        public RestockItem(Form prevForm)
        {
            InitializeComponent();
            previousForm = prevForm;
        }

        private void txbItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string itemName = txbItem.Text.Trim();
            bool validQty = int.TryParse(txbQty.Text.Trim(), out int qty);

            if (string.IsNullOrEmpty(itemName) || !validQty || qty <= 0)
            {
                MessageBox.Show("Enter a valid item name and a positive quantity.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Inventory WHERE ItemName = @name", conn);
                checkCmd.Parameters.AddWithValue("@name", itemName);
                int exists = (int)checkCmd.ExecuteScalar();

                if (exists == 0)
                {
                    MessageBox.Show("The item doesn't exist in the inventory.");
                    return;
                }

                SqlCommand updateCmd = new SqlCommand("UPDATE Inventory SET Quantity = Quantity + @qty WHERE ItemName = @name", conn);
                updateCmd.Parameters.AddWithValue("@qty", qty);
                updateCmd.Parameters.AddWithValue("@name", itemName);
                updateCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Item restocked successfully.");
            txbItem.Clear();
            txbQty.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}