using System;//using the System library in your project.
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//using namespace
using System.Data.SqlClient;//Provides a way of reading a forward-only stream of rows from a SQL Server database.
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;//to provide an easier interface to develop the applications for desktop, tablet, PCs.
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BUCAssignment//Database
                       //This is form is based on enrolment
{
    public partial class EnrollmentForm1 : Form
    {
        //Declaration of Global variable gender for radio button
        string genders;
        //Declaration of Sql connection in global
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
        public EnrollmentForm1()
        {
            InitializeComponent();//code that creates and initializes the user interface objects dragged on the form surface with the values provided by programmer
        }

        //Declartion of private void of black for increment or decrement in the Dataset ..
        public void black()//private void black
        {
            try//this try catch exception block will execute on different thread
            {
                
                   
                        string fb = "";// is a sequence of characters for example 't','1' etc..
                                       //declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                        con.Open();//connection open 
                                   // Sql Command allows you to query and send commands to a database 
                        SqlCommand cmd = new SqlCommand("Select count(EnID) from Enrollments", con); // counting total number from member table. 
                        int i = Convert.ToInt32(cmd.ExecuteScalar());// this operation to execute any arbitrary SQL statements in SQL Server to return a single value
                
                con.Close();//connection close
                        i++;//auto increment by 1 i.e. ++
                        lab14.Text = fb + i.ToString();//The text box to fill autocrement

                    }

                    catch (Exception ex)//catch and store the exception in a local variable
            
                    {
                        MessageBox.Show(ex.Message);
                    }
                
            }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            
            try//this try catch exception block will execute on different thread

            {

                if (!Regex.Match(EMnametxt.Text, "^[A-Z][a-zA-Z]*$").Success)//Name validation in which your First Capital Letter is need
                {
                    MessageBox.Show("The name Require Capital Letter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);//if you enter which is not match with above, it will show error message box
                    EMnametxt.Focus();//to visible
                    return;//terminates execution of the function
                }

                else if (!Regex.Match(Entrnametxt.Text, "^[A-Z][a-zA-Z]*$").Success)//Name validation in which your First Capital Letter is need
                {
                    MessageBox.Show("The name Require Capital Letter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);//if you enter which is not match with above, it will show error message box
                    Entrnametxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (ClassEntxt.Text == "")//Class name  is left with blank for validation
                {
                    ClassEntxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your name", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your class name )otherwise error shown
                    ClassEntxt.Focus();//to visible
                    return;//terminates execution of the function
                }
               

                else if (Entrnametxt.Text == "")//Trainername is left with blank for validation
                {
                    Entrnametxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your name", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your trainer name )otherwise error shown
                    Entrnametxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (EMnametxt.Text == "")//Member name is left with blank for validation
                {
                    EMnametxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your name", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your  en Memebr name )otherwise error shown
                    EMnametxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (Endurattiontxt.Text == "")//Duration is left with blank for validation
                {
                    Endurattiontxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your name", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your duration )otherwise error shown
                    Endurattiontxt.Focus();//to visible
                    return;//terminates execution of the function
                }
               
                else if (EnTrainerSesstxt.Text == "")//Trainer session is left with blank for validation
                {
                    EnTrainerSesstxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your name", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your TrainerSession )otherwise error shown
                    EnTrainerSesstxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                else
                {



                    //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();//connection open
                    SqlCommand cmd = con.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                    cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                    cmd.CommandText = "insert into Enrollments(EnID,CLID,MemberName,EnDuration,TrainerName,Gender,TrainerSession) values('" + lab14.Text + "','" + ClassEntxt.Text + "','" + EMnametxt.Text + "','" + Endurattiontxt.Text + "','" + Entrnametxt.Text + "','" + genders + "','" + EnTrainerSesstxt + "')";
                    //Inseting a new data into Database while inserting into Enrolment Table
                    cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                    con.Close();//connecetion close
                    lab14.Text = "";//blank
                  
                    ClassEntxt.Text = "";
                    EMnametxt.Text = "";
                    Endurattiontxt.Text = "";
                  
                    Entrnametxt.Text = "";
                    EnTrainerSesstxt.Text = "";
                    MessageBox.Show("Submitt Sucessfully!");//Message box shown after you insert successfully
                    black();//recalling private void from above
                    if (Male.Checked == true)//recalling private void from above
                    {
                        genders = "Male";
                    }
                    else
                    {
                        genders = "Female";
                    }
                }

            }
            catch(Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }


            }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            genders = "Male";
        }

        private void EnrollmentForm1_Load(object sender, EventArgs e)
        {
            black();
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            genders = "Female";
        }

        private void EnMiddtxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void EMnametxt_TextChanged(object sender, EventArgs e)
        {
            EMnametxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void ClassEntxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassEntxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void Entrnametxt_TextChanged(object sender, EventArgs e)
        {
            Entrnametxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void TrIDddtxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Endurattiontxt_ValueChanged(object sender, EventArgs e)
        {
            Endurattiontxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void EnTrainerSesstxt_TextChanged(object sender, EventArgs e)
        {
            EnTrainerSesstxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void EMnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))//this validation represents that the user cannot type digit when filling form in Name box..
                e.Handled = true;//means completed the handling that this event requires", and it will stop base classes from doing any further

        }

        private void Entrnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))//this validation represents that the user cannot type digit when filling form in Name box..
                e.Handled = true;//means completed the handling that this event requires", and it will stop base classes from doing any further

        }

        private void EnMiddtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB..
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void EMnametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB..
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void ClassEntxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB..
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Entrnametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB..
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void TrIDddtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB..
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Endurattiontxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB..
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void EnTrainerSesstxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB..
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //CLear or Reset Code
            try //this try catch exception block will execute on different thread
            {

                //blank
               
                ClassEntxt.Text = "";
                EMnametxt.Text = "";
                Endurattiontxt.Text = "";
               
                Entrnametxt.Text = "";
                EnTrainerSesstxt.Text = ""; 
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Login= new Login();//attached to Welcom  registration
            Login.Show();
            this.Visible = false;//set contol visibility false
        }
    }
    }

