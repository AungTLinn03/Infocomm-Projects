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
    //This is form is based on Admin where selecting any of the option on interface to move another respective form
    public partial class AdminInsertafterview1 : Form
    {
        string genderss;//Declaration of Global variable gender for radio button
                        //Declaration of Sql connection in global

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminInsertafterview1()
        {
            InitializeComponent();//code that creates and initializes the user interface objects dragged on the form surface with the values provided by programmer
        }

        private void Zola()//private void Zola
        {
            try//this try catch exception block will execute on different thread
            {
                string bb = "";// is a sequence of characters for example 't','1' etc..
                //declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();//connection open 
                SqlCommand cmd = new SqlCommand("Select count(SId) from Staff", con); // counting total number from member table. 
                int i = Convert.ToInt32(cmd.ExecuteScalar());// this operation to execute any arbitrary SQL statements in SQL Server to return a single value
                con.Close();//connection close
                i++;//auto increment by 1 i.e. ++
                Sidtxt.Text = bb + i.ToString();//The text box to fill autocrement

            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void keyboard()//private void Zola
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
                DataTable dt = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                adapter.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dfg1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close
            }
            catch(Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void Ronaldo()//private void Ronaldo
        {
            try//this try catch exception block will execute on different thread
            {
                if (Smailetxt.Text.Length > 0)//mail length should be more than 0 letter
                {
                    Regex RegxEmail = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                    if (!RegxEmail.IsMatch(Smailetxt.Text.Trim()))//A regex is used to pattern matches a target string 
                    {
                        MessageBox.Show("Email is not valid, Please provide a valid email.", "Gautam POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                        Smailetxt.Focus();//to visible
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

                if (!Regex.Match(Snametxt.Text, "^[A-Z][a-zA-Z]*$").Success)//Name validation in which your First Capital Letter is need
                {
                    MessageBox.Show("The name is inccorrect or invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                    Snametxt.Focus();//to visible
                    return;//terminate the execution
                }

                if (!Regex.Match(SPhonetxt.Text, "^([0|\\+[0-9]{1,5})?([7-9][0-9]{9})$").Success)//Number validation is needed in which it needs atleast 10 character

                {
                    MessageBox.Show("Invalid Contact Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                    SPhonetxt.Focus();//to visible
                    return;//terminate the execution
                }
              

                    if (Snametxt.Text == "")//Sname is left with blank for validation
                {
                    Snametxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your name", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Information);//message box is shown (Please enter your name )otherwise error shown
                    Snametxt.Focus();//to visible
                    return;//terminate the execution
                }
                else if (Saddtxt.Text == "")//Saddress is left with blank for validation
                {
                    Saddtxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your Address", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Information);//message box is shown (Please enter your address )otherwise error shown
                    Saddtxt.Focus();//to visible
                    return;//terminate the execution
                }




                else if (SPhonetxt.Text == "")//SPhone is left with blank for validation
                {
                    SPhonetxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your contact number", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//message box is shown (Please enter your address )otherwise error shown
                    SPhonetxt.Focus();//to visible
                    return;//terminate the execution
                }


                else if (Smailetxt.Text == "")//Smail is left with blank for validation
                {
                    Smailetxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your Mail", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//message box is shown (Please enter your Mail)otherwise error shown
                    Smailetxt.Focus();//to visible
                    return;//terminate the execution
                }

                else if (SAgee.Text == "")//SAge is left with blank for validation
                {
                    SAgee.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your Date of Birth", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//message box is shown (Please enter your Age)otherwise error shown
                    SAgee.Focus();//to visible
                    return;//terminate the execution
                }




                else if (Sdurationtxt.Text == "")//Sduartion is left with blank for validation
                {
                    Sdurationtxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your duation box", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Error);//message box is shown (Please enter your duarition)otherwise error shown
                    Sdurationtxt.Focus();//to visible
                    return;//terminate the execution
                }



                if (SMale.Checked == true)//Gendervalidation is checked 
                {
                    genderss = "Male";
                }
                else
                {
                    genderss = "Female";
                }
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();//connection open
                SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "insert into Staff(SId,SName,SAddress,SAge,SPhone,SGender,SDuration,SEmail) values ('" + Sidtxt.Text + "','" + Snametxt.Text + "','" + Saddtxt.Text + "','" + SAgee.Text + "','" + SPhonetxt.Text + "','" + genderss + "','" + Sdurationtxt.Text + "',  '" + Smailetxt.Text + "')";
                //Inseting a new data into Database while inserting into Staff Table
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets

                conn.Close();//connecetion close
                Sidtxt.Text = "";//blank 
                Snametxt.Text = "";
                Saddtxt.Text = "";
                SAgee.Text = "";

                SPhonetxt.Text = "";
                Sdurationtxt.Text = "";
                Smailetxt.Text = "";
                keyboard();//recalling private void from above
                Ronaldo();//recalling private void from above
                Zola();//recalling private void from above



            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminInsertafterview1_Load(object sender, EventArgs e)
        {
            try//this try catch exception block will execute on different thread
            {
                if (this.SMale.Checked)
                    this.SMale.Checked = false;
                if (this.SFemale.Checked)
                    this.SFemale.Checked = false;
                keyboard();//recalling private void from above
                Zola();//recalling private void from above
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
            

        private void SMale_CheckedChanged(object sender, EventArgs e)
        {
            genderss = "SMale";
        }

        private void SFemale_CheckedChanged(object sender, EventArgs e)
        {
            genderss = "SFemale";
        }

        private void dfg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try//this try catch exception block will execute on different thread
            {
                if (e.RowIndex >= 0)
                {
                    //after click in the datagridview data ll automatically fill in the form 
                    DataGridViewRow row = this.dfg1.Rows[e.RowIndex];

                    Sidtxt.Text = row.Cells["Sid"].Value.ToString();
                    Snametxt.Text = row.Cells["SName"].Value.ToString();
                    Saddtxt.Text = row.Cells["SAddress"].Value.ToString();
                    SAgee.Text = row.Cells["SAge"].Value.ToString();
                    SPhonetxt.Text = row.Cells["SPhone"].Value.ToString();
                    genderss = row.Cells["SGender"].Value.ToString();
                    Sdurationtxt.Text = row.Cells["SDuration"].Value.ToString();
                    Smailetxt.Text = row.Cells["SEmail"].Value.ToString();


                }
            }
            catch(Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Smailetxt_TextChanged(object sender, EventArgs e)
        {
            Smailetxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void Smailetxt_Leave(object sender, EventArgs e)
        {
            Ronaldo();//recalling private void from above
        }

        private void Snametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;//means completed the handling that this event requires", and it will stop base classes from doing any further
        }

        private void Snametxt_TextChanged(object sender, EventArgs e)
        {
            Snametxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void SPhonetxt_TextChanged(object sender, EventArgs e)
        {
            SPhonetxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void Sdurationtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sdurationtxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void Saddtxt_TextChanged(object sender, EventArgs e)
        {
            Saddtxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void SAgee_TextChanged(object sender, EventArgs e)
        {
            SAgee.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void Snametxt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Snametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void SPhonetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Smailetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Sdurationtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Saddtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void SMale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void SAgee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//CLear or Reset Code
            try//this try catch exception block will execute on different thread
            {
                Snametxt.Text = "";
                Saddtxt.Text = "";
                SAgee.Text = "";

                SPhonetxt.Text = "";
                Sdurationtxt.Text = "";
                Smailetxt.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//catch and store the exception in a local variable
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var AdminInsert = new AdminInsert();//attached to AdminInsert  registration
            AdminInsert.Show();
            this.Visible = false;//set contol visibility false
        }
    }
}
