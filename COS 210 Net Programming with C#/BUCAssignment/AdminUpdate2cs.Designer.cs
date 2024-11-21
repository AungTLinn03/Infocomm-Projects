namespace BUCAssignment
{
    partial class AdminUpdate2cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUpdate2cs));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dgm1 = new System.Windows.Forms.DataGridView();
            this.SAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SPhonetxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Saddtxt = new System.Windows.Forms.TextBox();
            this.Smailetxt = new System.Windows.Forms.TextBox();
            this.Snametxt = new System.Windows.Forms.TextBox();
            this.Sidtxt = new System.Windows.Forms.TextBox();
            this.Genderr = new System.Windows.Forms.Label();
            this.Addresstxt = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.Label();
            this.MemberNametxt = new System.Windows.Forms.Label();
            this.MemberIDtxt = new System.Windows.Forms.Label();
            this.Sdurationtxt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgm1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(923, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 68);
            this.button1.TabIndex = 21;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Dgm1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(70, 648);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1174, 440);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Display";
            // 
            // Dgm1
            // 
            this.Dgm1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.Dgm1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgm1.GridColor = System.Drawing.Color.Lime;
            this.Dgm1.Location = new System.Drawing.Point(20, 52);
            this.Dgm1.Name = "Dgm1";
            this.Dgm1.RowHeadersWidth = 62;
            this.Dgm1.RowTemplate.Height = 28;
            this.Dgm1.Size = new System.Drawing.Size(1137, 273);
            this.Dgm1.TabIndex = 0;
            this.Dgm1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SAge
            // 
            this.SAge.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAge.Location = new System.Drawing.Point(1074, 309);
            this.SAge.Multiline = true;
            this.SAge.Name = "SAge";
            this.SAge.Size = new System.Drawing.Size(219, 49);
            this.SAge.TabIndex = 18;
            this.SAge.TextChanged += new System.EventHandler(this.SAge_TextChanged);
            this.SAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SAge_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(843, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "Staff Age";
            // 
            // SPhonetxt
            // 
            this.SPhonetxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPhonetxt.Location = new System.Drawing.Point(351, 329);
            this.SPhonetxt.Multiline = true;
            this.SPhonetxt.Name = "SPhonetxt";
            this.SPhonetxt.Size = new System.Drawing.Size(251, 58);
            this.SPhonetxt.TabIndex = 9;
            this.SPhonetxt.TextChanged += new System.EventHandler(this.SPhonetxt_TextChanged);
            this.SPhonetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SPhonetxt_KeyDown);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.AutoSize = true;
            this.Passwordtxt.BackColor = System.Drawing.Color.Transparent;
            this.Passwordtxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.ForeColor = System.Drawing.Color.Yellow;
            this.Passwordtxt.Location = new System.Drawing.Point(62, 342);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(217, 45);
            this.Passwordtxt.TabIndex = 3;
            this.Passwordtxt.Text = "Staff Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(62, 567);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 45);
            this.label8.TabIndex = 5;
            this.label8.Text = "Staff Duration";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.BackColor = System.Drawing.Color.Transparent;
            this.Male.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male.ForeColor = System.Drawing.Color.Yellow;
            this.Male.Location = new System.Drawing.Point(1013, 213);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(121, 45);
            this.Male.TabIndex = 16;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = false;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.BackColor = System.Drawing.Color.Transparent;
            this.Female.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female.ForeColor = System.Drawing.Color.Yellow;
            this.Female.Location = new System.Drawing.Point(1173, 213);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(154, 45);
            this.Female.TabIndex = 17;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = false;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // Saddtxt
            // 
            this.Saddtxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saddtxt.Location = new System.Drawing.Point(983, 121);
            this.Saddtxt.Multiline = true;
            this.Saddtxt.Name = "Saddtxt";
            this.Saddtxt.Size = new System.Drawing.Size(219, 49);
            this.Saddtxt.TabIndex = 15;
            this.Saddtxt.TextChanged += new System.EventHandler(this.Saddtxt_TextChanged);
            this.Saddtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Saddtxt_KeyDown);
            // 
            // Smailetxt
            // 
            this.Smailetxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Smailetxt.Location = new System.Drawing.Point(279, 434);
            this.Smailetxt.Multiline = true;
            this.Smailetxt.Name = "Smailetxt";
            this.Smailetxt.Size = new System.Drawing.Size(323, 70);
            this.Smailetxt.TabIndex = 10;
            this.Smailetxt.TextChanged += new System.EventHandler(this.Smailetxt_TextChanged);
            this.Smailetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Smailetxt_KeyDown);
            // 
            // Snametxt
            // 
            this.Snametxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snametxt.Location = new System.Drawing.Point(351, 229);
            this.Snametxt.Multiline = true;
            this.Snametxt.Name = "Snametxt";
            this.Snametxt.Size = new System.Drawing.Size(251, 59);
            this.Snametxt.TabIndex = 8;
            this.Snametxt.TextChanged += new System.EventHandler(this.Snametxt_TextChanged);
            this.Snametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Snametxt_KeyPress);
            // 
            // Sidtxt
            // 
            this.Sidtxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sidtxt.Location = new System.Drawing.Point(349, 110);
            this.Sidtxt.Multiline = true;
            this.Sidtxt.Name = "Sidtxt";
            this.Sidtxt.Size = new System.Drawing.Size(253, 60);
            this.Sidtxt.TabIndex = 7;
            this.Sidtxt.TextChanged += new System.EventHandler(this.Sidtxt_TextChanged);
            this.Sidtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sidtxt_KeyDown);
            this.Sidtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sidtxt_KeyPress);
            // 
            // Genderr
            // 
            this.Genderr.AutoSize = true;
            this.Genderr.BackColor = System.Drawing.Color.Transparent;
            this.Genderr.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderr.ForeColor = System.Drawing.Color.Yellow;
            this.Genderr.Location = new System.Drawing.Point(790, 213);
            this.Genderr.Name = "Genderr";
            this.Genderr.Size = new System.Drawing.Size(241, 45);
            this.Genderr.TabIndex = 13;
            this.Genderr.Text = "Staff Gender";
            // 
            // Addresstxt
            // 
            this.Addresstxt.AutoSize = true;
            this.Addresstxt.BackColor = System.Drawing.Color.Transparent;
            this.Addresstxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresstxt.ForeColor = System.Drawing.Color.Yellow;
            this.Addresstxt.Location = new System.Drawing.Point(683, 110);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(251, 45);
            this.Addresstxt.TabIndex = 12;
            this.Addresstxt.Text = "Staff Address";
            // 
            // Emailtxt
            // 
            this.Emailtxt.AutoSize = true;
            this.Emailtxt.BackColor = System.Drawing.Color.Transparent;
            this.Emailtxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailtxt.ForeColor = System.Drawing.Color.Yellow;
            this.Emailtxt.Location = new System.Drawing.Point(70, 446);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(216, 45);
            this.Emailtxt.TabIndex = 4;
            this.Emailtxt.Text = "Staff Email";
            // 
            // MemberNametxt
            // 
            this.MemberNametxt.AutoSize = true;
            this.MemberNametxt.BackColor = System.Drawing.Color.Transparent;
            this.MemberNametxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNametxt.ForeColor = System.Drawing.Color.Yellow;
            this.MemberNametxt.Location = new System.Drawing.Point(72, 229);
            this.MemberNametxt.Name = "MemberNametxt";
            this.MemberNametxt.Size = new System.Drawing.Size(214, 45);
            this.MemberNametxt.TabIndex = 2;
            this.MemberNametxt.Text = "Staff Name";
            // 
            // MemberIDtxt
            // 
            this.MemberIDtxt.AutoSize = true;
            this.MemberIDtxt.BackColor = System.Drawing.Color.Transparent;
            this.MemberIDtxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDtxt.ForeColor = System.Drawing.Color.Yellow;
            this.MemberIDtxt.Location = new System.Drawing.Point(89, 110);
            this.MemberIDtxt.Name = "MemberIDtxt";
            this.MemberIDtxt.Size = new System.Drawing.Size(158, 45);
            this.MemberIDtxt.TabIndex = 1;
            this.MemberIDtxt.Text = "Staff ID";
            // 
            // Sdurationtxt
            // 
            this.Sdurationtxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sdurationtxt.FormattingEnabled = true;
            this.Sdurationtxt.Items.AddRange(new object[] {
            "9:00Am to 11:00Am",
            "11:00Am to 1:00Pm",
            "1:00Pm to 3:00Pm",
            "3:00Pm to 5:00Pm",
            "5:00Pm to 7:00Pm",
            "7:00Pm to 9:00Pm"});
            this.Sdurationtxt.Location = new System.Drawing.Point(351, 584);
            this.Sdurationtxt.Name = "Sdurationtxt";
            this.Sdurationtxt.Size = new System.Drawing.Size(251, 49);
            this.Sdurationtxt.TabIndex = 11;
            this.Sdurationtxt.SelectedIndexChanged += new System.EventHandler(this.Sdurationtxt_SelectedIndexChanged);
            this.Sdurationtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sdurationtxt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(534, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Get Started";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(833, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 68);
            this.button2.TabIndex = 19;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(1086, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 68);
            this.button3.TabIndex = 20;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminUpdate2cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1464, 985);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sdurationtxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SPhonetxt);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Saddtxt);
            this.Controls.Add(this.Smailetxt);
            this.Controls.Add(this.Snametxt);
            this.Controls.Add(this.Sidtxt);
            this.Controls.Add(this.Genderr);
            this.Controls.Add(this.Addresstxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.MemberNametxt);
            this.Controls.Add(this.MemberIDtxt);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AdminUpdate2cs";
            this.Text = "AdminUpdate2cs";
            this.Load += new System.EventHandler(this.AdminUpdate2cs_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgm1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgm1;
        private System.Windows.Forms.TextBox SAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SPhonetxt;
        private System.Windows.Forms.Label Passwordtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.TextBox Saddtxt;
        private System.Windows.Forms.TextBox Smailetxt;
        private System.Windows.Forms.TextBox Snametxt;
        private System.Windows.Forms.TextBox Sidtxt;
        private System.Windows.Forms.Label Genderr;
        private System.Windows.Forms.Label Addresstxt;
        private System.Windows.Forms.Label Emailtxt;
        private System.Windows.Forms.Label MemberNametxt;
        private System.Windows.Forms.Label MemberIDtxt;
        private System.Windows.Forms.ComboBox Sdurationtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}