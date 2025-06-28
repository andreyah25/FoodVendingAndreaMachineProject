namespace VendingDekstopWindows
{
    partial class RestockItem
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
            txbItem = new TextBox();
            txbQty = new TextBox();
            lblName = new Label();
            label1 = new Label();
            lblRestock = new Label();
            btnAdd = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txbItem
            // 
            txbItem.BorderStyle = BorderStyle.FixedSingle;
            txbItem.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbItem.Location = new Point(147, 122);
            txbItem.Name = "txbItem";
            txbItem.Size = new Size(242, 29);
            txbItem.TabIndex = 0;
            txbItem.TextChanged += txbItem_TextChanged;
            // 
            // txbQty
            // 
            txbQty.BorderStyle = BorderStyle.FixedSingle;
            txbQty.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbQty.Location = new Point(147, 210);
            txbQty.Name = "txbQty";
            txbQty.Size = new Size(242, 29);
            txbQty.TabIndex = 1;
            txbQty.TextChanged += txbQty_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(35, 126);
            lblName.Name = "lblName";
            lblName.Size = new Size(83, 18);
            lblName.TabIndex = 2;
            lblName.Text = "Item Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 221);
            label1.Name = "label1";
            label1.Size = new Size(34, 18);
            label1.TabIndex = 3;
            label1.Text = "Qty:";
            // 
            // lblRestock
            // 
            lblRestock.AutoSize = true;
            lblRestock.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRestock.Location = new Point(147, 37);
            lblRestock.Name = "lblRestock";
            lblRestock.Size = new Size(240, 31);
            lblRestock.TabIndex = 4;
            lblRestock.Text = "RESTOCK ITEMS";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 192, 255);
            btnAdd.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(211, 269);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.Yes;
            btnAdd.Size = new Size(119, 39);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 192, 255);
            btnBack.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(35, 397);
            btnBack.Name = "btnBack";
            btnBack.RightToLeft = RightToLeft.Yes;
            btnBack.Size = new Size(92, 28);
            btnBack.TabIndex = 6;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // RestockItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(527, 450);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(lblRestock);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(txbQty);
            Controls.Add(txbItem);
            Name = "RestockItem";
            Text = "RestockItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbItem;
        private TextBox txbQty;
        private Label lblName;
        private Label label1;
        private Label lblRestock;
        private Button btnAdd;
        private Button btnBack;
    }
}