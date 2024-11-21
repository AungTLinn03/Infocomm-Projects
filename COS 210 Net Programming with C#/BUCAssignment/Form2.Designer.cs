namespace BUCAssignment
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.rdbUsers = new System.Windows.Forms.RadioButton();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.checkbxshowpas = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MemberNametxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbUsers
            // 
            this.rdbUsers.AutoSize = true;
            this.rdbUsers.BackColor = System.Drawing.Color.DarkBlue;
            this.rdbUsers.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUsers.ForeColor = System.Drawing.Color.White;
            this.rdbUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbUsers.Location = new System.Drawing.Point(40, 52);
            this.rdbUsers.Name = "rdbUsers";
            this.rdbUsers.Size = new System.Drawing.Size(129, 55);
            this.rdbUsers.TabIndex = 0;
            this.rdbUsers.TabStop = true;
            this.rdbUsers.Text = "User";
            this.rdbUsers.UseVisualStyleBackColor = false;
            this.rdbUsers.CheckedChanged += new System.EventHandler(this.User_CheckedChanged);
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.BackColor = System.Drawing.Color.DarkBlue;
            this.rdbAdmin.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdmin.ForeColor = System.Drawing.Color.White;
            this.rdbAdmin.Location = new System.Drawing.Point(276, 52);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(164, 55);
            this.rdbAdmin.TabIndex = 1;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Admin";
            this.rdbAdmin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.DarkBlue;
            this.username.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(40, 238);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(312, 63);
            this.username.TabIndex = 4;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.DarkBlue;
            this.password.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.password.Location = new System.Drawing.Point(40, 426);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(301, 57);
            this.password.TabIndex = 5;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // checkbxshowpas
            // 
            this.checkbxshowpas.AutoSize = true;
            this.checkbxshowpas.BackColor = System.Drawing.Color.Transparent;
            this.checkbxshowpas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbxshowpas.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.checkbxshowpas.ForeColor = System.Drawing.Color.Magenta;
            this.checkbxshowpas.Location = new System.Drawing.Point(102, 509);
            this.checkbxshowpas.Name = "checkbxshowpas";
            this.checkbxshowpas.Size = new System.Drawing.Size(230, 38);
            this.checkbxshowpas.TabIndex = 8;
            this.checkbxshowpas.Text = "Show Password";
            this.checkbxshowpas.UseVisualStyleBackColor = false;
            this.checkbxshowpas.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Magenta;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(86, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 59);
            this.button1.TabIndex = 10;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.button2.Location = new System.Drawing.Point(322, 629);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 59);
            this.button2.TabIndex = 11;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MemberNametxt
            // 
            this.MemberNametxt.AutoSize = true;
            this.MemberNametxt.BackColor = System.Drawing.Color.Transparent;
            this.MemberNametxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNametxt.ForeColor = System.Drawing.Color.Blue;
            this.MemberNametxt.Location = new System.Drawing.Point(58, 713);
            this.MemberNametxt.Name = "MemberNametxt";
            this.MemberNametxt.Size = new System.Drawing.Size(491, 27);
            this.MemberNametxt.TabIndex = 12;
            this.MemberNametxt.Text = "Does not have an account? Create a new Account";
            this.MemberNametxt.Click += new System.EventHandler(this.MemberNametxt_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 758);
            this.Controls.Add(this.MemberNametxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkbxshowpas);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbAdmin);
            this.Controls.Add(this.rdbUsers);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbUsers;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox checkbxshowpas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label MemberNametxt;
    }
}