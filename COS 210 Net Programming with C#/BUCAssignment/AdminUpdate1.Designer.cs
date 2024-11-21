namespace BUCAssignment
{
    partial class AdminUpdate1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUpdate1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgu1 = new System.Windows.Forms.DataGridView();
            this.U1Tclasstxt = new System.Windows.Forms.ComboBox();
            this.U1TPhonetxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.U1Tdurationtxt = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.U1TExperiencetxt = new System.Windows.Forms.ComboBox();
            this.U1Twghtxt = new System.Windows.Forms.ComboBox();
            this.U1Thghtxt = new System.Windows.Forms.ComboBox();
            this.U1Taddtxt = new System.Windows.Forms.TextBox();
            this.U1Tmailetxt = new System.Windows.Forms.TextBox();
            this.U1Tnametxt = new System.Windows.Forms.TextBox();
            this.U1Tidtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Joiningtxt = new System.Windows.Forms.Label();
            this.Addresstxt = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.Label();
            this.MemberNametxt = new System.Windows.Forms.Label();
            this.MemberIDtxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Genderr = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.mconditiontxt = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgu1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgu1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(270, 736);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 407);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update display";
            // 
            // dgu1
            // 
            this.dgu1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dgu1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgu1.GridColor = System.Drawing.Color.Lime;
            this.dgu1.Location = new System.Drawing.Point(20, 52);
            this.dgu1.Name = "dgu1";
            this.dgu1.RowHeadersWidth = 62;
            this.dgu1.RowTemplate.Height = 28;
            this.dgu1.Size = new System.Drawing.Size(702, 334);
            this.dgu1.TabIndex = 0;
            this.dgu1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgu1_CellContentClick);
            // 
            // U1Tclasstxt
            // 
            this.U1Tclasstxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U1Tclasstxt.FormattingEnabled = true;
            this.U1Tclasstxt.Items.AddRange(new object[] {
            "Gym",
            "Boxing",
            "Karate",
            "walkover",
            "Zumba",
            "Yoga",
            "Wrestling",
            "Mix Martial Arts",
            "Cardio"});
            this.U1Tclasstxt.Location = new System.Drawing.Point(575, 672);
            this.U1Tclasstxt.Name = "U1Tclasstxt";
            this.U1Tclasstxt.Size = new System.Drawing.Size(266, 44);
            this.U1Tclasstxt.TabIndex = 12;
            this.U1Tclasstxt.SelectedIndexChanged += new System.EventHandler(this.U1Tclasstxt_SelectedIndexChanged);
            this.U1Tclasstxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.U1Tclasstxt_KeyDown);
            // 
            // U1TPhonetxt
            // 
            this.U1TPhonetxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U1TPhonetxt.Location = new System.Drawing.Point(331, 319);
            this.U1TPhonetxt.Multiline = true;
            this.U1TPhonetxt.Name = "U1TPhonetxt";
            this.U1TPhonetxt.Size = new System.Drawing.Size(357, 61);
            this.U1TPhonetxt.TabIndex = 8;
            this.U1TPhonetxt.TextChanged += new System.EventHandler(this.U1TPhonetxt_TextChanged);
            this.U1TPhonetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.U1TPhonetxt_KeyDown);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.AutoSize = true;
            this.Passwordtxt.BackColor = System.Drawing.Color.Transparent;
            this.Passwordtxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.ForeColor = System.Drawing.Color.White;
            this.Passwordtxt.Location = new System.Drawing.Point(22, 319);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(263, 45);
            this.Passwordtxt.TabIndex = 3;
            this.Passwordtxt.Text = "Trainer Phone";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(1023, 755);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 68);
            this.button1.TabIndex = 25;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // U1Tdurationtxt
            // 
            this.U1Tdurationtxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U1Tdurationtxt.FormattingEnabled = true;
            this.U1Tdurationtxt.Items.AddRange(new object[] {
            "9:00Am-12:00Pm(Morning Workout)",
            "12:00Pm-1:00Pm(Lunch Break)",
            "1:00Pm-5:00Pm(Evening Workout)",
            "5:00Pm-8:00Pm(Music/Zumba Dance/Play interesting Games)",
            "8:30Pm(Close)..,No Weekend holiday."});
            this.U1Tdurationtxt.Location = new System.Drawing.Point(354, 533);
            this.U1Tdurationtxt.Name = "U1Tdurationtxt";
            this.U1Tdurationtxt.Size = new System.Drawing.Size(350, 44);
            this.U1Tdurationtxt.TabIndex = 10;
            this.U1Tdurationtxt.SelectedIndexChanged += new System.EventHandler(this.U1Tdurationtxt_SelectedIndexChanged);
            this.U1Tdurationtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.U1Tdurationtxt_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 516);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(311, 45);
            this.label8.TabIndex = 5;
            this.label8.Text = "Trainer Duration";
            // 
            // U1TExperiencetxt
            // 
            this.U1TExperiencetxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U1TExperiencetxt.FormattingEnabled = true;
            this.U1TExperiencetxt.Items.AddRange(new object[] {
            "1Years",
            "2Years",
            "3Years",
            "4Years",
            "5Years",
            "6Years",
            "7Years",
            "8Years",
            "9Years",
            "10Years",
            "11Years",
            "12Years",
            "13Years",
            "14Years",
            "15Years",
            "16Years",
            "17Years",
            "18Years",
            "19Years",
            "20Years",
            "and more"});
            this.U1TExperiencetxt.Location = new System.Drawing.Point(1363, 234);
            this.U1TExperiencetxt.Name = "U1TExperiencetxt";
            this.U1TExperiencetxt.Size = new System.Drawing.Size(266, 44);
            this.U1TExperiencetxt.TabIndex = 16;
            this.U1TExperiencetxt.SelectedIndexChanged += new System.EventHandler(this.U1TExperiencetxt_SelectedIndexChanged);
            this.U1TExperiencetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.U1TExperiencetxt_KeyDown);
            // 
            // U1Twghtxt
            // 
            this.U1Twghtxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U1Twghtxt.FormattingEnabled = true;
            this.U1Twghtxt.Items.AddRange(new object[] {
            "40-50kg",
            "50-60kg",
            "60-70kg",
            "70-80kg",
            "80-90kg",
            "90-100kg",
            "100-110kg",
            "110-120kg",
            "120-130kg",
            "130-140kg",
            "150kg and above"});
            this.U1Twghtxt.Location = new System.Drawing.Point(1320, 590);
            this.U1Twghtxt.Name = "U1Twghtxt";
            this.U1Twghtxt.Size = new System.Drawing.Size(179, 44);
            this.U1Twghtxt.TabIndex = 22;
            this.U1Twghtxt.SelectedIndexChanged += new System.EventHandler(this.U1Twghtxt_SelectedIndexChanged);
            this.U1Twghtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.U1Twghtxt_KeyDown);
            // 
            // U1Thghtxt
            // 
            this.U1Thghtxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U1Thghtxt.FormattingEnabled = true;
            this.U1Thghtxt.Items.AddRange(new object[] {
            "129.54 cm",
            "132.08 cm",
            "134.62 cm",
            "137.16 cm",
            "139.70 cm",
            "142.24 cm",
            "144.78 cm",
            "147.32 cm",
            "149.86 cm",
            "152.40 cm",
            "154.94 cm",
            "157.48 cm",
            "160.02 cm",
            "162.56 cm",
            "165.10 cm",
            "167.64 cm",
            "170.18 cm",
            "172.72 cm",
            "175.26 cm",
            "177.80 cm",
            "180.34 cm",
            "182.88 cm",
            "185.42 cm",
            "187.96 cm",
            "190.50 cm ",
            "193.04 cm ",
            "195.58 cm ",
            "198.12 cm ",
            "200.66 cm ",
            "other...."});
            this.U1Thghtxt.Location = new System.Drawing.Point(1059, 599);
            this.U1Thghtxt.Name = "U1Thghtxt";
            this.U1Thghtxt.Size = new System.Drawing.Size(169, 44);
            this.U1Thghtxt.TabIndex = 21;
            this.U1Thghtxt.SelectedIndexChanged += new System.EventHandler(this.U1Thghtxt_SelectedIndexChanged);
            this.U1Thghtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.U1Thghtxt_KeyDown);
            // 
            // U1Taddtxt
            // 
            this.U1Taddtxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U1Taddtxt.Location = new System.Drawing.Point(1363, 125);
            this.U1Taddtxt.Multiline = true;
            this.U1Taddtxt.Name = "U1Taddtxt";
            this.U1Taddtxt.Size = new System.Drawing.Size(266, 49);
            this.U1Taddtxt.TabIndex = 15;
            this.U1Taddtxt.TextChanged += new System.EventHandler(this.U1Taddtxt_TextChanged);
            this.U1Taddtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.U1Taddtxt_KeyDown);
            // 
            // U1Tmailetxt
            // 
            this.U1Tmailetxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U1Tmailetxt.Location = new System.Drawing.Point(331, 415);
            this.U1Tmailetxt.Multiline = true;
            this.U1Tmailetxt.Name = "U1Tmailetxt";
            this.U1Tmailetxt.Size = new System.Drawing.Size(357, 49);
            this.U1Tmailetxt.TabIndex = 9;
            this.U1Tmailetxt.TextChanged += new System.EventHandler(this.U1Tmailetxt_TextChanged);
            this.U1Tmailetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.U1Tmailetxt_KeyDown);
            // 
            // U1Tnametxt
            // 
            this.U1Tnametxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U1Tnametxt.Location = new System.Drawing.Point(331, 213);
            this.U1Tnametxt.Multiline = true;
            this.U1Tnametxt.Name = "U1Tnametxt";
            this.U1Tnametxt.Size = new System.Drawing.Size(346, 49);
            this.U1Tnametxt.TabIndex = 7;
            this.U1Tnametxt.TextChanged += new System.EventHandler(this.U1Tnametxt_TextChanged);
            this.U1Tnametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.U1Tnametxt_KeyDown);
            this.U1Tnametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.U1Tnametxt_KeyPress);
            // 
            // U1Tidtxt
            // 
            this.U1Tidtxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U1Tidtxt.Location = new System.Drawing.Point(316, 108);
            this.U1Tidtxt.Multiline = true;
            this.U1Tidtxt.Name = "U1Tidtxt";
            this.U1Tidtxt.Size = new System.Drawing.Size(221, 45);
            this.U1Tidtxt.TabIndex = 6;
            this.U1Tidtxt.TextChanged += new System.EventHandler(this.U1Tidtxt_TextChanged);
            this.U1Tidtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.U1Tidtxt_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1292, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 45);
            this.label5.TabIndex = 23;
            this.label5.Text = " Trainer Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(973, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 45);
            this.label4.TabIndex = 20;
            this.label4.Text = " Trainer Height";
            // 
            // Joiningtxt
            // 
            this.Joiningtxt.AutoSize = true;
            this.Joiningtxt.BackColor = System.Drawing.Color.Transparent;
            this.Joiningtxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joiningtxt.ForeColor = System.Drawing.Color.White;
            this.Joiningtxt.Location = new System.Drawing.Point(616, 599);
            this.Joiningtxt.Name = "Joiningtxt";
            this.Joiningtxt.Size = new System.Drawing.Size(251, 45);
            this.Joiningtxt.TabIndex = 11;
            this.Joiningtxt.Text = "Trainer Class";
            // 
            // Addresstxt
            // 
            this.Addresstxt.AutoSize = true;
            this.Addresstxt.BackColor = System.Drawing.Color.Transparent;
            this.Addresstxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresstxt.ForeColor = System.Drawing.Color.White;
            this.Addresstxt.Location = new System.Drawing.Point(1027, 129);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(306, 45);
            this.Addresstxt.TabIndex = 13;
            this.Addresstxt.Text = " Trainer Address";
            // 
            // Emailtxt
            // 
            this.Emailtxt.AutoSize = true;
            this.Emailtxt.BackColor = System.Drawing.Color.Transparent;
            this.Emailtxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailtxt.ForeColor = System.Drawing.Color.White;
            this.Emailtxt.Location = new System.Drawing.Point(39, 409);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(271, 45);
            this.Emailtxt.TabIndex = 4;
            this.Emailtxt.Text = " Trainer Email";
            // 
            // MemberNametxt
            // 
            this.MemberNametxt.AutoSize = true;
            this.MemberNametxt.BackColor = System.Drawing.Color.Transparent;
            this.MemberNametxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNametxt.ForeColor = System.Drawing.Color.White;
            this.MemberNametxt.Location = new System.Drawing.Point(22, 200);
            this.MemberNametxt.Name = "MemberNametxt";
            this.MemberNametxt.Size = new System.Drawing.Size(260, 45);
            this.MemberNametxt.TabIndex = 2;
            this.MemberNametxt.Text = "Trainer Name";
            // 
            // MemberIDtxt
            // 
            this.MemberIDtxt.AutoSize = true;
            this.MemberIDtxt.BackColor = System.Drawing.Color.Transparent;
            this.MemberIDtxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDtxt.ForeColor = System.Drawing.Color.White;
            this.MemberIDtxt.Location = new System.Drawing.Point(30, 108);
            this.MemberIDtxt.Name = "MemberIDtxt";
            this.MemberIDtxt.Size = new System.Drawing.Size(195, 45);
            this.MemberIDtxt.TabIndex = 1;
            this.MemberIDtxt.Text = "TrainerID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(523, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            // 
            // Genderr
            // 
            this.Genderr.AutoSize = true;
            this.Genderr.BackColor = System.Drawing.Color.Transparent;
            this.Genderr.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderr.ForeColor = System.Drawing.Color.White;
            this.Genderr.Location = new System.Drawing.Point(1107, 310);
            this.Genderr.Name = "Genderr";
            this.Genderr.Size = new System.Drawing.Size(148, 45);
            this.Genderr.TabIndex = 17;
            this.Genderr.Text = "Gender";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.BackColor = System.Drawing.Color.Transparent;
            this.Male.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male.ForeColor = System.Drawing.Color.White;
            this.Male.Location = new System.Drawing.Point(1320, 319);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(110, 40);
            this.Male.TabIndex = 18;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = false;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.BackColor = System.Drawing.Color.Transparent;
            this.Female.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female.ForeColor = System.Drawing.Color.White;
            this.Female.Location = new System.Drawing.Point(1476, 315);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(140, 40);
            this.Female.TabIndex = 19;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = false;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // mconditiontxt
            // 
            this.mconditiontxt.AutoSize = true;
            this.mconditiontxt.BackColor = System.Drawing.Color.Transparent;
            this.mconditiontxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mconditiontxt.ForeColor = System.Drawing.Color.White;
            this.mconditiontxt.Location = new System.Drawing.Point(995, 217);
            this.mconditiontxt.Name = "mconditiontxt";
            this.mconditiontxt.Size = new System.Drawing.Size(350, 45);
            this.mconditiontxt.TabIndex = 14;
            this.mconditiontxt.Text = "Trainer Experience";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(1249, 755);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 68);
            this.button2.TabIndex = 26;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(1135, 839);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 68);
            this.button3.TabIndex = 27;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminUpdate1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1651, 919);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Genderr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.U1Tclasstxt);
            this.Controls.Add(this.U1TPhonetxt);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.U1Tdurationtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.U1TExperiencetxt);
            this.Controls.Add(this.U1Twghtxt);
            this.Controls.Add(this.U1Thghtxt);
            this.Controls.Add(this.U1Taddtxt);
            this.Controls.Add(this.U1Tmailetxt);
            this.Controls.Add(this.U1Tnametxt);
            this.Controls.Add(this.U1Tidtxt);
            this.Controls.Add(this.mconditiontxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Joiningtxt);
            this.Controls.Add(this.Addresstxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.MemberNametxt);
            this.Controls.Add(this.MemberIDtxt);
            this.Controls.Add(this.label1);
            this.Name = "AdminUpdate1";
            this.Text = "AdminUpdate1";
            this.Load += new System.EventHandler(this.AdminUpdate1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgu1;
        private System.Windows.Forms.ComboBox U1Tclasstxt;
        private System.Windows.Forms.TextBox U1TPhonetxt;
        private System.Windows.Forms.Label Passwordtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox U1Tdurationtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox U1TExperiencetxt;
        private System.Windows.Forms.ComboBox U1Twghtxt;
        private System.Windows.Forms.ComboBox U1Thghtxt;
        private System.Windows.Forms.TextBox U1Taddtxt;
        private System.Windows.Forms.TextBox U1Tmailetxt;
        private System.Windows.Forms.TextBox U1Tnametxt;
        private System.Windows.Forms.TextBox U1Tidtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Joiningtxt;
        private System.Windows.Forms.Label Addresstxt;
        private System.Windows.Forms.Label Emailtxt;
        private System.Windows.Forms.Label MemberNametxt;
        private System.Windows.Forms.Label MemberIDtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Genderr;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.Label mconditiontxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}