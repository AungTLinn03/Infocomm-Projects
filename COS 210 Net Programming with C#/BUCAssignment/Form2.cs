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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace BUCAssignment
{
    //This form is based on Login for Admin and Memeber
    public partial class Login : Form
    {
        public Login()//Login Form 
        {
            InitializeComponent();//code that creates and initializes the user interface objects dragged on the form surface with the values provided by programmer
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//Under the line represent the validation for show password
        {
            //this try catch exception block will execute on different thread
            try
            {
                if (checkbxshowpas.Checked)//if is checked to validate the checkboxes that match with password
                {
                    password.PasswordChar = '\0';

                }
                else
                {
                    password.PasswordChar = '*';

                }
            }
            //catch and store the exception in a local variable
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
                
        }

        private void User_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        { 
           

        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            username.BackColor = Color.Black;//Text changed is used to changed the color after entering the text.
            //That is to change backcolor into whiteSmoke.....
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.BackColor = Color.Black;//Text changed is used to changed the color after entering the text.
            //That is to change backcolor into whiteSmoke.....
        }

        private void confirmpassword_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            //this try catch exception block will execute on different thread
            try
            {
                //if condition is used to validate the username and password if user click login without entering data
                if (username.Text == "")//username is left with blank for validation
                {
                    username.BackColor = Color.OrangeRed;//the backcolor will changed to orangecolor when you type 
                    MessageBox.Show("Please Enter your name", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Error);//message box is shown (Please enter your name )otherwise error shown
                    username.Focus();//focus is used to visible the text
                    return;//terminater the execution of the function
                }
                else if (password.Text == "")//username is left with blank for validation
                {
                    password.BackColor = Color.OrangeRed; //the backcolor will changed to orangecolor when you type 
                    MessageBox.Show("Please Enter your password", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Error);//message box is shown (Please enter your name )otherwise error shown

                    return;//terminate the execution of the function
                }



                else if (rdbUsers.Checked == false && rdbAdmin.Checked == false)//if condition used to check the radiobutton ie.male and female..
                {
                    MessageBox.Show("Choose any one");//Message box.Show is used to select if not selected male or female 
                }
                else if (string.IsNullOrEmpty(username.Text))//validate the string radio(name) username 
                {
                    MessageBox.Show("Username is empty.\n Enter Username.");//if not selected and submit then it will express and error with the message box
                    return;//terminate the execution of the function

                }

                else if (string.IsNullOrEmpty(rdbAdmin.Text))//validate the string (Admin) 
                {
                    MessageBox.Show("Password is empty.\n Enter Password");//if not selected and submit then it will express and error with the message box
                    return;//terminate the execution of the function
                }
                //if rdbAdmin is checked true it will connected to database....
                if (rdbAdmin.Checked == true)//rdbAdminchecked true

                {
                    //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..

                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                    // query string collection is used to retrieve the variable value in from database
                    string query = "select * from  UserAdmin where Username = '" + username.Text + "' and Password = '" + password.Text.Trim() + "'";
                    //to select Username and Passowrd from Member table to recover specifiy information
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    //The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                    DataTable dt = new DataTable();
                    //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                    //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                    adapter.Fill(dt);
                    // Adds or refreshe rows in the DataSet to match those in the data source.
                    if (dt.Rows.Count == 1)//To add row at the position in the database
                    {
                        MessageBox.Show("Login successful.");// after validation Login will show with Messagebox..
                        username.Text = "";
                        password.Text = "";
                        var AdminSearch = new AdminSearch();//attached to Form3 registration
                        AdminSearch.Show();
                        this.Visible = false;//set contol visibility false


                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password");//otherwise incorrect username or password
                        username.Text = "";
                        password.Text = "";


                    }
                }
                //if rdbUser is checked true it will connected to database....
                if (rdbUsers.Checked == true)  //rdbAdminchecked true 


                {

                    //declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..

                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                    // query string collection is used to retrieve the variable value in from database
                    string query = "select * from  Member where MName = '" + username.Text + "' and MPassword = '" + password.Text.Trim() + "'";
                    //to select Username and Passowrd from Member table to recover specifiy information
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    //The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                    DataTable dt = new DataTable();
                    //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                    //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                    adapter.Fill(dt);
                    //Adds or refreshe rows in the DataSet to match those in the data source.
                    if (dt.Rows.Count == 1)//To add row at the position in the database
                    {
                        MessageBox.Show("Login successful.");// after validation Login will show with Messagebox..
                        username.Text = "";
                        password.Text = "";
                        var EnrollmentForm1 = new EnrollmentForm1();//attached to Form3 registration
                        EnrollmentForm1.Show();
                        this.Visible = false;//set contol visibility false




                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password");//otherwise incorrect username or password
                        username.Text = "";
                        password.Text = "";


                    }
                }
            }
            catch (Exception ex)
            {
                //catch and store the exception in a local variable
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)//this code is used to clear
            // the data that you insert in this form...
        {
            try
            {
                //this exception block will execute on different thread
                username.Text = "";//leaving blank is clearing the username
                password.Text = "";//leaving blank is clearing the password



            }
            catch (Exception ex)
            {
                //catch and store the exception in a local variable
                MessageBox.Show(ex.Message);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            //This line of code load data into the 'userAdmin' table.
            //this.UsernmaeTableAdapter.Fill(this.BUCAssignmentDs.UserAdmin);
        }

        private void MemberNametxt_Click(object sender, EventArgs e)
        {
            var Allclassess = new Allclasses();//attached to Form3 registration
            Allclassess.Show();
            this.Visible = false;//set contol visibility false
        }
    }
    }
    

