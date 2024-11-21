using System;//using the System library in your project.
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//using namespace
using System.Data.SqlClient;//Provides a way of reading a forward-only stream of rows from a SQL Server database.
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;//a pattern which is used to parse and check whether the given input text is matching with the given pattern or not
using System.Threading.Tasks;
using System.Windows.Forms;//to provide an easier interface to develop the applications for desktop, tablet, PCs.
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BUCAssignment//Database
                       //This is form is based on updating of exisiting member
{
    public partial class AdminUpdate : Form
    {
        string genders;//Declaration of Global variable gender for radio button
                       //Declaration of Sql connection in global

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");

        public AdminUpdate()
        {
            InitializeComponent();//code that creates and initializes the user interface objects dragged on the form surface with the values provided by programmer
        }
        //Declaration of Sql connection in local
        //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
        private void watch()//private void watch
        {
            try//this try catch exception block will execute on different thread
            {
                conn.Open();//connection open
            string query = "select * from Member";//returns a string that contains a provider command,// used to specify that the query should return all columns of the queried tables.
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dt = new DataSet();
            sda.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
            dgl1.DataSource = dt.Tables[0]; //Datasource i.e viewing data form dataset into DataGridview
            conn.Close();//connection close
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Emailvalidation()//Email validation
        {
            if (Umailetxt.Text.Length > 0)//mail length should be more than 0 letter
            {
                // mail should contain .com,One Character@,Alphabets and numbers
                Regex RegxEmail = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!RegxEmail.IsMatch(Umailetxt.Text.Trim()))//A regex is used to pattern matches a target string 
                {
                    MessageBox.Show("Email incomplete, Please provide a valid email.", "Gautam POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                    Umailetxt.Focus();//to visible
                    return;//terminate the execution
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            try//this try catch exception block will execute on different thread
            {

                if (!Regex.Match(UMnametxt.Text, "^[A-Z][a-zA-Z]*$").Success)//Name validation in which your First Capital Letter is need
                {
                    MessageBox.Show("The name is inccorrect or invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                    UMnametxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                if (!Regex.Match(UCnumbertxt.Text, "^([0|\\+[0-9]{1,5})?([7-9][0-9]{9})$").Success)//Number validation is needed in which it needs atleast 10 character

                {
                    MessageBox.Show("Invalid Contact Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//if you enter which is not match with above, it will show error message box
                   UCnumbertxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                if (Regex.Match(UDOBtxts.Text, @"<10").Success)//Age must not less than 10 for gym registation
                {
                    MessageBox.Show("Age must be above 10!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                    UDOBtxts.Focus();//visible
                    return;//terminates execution of the function
                }
                if (UMnametxt.Text == "")//UMname is left with blank for validation
                {
                    UMnametxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your name", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your name )otherwise error shown
                    UMnametxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                if (UPguardtxt.Text == "")//Guardianis left with blank for validation
                {
                    UPguardtxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your parent name", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your parent name )otherwise error shown
                    UPguardtxt.Focus();//to visible
                    return;//terminates execution of the function
                }
               else if (UCnumbertxt.Text == "")//Unumber is left with blank for validation
                {
                    UCnumbertxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your number", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your number )otherwise error shown
                    UMnametxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (Umailetxt.Text == "")//Umailtext is left with blank for validation
                {
                    Umailetxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your mail", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your mail )otherwise error shown
                    Umailetxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (Uaddtxt.Text == "")//Umailtext is left with blank for validation
                {
                    Uaddtxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your address", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your address )otherwise error shown
                    Uaddtxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (UDOBtxts.Text == "")//DOB is left with blank for validation
                {
                    UDOBtxts.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your date of birth", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your mDOB )otherwise error shown
                    UDOBtxts.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (Uhghtxt.Text == "")//height is left with blank for validation
                {
                    Uhghtxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your height", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your height )otherwise error shown
                    Uhghtxt.Focus();//to visible
                    return;//terminates execution of the function
                }

                else if (Uwghtxt.Text == "")//weight is left with blank for validation
                {
                    Uwghtxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your weight", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your weight )otherwise error shown
                    Uwghtxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (UConditiontxt.Text == "")//weight is left with blank for validation
                {
                    UConditiontxt.BackColor = Color.Red; //condition backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your condition", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your condition )otherwise error shown
                    UConditiontxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (Udurationtxt.Text == "")//duration is left with blank for validation
                {
                    Udurationtxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your duration", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your duration )otherwise error shown
                    Udurationtxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                else if (UCoststxt.Text == "")//costs is left with blank for validation
                {
                    UCoststxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your condition", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Stop);//message box is shown (Please enter your condition )otherwise error shown
                    UCoststxt.Focus();//to visible
                    return;//terminates execution of the function
                }








                //check validation for gender radiobutton
                if (Male.Checked == true)//if male check validation is true
            {
                genders = "Male";
            }
            else
            {
                genders = "Female";// otherwise female
            }
            //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();//connection open
            SqlCommand cmd =conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
            cmd.CommandType=CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
            cmd.CommandText = "Update Member set MID ='" + UMidtxt.Text + "',MName='" + UMnametxt.Text + "',PGuard='" + UPguardtxt.Text + "',CNumber='" + UCnumbertxt.Text + "',Email='" + Umailetxt.Text + "',Address='" + Uaddtxt.Text + "',Gender='"+genders+"', DOB='" + UDOBtxts.Text + "',Height='" + Uhghtxt.Text + "',Weight='" + Uwghtxt.Text + "',Mcondition='" + UConditiontxt.Text + "',Duration='" + Udurationtxt.Text + "',Costs='" + UCoststxt.Text + "' where MID='" + UMidtxt.Text+"'";
            //updating a new data into Database while inserting into member Table
            cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
            conn.Close();//connection close
            UMidtxt.Text = "";//blank
            UMnametxt.Text = "";
            UPguardtxt.Text = "";
            UCnumbertxt.Text = "";
            Umailetxt.Text = "";
            Uaddtxt.Text = "";
            UDOBtxts.Text = "";
            Uhghtxt.Text = "";
            Uwghtxt.Text = "";
            UConditiontxt.Text = "";
            Udurationtxt.Text = "";
            UCoststxt.Text = "";
            watch();//recalling private void from above
                Emailvalidation();//recalling private void from above
                MessageBox.Show("Update Succesfully");//message box show n after successful update
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminUpdate_Load(object sender, EventArgs e)
        {
            watch();//recalling private void from above
        }

        private void dgl1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try//this try catch exception block will execute on different thread
            {
                if (e.RowIndex >= 0)
            {
                    //after click in the datagridview data ll automatically fill in the form 
                    DataGridViewRow row = this.dgl1.Rows[e.RowIndex];

                UMidtxt.Text = row.Cells["MID"].Value.ToString();
                UMnametxt.Text = row.Cells["MName"].Value.ToString();
                UPguardtxt.Text = row.Cells["PGuard"].Value.ToString();
                UCnumbertxt.Text = row.Cells["CNumber"].Value.ToString();
                Umailetxt.Text = row.Cells["Email"].Value.ToString();
                Uaddtxt.Text = row.Cells["Address"].Value.ToString();
                genders = row.Cells["Gender"].Value.ToString();
            
                Uhghtxt.Text = row.Cells["Height"].Value.ToString();
                Uwghtxt.Text = row.Cells["Weight"].Value.ToString();
                UConditiontxt.Text = row.Cells["Mcondition"].Value.ToString();
                Udurationtxt.Text = row.Cells["Duration"].Value.ToString();
                UCoststxt.Text = row.Cells["Costs"].Value.ToString();

            }
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            genders = "Male";
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            genders = "Female";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //CLear or Reset Code
            try //this try catch exception block will execute on different thread
            {

                UMidtxt.Text = "";//blank
                UMnametxt.Text = "";
                UPguardtxt.Text = "";
                UCnumbertxt.Text = "";
                Umailetxt.Text = "";
                Uaddtxt.Text = "";
                UDOBtxts.Text = "";
                Uhghtxt.Text = "";
                Uwghtxt.Text = "";
                UConditiontxt.Text = "";
                Udurationtxt.Text = "";
                UCoststxt.Text = "";
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UMidtxt_TextChanged(object sender, EventArgs e)
        {
            UMidtxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void UMnametxt_TextChanged(object sender, EventArgs e)
        {
            UMnametxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void UPguardtxt_TextChanged(object sender, EventArgs e)
        {
             UPguardtxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }
        

        private void UCnumbertxt_TextChanged(object sender, EventArgs e)
        {
            UCnumbertxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void Umailetxt_TextChanged(object sender, EventArgs e)
        {
            Umailetxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void Udurationtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Udurationtxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void Uaddtxt_TextChanged(object sender, EventArgs e)
        {
            Uaddtxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type

        }

        private void UDOBtxts_ValueChanged(object sender, EventArgs e)
        {
            UDOBtxts.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void Uhghtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Uhghtxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void Uwghtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Uwghtxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void UConditiontxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            UConditiontxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void UCoststxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            UCoststxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void UMnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))//this validation represents that the user cannot type digit when filling form in Name box..
                e.Handled = true;//means completed the handling that this event requires", and it will stop base classes from doing any further
        }

        private void UPguardtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))//this validation represents that the user cannot type digit when filling form in Name box..
                e.Handled = true;//means completed the handling that this event requires", and it will stop base classes from doing any further
        }

        private void UMidtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void UMnametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void UPguardtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void UCnumbertxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Umailetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Udurationtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Uaddtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void UDOBtxts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Uhghtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Uwghtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void UConditiontxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void UCoststxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var Updatepreview = new Updatepreview();//attached to Welcom  registration
            Updatepreview.Show();
            this.Visible = false;//set contol visibility false
        }

        private void button7_Click(object sender, EventArgs e)
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
            var Updatepreview= new Updatepreview();//attached to Welcom  registration
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
