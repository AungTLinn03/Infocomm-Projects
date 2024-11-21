using System;//using the System library in your project.
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//using namespace
using System.Data.SqlClient;//Provides a way of reading a forward-only stream of rows from a SQL Server database.
using System.Drawing;//The Graphics class provides methods for drawing to the display device. 
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;//a pattern which is used to parse and check whether the given input text is matching with the given pattern or not
using System.Threading.Tasks;
using System.Windows.Forms;//to provide an easier interface to develop the applications for desktop, tablet, PCs.
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BUCAssignment//Database
{
    //This is form is based on registration of new trainer by UserAdmin
    public partial class AdminInsertafterview : Form
    {
        string genders;//Declaration of Global variable gender for radio button
                       //Declaration of Sql connection in global
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");

        public AdminInsertafterview()
        {
            InitializeComponent();//code that creates and initializes the user interface objects dragged on the form surface with the values provided by programmer
        }
        public void Rhodes()//private void Rhodes
        {
            try//this try catch exception block will execute on different thread
            {
                string fb = "";// is a sequence of characters for example 't','1' etc..
                //declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();//connection open 
                           // Sql Command allows you to query and send commands to a database 
                SqlCommand cmd = new SqlCommand("Select count(TrID) from Trainer", con); // counting total number from member table. 
                int i = Convert.ToInt32(cmd.ExecuteScalar());// this operation to execute any arbitrary SQL statements in SQL Server to return a single value
                con.Close();//connection close
                i++;//auto increment by 1 i.e. ++
                Tidtxt.Text = fb + i.ToString();//The text box to fill autocrement

            }
            catch(Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Declareation of private void mouse to select Member table name from Database to connect 
        private void mouse()//private void mouse
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
                DataTable dt = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                adapter.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dgm1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void Emailvalidation()//Email validation
        {
            try//this try catch exception block will execute on different thread
            {
                if (Tmailetxt.Text.Length > 0)//mail length should be more than 0 letter
                {
                    Regex RegxEmail = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                    if (!RegxEmail.IsMatch(Tmailetxt.Text.Trim()))//A regex is used to pattern matches a target string 
                    {
                        MessageBox.Show("Email is not valid, Please provide a valid email.", "Gautam POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                        Tmailetxt.Focus();//to visible
                        return;//terminate the execution
                    }
                }
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try//this try catch exception block will execute on different thread
            {

                if (!Regex.Match(Tnametxt.Text, "^[A-Z][a-zA-Z]*$").Success)//Name validation in which your First Capital Letter is need
                {
                    MessageBox.Show("The name is inccorrect or invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                    Tnametxt.Focus();//to visible
                    return;//terminates execution of the function
                }

                if (!Regex.Match(TPhonetxt.Text, "^([0|\\+[0-9]{1,5})?([7-9][0-9]{9})$").Success)//Number validation is needed in which it needs atleast 10 character

                {
                    MessageBox.Show("Invalid Contact Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//if you enter which is not match with above, it will show error message box
                    TPhonetxt.Focus();//to visible
                    return;//terminates execution of the function
                }


                else if (Taddtxt.Text == "")//Address is left with blank for validation
                {
                    Taddtxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your Address", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//message box is shown (Please enter your name )otherwise error shown
                    Taddtxt.Focus();//to visible
                    return;//terminates execution of the function
                }


                if (Regex.Match(TDOBtxts.Text, @"<18").Success)//Age must not less than 18 for gym registation
                {
                    MessageBox.Show("Age must be above 18!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//if you enter which is not match with above, it will show error message box
                    DOBtxt.Focus();//to visible
                    return;//terminates execution of the function
                }




                if (Tnametxt.Text == "")//Mname is left with blank for validation
                {
                    Tnametxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your name", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//message box is shown (Please enter your name )otherwise error shown
                    Tnametxt.Focus();//to visible
                    return;//terminates execution of the function
                }



                else if (TPhonetxt.Text == "")//Phone number is left with blank for validation
                {
                    TPhonetxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your contact number", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//message box is shown (Please enter your phone number )otherwise error shown
                    TPhonetxt.Focus();//to visible
                    return;//terminates execution of the function
                }


                else if (Tmailetxt.Text == "")//Mail is left with blank for validation
                {
                    Tmailetxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your Mail", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//message box is shown (Please enter your email )otherwise error shown
                    Tmailetxt.Focus();//to visible
                    return;//terminates execution of the function
                }

                else if (TDOBtxts.Text == "")//DOB is left with blank for validation
                {
                    TDOBtxts.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your Date of Birth", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//message box is shown (Please enter your date of birth )otherwise error shown
                    TDOBtxts.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (Thghtxt.Text == "")//height is left with blank for validation
                {
                    Thghtxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your height", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//message box is shown (Please enter your height )otherwise error shown
                    Thghtxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (Twghtxt.Text == "")//weight is left with blank for validation
                {
                    Twghtxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your weight", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//message box is shown (Please enter your weight )otherwise error shown
                    Twghtxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (TExperiencetxt.Text == "")//Experience is left with blank for validation
                {
                    TExperiencetxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your joining filed", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//message box is shown (Please enter your experience )otherwise error shown
                    TExperiencetxt.Focus();//to visible
                    return;//terminates execution of the function

                }

                else if (Tdurationtxt.Text == "")//duration is left with blank for validation
                {
                    Tdurationtxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your duation box", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//message box is shown (Please enter your duration )otherwise error shown
                    Tdurationtxt.Focus();//to visible
                    return;//terminates execution of the function
                }

                else if (Tclasstxt.Text == "")//class is left with blank for validation
                {
                    Tclasstxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your Price for Gym", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//message box is shown (Please enter your costs )otherwise error shown
                    Tclasstxt.Focus();//to visible
                    return;//terminates execution of the function
                }


                if (Male.Checked == true)//Gendervalidation is checked 
                {
                    genders = "Male";
                }
                else
                {
                    genders = "Female";
                }
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();//connection open
                SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "insert into Trainer(TrID,TrainerName,TrainerAddress,TrainerPhone,TrainerGmail,TrainerGender,TrainerClass,TrainerHeight,TrainerWeight,TrainerDOB,TrainerExperience,TrainerDuration) values ('" + Tidtxt.Text + "','" + Tnametxt.Text + "','" + Taddtxt.Text + "','" + TPhonetxt.Text + "','" + Tmailetxt.Text + "','" + genders + "','" + Tclasstxt.Text + "',  '" + Thghtxt.Text + "','" + Twghtxt.Text + "','" + TDOBtxts.Text + "','" + TExperiencetxt.Text + "','" + Tdurationtxt.Text + "')";
                //Inseting a new data into Database while inserting into Trainer Table
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets


                conn.Close();//connecetion close
                Tidtxt.Text = "";//blank 
                Tnametxt.Text = "";
                Taddtxt.Text = "";
                TPhonetxt.Text = "";
                Tmailetxt.Text = "";
                Tclasstxt.Text = "";
                Thghtxt.Text = "";
                Twghtxt.Text = "";
                TDOBtxts.Text = "";
                TExperiencetxt.Text = "";
                Tdurationtxt.Text = "";
                Emailvalidation();//recalling private void from above
                mouse();//recalling private void from above
                Rhodes();//recalling private void from above





                MessageBox.Show("Inserted Successfully");//Message box shown after you insert successfully


            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }

        }
             

            private void Female_CheckedChanged(object sender, EventArgs e)
        {
            genders = "Female";
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            genders = "Male";
        }

        private void AdminInsertafterview_Load(object sender, EventArgs e)
        {
            try//this try catch exception block will execute on different thread
            {
                if (this.Male.Checked)
                    this.Male.Checked = false;
                if (this.Female.Checked)
                    this.Female.Checked = false;
                mouse();//recalling private void from above
                Rhodes();//recalling private void from above
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgm1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try//this try catch exception block will execute on different thread
            {

                if (e.RowIndex >= 0)
                {
                    //after click in the datagridview data ll automatically fill in the form 
                    DataGridViewRow row = this.dgm1.Rows[e.RowIndex];

                    Tidtxt.Text = row.Cells["TrID"].Value.ToString();
                    Tnametxt.Text = row.Cells["TrainerName"].Value.ToString();
                    Taddtxt.Text = row.Cells["TrainerAddress"].Value.ToString();
                    TPhonetxt.Text = row.Cells["TrainerPhone"].Value.ToString();
                    Tmailetxt.Text = row.Cells["TrainerGmail"].Value.ToString();
                    genders = row.Cells["TrainerGender"].Value.ToString();
                    Tclasstxt.Text = row.Cells["TrainerClass"].Value.ToString();
                    Thghtxt.Text = row.Cells["TrainerHeight"].Value.ToString();
                    Twghtxt.Text = row.Cells["TrainerWeight"].Value.ToString();
                    TDOBtxts.Text = row.Cells["TrainerDOB"].Value.ToString();
                    TExperiencetxt.Text = row.Cells["TrainerExperience"].Value.ToString();
                    Tdurationtxt.Text = row.Cells["TrainerDuration"].Value.ToString();

                }
            }
            catch(Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Tnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;//means completed the handling that this event requires", and it will stop base classes from doing any further
        }

        private void Tnametxt_TextChanged(object sender, EventArgs e)
        {
            Tnametxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void TPhonetxt_TextChanged(object sender, EventArgs e)
        {
            TPhonetxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void Tmailetxt_TextChanged(object sender, EventArgs e)
        {
            Tmailetxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void Tdurationtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tdurationtxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void Taddtxt_TextChanged(object sender, EventArgs e)
        {
            Taddtxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void TDOBtxts_ValueChanged(object sender, EventArgs e)
        {
            TDOBtxts.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void TExperiencetxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            TExperiencetxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void Tclasstxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tclasstxt.BackColor = Color.Orange; //the color change from back color into Orange after you enter type...
        }

        private void Thghtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thghtxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void Twghtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

            Twghtxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void Tnametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void TPhonetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Tmailetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Tdurationtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Taddtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void TDOBtxts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void TExperiencetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Tclasstxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Thghtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Twghtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { //CLear or Reset Code
            try//this try catch exception block will execute on different thread
            {
             
                Tnametxt.Text = "";
                Taddtxt.Text = "";
                TPhonetxt.Text = "";
                Tmailetxt.Text = "";
                Tclasstxt.Text = "";
                Thghtxt.Text = "";
                Twghtxt.Text = "";
                TDOBtxts.Text = "";
                TExperiencetxt.Text = "";
                Tdurationtxt.Text = "";
            }
            catch(Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Tmailetxt_Leave(object sender, EventArgs e)
        {
            Emailvalidation();//recalling private void from above
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            var AdminInsert = new AdminInsert();//attached to AdminInsert  registration
            AdminInsert.Show();
            this.Visible = false;//set contol visibility false
        }
    }
}
