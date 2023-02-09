using Google.Protobuf.Reflection;
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
    public partial class AddBranchesForm : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=root;database=arnolda_hauterhoff6824");

        private Form1 mainForm;
        public AddBranchesForm(Form1 callingForm)
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

        //Create SQL query to insert information into the Branch Table on the database
        private void InsertButton_Click(object sender, EventArgs e)
        {
            //Validate User Input in each textbox
            if (textBox_BranchID.Text == "" || System.Text.RegularExpressions.Regex.IsMatch(textBox_BranchID.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter a number for BranchID. \n");
                //textBox_CustomerID.Text = textBox_CustomerID.Text.Remove(textBox_CustomerID.Text.Length - 1);
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_BranchInfo.Text == "" || System.Text.RegularExpressions.Regex.IsMatch(textBox_BranchInfo.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter a number for BranchInfo. \n");
                //textBox_CustomerID.Text = textBox_CustomerID.Text.Remove(textBox_CustomerID.Text.Length - 1);
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_BranchLocation.Text == "" || textBox_BranchLocation.Text.Length > 25)
            {
                MessageBox.Show("Entry for Branch Location is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }

            //INSERT user input using a SQL query
            else
            {
                var watch = System.Diagnostics.Stopwatch.StartNew(); //Execution Time - Start

                con.Open();
                string query = "INSERT INTO branch (BranchID, BranchInfo, BranchLocation) " +
                    "VALUES (" + textBox_BranchID.Text + "," + textBox_BranchInfo.Text + ",'" + textBox_BranchLocation.Text + "')";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
