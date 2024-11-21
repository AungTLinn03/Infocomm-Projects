using System;//using the System library in your project.
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//using namespace
using System.Data.SqlClient;//Provides a way of reading a forward-only stream of rows from a SQL Server database.
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//to provide an easier interface to develop the applications for desktop, tablet, PCs.

namespace BUCAssignment//Database
{
    //This is form is based on Searching of every table name present in Database
    public partial class AdminSearch : Form
    {
        public AdminSearch()
        {
            InitializeComponent();//code that creates and initializes the user interface objects dragged on the form surface with the values provided by programmer
        }
        // Declareation of private void mouse to select Member table name from Database to connect 
        private void burger()//private void burger

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
                dmm1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pizza()//private void pizza
        {

            try//this try catch exception block will execute on different thread
            {
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();//connection open
                SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "select * from Classes";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt = new DataTable();
                // It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void chicken()//private void chicken
        {
            try//this try catch exception block will execute on different thread
            {
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();//connection open
            SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
            cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
             cmd.CommandText = "select * from Staff";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt = new DataTable();
                // It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void fish  ()//private void fish

        {
            try//this try catch exception block will execute on different thread
            {
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();//connection open
                SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "select * from Trainer";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt = new DataTable();
                // It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void prawn()//private void prawn
        {
            try//this try catch exception block will execute on different threa
            { 
            //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();//connection open
            SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
            cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
            cmd.CommandText = "select * from Enrollments";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
            cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
            SqlDataAdapter ada = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
            DataTable dt = new DataTable();
            // It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
            //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
            ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
            dmm1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
            conn.Close();//connection close
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void sandwich()//private void sandwich
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
                // It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.

                ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close


                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();//connection open
                SqlCommand cmd1 = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "select * from Classes";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada1 = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt1 = new DataTable();
                // It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.

                ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close



                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();//connection open
                SqlCommand cmd2 = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "select *  from Staff";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada2 = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt2 = new DataTable();
                // It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.

                ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close




                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();//connection open
                SqlCommand cmd3 = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "select * from Trainer";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada3 = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt3 = new DataTable();
                // It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.

                ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close




                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn4 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();//connection open
                SqlCommand cmd4 = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "select * from Enrollments";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada4 = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt4 = new DataTable();
                // It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.

                ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();
            }//connection close
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            fish();//recalling private void fish from above
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try //this try catch exception block will execute on different thread
            {


                //if rdbAdmin is checked true it will connected to database....
                if (RdbMember.Checked == false && RdbClass.Checked == false && RdbClass.Checked == false && RdbStaff.Checked == false && RdbTrainer.Checked == false && RdbEnrollment.Checked == false)
                {
                    MessageBox.Show("Select any of the following,Error shown");//otherwise it ll show error
                }
                else if (RdbMember.Checked == true)//Rdbmemberchecked
                {
                    //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();//connection open
                    SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                    cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                    cmd.CommandText = "select * from Member where MID ='" + Searchtxt.Text + "'";//to select MID from Member table to recover specifiy information
                    cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                    DataTable dt = new DataTable();
                    // It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                    //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                    ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                    if (dt.Rows.Count == 1) //To add row at the position in the database
                    {
                        dmm1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                        conn.Close();//connection close
                        Searchtxt.Text = "";//blank
                    }
                    else
                    {
                        MessageBox.Show("Member ID Not Found or not in the list");// after validation Login will show with Messagebox..
                        Searchtxt.Text = "";
                    }


                }
                else if (RdbClass.Checked == true)//RdbClass checked
                {
                    //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();//connection open
                    SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                    cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                    cmd.CommandText = "select * from Classes where CLID ='" + Searchtxt.Text + "'";//to select CLID from Classes table to recover specifiy information
                    cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                    DataTable dt = new DataTable();
                    // It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                    //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                    ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                    if (dt.Rows.Count == 1)//To add row at the position in the database
                    {
                        dmm1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                        conn.Close();//connection close
                        Searchtxt.Text = "";//blank
                    }
                    else
                    {
                        MessageBox.Show("Class ID Not Found or not in the list");// after validation Login will show with Messagebox..
                        Searchtxt.Text = "";
                    }

                }
                else if (RdbStaff.Checked == true)//Rdbstaffchecked
                {
                    //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();//connection open
                    SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                    cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                    cmd.CommandText = "select * from Staff where Sid ='" + Searchtxt.Text + "'";//to select Sid from staff table to recover specifiy information
                    cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                    DataTable dt = new DataTable();
                    // It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                    //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.

                    ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                    if (dt.Rows.Count == 1)//To add row at the position in the database
                    {
                        dmm1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                        conn.Close();//connection close
                        Searchtxt.Text = "";//blank
                    }
                    else
                    {
                        MessageBox.Show("Staff ID Not Found or not in the list");// after validation Login will show with Messagebox..
                        Searchtxt.Text = "";
                    }


                }
                else if (RdbTrainer.Checked == true)//Rdbtrainer checked true
                {
                    //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();//connection open
                    SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                    cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                    cmd.CommandText = "select * from Trainer where TrID ='" + Searchtxt.Text + "'";//to select TrId from Trainer table to recover specifiy information
                    cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                    DataTable dt = new DataTable();
                    // It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                    //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                    ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                    if (dt.Rows.Count == 1)//To add row at the position in the database
                    {
                        dmm1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                        conn.Close();//connection close
                        Searchtxt.Text = "";//blank
                    }
                    else
                    {
                        MessageBox.Show("Trainer ID Not Found or not in the list");// after validation Login will show with Messagebox..
                        Searchtxt.Text = "";
                    }
                }
                else if (RdbEnrollment.Checked == true)//RdbEnrollment checked true
                {
                    //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();//connection open
                    SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                    cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                    cmd.CommandText = "select * from Enrollments  where EnID ='" + Searchtxt.Text + "'";//to select EnID from Enrollment table to recover specifiy information
                    cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                    DataTable dt = new DataTable();
                    // It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                    //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                    ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                    if (dt.Rows.Count == 1)//To add row at the position in the database
                    {
                        dmm1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                        conn.Close();//connection close
                        Searchtxt.Text = "";//blank
                    }
                    else
                    {
                        MessageBox.Show("Enrollment ID Not Found or not in the list");// after validation Login will show with Messagebox..
                        Searchtxt.Text = "";
                    }
                }
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void AdminSearch_Load(object sender, EventArgs e)
        {
            sandwich();//recalling private void from above
        }

        private void RdbMember_CheckedChanged(object sender, EventArgs e)
        {
            burger();//recalling private void  from above
        }

        private void RdbClass_CheckedChanged(object sender, EventArgs e)
        {
            pizza();//recalling private void from above
        }

        private void RdbStaff_CheckedChanged(object sender, EventArgs e)
        {
            chicken();//recalling private void from above
        }

        private void RdbEnrollment_CheckedChanged(object sender, EventArgs e)
        {
            prawn();//recalling private void from above
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var AdminSearch = new AdminSearch();//attached to Form3 registration
            AdminSearch.Show();
            this.Visible = false;//set contol visibility false
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var AdminView=new AdminView();//attached to Form3 registration
            AdminView.Show();
            this.Visible=false;//set contol visibility false
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Updatepreview = new Updatepreview();//attached to Form3 registration
            Updatepreview.Show();
            this.Visible = false;//set contol visibility false
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var AdminInsert = new AdminInsert();//attached to Form3 registration
            AdminInsert.Show();
            this.Visible = false;//set contol visibility false
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var AdminDelete = new AdminDelete();//attached to Form3 registration
            AdminDelete.Show();
            this.Visible = false;//set contol visibility false
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();//attached to Form3 registration
            Form3.Show();
            this.Visible = false;//set contol visibility false
        }
    }
}
