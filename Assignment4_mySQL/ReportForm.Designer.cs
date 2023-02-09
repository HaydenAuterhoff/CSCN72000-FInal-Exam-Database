namespace Assignment4_mySQL
{
    partial class ReportForm
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
            this.SearchCustomerIDButton = new System.Windows.Forms.Button();
            this.FindInfoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CustomerLastName = new System.Windows.Forms.Label();
            this.textBox_CustomerLastName = new System.Windows.Forms.TextBox();
            this.CustomerFirstName = new System.Windows.Forms.Label();
            this.textBox_CustomerFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.Label();
            this.textBox_CustomerID = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(1115, 415);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 0;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // SearchCustomerIDButton
            // 
            this.SearchCustomerIDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCustomerIDButton.Location = new System.Drawing.Point(92, 286);
            this.SearchCustomerIDButton.Name = "SearchCustomerIDButton";
            this.SearchCustomerIDButton.Size = new System.Drawing.Size(124, 49);
            this.SearchCustomerIDButton.TabIndex = 6;
            this.SearchCustomerIDButton.Text = "Search";
            this.SearchCustomerIDButton.UseVisualStyleBackColor = true;
            this.SearchCustomerIDButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FindInfoButton
            // 
            this.FindInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindInfoButton.Location = new System.Drawing.Point(349, 211);
            this.FindInfoButton.Name = "FindInfoButton";
            this.FindInfoButton.Size = new System.Drawing.Size(124, 49);
            this.FindInfoButton.TabIndex = 7;
            this.FindInfoButton.Text = "Search";
            this.FindInfoButton.UseVisualStyleBackColor = true;
            this.FindInfoButton.Click += new System.EventHandler(this.FindInfoButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(603, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.AutoSize = true;
            this.CustomerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLastName.Location = new System.Drawing.Point(63, 225);
            this.CustomerLastName.Name = "CustomerLastName";
            this.CustomerLastName.Size = new System.Drawing.Size(132, 16);
            this.CustomerLastName.TabIndex = 12;
            this.CustomerLastName.Text = "Customer Last Name";
            // 
            // textBox_CustomerLastName
            // 
            this.textBox_CustomerLastName.Location = new System.Drawing.Point(66, 244);
            this.textBox_CustomerLastName.Name = "textBox_CustomerLastName";
            this.textBox_CustomerLastName.Size = new System.Drawing.Size(169, 20);
            this.textBox_CustomerLastName.TabIndex = 11;
            // 
            // CustomerFirstName
            // 
            this.CustomerFirstName.AutoSize = true;
            this.CustomerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerFirstName.Location = new System.Drawing.Point(63, 169);
            this.CustomerFirstName.Name = "CustomerFirstName";
            this.CustomerFirstName.Size = new System.Drawing.Size(132, 16);
            this.CustomerFirstName.TabIndex = 10;
            this.CustomerFirstName.Text = "Customer First Name";
            // 
            // textBox_CustomerFirstName
            // 
            this.textBox_CustomerFirstName.Location = new System.Drawing.Point(66, 188);
            this.textBox_CustomerFirstName.Name = "textBox_CustomerFirstName";
            this.textBox_CustomerFirstName.Size = new System.Drawing.Size(169, 20);
            this.textBox_CustomerFirstName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(568, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Customer Last Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(571, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 20);
            this.textBox3.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(568, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Customer First Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(571, 150);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(169, 20);
            this.textBox4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(62, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 40);
            this.label5.TabIndex = 21;
            this.label5.Text = "Search for CustomerID \r\nby Customer Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(323, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 40);
            this.label6.TabIndex = 22;
            this.label6.Text = "Find the Customer Info\r\nby CustomerID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(739, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Find ALL Items ordered by a Customer";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CustomerID.Location = new System.Drawing.Point(324, 152);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(81, 17);
            this.CustomerID.TabIndex = 25;
            this.CustomerID.Text = "CustomerID";
            // 
            // textBox_CustomerID
            // 
            this.textBox_CustomerID.Location = new System.Drawing.Point(327, 172);
            this.textBox_CustomerID.Name = "textBox_CustomerID";
            this.textBox_CustomerID.Size = new System.Drawing.Size(169, 20);
            this.textBox_CustomerID.TabIndex = 24;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(757, 131);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(433, 175);
            this.dgv.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(312, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 196);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(51, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 280);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(561, 78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(644, 243);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(411, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "CSCN72000 Assignment 4 - Hayden Auterhoff";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.textBox_CustomerID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.CustomerLastName);
            this.Controls.Add(this.textBox_CustomerLastName);
            this.Controls.Add(this.CustomerFirstName);
            this.Controls.Add(this.textBox_CustomerFirstName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FindInfoButton);
            this.Controls.Add(this.SearchCustomerIDButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Name = "ReportForm";
            this.Text = "JoinForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button SearchCustomerIDButton;
        private System.Windows.Forms.Button FindInfoButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CustomerLastName;
        private System.Windows.Forms.TextBox textBox_CustomerLastName;
        private System.Windows.Forms.Label CustomerFirstName;
        private System.Windows.Forms.TextBox textBox_CustomerFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.TextBox textBox_CustomerID;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
    }
}