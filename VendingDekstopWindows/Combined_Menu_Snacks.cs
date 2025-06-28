using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace VendingDekstopWindows
{
    public partial class Customer_Menu_Snack : Form
    {
        private string connectionString = "Data Source=LAPTOP-K9BIE3M3\\SQLEXPRESS;Initial Catalog=VendingMachineDB;Integrated Security=True;Encrypt=False;";
        private string selectedItem = "";

        public Customer_Menu_Snack()
        {
            InitializeComponent();
            LoadBalance();
        }

        private void LoadBalance()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Balance FROM CustomerBalance", conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                    txbBalance.Text = Convert.ToDecimal(result).ToString("0.00");
                else
                    txbBalance.Text = "0.00";
            }
        }

        private void LoadItem(string itemName)
        {
            selectedItem = itemName;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Price FROM Inventory WHERE ItemName = @item", conn);
                cmd.Parameters.AddWithValue("@item", itemName);
                object result = cmd.ExecuteScalar();

                if (result != null)
                    txbPrice.Text = Convert.ToDecimal(result).ToString("0.00");
                else
                    MessageBox.Show("Item not found in database.");
            }
        }

        private void btn1_Click(object sender, EventArgs e) => LoadItem("COKE");
        private void btn2_Click(object sender, EventArgs e) => LoadItem("SPRITE");
        private void btn3_Click(object sender, EventArgs e) => LoadItem("ROYAL");
        private void btn4_Click(object sender, EventArgs e) => LoadItem("PIATTOS");
        private void btn5_Click(object sender, EventArgs e) => LoadItem("LAYS");

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txbPrice.Text, out decimal price) ||
                !decimal.TryParse(txbBalance.Text, out decimal balance))
            {
                MessageBox.Show("Invalid price or balance.");
                return;
            }

            if (balance < price)
            {
                MessageBox.Show("Insufficient balance.");
                return;
            }

            decimal newBalance = balance - price;
            decimal change = balance - price;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();


                SqlCommand checkQty = new SqlCommand("SELECT Quantity FROM Inventory WHERE ItemName = @item", conn);
                checkQty.Parameters.AddWithValue("@item", selectedItem);
                int currentQty = Convert.ToInt32(checkQty.ExecuteScalar());

                if (currentQty <= 0)
                {
                    MessageBox.Show("Item out of stock.");
                    return;
                }

                SqlCommand updateQty = new SqlCommand("UPDATE Inventory SET Quantity = Quantity - 1 WHERE ItemName = @item", conn);
                updateQty.Parameters.AddWithValue("@item", selectedItem);
                updateQty.ExecuteNonQuery();


                SqlCommand updateBalance = new SqlCommand("UPDATE CustomerBalance SET Balance = @balance", conn);
                updateBalance.Parameters.AddWithValue("@balance", newBalance);
                updateBalance.ExecuteNonQuery();
            }


            txbBalance.Text = newBalance.ToString("0.00");
            txbChange.Text = change.ToString("0.00");
            txbPrice.Clear();

            MessageBox.Show("Purchase successful!");
        }
        private void txbChange_TextChanged(object sender, EventArgs e)
        {

        }
        private void txbBalance_TextChanged(object sender, EventArgs e)
        {

        }
        private void txbPrice_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}