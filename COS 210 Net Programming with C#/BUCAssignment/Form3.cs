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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;//a pattern which is used to parse and check whether the given input text is matching with the given pattern or not
using ComponentFactory.Krypton.Toolkit;
using System.Reflection.Emit;
using System.Windows.Forms.VisualStyles;

namespace BUCAssignment//Database


{
   
    //This is form is based on registration of new user 
            
            
            
            
            
    public partial class Form3 : Form
        {
        //Declaration of Global variable gender for radio button
            string gender;
        //Declaration of Sql connection in global
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");


            public Form3()
            {
                InitializeComponent();//code that creates and initializes the user interface objects dragged on the form surface with the values provided by programmer

        }

        //Declartion of private void of spiderman for increment or decrement in the Dataset ..
            private void spiderman()//private void spiderman
        {
            //this try catch exception block will execute on different thread
            try
                {
                    
                    string st = "";// is a sequence of characters for example 't','1' etc..
                //declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();//connection open 
                               // Sql Command allows you to query and send commands to a database 
                SqlCommand cmd = new SqlCommand("Select count(MID) from Member", con); // counting total number from member table. 
                    int i = Convert.ToInt32(cmd.ExecuteScalar());// this operation to execute any arbitrary SQL statements in SQL Server to return a single value
                con.Close();//connection close
                    i++;//auto increment by 1 i.e. ++
                    Midtxt.Text = st + i.ToString();//The text box to fill autocrement
                
                }



                catch (Exception ex) //catch and store the exception in a local variable
            {
                    MessageBox.Show(ex.Message);
                }
            }

            private void raio()

