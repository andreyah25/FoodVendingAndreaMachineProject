using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace VendingDekstopWindows
{
    public partial class View_Inventory : Form
    {
        private Form previousForm;
        private string connectionString = "Data Source=Andrea\\SQLEXPRESS;Initial Catalog=VendingInventoryWindows;Integrated Security=True;Encrypt=False;";

        public View_Inventory(Form prevForm)
        {
            InitializeComponent();
            previousForm = prevForm;
            LoadInventory();


        }

        private void LoadInventory()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Inventory", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}