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

namespace BUCAssignment//Database
                       //This is form is based on updating of exisiting member
{

    public partial class AdminUpdate3 : Form
    {
       
        public AdminUpdate3()
        {
            InitializeComponent();//code that creates and initializes the user interface objects dragged on the form surface with the values provided by programmer
        }

        private void cute()//private void bread
        {
            try//this try catch exception block will execute on different thread
            {//Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();//connection open
                SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "select * from Classes";//selecting class from database
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                DataTable dt = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                adapter.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                dgz1.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
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
                if (ClassIdtxt.Text == "" || Classatitlestxt.Text == "" || Trainertxt.Text == "" || Placetxt.Text == "" || ClassDatetxt.Text == "" || SessionClasstxt.Text == "" || ClassFeestxt.Text == "")
                {
                    ClassIdtxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    Classatitlestxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    Trainertxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    Placetxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    ClassDatetxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    SessionClasstxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    ClassFeestxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                  


                    MessageBox.Show("You have still left with information to fill", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (!Regex.Match(Classatitlestxt.Text, "^[A-Z][a-zA-Z]*$").Success)//Name validation in which your First Capital Letter is need
                {
                    MessageBox.Show("The name is inccorrect or invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                    Classatitlestxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                
                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();//connection open
                SqlCommand cmd = con.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "Update Classes set CLID='" + ClassIdtxt.Text + "',ClassT='" + Classatitlestxt.Text + "',Trainer='" + Trainertxt.Text + "',Place='" + Placetxt.Text + "',ClassDate='" + ClassDatetxt.Text + "',Session='" + SessionClasstxt + "',Fees='" + ClassFeestxt.Text + "' where CLID='" + ClassIdtxt.Text + "'";
                //updating a new data into Database while inserting into Trainer Table
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                con.Close();//connection close
                ClassIdtxt.Text = "";//blank
                Classatitlestxt.Text = "";
                Trainertxt.Text = "";
                Placetxt.Text = "";
                ClassDatetxt.Text = "";
                SessionClasstxt.Text = "";
                ClassFeestxt.Text = "";
                cute();//recalling private from above
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }


            private void dgz1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try//this try catch exception block will execute on different thread
            {
                if (e.RowIndex >= 0)//after click in the datagridview data ll automatically fill in the form 
                {
                DataGridViewRow row = this.dgz1.Rows[e.RowIndex];

                ClassIdtxt.Text = row.Cells["CLID"].Value.ToString();
                Classatitlestxt.Text = row.Cells["ClassT"].Value.ToString();
                Trainertxt.Text = row.Cells["Trainer"].Value.ToString();
                Placetxt.Text = row.Cells["Place"].Value.ToString();
                ClassDatetxt.Text = row.Cells["ClassDate"].Value.ToString();
                SessionClasstxt.Text = row.Cells["Session"].Value.ToString();
                ClassFeestxt.Text = row.Cells["Fees"].Value.ToString();



            }
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClassSessiontxt_Load(object sender, EventArgs e)
        {
            cute();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //CLear or Reset Code
            try //this try catch exception block will execute on different thread
            {
                ClassIdtxt.Text = "";//blank
                Classatitlestxt.Text = "";
                Trainertxt.Text = "";
                Placetxt.Text = "";
                ClassDatetxt.Text = "";
                SessionClasstxt.Text = "";
                ClassFeestxt.Text = "";
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClassIdtxt_TextChanged(object sender, EventArgs e)
        {
            ClassIdtxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void Classatitlestxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classatitlestxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void Trainertxt_TextChanged(object sender, EventArgs e)
        {
            Trainertxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void Placetxt_TextChanged(object sender, EventArgs e)
        {
            Placetxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void ClassDatetxt_TextChanged(object sender, EventArgs e)
        {
            ClassDatetxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void SessionClasstxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            SessionClasstxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void ClassFeestxt_TextChanged(object sender, EventArgs e)
        {
            ClassFeestxt.BackColor = Color.Lime;//turn backcolor text to Lime after you type
        }

        private void ClassIdtxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Classatitlestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))//this validation represents that the user cannot type digit when filling form in Name box..
                e.Handled = true;//means completed the handling that this event requires", and it will stop base classes from doing any further
        }

        private void ClassIdtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Classatitlestxt_KeyDown(object sender, KeyEventArgs e)
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

        private void SessionClasstxt_KeyDown(object sender, KeyEventArgs e)
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
            var Updatepreview = new Updatepreview();//attached to Welcom  registration
            Updatepreview.Show();
            this.Visible = false;//set contol visibility false
        }
    }
}
