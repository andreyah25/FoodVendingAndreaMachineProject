namespace VendingDekstopWindows
{
    partial class CustomerPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMenu = new Label();
            btnSnacks = new Button();
            btnBalance = new Button();
            btnAddFund = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.Location = new Point(192, 47);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(187, 31);
            lblMenu.TabIndex = 5;
            lblMenu.Text = "MAIN MENU:";
            // 
            // btnSnacks
            // 
            btnSnacks.BackColor = Color.FromArgb(255, 192, 255);
            btnSnacks.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSnacks.Location = new Point(208, 106);
            btnSnacks.Name = "btnSnacks";
            btnSnacks.Size = new Size(156, 41);
            btnSnacks.TabIndex = 6;
            btnSnacks.Text = "SHOW SNACKS";
            btnSnacks.UseVisualStyleBackColor = false;
            btnSnacks.Click += btnSnacks_Click;
            // 
            // btnBalance
            // 
            btnBalance.BackColor = Color.FromArgb(255, 192, 255);
            btnBalance.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBalance.Location = new Point(208, 182);
            btnBalance.Name = "btnBalance";
            btnBalance.Size = new Size(156, 41);
            btnBalance.TabIndex = 7;
            btnBalance.Text = "VIEW BALANCE";
            btnBalance.UseVisualStyleBackColor = false;
            btnBalance.Click += btnBalance_Click;
            // 
            // btnAddFund
            // 
            btnAddFund.BackColor = Color.FromArgb(255, 192, 255);
            btnAddFund.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddFund.Location = new Point(208, 259);
            btnAddFund.Name = "btnAddFund";
            btnAddFund.Size = new Size(156, 41);
            btnAddFund.TabIndex = 8;
            btnAddFund.Text = "ADD FUNDS";
            btnAddFund.UseVisualStyleBackColor = false;
            btnAddFund.Click += btnAddFund_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 192, 255);
            btnCancel.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(208, 334);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(156, 41);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // CustomerPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(583, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnAddFund);
            Controls.Add(btnBalance);
            Controls.Add(btnSnacks);
            Controls.Add(lblMenu);
            Name = "CustomerPage";
            Text = "CustomerPage";
            Load += CustomerPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenu;
        private Button btnSnacks;
        private Button btnBalance;
        private Button btnAddFund;
        private Button btnCancel;
    }
}