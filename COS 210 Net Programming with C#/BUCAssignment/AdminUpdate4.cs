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
    public partial class AdminUpdate4 : Form
       
    {
        SqlDataReader dr;
        //Declaration of Global variable gender for radio button
        string gender;
        //Declaration of Sql connection in global
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");


        public AdminUpdate4()
        {
            InitializeComponent();//code that creates and initializes the user interface objects dragged on the form surface with the values provided by programmer
        }
        private void excuses()//private void bread
        {
            try//this try catch exception block will execute on different thread
            {//Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();//connection open
                SqlCommand cmd = conn.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "select * from Enrollments";//selecting enrollments from database
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                DataTable dt = new DataTable();
                //It represents the database tables that provide a collection of rows and columns in grid form form existing one to new one
                //The Fill method retrieves rows from the data source using the SELECT statement specified by an associated SelectCommand property.
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);//The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data with parameter including query and connection...
                adapter.Fill(dt);// Adds or refreshe rows in the DataSet to match those in the data source.
                Aug.DataSource = dt;//Datasource i.e viewing data form dataset into DataGridview
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
                if (Enidtxt.Text == "" || EMnametxt.Text == "" || ClassEntxt.Text == "" || Entrnametxt.Text == "" || Endurattiontxt.Text == "" || EnTrainerSesstxt.Text == "" )
                {
                    Enidtxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    EMnametxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    ClassEntxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    Entrnametxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    Endurattiontxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    EnTrainerSesstxt.BackColor = Color.Red; //the backcolor will changed to Red when you type
                    



                    MessageBox.Show("You have still left with information to fill", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (!Regex.Match(EMnametxt.Text, "^[A-Z][a-zA-Z]*$").Success)//Name validation in which your First Capital Letter is need
                {
                    MessageBox.Show("The name is inccorrect or invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                    EMnametxt.Focus();//to visible
                    return;//terminates execution of the function
                }
                if (!Regex.Match(Entrnametxt.Text, "^[A-Z][a-zA-Z]*$").Success)//Name validation in which your First Capital Letter is need
                {
                    MessageBox.Show("The name is inccorrect or invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);//if you enter which is not match with above, it will show error message box
                    Entrnametxt.Focus();//to visible
                    return;//terminates execution of the function
                }

                //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();//connection open
                SqlCommand cmd = con.CreateCommand();//Represents a set of data commands and a database connection that are used to fill the DataSet and update a SQL Server database
                cmd.CommandType = CommandType.Text;//the property CommandText should contain text of a query that must be run on the server
                cmd.CommandText = "Update Enrollments set EnID='" + Enidtxt.Text + "',CLID='" + ClassEntxt.Text + "',MemberName='" + EMnametxt.Text + "',EnDuration='" + Endurattiontxt.Text + "',Gender='" + gender + "',TrainerSession='" + EnTrainerSesstxt.Text + "' where EnID='" + Enidtxt.Text + "'";
                //updating a new data into Database while inserting into Trainer Table
                cmd.ExecuteNonQuery();//The ExecuteNonQuery() is one of the most frequently used method in SqlCommand Object, and is used for executing statements that do not return result sets
                con.Close();//connection close
                Enidtxt.Text = "";//blank
                EMnametxt.Text = "";
                ClassEntxt.Text = "";
                Entrnametxt.Text = "";
                Endurattiontxt.Text = "";
                EnTrainerSesstxt.Text = "";
               
                excuses();//recalling private from above
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";

        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void Aug_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try//this try catch exception block will execute on different thread
            {
                if (e.RowIndex >= 0)//after click in the datagridview data ll automatically fill in the form 
                {
                    DataGridViewRow row = this.Aug.Rows[e.RowIndex];

                    Enidtxt.Text = row.Cells["EnID"].Value.ToString();
                    ClassEntxt.Text = row.Cells["CLID"].Value.ToString();
                    EMnametxt.Text = row.Cells["MemberName"].Value.ToString();
                    Endurattiontxt.Text = row.Cells["EnDuration"].Value.ToString();
                    Entrnametxt.Text = row.Cells["TrainerName"].Value.ToString();
                    EnTrainerSesstxt.Text = row.Cells["Session"].Value.ToString();
                   


                }
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminUpdate4_Load(object sender, EventArgs e)
        {
            excuses();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CLear or Reset Code
            try //this try catch exception block will execute on different thread
            {
                Enidtxt.Text = "";//blank
                EMnametxt.Text = "";
                ClassEntxt.Text = "";
                Entrnametxt.Text = "";
                Endurattiontxt.Text = "";
                EnTrainerSesstxt.Text = "";
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Updatepreview = new Updatepreview();//attached to Welcom  registration
            Updatepreview.Show();
            this.Visible = false;//set contol visibility false
        }

        private void Enid_TextChanged(object sender, EventArgs e)
        {
            Enid.BackColor = Color.Lime;//turn backcolor text to Lime after you type
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

        private void Enid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void EMnametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void ClassEntxt_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Entrnametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void ClassEntxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void Endurattiontxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void EnTrainerSesstxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Keycode is equal to key enter in which ...you can use enter instead of TAB.
            {
                SendKeys.Send("{TAB}");//Uses Enter key instead of "TAB"
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try//this try catch exception block will execute on different thread
            {
                {
                    if (string.IsNullOrEmpty(Enidtxt.Text))
                    {
                        MessageBox.Show("Enter ID..? please");//if error message box shown
                    }
                    else
                    {

                        //Connection to database ,//declaration of variable and set the connection string with new SqlConnection by liniking with the datasource..
                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BUCAssignment.mdf;Integrated Security=True;Connect Timeout=30");
                        con.Open();//connection open



                        SqlCommand cmd = new SqlCommand("select*from Enrollments where EnID=@EnID", con);//using command
                        cmd.Parameters.AddWithValue("EnID", int.Parse(Enidtxt.Text));
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();



                        da.Fill(dt);
                        Aug.DataSource = dt;
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                           
                            string ClID = dr["CLID"].ToString();
                            string MemberName = dr["MemberName"].ToString();
                            string EnDuration = dr["EnDuration"].ToString();
                            string TrainerName = dr["TrainerName"].ToString();
                            string TrainerSession = dr["TrainerSession"].ToString();




                            EMnametxt.Text = MemberName;
                            ClassEntxt.Text = ClID;
                            Entrnametxt.Text = TrainerName;
                            Endurattiontxt.Text = EnDuration;
                            EnTrainerSesstxt.Text = TrainerSession;


                        

                        }

                    }
                }
            }
            catch (Exception ex)//catch and store the exception in a local variable
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
    


