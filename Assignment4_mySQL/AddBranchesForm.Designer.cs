namespace Assignment4_mySQL
{
    partial class AddBranchesForm
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
            this.BranchID = new System.Windows.Forms.Label();
            this.textBox_BranchID = new System.Windows.Forms.TextBox();
            this.BranchInfo = new System.Windows.Forms.Label();
            this.textBox_BranchInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BranchLocation = new System.Windows.Forms.Label();
            this.textBox_BranchLocation = new System.Windows.Forms.TextBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BranchID
            // 
            this.BranchID.AutoSize = true;
            this.BranchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BranchID.Location = new System.Drawing.Point(164, 124);
            this.BranchID.Name = "BranchID";
            this.BranchID.Size = new System.Drawing.Size(77, 20);
            this.BranchID.TabIndex = 4;
            this.BranchID.Text = "BranchID";
            // 
            // textBox_BranchID
            // 
            this.textBox_BranchID.Location = new System.Drawing.Point(247, 124);
            this.textBox_BranchID.Name = "textBox_BranchID";
            this.textBox_BranchID.Size = new System.Drawing.Size(169, 20);
            this.textBox_BranchID.TabIndex = 3;
            // 
            // BranchInfo
            // 
            this.BranchInfo.AutoSize = true;
            this.BranchInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BranchInfo.Location = new System.Drawing.Point(153, 176);
            this.BranchInfo.Name = "BranchInfo";
            this.BranchInfo.Size = new System.Drawing.Size(88, 20);
            this.BranchInfo.TabIndex = 6;
            this.BranchInfo.Text = "BranchInfo";
            // 
            // textBox_BranchInfo
            // 
            this.textBox_BranchInfo.Location = new System.Drawing.Point(247, 176);
            this.textBox_BranchInfo.Name = "textBox_BranchInfo";
            this.textBox_BranchInfo.Size = new System.Drawing.Size(169, 20);
            this.textBox_BranchInfo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "(Entry is a FK that matches BranchID)";
            // 
            // BranchLocation
            // 
            this.BranchLocation.AutoSize = true;
            this.BranchLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BranchLocation.Location = new System.Drawing.Point(116, 238);
            this.BranchLocation.Name = "BranchLocation";
            this.BranchLocation.Size = new System.Drawing.Size(125, 20);
            this.BranchLocation.TabIndex = 9;
            this.BranchLocation.Text = "Branch Location";
            // 
            // textBox_BranchLocation
            // 
            this.textBox_BranchLocation.Location = new System.Drawing.Point(247, 238);
            this.textBox_BranchLocation.Name = "textBox_BranchLocation";
            this.textBox_BranchLocation.Size = new System.Drawing.Size(169, 20);
            this.textBox_BranchLocation.TabIndex = 8;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(713, 415);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 10;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.InsertButton.Location = new System.Drawing.Point(516, 151);
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
            this.label2.Location = new System.Drawing.Point(243, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "CSCN72000 Assignment 4 - Hayden Auterhoff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(211, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Note: need to disable Global FK check in MySQL to add to table";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddBranchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.BranchLocation);
            this.Controls.Add(this.textBox_BranchLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BranchInfo);
            this.Controls.Add(this.textBox_BranchInfo);
            this.Controls.Add(this.BranchID);
            this.Controls.Add(this.textBox_BranchID);
            this.Name = "AddBranchesForm";
            this.Text = "AddBranchesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BranchID;
        private System.Windows.Forms.TextBox textBox_BranchID;
        private System.Windows.Forms.Label BranchInfo;
        private System.Windows.Forms.TextBox textBox_BranchInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BranchLocation;
        private System.Windows.Forms.TextBox textBox_BranchLocation;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}