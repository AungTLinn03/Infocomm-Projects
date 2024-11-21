using System;//using the System library in your project.
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//using namespace
using System.Data.SqlClient;//Provides a way of reading a forward-only stream of rows from a SQL Server database.
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//to provide an easier interface to develop the applications for desktop, tablet, PCs.
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BUCAssignment
{
    public partial class AdminInsertafterview2 : Form
    {
     
        public AdminInsertafterview2()
        {
            InitializeComponent();//code that creates and initializes the user interface objects dragged on the form surface with the values provided by programmer
        }
        private void Mia()//private void Rhodes
        {
            try//this try catch exception block will execute on different thread
            {
                string fbc = "";//this try catch exception block will execute on different thread
                //declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();//connection open // Sql Command allows you to query and send commands to a database 
                SqlCommand cmd = new SqlCommand("Select count(CLID) from Classes", con); // counting total number from member table. 
                int i = Convert.ToInt32(cmd.ExecuteScalar());// this operation to execute any arbitrary SQL statements in SQL Server to return a single value
                con.Close();//connection close
                i++;//auto increment by 1 i.e. ++
                ClassIdtxt.Text = fbc + i.ToString();//The text box to fill autocrement

            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Declareation of private void girl to select Member table name from Database to connect 
        private void girl()
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
                DataTable dt = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                adapter.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                asd1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview


                conn.Close();//connection close
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try //this try catch exception block will execute on different thread
            {
                if (Classtitletxt.Text == "")//title is left with blank for validation
                {
                    Classtitletxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your classtitle", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//message box is shown (Please enter your name of class )otherwise error shown
                    Classtitletxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                if (Trainertxt.Text == "")//Trainer is left with blank for validation
                {
                    Trainertxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your Trainer", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//message box is shown (Please enter your Trainer name )otherwise error shown
                    Trainertxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                if (Placetxt.Text == "")//Placetxt is left with blank for validation
                {
                    Placetxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your Place ", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//message box is shown (Please enter your place )otherwise error shown
                    Placetxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                if (ClassDatetxt.Text == "")//class date is left with blank for validation
                {
                    ClassDatetxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your ClassDate", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//message box is shown (Please enter your classdate )otherwise error shown
                    ClassDatetxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                if (ClassSessiontxt.Text == "")//Session is left with blank for validation
                {
                    ClassSessiontxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your Session", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//message box is shown (Please enter your Session )otherwise error shown
                    ClassSessiontxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                if (ClassFeestxt.Text == "")//fees is left with blank for validation
                {
                    ClassFeestxt.BackColor = Color.Red;//the backcolor will changed to Red when you type
                    MessageBox.Show("Please Enter your ClassFees", "Error shown", MessageBoxButtons.OK, MessageBoxIcon.Warning);//message box is shown (Please enter your fees )otherwise error shown
                    ClassFeestxt.Focus();//to visible
                    return;//terminates execution of the function
                }





                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();//connection open
                SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                //Inseting a new data into Database while inserting into Trainer Table
                cmd.CommandText = "insert into Classes(CLID,ClassT,Trainer,Place,ClassDate,Session,Fees) values ('" + ClassIdtxt.Text + "','" + Classtitletxt.Text + "','" + Trainertxt.Text + "','" + Placetxt.Text + "','" + ClassDatetxt.Text + "','" + ClassSessiontxt.Text + "',  '" + ClassFeestxt.Text + "')";
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                asd1.DataSource = conn;//Datasource i.e viewing data form dataset into DataGridview

                conn.Close();//connection close
                girl();//recalling private void from above
                ClassIdtxt.Text = "";//blank 
                Classtitletxt.Text = "";
                Trainertxt.Text = "";
                Placetxt.Text = "";

                ClassDatetxt.Text = "";
                ClassSessiontxt.Text = "";
                ClassFeestxt.Text = "";
                MessageBox.Show("Inserted Successfully");//Message box shown after you insert successfully..
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AdminInsertafterview2_Load(object sender, EventArgs e)
        {
            girl();//recalling private void from above
            Mia();//recalling private void from above
        }

        private void asd1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try//this try catch exception block will execute on different thread
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.asd1.Rows[e.RowIndex];

                    ClassIdtxt.Text = row.Cells["CLID"].Value.ToString();
                    Classtitletxt.Text = row.Cells["ClassT"].Value.ToString();
                    Trainertxt.Text = row.Cells["Trainer"].Value.ToString();
                    Placetxt.Text = row.Cells["Place"].Value.ToString();
                    ClassDatetxt.Text = row.Cells["ClassDate"].Value.ToString();
                    ClassSessiontxt.Text = row.Cells["Session"].Value.ToString();
                    ClassFeestxt.Text = row.Cells["Fees"].Value.ToString();


                }
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Trainertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;//means completed the handling that this event requires", and it will stop base classes from doing any further
        }

        private void Placetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;//means completed the handling that this event requires", and it will stop base classes from doing any further
        }

        private void Classtitletxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classtitletxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void Trainertxt_TextChanged(object sender, EventArgs e)
        {
            Trainertxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void Placetxt_TextChanged(object sender, EventArgs e)
        {
            Placetxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void ClassDatetxt_TextChanged(object sender, EventArgs e)
        {
            ClassDatetxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void ClassSessiontxt_SelectedIndexChanged(object sender, EventArgs e)
        {
           ClassSessiontxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void ClassFeestxt_TextChanged(object sender, EventArgs e)
        {
            ClassFeestxt.BackColor = Color.Orange;//the color change from back color into Orange after you enter type...
        }

        private void Classtitletxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Trainertxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Placetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void ClassDatetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void ClassSessiontxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void ClassFeestxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CLear or Reset Code
            try//this try catch exception block will execute on different thread
            {
               
                Classtitletxt.Text = "";
                Trainertxt.Text = "";
                Placetxt.Text = "";

                ClassDatetxt.Text = "";
                ClassSessiontxt.Text = "";
                ClassFeestxt.Text = "";
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
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
