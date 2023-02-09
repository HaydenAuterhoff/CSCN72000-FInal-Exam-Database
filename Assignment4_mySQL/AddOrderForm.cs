using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_mySQL
{
    public partial class AddOrderForm : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=root;database=arnolda_hauterhoff6824");

        private Form1 mainForm;
        public AddOrderForm(Form1 callingForm)
        {
            this.mainForm = callingForm;
            InitializeComponent();
        }

        //Return to main page
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        //Create SQL query to insert information into the Order Table on the database
        private void InsertButton_Click(object sender, EventArgs e)
        {

            //Validate User Input in each textbox
            if (textBox_OrderID.Text == "" || System.Text.RegularExpressions.Regex.IsMatch(textBox_OrderID.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter a number for OrderID. \n");
                //textBox_CustomerID.Text = textBox_CustomerID.Text.Remove(textBox_CustomerID.Text.Length - 1);
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_CustomerID.Text == "" || System.Text.RegularExpressions.Regex.IsMatch(textBox_CustomerID.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter a number for CustomerID. \n");
                //textBox_CustomerID.Text = textBox_CustomerID.Text.Remove(textBox_CustomerID.Text.Length - 1);
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_BranchID.Text == "" || System.Text.RegularExpressions.Regex.IsMatch(textBox_BranchID.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter a number for BranchID. \n");
                //textBox_CustomerID.Text = textBox_CustomerID.Text.Remove(textBox_CustomerID.Text.Length - 1);
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_CreditAuthorizationStatus.Text == "" || textBox_CreditAuthorizationStatus.Text.Length > 25)
            {
                MessageBox.Show("Entry for Credit Authorization Status is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_OrderDate.Text == "" || textBox_OrderDate.Text.Length > 25)
            {
                MessageBox.Show("Entry for Order Date is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }

            //INSERT user input using a SQL query
            else
            {
                var watch = System.Diagnostics.Stopwatch.StartNew(); //Execution Time - Start

                con.Open();
                string query = "INSERT INTO customerorder (OrderID, CustomerID, OrderDate, CreditAuthorizationStatus, BranchID) " +
                    "VALUES (" + textBox_OrderID.Text + "," + textBox_CustomerID.Text + ",'" + textBox_OrderDate.Text + "', " +
                    "'" + textBox_CreditAuthorizationStatus.Text + "'," + textBox_BranchID.Text + ")";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                watch.Stop(); //Execution Time - Stop
                var elapsedMs = watch.ElapsedMilliseconds;

                MessageBox.Show("The information has been added to the Arnolda Database! \n" +
                    "Please press the Return Button if you are finish or enter another entry!\n" +
                    "\n" +
                    "Time taken: " + elapsedMs + " milliseconds");
                con.Close();
            }
        }
    }
}
