namespace VendingDekstopWindows
{
    public partial class SelectUser : Form
    {
        public SelectUser()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            PIN_Page pin_Page = new PIN_Page();
            pin_Page.Show();
            this.Hide();

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            PIN_Page pin_Page = new PIN_Page();
            pin_Page.Show();
            this.Hide();
        }
    }
}