namespace BUCAssignment
{
    partial class AdminDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDelete));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.RdbClass = new System.Windows.Forms.RadioButton();
            this.RdbEnrollment = new System.Windows.Forms.RadioButton();
            this.RdbTrainer = new System.Windows.Forms.RadioButton();
            this.RdbStaff = new System.Windows.Forms.RadioButton();
            this.RdbMember = new System.Windows.Forms.RadioButton();
            this.deletetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dmm3 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmm3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.RdbClass);
            this.groupBox1.Controls.Add(this.RdbEnrollment);
            this.groupBox1.Controls.Add(this.RdbTrainer);
            this.groupBox1.Controls.Add(this.RdbStaff);
            this.groupBox1.Controls.Add(this.RdbMember);
            this.groupBox1.Controls.Add(this.deletetxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dmm3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Purple;
            this.groupBox1.Location = new System.Drawing.Point(12, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1274, 562);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MidnightBlue;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Lime;
            this.button7.Location = new System.Drawing.Point(1117, 40);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(151, 64);
            this.button7.TabIndex = 17;
            this.button7.Text = "Delete ";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // RdbClass
            // 
            this.RdbClass.AutoSize = true;
            this.RdbClass.ForeColor = System.Drawing.Color.Magenta;
            this.RdbClass.Location = new System.Drawing.Point(204, 75);
            this.RdbClass.Name = "RdbClass";
            this.RdbClass.Size = new System.Drawing.Size(120, 45);
            this.RdbClass.TabIndex = 13;
            this.RdbClass.TabStop = true;
            this.RdbClass.Text = "Class";
            this.RdbClass.UseVisualStyleBackColor = true;
            this.RdbClass.CheckedChanged += new System.EventHandler(this.RdbClass_CheckedChanged);
            // 
            // RdbEnrollment
            // 
            this.RdbEnrollment.AutoSize = true;
            this.RdbEnrollment.ForeColor = System.Drawing.Color.Magenta;
            this.RdbEnrollment.Location = new System.Drawing.Point(367, 75);
            this.RdbEnrollment.Name = "RdbEnrollment";
            this.RdbEnrollment.Size = new System.Drawing.Size(198, 45);
            this.RdbEnrollment.TabIndex = 12;
            this.RdbEnrollment.TabStop = true;
            this.RdbEnrollment.Text = "Enrollment";
            this.RdbEnrollment.UseVisualStyleBackColor = true;
            this.RdbEnrollment.CheckedChanged += new System.EventHandler(this.RdbEnrollment_CheckedChanged);
            // 
            // RdbTrainer
            // 
            this.RdbTrainer.AutoSize = true;
            this.RdbTrainer.ForeColor = System.Drawing.Color.Magenta;
            this.RdbTrainer.Location = new System.Drawing.Point(204, 24);
            this.RdbTrainer.Name = "RdbTrainer";
            this.RdbTrainer.Size = new System.Drawing.Size(144, 45);
            this.RdbTrainer.TabIndex = 11;
            this.RdbTrainer.TabStop = true;
            this.RdbTrainer.Text = "Trainer";
            this.RdbTrainer.UseVisualStyleBackColor = true;
            this.RdbTrainer.CheckedChanged += new System.EventHandler(this.RdbTrainer_CheckedChanged);
            // 
            // RdbStaff
            // 
            this.RdbStaff.AutoSize = true;
            this.RdbStaff.ForeColor = System.Drawing.Color.Magenta;
            this.RdbStaff.Location = new System.Drawing.Point(367, 24);
            this.RdbStaff.Name = "RdbStaff";
            this.RdbStaff.Size = new System.Drawing.Size(112, 45);
            this.RdbStaff.TabIndex = 10;
            this.RdbStaff.TabStop = true;
            this.RdbStaff.Text = "Staff";
            this.RdbStaff.UseVisualStyleBackColor = true;
            this.RdbStaff.CheckedChanged += new System.EventHandler(this.RdbStaff_CheckedChanged);
            // 
            // RdbMember
            // 
            this.RdbMember.AutoSize = true;
            this.RdbMember.ForeColor = System.Drawing.Color.Magenta;
            this.RdbMember.Location = new System.Drawing.Point(35, 48);
            this.RdbMember.Name = "RdbMember";
            this.RdbMember.Size = new System.Drawing.Size(163, 45);
            this.RdbMember.TabIndex = 9;
            this.RdbMember.TabStop = true;
            this.RdbMember.Text = "Member";
            this.RdbMember.UseVisualStyleBackColor = true;
            this.RdbMember.CheckedChanged += new System.EventHandler(this.RdbMember_CheckedChanged);
            // 
            // deletetxt
            // 
            this.deletetxt.ForeColor = System.Drawing.Color.Magenta;
            this.deletetxt.Location = new System.Drawing.Point(798, 49);
            this.deletetxt.Multiline = true;
            this.deletetxt.Name = "deletetxt";
            this.deletetxt.Size = new System.Drawing.Size(286, 47);
            this.deletetxt.TabIndex = 2;
            this.deletetxt.TextChanged += new System.EventHandler(this.deletetxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(578, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete ID:";
            // 
            // dmm3
            // 
            this.dmm3.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dmm3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dmm3.GridColor = System.Drawing.Color.Lime;
            this.dmm3.Location = new System.Drawing.Point(57, 133);
            this.dmm3.Name = "dmm3";
            this.dmm3.RowHeadersWidth = 62;
            this.dmm3.RowTemplate.Height = 28;
            this.dmm3.Size = new System.Drawing.Size(1156, 406);
            this.dmm3.TabIndex = 0;
            this.dmm3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MistyRose;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Magenta;
            this.button5.Location = new System.Drawing.Point(1022, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 67);
            this.button5.TabIndex = 16;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MistyRose;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Magenta;
            this.button4.Location = new System.Drawing.Point(810, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 67);
            this.button4.TabIndex = 15;
            this.button4.Text = "Delete ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MistyRose;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Magenta;
            this.button6.Location = new System.Drawing.Point(617, 44);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 67);
            this.button6.TabIndex = 14;
            this.button6.Text = "Insert";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Magenta;
            this.button3.Location = new System.Drawing.Point(431, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 67);
            this.button3.TabIndex = 13;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Magenta;
            this.button2.Location = new System.Drawing.Point(238, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 67);
            this.button2.TabIndex = 12;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Magenta;
            this.button1.Location = new System.Drawing.Point(47, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 67);
            this.button1.TabIndex = 11;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1565, 846);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminDelete";
            this.Text = "AdminDelete";
            this.Load += new System.EventHandler(this.AdminDelete_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmm3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox deletetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dmm3;
        private System.Windows.Forms.RadioButton RdbClass;
        private System.Windows.Forms.RadioButton RdbEnrollment;
        private System.Windows.Forms.RadioButton RdbTrainer;
        private System.Windows.Forms.RadioButton RdbStaff;
        private System.Windows.Forms.RadioButton RdbMember;
        private System.Windows.Forms.Button button7;
    }
}