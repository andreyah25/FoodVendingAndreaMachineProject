namespace VendingDekstopWindows
{
    partial class SelectUser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblVending = new Label();
            lblUser = new Label();
            btnCustomer = new Button();
            btnAdmin = new Button();
            SuspendLayout();
            // 
            // lblVending
            // 
            lblVending.AutoSize = true;
            lblVending.Font = new Font("Monotype Corsiva", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblVending.Location = new Point(108, 62);
            lblVending.Name = "lblVending";
            lblVending.Size = new Size(305, 39);
            lblVending.TabIndex = 0;
            lblVending.Text = "Food Vending Machine";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(207, 140);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(110, 23);
            lblUser.TabIndex = 1;
            lblUser.Text = "Select User:";
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.FromArgb(255, 192, 255);
            btnCustomer.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomer.Location = new Point(181, 205);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(166, 41);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(255, 192, 255);
            btnAdmin.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdmin.Location = new Point(181, 292);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(166, 41);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // SelectUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(559, 450);
            Controls.Add(btnAdmin);
            Controls.Add(btnCustomer);
            Controls.Add(lblUser);
            Controls.Add(lblVending);
            Name = "SelectUser";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVending;
        private Label lblUser;
        private Button btnCustomer;
        private Button btnAdmin;
    }
}
