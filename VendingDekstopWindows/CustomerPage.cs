using System;
using System.Windows.Forms;

namespace VendingDekstopWindows
{
    public partial class CustomerPage : Form
    {
        public CustomerPage()
        {
            InitializeComponent();
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {

        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            try
            {
                Customer_Menu_Snack snack = new Customer_Menu_Snack();
                snack.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open snack menu: " + ex.Message);
            }
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            try
            {
                Combined_Menu_Functions menu = new Combined_Menu_Functions();
                menu.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open balance menu: " + ex.Message);
            }
        }

        private void btnAddFund_Click(object sender, EventArgs e)
        {
            try
            {
                Combined_Menu_Functions menu = new Combined_Menu_Functions();
                menu.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open add fund menu: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                SelectUser selectUser = new SelectUser();
                selectUser.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to go back to selection: " + ex.Message);
            }
        }
    }
}