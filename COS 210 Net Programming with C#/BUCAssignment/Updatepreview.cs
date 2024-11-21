using System;//using the System library in your project.
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//using namespace
using System.Data.SqlClient;//Provides a way of reading a forward-only stream of rows from a SQL Server database.
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//to provide an easier interface to develop the applications for desktop, tablet, PCs.

namespace BUCAssignment//Database
{
    public partial class Updatepreview : Form
    {
        public Updatepreview()
        {
            InitializeComponent();//code that creates and initializes the user interface objects dragged on the form surface with the values provided by programmer
        }

        private void RdbMember_CheckedChanged(object sender, EventArgs e)
        {
            try//this try catch exception block will execute on different thread
            {
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();//connection open
                SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "select * from Member";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dss1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RdbClass_CheckedChanged(object sender, EventArgs e)
        {
            try//this try catch exception block will execute on different thread
            {
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
            conn1.Open();//connection open
                SqlCommand cmd1 = conn1.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd1.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd1.CommandText = "select * from Classes";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
                cmd1.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada1 = new SqlDataAdapter(cmd1);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt1 = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.

                ada1.Fill(dt1);// Adds or refreshe rows in the DataSet to match those in the data source.
                dss1.DataSource = dt1;//Datasource i.e viewing data form dataset into DataGridview
                conn1.Close();//connection close
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
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
                cmd2.CommandText = "select * from staff";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
                cmd2.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada2 = new SqlDataAdapter(cmd2);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt2 = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.

                ada2.Fill(dt2);// Adds or refreshe rows in the DataSet to match those in the data source.
                dss1.DataSource = dt2;//Datasource i.e viewing data form dataset into DataGridview
                conn2.Close();//connection close
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RdbTrainer_CheckedChanged(object sender, EventArgs e)
        {
            try//this try catch exception block will execute on different thread
            {
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
            conn3.Open();//connection open
                SqlCommand cmd3 = conn3.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd3.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd3.CommandText = "select * from Trainer";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
                cmd3.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada3 = new SqlDataAdapter(cmd3);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt3 = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                ada3.Fill(dt3);// Adds or refreshe rows in the DataSet to match those in the data source.
                dss1.DataSource = dt3;//Datasource i.e viewing data form dataset into DataGridview
                conn3.Close();//connection close
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RdbEnrollment_CheckedChanged(object sender, EventArgs e)
        {

            try//this try catch exception block will execute on different thread
            {
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
            conn3.Open();//connection open
                SqlCommand cmd3 = conn3.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd3.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd3.CommandText = "select * from Enrollment";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
                cmd3.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada3 = new SqlDataAdapter(cmd3);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt3 = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                ada3.Fill(dt3);// Adds or refreshe rows in the DataSet to match those in the data source.
                dss1.DataSource = dt3;//Datasource i.e viewing data form dataset into DataGridview
                conn3.Close();//connection close
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try //this try catch exception block will execute on different thread
            {
                //validation
                if (RdbTrainer.Checked == true)//if Rdbtrainer checked is true it will proceed
                {
                    var AdminUpdate1 = new AdminUpdate1();//attached to admiinsertafterview  registration
                    AdminUpdate1.Show();//show
                    this.Visible = false;//set contol visibility false
                }
                if (RdbStaff.Checked == true)//if Staff checked is true it will proceed
                {
                    var AdminUpdate2cs = new AdminUpdate2cs();//attached to admininsertafterview  registration
                    AdminUpdate2cs.Show();//show
                    this.Visible = false;//set contol visibility false
                }

                if (RdbClass.Checked == true)//if RdbClass checked is true it will proceed
                {
                    var AdminUpdate3 = new AdminUpdate3();//attached to admininsertafterview  registration
                    AdminUpdate3.Show();//show
                    this.Visible = false;//set contol visibility false
                }
                if (RdbMember.Checked == true)//if RdbClass checked is true it will proceed
                {
                    var AdminUpdate = new AdminUpdate();//attached to admininsertafterview  registration
                    AdminUpdate.Show();//show
                    this.Visible = false;//set contol visibility false
                }
                if (RdbEnrollment.Checked == true)//if RdbClass checked is true it will proceed
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

        private void button7_Click(object sender, EventArgs e)
        {
            var AdminSearch = new AdminSearch();//attached to admininsertafterview  registration
            AdminSearch.Show();//show
            this.Visible = false;//set contol visibility false
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var AdminView = new AdminView();//attached to admininsertafterview  registration
            AdminView.Show();//show
            this.Visible = false;//set contol visibility false
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Updatepreview = new Updatepreview();//attached to admininsertafterview  registration
            Updatepreview.Show();//show
            this.Visible = false;//set contol visibility false
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var AdminInsert= new AdminInsert();//attached to admininsertafterview  registration
            AdminInsert.Show();//show
            this.Visible = false;//set contol visibility false
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var AdminDelete= new AdminDelete();//attached to admininsertafterview  registration
            AdminDelete.Show();//show
            this.Visible = false;//set contol visibility false
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();//attached to admininsertafterview  registration
            Form3.Show();//show
            this.Visible = false;//set contol visibility false
        }
    }
}
