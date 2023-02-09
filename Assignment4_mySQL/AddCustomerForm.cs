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
    public partial class AddCustomerForm : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=root;database=arnolda_hauterhoff6824");

        private Form1 mainForm;

        public AddCustomerForm(Form1 callingForm)
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

        //Create SQL query to insert information into the Customer Table on the database
        private void InsertButton_Click(object sender, EventArgs e)
        {

            //Validate User Input in each textbox
            if (textBox_CustomerID.Text == "" || System.Text.RegularExpressions.Regex.IsMatch(textBox_CustomerID.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter a number for CustomerID. \n");
                //textBox_CustomerID.Text = textBox_CustomerID.Text.Remove(textBox_CustomerID.Text.Length - 1);
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_CustomerFirstName.Text == "" || textBox_CustomerFirstName.Text.Length > 25)
            {
                MessageBox.Show("Entry for Customer First Name is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_CustomerLastName.Text == "" || textBox_CustomerLastName.Text.Length > 25)
            {
                MessageBox.Show("Entry for Customer Last Name is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_StreetAddress.Text == "" || textBox_StreetAddress.Text.Length > 25)
            {
                MessageBox.Show("Entry for Street Address is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_City.Text == "" || textBox_City.Text.Length > 25)
            {
                MessageBox.Show("Entry for City is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_Province.Text == "" || textBox_Province.Text.Length > 25)
            {
                MessageBox.Show("Entry for Province is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_PostalCode.Text == "" || textBox_PostalCode.Text.Length > 25)
            {
                MessageBox.Show("Entry for Postal Code is incorrect \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_TelephoneNumber.Text == "" || textBox_TelephoneNumber.Text.Length > 25)
            {
                MessageBox.Show("Entry for Telephone Number is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_Email.Text == "" || textBox_Email.Text.Length > 25)
            {
                MessageBox.Show("Entry for Email is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_PrimaryLanguage.Text == "" || textBox_PrimaryLanguage.Text.Length > 25)
            {
                MessageBox.Show("Entry for Primary Language is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_AccountID.Text == "" || System.Text.RegularExpressions.Regex.IsMatch(textBox_AccountID.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter a number for AccountID.");
                this.Controls.Clear();
                this.InitializeComponent();
            }

            //INSERT user input using a SQL query
            else
            {
                var watch = System.Diagnostics.Stopwatch.StartNew(); //Execution Time - Start

                con.Open();
                string query = "INSERT INTO customer (CustomerID, CustomerFirstName, CustomerLastName, StreetAddress, " +
                    "City, Province, PostalCode, TelephoneNumber, Email, PrimaryLanguage, AccountID) VALUES " +
                    "(" + textBox_CustomerID.Text + ",'" + textBox_CustomerFirstName.Text + "','" + textBox_CustomerLastName.Text + "'," +
                    "'" + textBox_StreetAddress.Text + "','" + textBox_City.Text + "','" + textBox_Province.Text + "'," +
                    "'" + textBox_PostalCode.Text + "','" + textBox_TelephoneNumber.Text + "','" + textBox_Email.Text + "'," +
                    "'" + textBox_PrimaryLanguage.Text + "'," + textBox_AccountID.Text + ")";
                MySqlCommand cmd = new MySqlCommand(query, con);
                //int value = cmd.ExecuteNonQuery();
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