            {



            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
            {
                wghtxt.BackColor = Color.Gold;//turn backcolor text to Gold after you type
            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
            {

            }
        // Declareation of private void specs to select Member table name from Database to connect 
            private void specs()//private void specs
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
                DataTable dt = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                adapter.Fill(dt); // Adds or refreshe rows in the DataSet to match those in the data source.
                conn.Close();//connection close

            }
            catch (Exception ex) //catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void button1_Click(object sender, EventArgs e)
            {
            try//this try catch exception block will execute on different thread
            {
                
          
                if (!Regex.Match(Mnametxt.Text, "^[A-Z][a-zA-Z]*$").Success)//Name validation in which your First Capital Letter is need
                {
                    MessageBox.Show("The name Require Capital Letter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);//if you enter which is not match with above, it will show error message box
                    Mnametxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                if (!Regex.Match(Cnumbertxt.Text, "^([0|\\+[0-9]{1,5})?([7-9][0-9]{9})$").Success)//Number validation is needed in which it needs atleast 10 character

                {
                    MessageBox.Show("Invalid Contact Number,Or Atleast Number should be 10 digit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);//if you enter which is not match with above, it will show error message box
                    Cnumbertxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                if (!Regex.Match(textBox1.Text, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$").Success)//One capital letter,small letter and one character is need for high security

                {
                    MessageBox.Show("Strong Password Needed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                    textBox1.Focus();//visible
                    return;//terminates execution of the function
                }
                if (Regex.Match(DOBtxt.Text, @"<10").Success)//Age must not less than 10 for gym registation
                {
                    MessageBox.Show("Age must be above 10!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                    DOBtxt.Focus();//visible
                    return;//terminates execution of the function
                }




                if (Mnametxt.Text == "")//Mname is left with blank for validation
                {
                    Mnametxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your name", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your name )otherwise error shown
                    Mnametxt.Focus();//to visible
                    return;//terminates execution of the function
                }

                else if (Pguardtxt.Text == "")//Pguard is left with blank for validation
                {
                    Pguardtxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your Parents Name", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your ParentGuardian )otherwise error shown
                    Pguardtxt.Focus();//to visible
                    return;//terminates execution of the function
                }

                else if (Cnumbertxt.Text == "")//Phone number is left with blank for validation
                {
                    Cnumbertxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your contact number", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your PhoneNumber )otherwise error shown
                    Cnumbertxt.Focus();//to visible
                    return;//terminates execution of the function
                }


                else if (mailetxt.Text == "")//Mail is left with blank for validation
                {
                    mailetxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your Mail", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your mail )otherwise error shown
                    mailetxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (addtxt.Text == "")//Address is left with blank for validation
                
                    {
                    addtxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your Address", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your address )otherwise error shown
                    addtxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (DOBtxts.Text == "")//Date of Birth is left with blank for validation
                {
                    DOBtxts.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your Date of Birth", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your Date of Birth )otherwise error shown
                    DOBtxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (hghtxt.Text == "")//Height is left with blank for validation
                {
                    hghtxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your height", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your height)otherwise error shown
                    hghtxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (wghtxt.Text == "")//Weight is left with blank for validation
                {
                    wghtxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your weight", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your weight)otherwise error shown
                    wghtxt.Focus();//to visible 
                    return;//terminates execution of the function
                }
                else if (Amud.Text == "")//Joining is left with blank for validation
                {
                    Amud.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your joining filed", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your joining field)otherwise error shown
                    Amud.Focus();//to visible
                    return;//terminates execution of the function

                }

                else if (durationtxt.Text == "")//duration is left with blank for validation
                {
                    durationtxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your duation box", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your duration field)otherwise error shown
                    durationtxt.Focus();//to visible
                    return;//terminates execution of the function
                }

                else if (Coststxt.Text == "")//Costs is left with blank for validation
                {
                    Coststxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your Price for Gym", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your Costs field)otherwise error shown
                    Coststxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (textBox1.Text == "")//Password is left with blank for validation
                {
                    textBox1.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your Password", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your Password field)otherwise error shown
                    textBox1.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (textBox1.Text != confirmpasswords.Text)// Confirm Password is left with blank for validation
                {
                    textBox1.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Check your password", "Error Display", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your ConfirmPassword field)otherwise error shown
                    textBox1.Text = "";
                    confirmpasswords.Focus();//to visible
                    return;//terminates execution of the function
                    
                }
                else
                {
                    //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();//connection open
                    SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                    cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                    cmd.CommandText = "insert into Member(MID,MName,PGuard,CNumber,Email,Address,Gender,DOB,Height,Weight,MJoin,Mcondition,Duration,Costs,MPassword) values ('" + Midtxt.Text + "','" + Mnametxt.Text + "','" + Pguardtxt.Text + "','" + Cnumbertxt.Text + "','" + mailetxt.Text + "','" + addtxt.Text + "','" + gender + "','" + DOBtxts.Text + "','" + hghtxt.Text + "','" + wghtxt.Text + "','" + Amud.Text + "','" + Conditiontxt.Text + "','" + durationtxt.Text + "','" + Coststxt.Text + "','" + textBox1.Text + "')";
                    //Inseting a new data into Database while inserting into Member Table
                    cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                    conn.Close();//connecetion close
                    Midtxt.Text = "";//blank 
                    Mnametxt.Text = "";
                    Pguardtxt.Text = "";
                    Cnumbertxt.Text = "";
                    mailetxt.Text = "";
                    addtxt.Text = "";
                    DOBtxts.Text = "";
                    hghtxt.Text = "";
                    wghtxt.Text = "";
                    Amud.Text = "";
                    Conditiontxt.Text = "";
                    durationtxt.Text = "";
                    Coststxt.Text = "";
                    textBox1.Text = "";
                    confirmpasswords.Text = "";

                    MessageBox.Show("Inserted Successfull");//Message box shown after you insert successfully
                    spiderman();//recalling private void from above
                    specs();//recalling private void from above
                    var EnrollmentForm1 = new EnrollmentForm1();//attached to Form3 registration
                    EnrollmentForm1.Show();
                    this.Visible = false;//set contol visibility false


                    if (Male.Checked == true)//Gendervalidation is checked 
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                }
                }


                catch (Exception ex)//catch and store the exception in a local variable
            {
                    MessageBox.Show(ex.Message);
                }
          



        }


















            private void Female_CheckedChanged(object sender, EventArgs e)
            {
                gender = "Female";//gender from global variable
            }

            private void label2_Click_1(object sender, EventArgs e)
            {

            }




            private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
            {
                Conditiontxt.BackColor = Color.Gold;//Text changed is used to changed the color after entering the text.
                                                    //That is to change backcolor into Gold.....
        }

        private void label7_Click(object sender, EventArgs e)
            {

            }

            private void durationtxt_SelectedIndexChanged(object sender, EventArgs e)
            {
                durationtxt.BackColor = Color.Gold;//Text changed is used to changed the color after entering the text.
                                                   //That is to change backcolor into Gold....
        }

        private void Form3_Load(object sender, EventArgs e)
            {
            spiderman();//recalling private void from above
                specs();//recalling private void from above
            if (this.Male.Checked)//validation for radiobutton 
                    this.Male.Checked = false;
                if (this.Female.Checked)
                    this.Female.Checked = false;
            }

            private void Male_CheckedChanged(object sender, EventArgs e)
            {
                gender = "Male";
            }

            private void Midtxt_TextChanged(object sender, EventArgs e)
            {

            }

            private void Midtxt_KeyPress(object sender, KeyPressEventArgs e)
            {

            }

            private void Mnametxt_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))//this validation represents that the user cannot type digit when filling form in Name box..
                    e.Handled = true;//means completed the handling that this event requires", and it will stop base classes from doing any further

        }

            private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
            {
               

            }

        private void Coststxt_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

            private void mailetxt_Leave(object sender, EventArgs e)
            {
                Emailvalidation();//recalling private void Emailvalidation
            }
            private void Emailvalidation()//Email validation
            {
                if (mailetxt.Text.Length > 0)//mail length should be more than 0 letter
                {
                // mail should contain .com,One Character@,Alphabets and numbers
                    Regex RegxEmail = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                    if (!RegxEmail.IsMatch(mailetxt.Text.Trim()))//A regex is used to pattern matches a target string 
                {
                        MessageBox.Show("Email incomplete, Please provide a valid email.", "Gautam POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                    mailetxt.Focus();//to visible
                        return;//terminate the execution
                    }
                }
            }
   



            private void Mnametxt_TextChanged(object sender, EventArgs e)
            {
                Mnametxt.BackColor = Color.Gold;//Text changed is used to changed the color after entering the text.
                                                       //That is to change backcolor into whiteSmoke.....
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
            {
                textBox1.BackColor = Color.Gold;//Text changed is used to changed the color after entering the text.
                                                //That is to change backcolor into whiteSmoke.....

        }

        private void Cnumbertxt_TextChanged(object sender, EventArgs e)
            {
                Cnumbertxt.BackColor = Color.Gold;//Text changed is used to changed the color after entering the text.
                                                  //That is to change backcolor into whiteSmoke.....
        }

        private void mailetxt_TextChanged(object sender, EventArgs e)
            {
                mailetxt.BackColor = Color.Gold;//Text changed is used to changed the color after entering the text.
                                                //That is to change backcolor into whiteSmoke.....
        }

        private void Pguardtxt_TextChanged(object sender, EventArgs e)
            {
                Pguardtxt.BackColor = Color.Gold;//Text changed is used to changed the color after entering the text.
                                                 //That is to change backcolor into whiteSmoke.....
        }

        private void addtxt_TextChanged(object sender, EventArgs e)
            {
                addtxt.BackColor = Color.Gold;//Text changed is used to changed the color after entering the text.
                                              //That is to change backcolor into whiteSmoke.....
        }

        private void DOBtxts_ValueChanged(object sender, EventArgs e)
            {
                DOBtxts.BackColor = Color.Gold;//Text changed is used to changed the color after entering the text.
                                               //That is to change backcolor into whiteSmoke.....
        }

        private void hghtxt_SelectedIndexChanged(object sender, EventArgs e)
            {
                hghtxt.BackColor = Color.Gold;//Text changed is used to changed the color after entering the text.
                                              //That is to change backcolor into whiteSmoke.....

        }

        private void Amud_SelectedIndexChanged(object sender, EventArgs e)
            {
                Amud.BackColor = Color.Gold;//Text changed is used to changed the color after entering the text.
                                            //That is to change backcolor into whiteSmoke.....
        }

        private void Coststxt_SelectedIndexChanged(object sender, EventArgs e)
            {
                Coststxt.BackColor = Color.Gold;//Text changed is used to changed the color after entering the text.
                                                //That is to change backcolor into whiteSmoke.....
        }

        private void Pguardtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))//this validation represents that the user cannot type digit when filling form in Name box..
                e.Handled = true;//means completed the handling that this event requires", and it will stop base classes from doing any further

        }

        private void Mnametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB..
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB..
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Cnumbertxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB..
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void mailetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Pguardtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB..
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void durationtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB..
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void addtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void DOBtxts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void hghtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void wghtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Male_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Amud_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Conditiontxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Coststxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            
        }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if(checkBox1.Checked)//validation for  show password
            {
                textBox1.PasswordChar = '\0';
                confirmpasswords.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
                confirmpasswords.PasswordChar = '*';
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CLear or Reset Code
            try //this try catch exception block will execute on different thread
            {


                Midtxt.Text = "";
                Mnametxt.Text = "";
                Pguardtxt.Text = "";
                Cnumbertxt.Text = "";
                mailetxt.Text = "";
                addtxt.Text = "";
                DOBtxts.Text = "";
                hghtxt.Text = "";
                wghtxt.Text = "";
                Amud.Text = "";
                Conditiontxt.Text = "";
                durationtxt.Text = "";
                Coststxt.Text = "";
                textBox1.Text = "";
                confirmpasswords.Text = "";
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
              }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Allclassess = new Allclasses();//attached to Form3 registration
            Allclassess.Show();
            this.Visible = false;//set contol visibility false
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            try // Error Exception Handling 
            {
                // To show that both password and confirm password are matched.
                if (Passwordtxt.Text == confirmpasswords.Text)
                {
                    label3.ForeColor = Color.Green;
                    label3.Text = "MATCHED";
                }
                else
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "NOT MATCHED";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var EnrollmentForm1 = new EnrollmentForm1();//attached to Form3 registration
            EnrollmentForm1.Show();
            this.Visible = false;//set contol visibility false
        }
    }

    }
    

           