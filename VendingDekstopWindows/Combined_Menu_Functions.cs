using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace VendingDekstopWindows
{
    public partial class Combined_Menu_Functions : Form
    {
        private string connectionString = "Data Source=LAPTOP-K9BIE3M3\\SQLEXPRESS;Initial Catalog=VendingMachineDB;Integrated Security=True;Encrypt=False;";

        public Combined_Menu_Functions()
        {
            InitializeComponent();
            this.Load += Combined_Menu_Functions_Load;
        }

        private void Combined_Menu_Functions_Load(object sender, EventArgs e)
        {
            LoadBalance();
        }

        private void LoadBalance()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Balance FROM CustomerBalance";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    txbBalance.Text = Convert.ToDecimal(result).ToString("0.00");
                }
                else
                {
                    txbBalance.Text = "0.00";
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txbBalance.Text, out decimal currentBalance) &&
                decimal.TryParse(txbMoney.Text, out decimal addAmount))
            {
                decimal newBalance = currentBalance + addAmount;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE CustomerBalance SET Balance = @Balance";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Balance", newBalance);
                    cmd.ExecuteNonQuery();
                }

                txbBalance.Text = newBalance.ToString("0.00");
                txbMoney.Text = "";
                MessageBox.Show("Balance updated successfully!");
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            new CustomerPage().Show();
        }

        private void txbBalance_TextChanged(object sender, EventArgs e)
        {
            txbBalance.ReadOnly = true;
        }

        private void txbMoney_TextChanged(object sender, EventArgs e)
        {
        }
    }
}