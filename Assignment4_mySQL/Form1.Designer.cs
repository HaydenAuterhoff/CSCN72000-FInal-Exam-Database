namespace Assignment4_mySQL
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.CustomerListButton = new System.Windows.Forms.Button();
            this.OrdersListButton = new System.Windows.Forms.Button();
            this.BranchesListButton = new System.Windows.Forms.Button();
            this.ItemsListButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.AddBranchesButton = new System.Windows.Forms.Button();
            this.AddOrderButtons = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitProgramButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReportButton.Location = new System.Drawing.Point(253, 390);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(161, 39);
            this.ReportButton.TabIndex = 3;
            this.ReportButton.Text = "Generate Reports";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(129, 92);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(646, 280);
            this.dgv.TabIndex = 4;
            // 
            // CustomerListButton
            // 
            this.CustomerListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CustomerListButton.Location = new System.Drawing.Point(11, 134);
            this.CustomerListButton.Name = "CustomerListButton";
            this.CustomerListButton.Size = new System.Drawing.Size(112, 49);
            this.CustomerListButton.TabIndex = 5;
            this.CustomerListButton.Text = "View Customers";
            this.CustomerListButton.UseVisualStyleBackColor = true;
            this.CustomerListButton.Click += new System.EventHandler(this.CustomerListButton_Click);
            // 
            // OrdersListButton
            // 
            this.OrdersListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OrdersListButton.Location = new System.Drawing.Point(11, 244);
            this.OrdersListButton.Name = "OrdersListButton";
            this.OrdersListButton.Size = new System.Drawing.Size(112, 49);
            this.OrdersListButton.TabIndex = 6;
            this.OrdersListButton.Text = "View Orders";
            this.OrdersListButton.UseVisualStyleBackColor = true;
            this.OrdersListButton.Click += new System.EventHandler(this.OrdersListButton_Click);
            // 
            // BranchesListButton
            // 
            this.BranchesListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BranchesListButton.Location = new System.Drawing.Point(11, 189);
            this.BranchesListButton.Name = "BranchesListButton";
            this.BranchesListButton.Size = new System.Drawing.Size(112, 49);
            this.BranchesListButton.TabIndex = 7;
            this.BranchesListButton.Text = "View Branches";
            this.BranchesListButton.UseVisualStyleBackColor = true;
            this.BranchesListButton.Click += new System.EventHandler(this.BranchesListButton_Click);
            // 
            // ItemsListButton
            // 
            this.ItemsListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ItemsListButton.Location = new System.Drawing.Point(11, 299);
            this.ItemsListButton.Name = "ItemsListButton";
            this.ItemsListButton.Size = new System.Drawing.Size(112, 49);
            this.ItemsListButton.TabIndex = 8;
            this.ItemsListButton.Text = "View Items";
            this.ItemsListButton.UseVisualStyleBackColor = true;
            this.ItemsListButton.Click += new System.EventHandler(this.ItemsListButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddCustomerButton.Location = new System.Drawing.Point(439, 54);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(108, 32);
            this.AddCustomerButton.TabIndex = 9;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // AddBranchesButton
            // 
            this.AddBranchesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddBranchesButton.Location = new System.Drawing.Point(553, 54);
            this.AddBranchesButton.Name = "AddBranchesButton";
            this.AddBranchesButton.Size = new System.Drawing.Size(108, 32);
            this.AddBranchesButton.TabIndex = 10;
            this.AddBranchesButton.Text = "Add Branch";
            this.AddBranchesButton.UseVisualStyleBackColor = true;
            this.AddBranchesButton.Click += new System.EventHandler(this.AddBranchesButton_Click);
            // 
            // AddOrderButtons
            // 
            this.AddOrderButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddOrderButtons.Location = new System.Drawing.Point(667, 54);
            this.AddOrderButtons.Name = "AddOrderButtons";
            this.AddOrderButtons.Size = new System.Drawing.Size(108, 32);
            this.AddOrderButtons.TabIndex = 11;
            this.AddOrderButtons.Text = "Add Orders";
            this.AddOrderButtons.UseVisualStyleBackColor = true;
            this.AddOrderButtons.Click += new System.EventHandler(this.AddOrderButtons_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "LISTS";
            // 
            // ExitProgramButton
            // 
            this.ExitProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitProgramButton.Location = new System.Drawing.Point(694, 400);
            this.ExitProgramButton.Name = "ExitProgramButton";
            this.ExitProgramButton.Size = new System.Drawing.Size(81, 38);
            this.ExitProgramButton.TabIndex = 13;
            this.ExitProgramButton.Text = "Exit";
            this.ExitProgramButton.UseVisualStyleBackColor = true;
            this.ExitProgramButton.Click += new System.EventHandler(this.ExitProgramButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(249, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "CSCN72000 Assignment 4 - Hayden Auterhoff";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(439, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "Final Exam";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitProgramButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddOrderButtons);
            this.Controls.Add(this.AddBranchesButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.ItemsListButton);
            this.Controls.Add(this.BranchesListButton);
            this.Controls.Add(this.OrdersListButton);
            this.Controls.Add(this.CustomerListButton);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button CustomerListButton;
        private System.Windows.Forms.Button OrdersListButton;
        private System.Windows.Forms.Button BranchesListButton;
        private System.Windows.Forms.Button ItemsListButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button AddBranchesButton;
        private System.Windows.Forms.Button AddOrderButtons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitProgramButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

