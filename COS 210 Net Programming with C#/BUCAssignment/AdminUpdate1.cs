using System;//using the System library in your project.
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//using namespace
using System.Data.SqlClient;//Provides a way of reading a forward-only stream of rows from a SQL Server database.
using System.Drawing;//The Graphics class provides methods for drawing to the display device. 
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;//a pattern which is used to parse and check whether the given input text is matching with the given pattern or not
using System.Threading.Tasks;
using System.Windows.Forms;//to provide an easier interface to develop the applications for desktop, tablet, PCs.

namespace BUCAssignment//Database
                       //This is form is based on updating of exisiting member
{
    public partial class AdminUpdate1 : Form
    {
        string genders;//Declaration of Global variable gender for radio button
        //Declaration of Sql connection in global

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminUpdate1()
        {
            InitializeComponent();//code that creates and initializes the user interface objects dragged on the form surface with the values provided by programmer
        }

        private void bread()//private void bread
        {
            try//this try catch exception block will execute on different thread
            {
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();//connection open
                SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "select * from Trainer";//selecting trainer from database
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                DataTable dt = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                adapter.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dgu1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();//connection close
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try//this try catch exception block will execute on different thread
            {//validation
                if (U1Tidtxt.Text == "" || U1Tnametxt.Text == "" || U1Taddtxt.Text == "" || U1TPhonetxt.Text == "" || U1Tmailetxt.Text == "" || U1Tclasstxt.Text == "" || U1Thghtxt.Text == "" || U1Twghtxt.Text == "" || U1TExperiencetxt.Text == "" || U1Tdurationtxt.Text == "")
                {
                    U1Tidtxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    U1Tnametxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    U1Taddtxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    U1TPhonetxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    U1Tmailetxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    U1Tclasstxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    U1Thghtxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    U1Twghtxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    U1TExperiencetxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    U1Tdurationtxt.BackColor = Color.Red; //the backcolor will changed to Red when you type



                    MessageBox.Show("You have still left with information to fill", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (!Regex.Match(U1Tnametxt.Text, "^[A-Z][a-zA-Z]*$").Success)//Name validation in which your First Capital Letter is need
                {
                    MessageBox.Show("The name is inccorrect or invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                    U1Tnametxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                if (!Regex.Match(U1TPhonetxt.Text, @"^\(?([0-9]{3})\)?[-. ] ?([0-9]{3})[-.]?([0-9]{4})$").Success)//Phone validation in which your First Capital Letter is need

                {
                    MessageBox.Show("Invalid Contact Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                    U1TPhonetxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();//connection open
                SqlCommand cmd = con.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "Update Trainer set TrID='" + U1Tidtxt.Text + "',TrainerName='" + U1Tnametxt.Text + "',TrainerAddress='" + U1Taddtxt.Text + "',TrainerPhone='" + U1TPhonetxt.Text + "',TrainerGmail='" + U1Tmailetxt.Text + "',TrainerGender='"+genders+"',TrainerClass='" + U1Tclasstxt.Text + "', TrainerHeight='" + U1Thghtxt.Text + "',TrainerWeight='" + U1Twghtxt.Text + "',TrainerExperience='" + U1TExperiencetxt.Text + "',TrainerDuration='" + U1Tdurationtxt.Text + "' where TrID='" + U1Tidtxt.Text + "'";
                //updating a new data into Database while inserting into Trainer Table
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                con.Close();//connection close
                U1Tidtxt.Text = "";//blank
                U1Tnametxt.Text = "";
                U1TPhonetxt.Text = "";
                U1Tmailetxt.Text = "";
                U1Taddtxt.Text = "";
                U1Thghtxt.Text = "";
                U1Twghtxt.Text = "";

                U1Tdurationtxt.Text = "";
                U1TExperiencetxt.Text = "";
                bread();//recalling private from above
                MessageBox.Show("Update Succesfully");
                }

            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminUpdate1_Load(object sender, EventArgs e)
        {
            bread();//recalling private from above
        }

        private void dgu1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try//this try catch exception block will execute on different thread
            {
                if (e.RowIndex >= 0)//after click in the datagridview data ll automatically fill in the form 
                {
                DataGridViewRow row = this.dgu1.Rows[e.RowIndex];

                U1Tidtxt.Text = row.Cells["TrID"].Value.ToString();
                U1Tnametxt.Text = row.Cells["TrainerName"].Value.ToString();
                U1Taddtxt.Text = row.Cells["TrainerAddress"].Value.ToString();
                U1TPhonetxt.Text = row.Cells["TrainerPhone"].Value.ToString();
                U1Tmailetxt.Text = row.Cells["TrainerGmail"].Value.ToString();
                genders = row.Cells["TrainerGender"].Value.ToString();
                U1Tclasstxt.Text = row.Cells["TrainerClass"].Value.ToString();
                U1Thghtxt.Text = row.Cells["TrainerHeight"].Value.ToString();
                U1Twghtxt.Text = row.Cells["TrainerWeight"].Value.ToString();
               
                U1TExperiencetxt.Text = row.Cells["TrainerExperience"].Value.ToString();
                U1Tdurationtxt.Text = row.Cells["TrainerDuration"].Value.ToString();

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

        private void U1Tidtxt_TextChanged(object sender, EventArgs e)
        {
            U1Tidtxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void U1Tnametxt_TextChanged(object sender, EventArgs e)
        {
            U1Tnametxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void U1TPhonetxt_TextChanged(object sender, EventArgs e)
        {
            U1TPhonetxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void U1Tmailetxt_TextChanged(object sender, EventArgs e)
        {
            U1Tmailetxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void U1Tdurationtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            U1Tdurationtxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void U1Taddtxt_TextChanged(object sender, EventArgs e)
        {
            U1Taddtxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void U1TExperiencetxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            U1TExperiencetxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void U1Tclasstxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            U1Tclasstxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void U1Thghtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            U1Thghtxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void U1Twghtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            U1Twghtxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Updatepreview = new Updatepreview();//attached to Welcom  registration
            Updatepreview.Show();
            this.Visible = false;//set contol visibility false
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //CLear or Reset Code
            try //this try catch exception block will execute on different thread
            {
                U1Tidtxt.Text = "";//blank
                U1Tnametxt.Text = "";
                U1TPhonetxt.Text = "";
                U1Tmailetxt.Text = "";
                U1Taddtxt.Text = "";
                U1Thghtxt.Text = "";
                U1Twghtxt.Text = "";

                U1Tdurationtxt.Text = "";
                U1TExperiencetxt.Text = "";
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void U1Tnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))//this validation represents that the user cannot type digit when filling form in Name box..
                e.Handled = true;//means completed the handling that this event requires", and it will stop base classes from doing any further
        }

        private void U1Tidtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void U1Tnametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void U1TPhonetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void U1Tmailetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void U1Tdurationtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void U1Tclasstxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void U1Taddtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void U1TExperiencetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void U1Thghtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void U1Twghtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }
    }
}
