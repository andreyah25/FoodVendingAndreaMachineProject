namespace VendingDekstopWindows
{
    partial class AdminPage
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
            label1 = new Label();
            btnBack = new Button();
            btnRestock = new Button();
            btnExit = new Button();
            btnAddItem = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnView = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 33);
            label1.Name = "label1";
            label1.Size = new Size(188, 31);
            label1.TabIndex = 0;
            label1.Text = "ADMIN PAGE";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(35, 394);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(99, 33);
            btnBack.TabIndex = 3;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRestock
            // 
            btnRestock.BackColor = Color.FromArgb(255, 192, 255);
            btnRestock.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestock.Location = new Point(49, 106);
            btnRestock.Name = "btnRestock";
            btnRestock.Size = new Size(168, 41);
            btnRestock.TabIndex = 4;
            btnRestock.Text = "RESTOCK ITEMS";
            btnRestock.UseVisualStyleBackColor = false;
            btnRestock.Click += btnRestock_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 128, 128);
            btnExit.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(388, 394);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(99, 33);
            btnExit.TabIndex = 8;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(255, 192, 255);
            btnAddItem.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddItem.Location = new Point(49, 201);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(168, 41);
            btnAddItem.TabIndex = 9;
            btnAddItem.Text = "ADD NEW ITEM";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 192, 255);
            btnSearch.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(336, 201);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(168, 41);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "SEARCH ITEM";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 255);
            btnDelete.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(336, 106);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(168, 41);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "DELETE ITEM";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(255, 192, 255);
            btnView.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnView.Location = new Point(198, 272);
            btnView.Name = "btnView";
            btnView.Size = new Size(168, 41);
            btnView.TabIndex = 12;
            btnView.Text = "VIEW INVENTORY";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(555, 450);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnAddItem);
            Controls.Add(btnExit);
            Controls.Add(btnRestock);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Name = "AdminPage";
            Text = "AdminPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBack;
        private Button btnRestock;
        private Button btnExit;
        private Button btnAddItem;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnView;
    }
}