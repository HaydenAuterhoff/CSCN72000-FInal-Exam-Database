namespace Assignment4_mySQL
{
    partial class AddCustomerForm
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
            this.textBox_CustomerID = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.Label();
            this.CustomerFirstName = new System.Windows.Forms.Label();
            this.textBox_CustomerFirstName = new System.Windows.Forms.TextBox();
            this.CustomerLastName = new System.Windows.Forms.Label();
            this.textBox_CustomerLastName = new System.Windows.Forms.TextBox();
            this.StreetAddress = new System.Windows.Forms.Label();
            this.textBox_StreetAddress = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.Label();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.Province = new System.Windows.Forms.Label();
            this.textBox_Province = new System.Windows.Forms.TextBox();
            this.PostalCode = new System.Windows.Forms.Label();
            this.textBox_PostalCode = new System.Windows.Forms.TextBox();
            this.TelephoneNumber = new System.Windows.Forms.Label();
            this.textBox_TelephoneNumber = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.PrimaryLanguage = new System.Windows.Forms.Label();
            this.textBox_PrimaryLanguage = new System.Windows.Forms.TextBox();
            this.AccountID = new System.Windows.Forms.Label();
            this.textBox_AccountID = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(713, 415);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 0;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // textBox_CustomerID
            // 
            this.textBox_CustomerID.Location = new System.Drawing.Point(218, 72);
            this.textBox_CustomerID.Name = "textBox_CustomerID";
            this.textBox_CustomerID.Size = new System.Drawing.Size(169, 20);
            this.textBox_CustomerID.TabIndex = 1;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CustomerID.Location = new System.Drawing.Point(117, 72);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(95, 20);
            this.CustomerID.TabIndex = 2;
            this.CustomerID.Text = "CustomerID";
            // 
            // CustomerFirstName
            // 
            this.CustomerFirstName.AutoSize = true;
            this.CustomerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CustomerFirstName.Location = new System.Drawing.Point(53, 121);
            this.CustomerFirstName.Name = "CustomerFirstName";
            this.CustomerFirstName.Size = new System.Drawing.Size(159, 20);
            this.CustomerFirstName.TabIndex = 4;
            this.CustomerFirstName.Text = "Customer First Name";
            // 
            // textBox_CustomerFirstName
            // 
            this.textBox_CustomerFirstName.Location = new System.Drawing.Point(218, 121);
            this.textBox_CustomerFirstName.Name = "textBox_CustomerFirstName";
            this.textBox_CustomerFirstName.Size = new System.Drawing.Size(169, 20);
            this.textBox_CustomerFirstName.TabIndex = 3;
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.AutoSize = true;
            this.CustomerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CustomerLastName.Location = new System.Drawing.Point(53, 166);
            this.CustomerLastName.Name = "CustomerLastName";
            this.CustomerLastName.Size = new System.Drawing.Size(159, 20);
            this.CustomerLastName.TabIndex = 6;
            this.CustomerLastName.Text = "Customer Last Name";
            // 
            // textBox_CustomerLastName
            // 
            this.textBox_CustomerLastName.Location = new System.Drawing.Point(218, 166);
            this.textBox_CustomerLastName.Name = "textBox_CustomerLastName";
            this.textBox_CustomerLastName.Size = new System.Drawing.Size(169, 20);
            this.textBox_CustomerLastName.TabIndex = 5;
            // 
            // StreetAddress
            // 
            this.StreetAddress.AutoSize = true;
            this.StreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StreetAddress.Location = new System.Drawing.Point(96, 219);
            this.StreetAddress.Name = "StreetAddress";
            this.StreetAddress.Size = new System.Drawing.Size(116, 20);
            this.StreetAddress.TabIndex = 8;
            this.StreetAddress.Text = "Street Address";
            // 
            // textBox_StreetAddress
            // 
            this.textBox_StreetAddress.Location = new System.Drawing.Point(218, 219);
            this.textBox_StreetAddress.Name = "textBox_StreetAddress";
            this.textBox_StreetAddress.Size = new System.Drawing.Size(169, 20);
            this.textBox_StreetAddress.TabIndex = 7;
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.City.Location = new System.Drawing.Point(177, 263);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(35, 20);
            this.City.TabIndex = 10;
            this.City.Text = "City";
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(218, 263);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(169, 20);
            this.textBox_City.TabIndex = 9;
            // 
            // Province
            // 
            this.Province.AutoSize = true;
            this.Province.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Province.Location = new System.Drawing.Point(143, 314);
            this.Province.Name = "Province";
            this.Province.Size = new System.Drawing.Size(69, 20);
            this.Province.TabIndex = 12;
            this.Province.Text = "Province";
            // 
            // textBox_Province
            // 
            this.textBox_Province.Location = new System.Drawing.Point(218, 314);
            this.textBox_Province.Name = "textBox_Province";
            this.textBox_Province.Size = new System.Drawing.Size(169, 20);
            this.textBox_Province.TabIndex = 11;
            // 
            // PostalCode
            // 
            this.PostalCode.AutoSize = true;
            this.PostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PostalCode.Location = new System.Drawing.Point(117, 363);
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.Size = new System.Drawing.Size(95, 20);
            this.PostalCode.TabIndex = 14;
            this.PostalCode.Text = "Postal Code";
            // 
            // textBox_PostalCode
            // 
            this.textBox_PostalCode.Location = new System.Drawing.Point(218, 363);
            this.textBox_PostalCode.Name = "textBox_PostalCode";
            this.textBox_PostalCode.Size = new System.Drawing.Size(169, 20);
            this.textBox_PostalCode.TabIndex = 13;
            // 
            // TelephoneNumber
            // 
            this.TelephoneNumber.AutoSize = true;
            this.TelephoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TelephoneNumber.Location = new System.Drawing.Point(439, 72);
            this.TelephoneNumber.Name = "TelephoneNumber";
            this.TelephoneNumber.Size = new System.Drawing.Size(144, 20);
            this.TelephoneNumber.TabIndex = 16;
            this.TelephoneNumber.Text = "Telephone Number";
            // 
            // textBox_TelephoneNumber
            // 
            this.textBox_TelephoneNumber.Location = new System.Drawing.Point(589, 72);
            this.textBox_TelephoneNumber.Name = "textBox_TelephoneNumber";
            this.textBox_TelephoneNumber.Size = new System.Drawing.Size(169, 20);
            this.textBox_TelephoneNumber.TabIndex = 15;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Email.Location = new System.Drawing.Point(535, 121);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 20);
            this.Email.TabIndex = 18;
            this.Email.Text = "Email";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(589, 121);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(169, 20);
            this.textBox_Email.TabIndex = 17;
            // 
            // PrimaryLanguage
            // 
            this.PrimaryLanguage.AutoSize = true;
            this.PrimaryLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PrimaryLanguage.Location = new System.Drawing.Point(446, 166);
            this.PrimaryLanguage.Name = "PrimaryLanguage";
            this.PrimaryLanguage.Size = new System.Drawing.Size(137, 20);
            this.PrimaryLanguage.TabIndex = 20;
            this.PrimaryLanguage.Text = "Primary Language";
            // 
            // textBox_PrimaryLanguage
            // 
            this.textBox_PrimaryLanguage.Location = new System.Drawing.Point(589, 166);
            this.textBox_PrimaryLanguage.Name = "textBox_PrimaryLanguage";
            this.textBox_PrimaryLanguage.Size = new System.Drawing.Size(169, 20);
            this.textBox_PrimaryLanguage.TabIndex = 19;
            // 
            // AccountID
            // 
            this.AccountID.AutoSize = true;
            this.AccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccountID.Location = new System.Drawing.Point(498, 219);
            this.AccountID.Name = "AccountID";
            this.AccountID.Size = new System.Drawing.Size(85, 20);
            this.AccountID.TabIndex = 22;
            this.AccountID.Text = "AccountID";
            // 
            // textBox_AccountID
            // 
            this.textBox_AccountID.Location = new System.Drawing.Point(589, 219);
            this.textBox_AccountID.Name = "textBox_AccountID";
            this.textBox_AccountID.Size = new System.Drawing.Size(169, 20);
            this.textBox_AccountID.TabIndex = 21;
            // 
            // InsertButton
            // 
            this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.InsertButton.Location = new System.Drawing.Point(539, 291);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(134, 69);
            this.InsertButton.TabIndex = 23;
            this.InsertButton.Text = "Insert Data";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(245, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "CSCN72000 Assignment 4 - Hayden Auterhoff";
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.AccountID);
            this.Controls.Add(this.textBox_AccountID);
            this.Controls.Add(this.PrimaryLanguage);
            this.Controls.Add(this.textBox_PrimaryLanguage);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.TelephoneNumber);
            this.Controls.Add(this.textBox_TelephoneNumber);
            this.Controls.Add(this.PostalCode);
            this.Controls.Add(this.textBox_PostalCode);
            this.Controls.Add(this.Province);
            this.Controls.Add(this.textBox_Province);
            this.Controls.Add(this.City);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.StreetAddress);
            this.Controls.Add(this.textBox_StreetAddress);
            this.Controls.Add(this.CustomerLastName);
            this.Controls.Add(this.textBox_CustomerLastName);
            this.Controls.Add(this.CustomerFirstName);
            this.Controls.Add(this.textBox_CustomerFirstName);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.textBox_CustomerID);
            this.Controls.Add(this.ReturnButton);
            this.Name = "AddCustomerForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.TextBox textBox_CustomerID;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.Label CustomerFirstName;
        private System.Windows.Forms.TextBox textBox_CustomerFirstName;
        private System.Windows.Forms.Label CustomerLastName;
        private System.Windows.Forms.TextBox textBox_CustomerLastName;
        private System.Windows.Forms.Label StreetAddress;
        private System.Windows.Forms.TextBox textBox_StreetAddress;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.Label Province;
        private System.Windows.Forms.TextBox textBox_Province;
        private System.Windows.Forms.Label PostalCode;
        private System.Windows.Forms.TextBox textBox_PostalCode;
        private System.Windows.Forms.Label TelephoneNumber;
        private System.Windows.Forms.TextBox textBox_TelephoneNumber;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label PrimaryLanguage;
        private System.Windows.Forms.TextBox textBox_PrimaryLanguage;
        private System.Windows.Forms.Label AccountID;
        private System.Windows.Forms.TextBox textBox_AccountID;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label label2;
    }
}