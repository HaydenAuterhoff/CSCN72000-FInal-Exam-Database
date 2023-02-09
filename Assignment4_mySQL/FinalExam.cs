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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment4_mySQL
{
    public partial class FinalExam : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=root;database=arnolda_hauterhoff6824");
        private Form1 mainForm;
        public FinalExam(Form1 callingForm)
        {
            this.mainForm = callingForm;
            InitializeComponent();
        }

        private void FinalExam_Load(object sender, EventArgs e)
        {

        }

        //Return to main page
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        //INSERT Dependent that references a valid Employee Name in the database (First and Last Name) 
        private void AddDependent_Click(object sender, EventArgs e)
        {
            //Validate User Input in each textbox
            if (textBox_Q2EmployeeFirstName.Text == "" || textBox_Q2EmployeeFirstName.Text.Length > 25)
            {
                MessageBox.Show("Entry for Employee First Name is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_Q2EmployeeLastName.Text == "" || textBox_Q2EmployeeLastName.Text.Length > 25)
            {
                MessageBox.Show("Entry for Employee Last Name is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_Q2DependentFirstName.Text == "" || textBox_Q2DependentFirstName.Text.Length > 25)
            {
                MessageBox.Show("Entry for Dependent First Name is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_Q2DependentLastName.Text == "" || textBox_Q2DependentLastName.Text.Length > 25)
            {
                MessageBox.Show("Entry for Dependent Last Name is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else if (textBox_Q2Relationship.Text == "" || textBox_Q2Relationship.Text.Length > 25)
            {
                MessageBox.Show("Entry for Relationship is incorrect! \n" +
                    "(No Entry or Too Long)");
                this.Controls.Clear();
                this.InitializeComponent();
            }

            //Insert User Input for Employee Name -- return EmployeeID
            else
            {
                var watch = System.Diagnostics.Stopwatch.StartNew(); //Execution Time - Start

                con.Open();
                string query = "SELECT * FROM employee WHERE EmployeeFirstName='" + textBox_Q2EmployeeFirstName.Text + "'AND EmployeeLastName='" + textBox_Q2EmployeeLastName.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    string EmployeeID = mdr.GetString("EmployeeID");
                    //MessageBox.Show("EmployeeID: " + mdr.GetString("EmployeeID"));
                    con.Close();

                    //------------------------------------------------------------------
                    //INSERT Dependent into table
                    con.Open();
                    string query2 = "INSERT INTO dependent (FirstName, LastName, EmployeeID, Relationship) " +
                        "VALUES ('" + textBox_Q2DependentFirstName.Text + "','" + textBox_Q2DependentLastName.Text + "'," + EmployeeID + ",'" + textBox_Q2Relationship.Text + "')";
                    MySqlCommand cmd2 = new MySqlCommand(query2, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();

                    //------------------------------------------------------------------
                    //Display on Data Grid View
                    con.Open();
                    string query3 = "SELECT employee.EmployeeFirstName, employee.EmployeeLastName, dependent.FirstName, dependent.LastName, dependent.Relationship " +
                        "FROM employee " +
                        "INNER JOIN dependent " +
                        "ON employee.EmployeeID = dependent.EmployeeID " +
                        "WHERE EmployeeFirstName='" + textBox_Q2EmployeeFirstName.Text + "'" +
                        "AND EmployeeLastName='" + textBox_Q2EmployeeLastName.Text + "'";
                    ;
                    MySqlDataAdapter SDA = new MySqlDataAdapter(query3, con);
                    DataSet DS = new System.Data.DataSet();
                    SDA.Fill(DS);
                    dgv2.DataSource = DS.Tables[0];

                    //dgv.DataSource = DS;
                    dgv2.Columns[0].HeaderText = "EmployeeFirstName";
                    dgv2.Columns[1].HeaderText = "EmployeeLastName";
                    dgv2.Columns[2].HeaderText = "FirstName";
                    dgv2.Columns[3].HeaderText = "LastName";
                    dgv2.Columns[4].HeaderText = "Relationship";

                    watch.Stop(); //Execution Time - Stop
                    var elapsedMs = watch.ElapsedMilliseconds;

                    MessageBox.Show("Time taken: " + elapsedMs + " milliseconds");
                }

                else
                {
                    watch.Stop(); //Execution Time - Stop
                    var elapsedMs = watch.ElapsedMilliseconds;

                    MessageBox.Show("No Data for This Name\n"
                        + "Time taken: " + elapsedMs + " milliseconds");
                }
            }

            con.Close();

        }

        //Using Aggregate Functions such as SUM and AVG to generate a sale report that meets specific criteria
        private void GenerateSalesReport_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew(); //Execution Time - Start

            con.Open();
            string query = "SELECT\r\n" +
                "\tCOUNT(*) AS 'Number of Order',\r\n" +
                "    SUM(orderline.OrderedQuantity * item.price) AS 'Total Sales',\r\n" +
                "    AVG(orderline.OrderedQuantity * item.price) AS 'Average Order Value',\r\n" +
                "    (SELECT COUNT(*) \r\n" +
                "\t\tFROM orderline \r\n" +
                "\t\tWHERE (SELECT SUM(orderline.OrderedQuantity * item.price)) > (SELECT AVG(orderline.OrderedQuantity * item.price)\r\n" +
                "        FROM orderline)) AS 'Orders Above Average'\r\n" +
                "FROM orderline\r\n" +
                "INNER JOIN item\r\n" +
                "ON orderline.ItemID = item.ItemID;";

            MySqlDataAdapter SDA = new MySqlDataAdapter(query, con);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS);
            dgv3.DataSource = DS.Tables[0];

            dgv3.Columns[0].HeaderText = "Number of Orders";
            dgv3.Columns[1].HeaderText = "Total Sales";
            dgv3.Columns[2].HeaderText = "Average Order Value";
            dgv3.Columns[3].HeaderText = "Orders Above Average";

            watch.Stop(); //Execution Time - Stop
            var elapsedMs = watch.ElapsedMilliseconds;

            MessageBox.Show("Time taken: " + elapsedMs + " milliseconds");

            con.Close();
        }

        //Using Aggregate function along with GROUP BY and HAVING to generate a sales report that indicates all orders over 50$
        private void GenerateSalesAbove50_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew(); //Execution Time - Start

            con.Open();
            string query = "SELECT orderline.OrderID,\r\n" +
                "    SUM(orderline.OrderedQuantity * item.price) AS 'Total Sales'\r\n" +
                "FROM orderline\r\n" +
                "INNER JOIN item\r\n" +
                "ON orderline.ItemID = item.ItemID\r\n" +
                "GROUP BY OrderID\r\n" +
                "HAVING SUM(orderline.OrderedQuantity * item.price) > 50;";

            MySqlDataAdapter SDA = new MySqlDataAdapter(query, con);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS);
            dgv4.DataSource = DS.Tables[0];

            dgv4.Columns[0].HeaderText = "OrderID";
            dgv4.Columns[1].HeaderText = "Total Sales";

            watch.Stop(); //Execution Time - Stop
            var elapsedMs = watch.ElapsedMilliseconds;

            MessageBox.Show("Time taken: " + elapsedMs + " milliseconds");

            con.Close();
        }

        //Using multiple JOINs to connect various tables to indicate the items a customer ordered that include composite items
        private void GenerateCustomerInfo_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew(); //Execution Time - Start

            con.Open();
            string query = "SELECT o.OrderID, o.CustomerID, ol.ItemID, c.CompositeID, c.CompositeDescription, i.ItemDescription\r\n" +
                "FROM `customerorder` o\r\n" +
                "INNER JOIN Orderline ol ON o.OrderID = ol.OrderID\r\n" +
                "INNER JOIN composite_item c ON ol.ItemID = c.ItemID\r\n" +
                "INNER JOIN Item i ON c.ItemID = i.ItemID\r\nWHERE CustomerID = 6;";

            MySqlDataAdapter SDA = new MySqlDataAdapter(query, con);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS);
            dgv1.DataSource = DS.Tables[0];

            dgv1.Columns[0].HeaderText = "OrderID";
            dgv1.Columns[1].HeaderText = "CustomerID";
            dgv1.Columns[2].HeaderText = "ItemID";
            dgv1.Columns[3].HeaderText = "CompositeID";
            dgv1.Columns[4].HeaderText = "CompositeDescription";
            dgv1.Columns[5].HeaderText = "ItemDescription";

            watch.Stop(); //Execution Time - Stop
            var elapsedMs = watch.ElapsedMilliseconds;

            MessageBox.Show("Time taken: " + elapsedMs + " milliseconds");

            con.Close();

        }
    }
}
