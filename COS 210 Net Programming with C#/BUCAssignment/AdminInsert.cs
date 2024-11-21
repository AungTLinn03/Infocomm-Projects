using System;//using the System library in your project.
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//using namespace
using System.Data.SqlClient;//Provides a way of reading a forward-only stream of rows from a SQL Server database.
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//to provide an easier interface to develop the applications for desktop, tablet, PCs.

namespace BUCAssignment//Database
{
    //This is form is based on Admin where selecting any of the option on interface to move another respective form
    public partial class AdminInsert : Form
    {
        public AdminInsert()
        {
            InitializeComponent();//code that creates and initializes the user interface objects dragged on the form surface with the values provided by programmer
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RdbStaff_CheckedChanged(object sender, EventArgs e)
        {

            try//this try catch exception block will execute on different thread
            {
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn2.Open();//connection open
                SqlCommand cmd2 = conn2.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd2.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd2.CommandText = "select * from staff";//the command line represent the select staff data from database
                cmd2.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada2 = new SqlDataAdapter(cmd2);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt2 = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                ada2.Fill(dt2);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm3.DataSource = dt2;//Datasource i.e viewing data form dataset into DataGridview
                conn2.Close();//connection close
            }
            catch (Exception ex) //catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RdbClass_CheckedChanged(object sender, EventArgs e)
        {
            try //this try catch exception block will execute on different thread
            {
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn1.Open();//connection open
                SqlCommand cmd1 = conn1.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd1.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd1.CommandText = "select * from Classes";//the command line represent the select class data from database
                cmd1.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada1 = new SqlDataAdapter(cmd1);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt1 = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                ada1.Fill(dt1);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm3.DataSource = dt1;//Datasource i.e viewing data form dataset into DataGridview
                conn1.Close();//connection close
            }
            catch (Exception ex) //catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RdbTrainer_CheckedChanged(object sender, EventArgs e)
        {
            try //this try catch exception block will execute on different thread
            {
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn4 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn4.Open();//connection open
                SqlCommand cmd4 = conn4.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd4.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd4.CommandText = "select * from Trainer";//the command line represent the select trainer data from database
                cmd4.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada4 = new SqlDataAdapter(cmd4);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt4 = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                ada4.Fill(dt4);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm3.DataSource = dt4;//Datasource i.e viewing data form dataset into DataGridview
                conn4.Close();//connection close
            }
            catch (Exception ex) //catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try //this try catch exception block will execute on different thread
            {
                //validation
                if (RdbTrainer.Checked == true)//if Rdbtrainer checked is true it will proceed
                {
                    var AdminInsertafterview = new AdminInsertafterview();//attached to admiinsertafterview  registration
                    AdminInsertafterview.Show();//show
                    this.Visible = false;//set contol visibility false
                }
                if (RdbStaff.Checked == true)//if Staff checked is true it will proceed
                {
                    var AdminInserafterview1 = new AdminInsertafterview1();//attached to admininsertafterview  registration
                    AdminInserafterview1.Show();//show
                    this.Visible = false;//set contol visibility false
                }

                if (RdbClass.Checked == true)//if RdbClass checked is true it will proceed
                {
                    var AdminInserafterview1 = new AdminInsertafterview1();//attached to admininsertafterview  registration
                    AdminInserafterview1.Show();//show
                    this.Visible = false;//set contol visibility false
                }
            }
            catch (Exception ex) //catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminInsert_Load(object sender, EventArgs e)
        {
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var AdminSearch = new AdminSearch();//attached to Welcom  registration
            AdminSearch.Show();
            this.Visible = false;//set contol visibility false
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var AdminView = new AdminView();//attached to Welcom  registration
            AdminView.Show();
            this.Visible = false;//set contol visibility false
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Updatepreview = new Updatepreview();//attached to Welcom  registration
            Updatepreview.Show();
            this.Visible = false;//set contol visibility false
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var AdminInsert = new AdminInsert();//attached to Welcom  registration
           AdminInsert.Show();
            this.Visible = false;//set contol visibility false
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var AdminDelete = new AdminDelete();//attached to Welcom  registration
            AdminDelete.Show();
            this.Visible = false;//set contol visibility false
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();//attached to Welcom  registration
            Form3.Show();
            this.Visible = false;//set contol visibility false
        }
    }
    }

