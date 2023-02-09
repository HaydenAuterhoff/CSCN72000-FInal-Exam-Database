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
    public partial class ReportForm : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=root;database=arnolda_hauterhoff6824");

        private Form1 mainForm;
        public ReportForm(Form1 callingForm)
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

        //Generate Report that searches for a CustomerID based on the Name user input --> Return message if CustomerID doesn't match a value
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Validate User Input in each textbox
            if (textBox_CustomerFirstName.Text == "" || textBox_CustomerFirstName.Text.Length > 25)
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

            //INSERT user input using a SQL query
            else
            {
                var watch = System.Diagnostics.Stopwatch.StartNew(); //Execution Time - Start

                con.Open();
                string query = "SELECT * FROM customer WHERE CustomerFirstName='" + textBox_CustomerFirstName.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, con);


                MySqlDataReader mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {
                    watch.Stop(); //Execution Time - Stop
                    var elapsedMs = watch.ElapsedMilliseconds;

                    MessageBox.Show("CustomerID: " + mdr.GetString("CustomerID") + "\n"
                        + "Time taken: " + elapsedMs + " milliseconds");
                }

                else
                {
                    watch.Stop(); //Execution Time - Stop
                    var elapsedMs = watch.ElapsedMilliseconds;

                    MessageBox.Show("No Data for This Name\n"
                        + "Time taken: " + elapsedMs + " milliseconds");
                }

                con.Close();
            }
        }

        //Generate Report to return all of the stored information of a Customer based on only the CustomerID user input --> Return message if CustomerID doesn't match a value
        private void FindInfoButton_Click(object sender, EventArgs e)
        {

            //Validate User Input in each textbox
            if (textBox_CustomerID.Text == "" || System.Text.RegularExpressions.Regex.IsMatch(textBox_CustomerID.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter a number for CustomerID. \n");
                //textBox_CustomerID.Text = textBox_CustomerID.Text.Remove(textBox_CustomerID.Text.Length - 1);
                this.Controls.Clear();
                this.InitializeComponent();
            }

            else
            {
                var watch = System.Diagnostics.Stopwatch.StartNew(); //Execution Time - Start

                con.Open();
                string query = "SELECT * FROM customer WHERE CustomerID=" + int.Parse(textBox_CustomerID.Text);
                MySqlCommand cmd = new MySqlCommand(query, con);


                MySqlDataReader mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {
                    watch.Stop(); //Execution Time - Stop
                    var elapsedMs = watch.ElapsedMilliseconds;

                    MessageBox.Show("First Name: " + mdr.GetString("CustomerFirstName") + "\n"
                        + "Last Name: " + mdr.GetString("CustomerLastName") + "\n"
                        + "Street Address: " + mdr.GetString("StreetAddress") + "\n"
                        + "City: " + mdr.GetString("City") + "\n"
                        + "Province: " + mdr.GetString("Province") + "\n"
                        + "Postal Code: " + mdr.GetString("PostalCode") + "\n"
                        + "Telephone Number: " + mdr.GetString("TelephoneNumber") + "\n"
                        + "Email: " + mdr.GetString("Email") + "\n"
                        + "Primary Language: " + mdr.GetString("PrimaryLanguage") + "\n"
                        + "AccountID: " + mdr.GetString("AccountID")
                        + "\n"
                        + "Time take: " + elapsedMs + " milliseconds");
                }

                else
                {
                    watch.Stop(); //Execution Time - Stop
                    var elapsedMs = watch.ElapsedMilliseconds;

                    MessageBox.Show("No Data for This Name\n"
                        + "Time taken: " + elapsedMs + " millseconds");
                }

                con.Close();
            }
        }

        //Generate Report by SELECT from two different tables with INNER JOIN and select only the user input with WHERE --> fill the DataGridView with return info
        private void button1_Click(object sender, EventArgs e)
        {

            //Validate User Input in each textbox
            if (textBox4.Text == "" || textBox4.Text.Length > 25)
            {
                MessageBox.Show("Entry for Customer First Name is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox3.Text == "" || textBox3.Text.Length > 25)
            {
                MessageBox.Show("Entry for Customer Last Name is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }

            //INSERT user input using a SQL query
            else
            {
                var watch = System.Diagnostics.Stopwatch.StartNew(); //Execution Time - Start

                con.Open();

                string query = "SELECT customerorder.orderID, customerorder.OrderDate, customer.CustomerFirstName, customer.CustomerLastName " +
                    "FROM customerorder " +
                    "INNER JOIN customer " +
                    "ON customerorder.CustomerID = customer.CustomerID " +
                    "WHERE CustomerFirstName='" + textBox4.Text + "'";
                MySqlDataAdapter SDA = new MySqlDataAdapter(query, con);
                DataSet DS = new System.Data.DataSet();
                SDA.Fill(DS);
                dgv.DataSource = DS.Tables[0];

                //dgv.DataSource = DS;
                dgv.Columns[0].HeaderText = "orderID";
                dgv.Columns[1].HeaderText = "OrderDate";
                dgv.Columns[2].HeaderText = "CustomerFirstName";
                dgv.Columns[3].HeaderText = "CustomerLastName";

                //MySqlCommand query = new MySqlCommand("SELECT customerorder.orderID, customerorder.OrderDate, customer.CustomerFirstName, customer.CustomerLastName " +
                //    "FROM customerorder " +
                //    "INNER JOIN customer " +
                //    "ON customerorder.CustomerID = customer.CustomerID " +
                //    "WHERE CustomerFirstName='" + textBox4.Text + "'");
                //MySqlDataAdapter SDA = new MySqlDataAdapter();
                //SDA.SelectCommand = query;
                //DataTable DT = new DataTable();
                //SDA.Fill(DT);

                watch.Stop(); //Execution Time - Stop
                var elapsedMs = watch.ElapsedMilliseconds;

                MessageBox.Show("Time taken: " + elapsedMs + " milliseconds");

                con.Close();
            }
        }
    }
}
