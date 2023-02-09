using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Assignment4_mySQL
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=root;database=arnolda_hauterhoff6824");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Button establishes a connection with mySQL and the arnolda_hauterhoff6824 database. Visual way to show connection, not needed for other applications (View, Add, or Reports)
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var watch = System.Diagnostics.Stopwatch.StartNew(); //Execution Time - Start

                string connstring = "server=localhost;uid=root;pwd=root;database=arnolda_hauterhoff6824";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();

                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;

                MessageBox.Show("Connection established with Arnolda database! \n" +
                    "Time taken: " + elapsedMs + " milliseconds");
                button1.BackColor = Color.Chartreuse;

                button1.Enabled = false;

                //string sql = "select * from account";
                //MySqlCommand cmd = new MySqlCommand(sql, con);
                //MySqlDataReader reader = cmd.ExecuteReader();

                //while (reader.Read())
                //{
                //    MessageBox.Show("PaymentDates " + reader["PaymentDates"] + "PaymentAmounts: " + reader["PaymentAmounts"]);
                //}
            } 
            
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Generate table from mySQL that selects all of the information in the Customer Table
        private void CustomerListButton_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew(); ////Execution Time - Start

            string sqlstr = "SELECT * FROM customer";
            MySqlDataAdapter SDA = new MySqlDataAdapter(sqlstr, con);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS, "customer");
            dgv.DataSource = DS.Tables[0];

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            MessageBox.Show("Time take: " + elapsedMs + " milliseconds");
        }

        //Generate table from mySQL that selects all of the information in the CustomerOrder Table
        private void OrdersListButton_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew(); ////Execution Time - Start

            string sqlstr = "SELECT * FROM customerorder";
            MySqlDataAdapter SDA = new MySqlDataAdapter(sqlstr, con);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS, "customerorder");
            dgv.DataSource = DS.Tables[0];

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            MessageBox.Show("Time take: " + elapsedMs + " milliseconds");

        }

        //Generate table from mySQL that selects all of the information in the Branches Table
        private void BranchesListButton_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew(); ////Execution Time - Start

            string sqlstr = "SELECT * FROM branch";
            MySqlDataAdapter SDA = new MySqlDataAdapter(sqlstr, con);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS, "branch");
            dgv.DataSource = DS.Tables[0];

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            MessageBox.Show("Time take: " + elapsedMs + " milliseconds");

        }

        //Generate table from mySQL that selects all of the information in the Items Table
        private void ItemsListButton_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew(); ////Execution Time - Start

            string sqlstr = "SELECT * FROM item";
            MySqlDataAdapter SDA = new MySqlDataAdapter(sqlstr, con);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS, "item");
            dgv.DataSource = DS.Tables[0];

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            MessageBox.Show("Time take: " + elapsedMs + " milliseconds");
        }

        //Enter Add Customer Page
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm add = new AddCustomerForm(this);

            add.Show();

            this.Hide();
        }

        //Enter Add Branch Page
        private void AddBranchesButton_Click(object sender, EventArgs e)
        {
            AddBranchesForm add = new AddBranchesForm(this);

            add.Show();

            this.Hide();
        }

        //Enter Add Order Page
        private void AddOrderButtons_Click(object sender, EventArgs e)
        {
            AddOrderForm add = new AddOrderForm(this);

            add.Show();

            this.Hide();
        }

        //Enter Add Customer Page
        private void addButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm add = new AddCustomerForm(this);

            add.Show();

            this.Hide();
        }

        //Enter Report Page
        private void ReportButton_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm(this);

            report.Show();

            this.Hide();
        }

        //Exit Program
        private void ExitProgramButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           FinalExam exam = new FinalExam(this);

            exam.Show();

            this.Hide();
        }
    }
}
