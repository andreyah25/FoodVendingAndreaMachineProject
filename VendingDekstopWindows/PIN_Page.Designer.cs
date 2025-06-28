namespace VendingDekstopWindows
{
    partial class PIN_Page
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
            label2 = new Label();
            btnProceed = new Button();
            txbPinCode = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(147, 102);
            label2.Name = "label2";
            label2.Size = new Size(179, 22);
            label2.TabIndex = 2;
            label2.Text = "ENTER YOUR PIN:";
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.FromArgb(255, 192, 255);
            btnProceed.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProceed.Location = new Point(185, 258);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(99, 33);
            btnProceed.TabIndex = 5;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // txbPinCode
            // 
            txbPinCode.BorderStyle = BorderStyle.FixedSingle;
            txbPinCode.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbPinCode.Location = new Point(159, 180);
            txbPinCode.Name = "txbPinCode";
            txbPinCode.Size = new Size(152, 26);
            txbPinCode.TabIndex = 4;
            txbPinCode.TextAlign = HorizontalAlignment.Center;
            // 
            // PIN_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(483, 450);
            Controls.Add(btnProceed);
            Controls.Add(txbPinCode);
            Controls.Add(label2);
            Name = "PIN_Page";
            Text = "PIN_Page";
            Load += PIN_Page_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnProceed;
        private TextBox txbPinCode;
    }
}