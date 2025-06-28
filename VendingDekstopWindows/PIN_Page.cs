using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingDekstopWindows
{
    public partial class PIN_Page : Form
    {
        public PIN_Page()
        {
            InitializeComponent();
        }

        private void PIN_Page_Load(object sender, EventArgs e)
        {


        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            string pin = txbPinCode.Text.Trim();
            if (pin == "0525")
            {
                AdminPage adminPage = new AdminPage(this);
                adminPage.Show();
                this.Hide();
            }
            else if (pin == "2005")
            {
                CustomerPage customerPage = new CustomerPage();
                customerPage.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong PIN. Please try again.");
                txbPinCode.Clear();

            }
        }
    }
}