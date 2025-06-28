namespace VendingDekstopWindows
{
    partial class Combined_Functions
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
            dgvInventory = new DataGridView();
            txbSearch = new TextBox();
            btnSearch = new Button();
            txbItem = new TextBox();
            txbPrice = new TextBox();
            txbQty = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lblItem = new Label();
            lblPrice = new Label();
            lblQty = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(47, 109);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.Size = new Size(354, 250);
            dgvInventory.TabIndex = 0;
            dgvInventory.CellClick += dgvInventory_CellClick;
            // 
            // txbSearch
            // 
            txbSearch.BorderStyle = BorderStyle.FixedSingle;
            txbSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSearch.Location = new Point(47, 52);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(251, 26);
            txbSearch.TabIndex = 1;
            txbSearch.TextChanged += txbSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 192, 192);
            btnSearch.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(304, 52);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(97, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txbItem
            // 
            txbItem.BorderStyle = BorderStyle.FixedSingle;
            txbItem.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbItem.Location = new Point(441, 130);
            txbItem.Name = "txbItem";
            txbItem.Size = new Size(122, 32);
            txbItem.TabIndex = 3;
            txbItem.TextChanged += txbItem_TextChanged;
            // 
            // txbPrice
            // 
            txbPrice.BorderStyle = BorderStyle.FixedSingle;
            txbPrice.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbPrice.Location = new Point(441, 206);
            txbPrice.Name = "txbPrice";
            txbPrice.Size = new Size(122, 32);
            txbPrice.TabIndex = 4;
            txbPrice.TextChanged += txbPrice_TextChanged;
            // 
            // txbQty
            // 
            txbQty.BorderStyle = BorderStyle.FixedSingle;
            txbQty.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbQty.Location = new Point(452, 278);
            txbQty.Name = "txbQty";
            txbQty.Size = new Size(122, 32);
            txbQty.TabIndex = 5;
            txbQty.TextChanged += txbQty_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 192, 192);
            btnAdd.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(569, 383);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(255, 192, 192);
            btnRemove.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(441, 383);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(101, 29);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItem.Location = new Point(592, 132);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(47, 23);
            lblItem.TabIndex = 11;
            lblItem.Text = "Item";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(592, 208);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(53, 23);
            lblPrice.TabIndex = 12;
            lblPrice.Text = "Price";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQty.Location = new Point(592, 280);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(82, 23);
            lblQty.TabIndex = 13;
            lblQty.Text = "Quantity";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 192, 192);
            btnBack.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(47, 383);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(101, 29);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Combined_Functions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(682, 450);
            Controls.Add(btnBack);
            Controls.Add(lblQty);
            Controls.Add(lblPrice);
            Controls.Add(lblItem);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txbQty);
            Controls.Add(txbPrice);
            Controls.Add(txbItem);
            Controls.Add(btnSearch);
            Controls.Add(txbSearch);
            Controls.Add(dgvInventory);
            Name = "Combined_Functions";
            Text = "Combined_Functions";
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInventory;
        private TextBox txbSearch;
        private Button btnSearch;
        private TextBox txbItem;
        private TextBox txbPrice;
        private TextBox txbQty;
        private Button btnAdd;
        private Button btnRemove;
        private Label lblItem;
        private Label lblPrice;
        private Label lblQty;
        private Button btnBack;
    }
}