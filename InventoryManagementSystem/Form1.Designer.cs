namespace InventoryManagementSystem
{
    partial class Form1
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
            lblIMS = new Label();
            lblInventory = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            btnDisplay = new Button();
            txtInventory = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtCategory = new TextBox();
            lblCategory = new Label();
            SuspendLayout();
            // 
            // lblIMS
            // 
            lblIMS.AutoSize = true;
            lblIMS.Location = new Point(54, 27);
            lblIMS.Name = "lblIMS";
            lblIMS.Size = new Size(199, 15);
            lblIMS.TabIndex = 0;
            lblIMS.Text = "INVENTORY MANAGEMENT SYSTEM";
            lblIMS.Click += label2_Click;
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.Location = new Point(62, 71);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(63, 15);
            lblInventory.TabIndex = 1;
            lblInventory.Text = "Inventory: ";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(62, 104);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(62, 138);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity:";
            lblQuantity.Click += label3_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(62, 217);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(157, 217);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(89, 23);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove ";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(106, 259);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(89, 23);
            btnDisplay.TabIndex = 7;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // txtInventory
            // 
            txtInventory.Location = new Point(131, 68);
            txtInventory.Name = "txtInventory";
            txtInventory.Size = new Size(100, 23);
            txtInventory.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(131, 101);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 12;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(131, 135);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 13;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(131, 169);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(100, 23);
            txtCategory.TabIndex = 15;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(62, 172);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 14;
            lblCategory.Text = "Category:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 315);
            Controls.Add(txtCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtInventory);
            Controls.Add(btnDisplay);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lblQuantity);
            Controls.Add(lblPrice);
            Controls.Add(lblInventory);
            Controls.Add(lblIMS);
            Name = "Form1";
            Text = "IMS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInventory;
        private Label lblIMS;
        private Label lblPrice;
        private Label lblQuantity;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnDisplay;
        private TextBox txtInventory;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtCategory;
        private Label lblCategory;
    }
}
