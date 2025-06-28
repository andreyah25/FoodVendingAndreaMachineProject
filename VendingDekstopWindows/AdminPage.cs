using System;
using System.Windows.Forms;

namespace VendingDekstopWindows
{
    public partial class AdminPage : Form
    {
        private Form previousForm;

        public AdminPage(Form prevForm)
        {
            InitializeComponent();
            previousForm = prevForm;
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            RestockItem restockItem = new RestockItem(this);
            restockItem.Show();
            this.Hide();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Combined_Functions combine = new Combined_Functions(this);
            combine.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Combined_Functions combine = new Combined_Functions(this);
            combine.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Combined_Functions combine = new Combined_Functions(this);
            combine.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            View_Inventory view = new View_Inventory(this);
            view.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            PIN_Page pin = new PIN_Page();
            pin.Show();
            this.Hide();
        }
    }
}