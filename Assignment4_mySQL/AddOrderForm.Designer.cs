namespace Assignment4_mySQL
{
    partial class AddOrderForm
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.OrderID = new System.Windows.Forms.Label();
            this.textBox_OrderID = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.Label();
            this.textBox_CustomerID = new System.Windows.Forms.TextBox();
            this.OrderDate = new System.Windows.Forms.Label();
            this.textBox_OrderDate = new System.Windows.Forms.TextBox();
            this.CreditStatus = new System.Windows.Forms.Label();
            this.textBox_CreditAuthorizationStatus = new System.Windows.Forms.TextBox();
            this.BranchID = new System.Windows.Forms.Label();
            this.textBox_BranchID = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(713, 415);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 1;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // OrderID
            // 
            this.OrderID.AutoSize = true;
            this.OrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OrderID.Location = new System.Drawing.Point(112, 124);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(66, 20);
            this.OrderID.TabIndex = 4;
            this.OrderID.Text = "OrderID";
            // 
            // textBox_OrderID
            // 
            this.textBox_OrderID.Location = new System.Drawing.Point(184, 124);
            this.textBox_OrderID.Name = "textBox_OrderID";
            this.textBox_OrderID.Size = new System.Drawing.Size(169, 20);
            this.textBox_OrderID.TabIndex = 3;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CustomerID.Location = new System.Drawing.Point(83, 163);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(95, 20);
            this.CustomerID.TabIndex = 6;
            this.CustomerID.Text = "CustomerID";
            // 
            // textBox_CustomerID
            // 
            this.textBox_CustomerID.Location = new System.Drawing.Point(184, 163);
            this.textBox_CustomerID.Name = "textBox_CustomerID";
            this.textBox_CustomerID.Size = new System.Drawing.Size(169, 20);
            this.textBox_CustomerID.TabIndex = 5;
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSize = true;
            this.OrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OrderDate.Location = new System.Drawing.Point(485, 163);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(84, 20);
            this.OrderDate.TabIndex = 8;
            this.OrderDate.Text = "OrderDate";
            // 
            // textBox_OrderDate
            // 
            this.textBox_OrderDate.Location = new System.Drawing.Point(575, 163);
            this.textBox_OrderDate.Name = "textBox_OrderDate";
            this.textBox_OrderDate.Size = new System.Drawing.Size(169, 20);
            this.textBox_OrderDate.TabIndex = 7;
            // 
            // CreditStatus
            // 
            this.CreditStatus.AutoSize = true;
            this.CreditStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreditStatus.Location = new System.Drawing.Point(369, 124);
            this.CreditStatus.Name = "CreditStatus";
            this.CreditStatus.Size = new System.Drawing.Size(200, 20);
            this.CreditStatus.TabIndex = 10;
            this.CreditStatus.Text = "Credit Authorization Status";
            // 
            // textBox_CreditAuthorizationStatus
            // 
            this.textBox_CreditAuthorizationStatus.Location = new System.Drawing.Point(575, 124);
            this.textBox_CreditAuthorizationStatus.Name = "textBox_CreditAuthorizationStatus";
            this.textBox_CreditAuthorizationStatus.Size = new System.Drawing.Size(169, 20);
            this.textBox_CreditAuthorizationStatus.TabIndex = 9;
            // 
            // BranchID
            // 
            this.BranchID.AutoSize = true;
            this.BranchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BranchID.Location = new System.Drawing.Point(101, 200);
            this.BranchID.Name = "BranchID";
            this.BranchID.Size = new System.Drawing.Size(77, 20);
            this.BranchID.TabIndex = 12;
            this.BranchID.Text = "BranchID";
            // 
            // textBox_BranchID
            // 
            this.textBox_BranchID.Location = new System.Drawing.Point(184, 200);
            this.textBox_BranchID.Name = "textBox_BranchID";
            this.textBox_BranchID.Size = new System.Drawing.Size(169, 20);
            this.textBox_BranchID.TabIndex = 11;
            // 
            // InsertButton
            // 
            this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.InsertButton.Location = new System.Drawing.Point(435, 254);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(134, 69);
            this.InsertButton.TabIndex = 24;
            this.InsertButton.Text = "Insert Data";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(240, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "CSCN72000 Assignment 4 - Hayden Auterhoff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(198, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Note: need to disable Global FK check in MySQL to add to table";
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.BranchID);
            this.Controls.Add(this.textBox_BranchID);
            this.Controls.Add(this.CreditStatus);
            this.Controls.Add(this.textBox_CreditAuthorizationStatus);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.textBox_OrderDate);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.textBox_CustomerID);
            this.Controls.Add(this.OrderID);
            this.Controls.Add(this.textBox_OrderID);
            this.Controls.Add(this.ReturnButton);
            this.Name = "AddOrderForm";
            this.Text = "AddOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label OrderID;
        private System.Windows.Forms.TextBox textBox_OrderID;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.TextBox textBox_CustomerID;
        private System.Windows.Forms.Label OrderDate;
        private System.Windows.Forms.TextBox textBox_OrderDate;
        private System.Windows.Forms.Label CreditStatus;
        private System.Windows.Forms.TextBox textBox_CreditAuthorizationStatus;
        private System.Windows.Forms.Label BranchID;
        private System.Windows.Forms.TextBox textBox_BranchID;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}