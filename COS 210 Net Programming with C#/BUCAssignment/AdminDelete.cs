using System;//using the System library in your project.
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//using namespace
using System.Data.SqlClient;//Provides a way of reading a forward-only stream of rows from a SQL Server database.
using System.Drawing;//The Graphics class provides methods for drawing to the display device. 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//to provide an easier interface to develop the applications for desktop, tablet, PCs.

namespace BUCAssignment//Database
{
    public partial class AdminDelete : Form
        //This form is about Deleting the entire row from dataset by entering Just ID
    {
        public AdminDelete()
        {
            InitializeComponent();//code that creates and initializes the user interface objects dragged on the form surface with the values provided by programmer
        }
        // Declareation of private void pepsi to select Member table name from Database to connect 
        private void pepsi()//private void pepsi
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
                dmm3.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close
            }
            catch (Exception ex) //catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Declareation of private void Cola to select Class table name from Database to connect 
        private void Cola()//private void Cola
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
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm3.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close
            }
            catch (Exception ex) //catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Declareation of private void Sprite to select Staff table name from Database to connect 
        private void Sprite()//private void sprite
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
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm3.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close
            }
            catch (Exception ex) //catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Declareation of private void Dew to select Trainer table name from Database to connect 
        private void Dew()//private void Dew
        {
            try//this try catch exception block will execute on different thread
            {
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();//connection open
                SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "select * from Trainer";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt = new DataTable();//It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                                               //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm3.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close(); //connection close
            }
            catch (Exception ex) //catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Declareation of private void Redbull to select Enrollment table name from Database to connect 
        private void Redbull()//private void RedBull
        {
            try//this try catch exception block will execute on different thread
            {
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();//connection open
                SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "select * from Enrollments";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt = new DataTable();//It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm3.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close
            }
            catch (Exception ex) //catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Declareation of private void Shark to select all table name from Database to connect ro view in Data Grid View
        private void shark()//private void Shark
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
                dmm3.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
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
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm3.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close


                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();//connection open
                SqlCommand cmd3 = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "select * from staff";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada3 = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt3 = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm3.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close



                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn4 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();//connection open
                SqlCommand cmd4 = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "select * from Trainer";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada4 = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt4 = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm3.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close



                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn5 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();//connection open
                SqlCommand cmd5 = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "select * from Enrollments";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                SqlDataAdapter ada5 = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                DataTable dt5 = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dmm3.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close
            }
            catch (Exception ex) //catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RdbStaff_CheckedChanged(object sender, EventArgs e)
        {
            Sprite();//recalling private void from above
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try//this try catch exception block will execute on different thread
            {
                //validation for radio button

                if (RdbMember.Checked == false && RdbClass.Checked == false && RdbClass.Checked == false && RdbStaff.Checked == false && RdbTrainer.Checked == false && RdbEnrollment.Checked == false)
                {
                    MessageBox.Show("Select any of the following", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if Does not selct any of the above it will show Error with messagge box buttons
                }
                else if (RdbMember.Checked == true)//if check it will connected to database
                {
                    //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();//connection open
                    SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                    cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                    cmd.CommandText = "DELETE FROM Member where MID ='" + deletetxt.Text + "'";//the command line represent the delete Member id which means related to id data will also remove from dataset
                    cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                    DataTable dt = new DataTable();//It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                    ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                    shark();
                    if (dt.Rows.Count == 1)//To add row at the position in the database
                    {
                        dmm3.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                        conn.Close();//connection close
                        deletetxt.Text = "";//blank for deletetext
                    }
                    else
                    {
                        MessageBox.Show("Member ID Deleted");// after validation member id  will be deleted showingwith Messagebox..
                        deletetxt.Text = "";//blank for deletetext
                    }


                }
                else if (RdbClass.Checked == true)//if check it will connected to database
                {
                    //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();//connection open
                    SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                    cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                    cmd.CommandText = "DELETE FROM Classes where CLID ='" + deletetxt.Text + "'";//the command line represent the delete class id which means related to id data will also remove from dataset
                    cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                    DataTable dt = new DataTable();//It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                    ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                    shark();
                    if (dt.Rows.Count == 1)//To add row at the position in the database
                    {
                        dmm3.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                        conn.Close();//connection close
                        deletetxt.Text = "";//blank for deletetext
                    }
                    else
                    {
                        MessageBox.Show("Class ID  Deleted");// after validation member id  will be deleted showingwith Messagebox..
                        deletetxt.Text = "";//blank for deletetext
                    }

                }
                else if (RdbStaff.Checked == true)//if check it will connected to database
                {
                    //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();//connection open
                    SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                    cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                    cmd.CommandText = "DELETE FROM Staff where Sid ='" + deletetxt.Text + "'";//the command line represent the delete staff id which means related to id data will also remove from dataset
                    cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                    DataTable dt = new DataTable();//It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                    ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                    shark();
                    if (dt.Rows.Count == 1)//To add row at the position in the database
                    {
                        dmm3.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                        conn.Close();//connection close
                        deletetxt.Text = "";//blank for deletetext
                    }
                    else
                    {
                        MessageBox.Show("Staff ID Deleted");// after validation member id  will be deleted showingwith Messagebox..
                        deletetxt.Text = "";//blank for deletetext
                    }


                }
                else if (RdbTrainer.Checked == true)//if check it will connected to database
                {
                    //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();//connection open
                    SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                    cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                    cmd.CommandText = "DELETE FROM Trainer where TrID ='" + deletetxt.Text + "'";//the command line represent the delete trainer id which means related to id data will also remove from dataset
                    cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                    DataTable dt = new DataTable();//It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                    shark();
                    ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                    if (dt.Rows.Count == 1)//To add row at the position in the database
                    {
                        dmm3.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                        conn.Close();//connection close
                        deletetxt.Text = "";//blank for deletetext
                    }
                    else
                    {
                        MessageBox.Show("Trainer ID Deleted");// after validation member id  will be deleted showingwith Messagebox..
                        deletetxt.Text = "";//blank for deletetext
                    }
                }
                else if (RdbEnrollment.Checked == true)//if check it will connected to database
                {
                    //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();//connection open
                    SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                    cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                    cmd.CommandText = "DELETE FROM Enrollments where EnID ='" + deletetxt.Text + "'";//the command line represent the delete Enrollment id which means related to id data will also remove from dataset
                    cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                    DataTable dt = new DataTable();//It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                    shark();
                    ada.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                    if (dt.Rows.Count == 1)//To add row at the position in the database
                    {
                        dmm3.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                        conn.Close();//connection close
                        deletetxt.Text = "";//blank for deletetext
                    }
                    else
                    {
                        MessageBox.Show("Enrollment ID Deleted");// after validation member id  will be deleted showingwith Messagebox..
                        deletetxt.Text = "";//blank for deletetext
                    }


                }
            }
            catch (Exception ex) //catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void AdminDelete_Load(object sender, EventArgs e)
        {
            shark();//recalling private void from above
        }

        private void RdbMember_CheckedChanged(object sender, EventArgs e)
        {
            pepsi();//recalling private void from above
        }

        private void RdbClass_CheckedChanged(object sender, EventArgs e)
        {
            Cola();//recalling private void from above
        }

        private void RdbTrainer_CheckedChanged(object sender, EventArgs e)
        {
            Dew();//recalling private void from above
        }

        private void RdbEnrollment_CheckedChanged(object sender, EventArgs e)
        {
            Redbull();//recalling private void from above
        }

        private void deletetxt_TextChanged(object sender, EventArgs e)
        {
            deletetxt.BackColor = Color.MistyRose;//the color change from back color into MistyRose after you enter type...
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
            var AdminDelete= new AdminDelete();//attached to Welcom  registration
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
