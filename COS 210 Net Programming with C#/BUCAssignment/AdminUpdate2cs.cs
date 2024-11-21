using System;//using the System library in your project.
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//using namespace
using System.Data.SqlClient;//Provides a way of reading a forward-only stream of rows from a SQL Server database.
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;//to provide an easier interface to develop the applications for desktop, tablet, PCs.
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BUCAssignment
{//Database
 //This is form is based on updating of exisiting member
    public partial class AdminUpdate2cs : Form
    {
        string genders;//Declaration of Global variable gender for radio button
                       //Declaration of Sql connection in global

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminUpdate2cs()
        {
            InitializeComponent();//code that creates and initializes the user interface objects dragged on the form surface with the values provided by programmer
        }

        private void Sharukhan()//private void Sharukhan
        {
            try//this try catch exception block will execute on different thread
            {
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();//connection open
                SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "select * from Staff";//selecting Staff from database
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                DataTable dt = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                adapter.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                Dgm1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
                conn.Close();
            }//connection close
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
                //this try catch exception block will execute on different thread
            if (e.RowIndex >= 0)//after click in the datagridview data ll automatically fill in the form 
            {
                DataGridViewRow row = this.Dgm1.Rows[e.RowIndex];

                Sidtxt.Text = row.Cells["Sid"].Value.ToString();
                Snametxt.Text = row.Cells["SName"].Value.ToString();
                Saddtxt.Text = row.Cells["SAddress"].Value.ToString();
                SAge.Text = row.Cells["SAge"].Value.ToString();
                SPhonetxt.Text = row.Cells["SPhone"].Value.ToString();
                genders = row.Cells["SGender"].Value.ToString();
                Sdurationtxt.Text = row.Cells["SDuration"].Value.ToString();
                Smailetxt.Text = row.Cells["SEmail"].Value.ToString();


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
            {//validation
                if
                   
                    (Sidtxt.Text == "" || Snametxt.Text == "" || Saddtxt.Text == "" || SAge.Text == "" || SPhonetxt.Text == "" || Sdurationtxt.Text == "" || Smailetxt.Text == "" )

                {
                    Sidtxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    Snametxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    Saddtxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    SAge.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    SPhonetxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    Sdurationtxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    Smailetxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                   


                    MessageBox.Show("You have still left with information to fill", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (!Regex.Match(Snametxt.Text, "^[A-Z][a-zA-Z]*$").Success)//Name validation in which your First Capital Letter is need
                {
                    MessageBox.Show("The name is inccorrect or invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                    Snametxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                if (!Regex.Match(SPhonetxt.Text, @"^\(?([0-9]{3})\)?[-. ] ?([0-9]{3})[-.]?([0-9]{4})$").Success)//Phone validation in which your First Capital Letter is need

                {
                    MessageBox.Show("Invalid Contact Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                    SPhonetxt.Focus();//to visible
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
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();//connection open
                SqlCommand cmd = con.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "Update Staff set Sid='" + Sidtxt.Text + "',SName='" + Snametxt.Text + "',SAddress='" + Saddtxt.Text + "',SAge='" + SAge.Text + "',SPhone='" + SPhonetxt.Text + "',SGender='" + genders + "',SDuration='" + Sdurationtxt.Text + "', SEmail='" + Smailetxt.Text + "' where Sid='" + Sidtxt.Text + "'";
                //updating a new data into Database while inserting into Trainer Table
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                con.Close();//connection close
                Sidtxt.Text = "";//blank
            Snametxt.Text = "";
            Saddtxt.Text = "";
            SAge.Text = "";
            SPhonetxt.Text = "";
            Sdurationtxt.Text = "";
            Smailetxt.Text = "";
            Sharukhan();//recalling private void from above
                MessageBox.Show("Update Succesfully");
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

        private void AdminUpdate2cs_Load(object sender, EventArgs e)
        {
            Sharukhan();//recalling private void from above
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //CLear or Reset Code
            try //this try catch exception block will execute on different thread
            {
                Sidtxt.Text = "";//blank
                Snametxt.Text = "";
                Saddtxt.Text = "";
                SAge.Text = "";
                SPhonetxt.Text = "";
                Sdurationtxt.Text = "";
                Smailetxt.Text = "";
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sidtxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Sidtxt_TextChanged(object sender, EventArgs e)
        {
            Sidtxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void Snametxt_TextChanged(object sender, EventArgs e)
        {
            Snametxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void SPhonetxt_TextChanged(object sender, EventArgs e)
        {
            SPhonetxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void Smailetxt_TextChanged(object sender, EventArgs e)
        {
            Smailetxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void Sdurationtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sdurationtxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void Saddtxt_TextChanged(object sender, EventArgs e)
        {
            Saddtxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void SAge_TextChanged(object sender, EventArgs e)
        {
            SAge.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void Sidtxt_KeyDown(object sender, KeyEventArgs e)
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

        private void SAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Snametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))//this validation represents that the user cannot type digit when filling form in Name box..
                e.Handled = true;//means completed the handling that this event requires", and it will stop base classes from doing any further
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Updatepreview = new Updatepreview();//attached to Welcom  registration
            Updatepreview.Show();
            this.Visible = false;//set contol visibility false
        }
    }
}
