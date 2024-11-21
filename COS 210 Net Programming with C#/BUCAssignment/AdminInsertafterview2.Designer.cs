namespace BUCAssignment
{
    partial class AdminInsertafterview2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInsertafterview2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.asd1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ClassFeestxt = new System.Windows.Forms.TextBox();
            this.ClassDatetxt = new System.Windows.Forms.TextBox();
            this.Placetxt = new System.Windows.Forms.TextBox();
            this.Trainertxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClassSessiontxt = new System.Windows.Forms.ComboBox();
            this.Classtitletxt = new System.Windows.Forms.ComboBox();
            this.ClassIdtxt = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asd1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.asd1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(195, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1126, 352);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert Display";
            // 
            // asd1
            // 
            this.asd1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.asd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asd1.GridColor = System.Drawing.Color.Red;
            this.asd1.Location = new System.Drawing.Point(32, 52);
            this.asd1.Name = "asd1";
            this.asd1.RowHeadersWidth = 62;
            this.asd1.RowTemplate.Height = 28;
            this.asd1.Size = new System.Drawing.Size(1064, 283);
            this.asd1.TabIndex = 0;
            this.asd1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asd1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(1176, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 63);
            this.button1.TabIndex = 14;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClassFeestxt
            // 
            this.ClassFeestxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassFeestxt.Location = new System.Drawing.Point(1023, 260);
            this.ClassFeestxt.Multiline = true;
            this.ClassFeestxt.Name = "ClassFeestxt";
            this.ClassFeestxt.Size = new System.Drawing.Size(241, 42);
            this.ClassFeestxt.TabIndex = 13;
            this.ClassFeestxt.TextChanged += new System.EventHandler(this.ClassFeestxt_TextChanged);
            this.ClassFeestxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClassFeestxt_KeyDown);
            // 
            // ClassDatetxt
            // 
            this.ClassDatetxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassDatetxt.Location = new System.Drawing.Point(1023, 62);
            this.ClassDatetxt.Multiline = true;
            this.ClassDatetxt.Name = "ClassDatetxt";
            this.ClassDatetxt.Size = new System.Drawing.Size(241, 42);
            this.ClassDatetxt.TabIndex = 11;
            this.ClassDatetxt.TextChanged += new System.EventHandler(this.ClassDatetxt_TextChanged);
            this.ClassDatetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClassDatetxt_KeyDown);
            // 
            // Placetxt
            // 
            this.Placetxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placetxt.Location = new System.Drawing.Point(310, 324);
            this.Placetxt.Multiline = true;
            this.Placetxt.Name = "Placetxt";
            this.Placetxt.Size = new System.Drawing.Size(241, 42);
            this.Placetxt.TabIndex = 7;
            this.Placetxt.TextChanged += new System.EventHandler(this.Placetxt_TextChanged);
            this.Placetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Placetxt_KeyDown);
            this.Placetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Placetxt_KeyPress);
            // 
            // Trainertxt
            // 
            this.Trainertxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trainertxt.Location = new System.Drawing.Point(310, 217);
            this.Trainertxt.Multiline = true;
            this.Trainertxt.Name = "Trainertxt";
            this.Trainertxt.Size = new System.Drawing.Size(241, 42);
            this.Trainertxt.TabIndex = 6;
            this.Trainertxt.TextChanged += new System.EventHandler(this.Trainertxt_TextChanged);
            this.Trainertxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Trainertxt_KeyDown);
            this.Trainertxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Trainertxt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(698, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 45);
            this.label7.TabIndex = 10;
            this.label7.Text = "Class Fees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(677, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 45);
            this.label6.TabIndex = 9;
            this.label6.Text = "Class Session";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(695, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 45);
            this.label5.TabIndex = 8;
            this.label5.Text = "Class Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "Place";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trainer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class Titles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class ID";
            // 
            // ClassSessiontxt
            // 
            this.ClassSessiontxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassSessiontxt.FormattingEnabled = true;
            this.ClassSessiontxt.Items.AddRange(new object[] {
            "Monday-Friday",
            "Tuesday-Sat",
            "Weekand",
            "Monday-Thursday",
            "Monday-Sunday"});
            this.ClassSessiontxt.Location = new System.Drawing.Point(975, 165);
            this.ClassSessiontxt.Name = "ClassSessiontxt";
            this.ClassSessiontxt.Size = new System.Drawing.Size(304, 44);
            this.ClassSessiontxt.TabIndex = 12;
            this.ClassSessiontxt.SelectedIndexChanged += new System.EventHandler(this.ClassSessiontxt_SelectedIndexChanged);
            this.ClassSessiontxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClassSessiontxt_KeyDown);
            // 
            // Classtitletxt
            // 
            this.Classtitletxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classtitletxt.FormattingEnabled = true;
            this.Classtitletxt.Items.AddRange(new object[] {
            "Gym",
            "Boxing",
            "Karate",
            "walkover",
            "Zumba",
            "Yoga",
            "Wrestling",
            "Mix Martial Arts",
            "Cardio"});
            this.Classtitletxt.Location = new System.Drawing.Point(310, 138);
            this.Classtitletxt.Name = "Classtitletxt";
            this.Classtitletxt.Size = new System.Drawing.Size(233, 44);
            this.Classtitletxt.TabIndex = 5;
            this.Classtitletxt.SelectedIndexChanged += new System.EventHandler(this.Classtitletxt_SelectedIndexChanged);
            this.Classtitletxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Classtitletxt_KeyDown);
            // 
            // ClassIdtxt
            // 
            this.ClassIdtxt.AutoSize = true;
            this.ClassIdtxt.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassIdtxt.ForeColor = System.Drawing.Color.Red;
            this.ClassIdtxt.Location = new System.Drawing.Point(398, 46);
            this.ClassIdtxt.Name = "ClassIdtxt";
            this.ClassIdtxt.Size = new System.Drawing.Size(0, 41);
            this.ClassIdtxt.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(963, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 63);
            this.button2.TabIndex = 16;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(747, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 63);
            this.button3.TabIndex = 17;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminInsertafterview2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1363, 771);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ClassIdtxt);
            this.Controls.Add(this.Classtitletxt);
            this.Controls.Add(this.ClassSessiontxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClassFeestxt);
            this.Controls.Add(this.ClassDatetxt);
            this.Controls.Add(this.Placetxt);
            this.Controls.Add(this.Trainertxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AdminInsertafterview2";
            this.Text = "AdminInsertafterview2";
            this.Load += new System.EventHandler(this.AdminInsertafterview2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.asd1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView asd1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ClassFeestxt;
        private System.Windows.Forms.TextBox ClassDatetxt;
        private System.Windows.Forms.TextBox Placetxt;
        private System.Windows.Forms.TextBox Trainertxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ClassSessiontxt;
        private System.Windows.Forms.ComboBox Classtitletxt;
        private System.Windows.Forms.Label ClassIdtxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}