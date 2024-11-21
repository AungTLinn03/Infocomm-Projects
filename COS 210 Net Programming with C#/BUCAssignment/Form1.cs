using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace BUCAssignment
{
    public partial class Welcome :  KryptonForm 
    {
        public Welcome()//Welcome Form 
        {
            InitializeComponent();
        }

        
        private void Login_Click(object sender, EventArgs e)//under the line represent the form that is connected to other form 
        {
            var Login = new Login();//atached to Login form 
            Login.Show();
            this.Visible = false;//set contol visibility false
        }

        private void button2_Click(object sender, EventArgs e)//under the line represent the form that is connected to other form 
        {
            var Allclassess=new Allclasses();//attached to Form3 registration
            Allclassess.Show();
            this.Visible=false;//set contol visibility false
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            
        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void kryptonColorButton1_SelectedColorChanged(object sender, ColorEventArgs e)
        {

        }
    }
}
