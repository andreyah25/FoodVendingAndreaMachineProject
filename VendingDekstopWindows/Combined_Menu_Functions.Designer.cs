namespace VendingDekstopWindows
{
    partial class Combined_Menu_Functions
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
            txbBalance = new TextBox();
            txbMoney = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txbBalance
            // 
            txbBalance.BorderStyle = BorderStyle.FixedSingle;
            txbBalance.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbBalance.Location = new Point(194, 71);
            txbBalance.Name = "txbBalance";
            txbBalance.Size = new Size(147, 35);
            txbBalance.TabIndex = 0;
            txbBalance.TextChanged += txbBalance_TextChanged;
            // 
            // txbMoney
            // 
            txbMoney.BorderStyle = BorderStyle.FixedSingle;
            txbMoney.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbMoney.Location = new Point(194, 236);
            txbMoney.Name = "txbMoney";
            txbMoney.Size = new Size(147, 35);
            txbMoney.TabIndex = 1;
            txbMoney.TextChanged += txbMoney_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 77);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 2;
            label1.Text = "BALANCE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 242);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 3;
            label2.Text = "ADDED MONEY:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 171);
            label3.Name = "label3";
            label3.Size = new Size(338, 21);
            label3.TabIndex = 4;
            label3.Text = "TYPE THE AMOUNT MONEY TO ADD";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 192, 192);
            btnAdd.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(212, 306);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 37);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "ADD FUND";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 192, 192);
            btnBack.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(21, 399);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(72, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Combined_Menu_Functions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(504, 450);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbMoney);
            Controls.Add(txbBalance);
            Name = "Combined_Menu_Functions";
            Text = "Combined_Menu_Functions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbBalance;
        private TextBox txbMoney;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Button btnBack;
    }
}