namespace BUCAssignment
{
    partial class AdminInsertafterview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInsertafterview));
            this.TPhonetxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Tdurationtxt = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Taddtxt = new System.Windows.Forms.TextBox();
            this.Tmailetxt = new System.Windows.Forms.TextBox();
            this.Tnametxt = new System.Windows.Forms.TextBox();
            this.Genderr = new System.Windows.Forms.Label();
            this.Addresstxt = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.Label();
            this.MemberNametxt = new System.Windows.Forms.Label();
            this.MemberIDtxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TExperiencetxt = new System.Windows.Forms.ComboBox();
            this.mconditiontxt = new System.Windows.Forms.Label();
            this.Joiningtxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tclasstxt = new System.Windows.Forms.ComboBox();
            this.Twghtxt = new System.Windows.Forms.ComboBox();
            this.Thghtxt = new System.Windows.Forms.ComboBox();
            this.TDOBtxts = new System.Windows.Forms.DateTimePicker();
            this.DOBtxt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgm1 = new System.Windows.Forms.DataGridView();
            this.Tidtxt = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgm1)).BeginInit();
            this.SuspendLayout();
            // 
            // TPhonetxt
            // 
            this.TPhonetxt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.TPhonetxt.Location = new System.Drawing.Point(261, 322);
            this.TPhonetxt.Multiline = true;
            this.TPhonetxt.Name = "TPhonetxt";
            this.TPhonetxt.Size = new System.Drawing.Size(219, 49);
            this.TPhonetxt.TabIndex = 8;
            this.TPhonetxt.TextChanged += new System.EventHandler(this.TPhonetxt_TextChanged);
            this.TPhonetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TPhonetxt_KeyDown);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.AutoSize = true;
            this.Passwordtxt.BackColor = System.Drawing.Color.Transparent;
            this.Passwordtxt.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.ForeColor = System.Drawing.Color.Aquamarine;
            this.Passwordtxt.Location = new System.Drawing.Point(12, 322);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(236, 41);
            this.Passwordtxt.TabIndex = 3;
            this.Passwordtxt.Text = "Trainer Phone";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(1688, 726);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 68);
            this.button1.TabIndex = 24;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tdurationtxt
            // 
            this.Tdurationtxt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tdurationtxt.FormattingEnabled = true;
            this.Tdurationtxt.Items.AddRange(new object[] {
            "9:00Am-12:00Pm(Morning Workout)",
            "12:00Pm-1:00Pm(Lunch Break)",
            "1:00Pm-5:00Pm(Evening Workout)",
            "5:00Pm-8:00Pm(Music/Zumba Dance/Play interesting Games)",
            "8:30Pm(Close)..,No Weekend holiday."});
            this.Tdurationtxt.Location = new System.Drawing.Point(285, 604);
            this.Tdurationtxt.Name = "Tdurationtxt";
            this.Tdurationtxt.Size = new System.Drawing.Size(350, 40);
            this.Tdurationtxt.TabIndex = 10;
            this.Tdurationtxt.SelectedIndexChanged += new System.EventHandler(this.Tdurationtxt_SelectedIndexChanged);
            this.Tdurationtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tdurationtxt_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Aquamarine;
            this.label8.Location = new System.Drawing.Point(1, 598);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(278, 41);
            this.label8.TabIndex = 5;
            this.label8.Text = "Trainer Duration";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.BackColor = System.Drawing.Color.Black;
            this.Male.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male.ForeColor = System.Drawing.Color.White;
            this.Male.Location = new System.Drawing.Point(1261, 181);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(99, 36);
            this.Male.TabIndex = 22;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = false;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.BackColor = System.Drawing.Color.White;
            this.Female.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female.ForeColor = System.Drawing.Color.Black;
            this.Female.Location = new System.Drawing.Point(1386, 181);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(125, 36);
            this.Female.TabIndex = 23;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = false;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // Taddtxt
            // 
            this.Taddtxt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taddtxt.Location = new System.Drawing.Point(802, 170);
            this.Taddtxt.Multiline = true;
            this.Taddtxt.Name = "Taddtxt";
            this.Taddtxt.Size = new System.Drawing.Size(219, 49);
            this.Taddtxt.TabIndex = 16;
            this.Taddtxt.TextChanged += new System.EventHandler(this.Taddtxt_TextChanged);
            this.Taddtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Taddtxt_KeyDown);
            // 
            // Tmailetxt
            // 
            this.Tmailetxt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tmailetxt.Location = new System.Drawing.Point(270, 467);
            this.Tmailetxt.Multiline = true;
            this.Tmailetxt.Name = "Tmailetxt";
            this.Tmailetxt.Size = new System.Drawing.Size(365, 72);
            this.Tmailetxt.TabIndex = 9;
            this.Tmailetxt.TextChanged += new System.EventHandler(this.Tmailetxt_TextChanged);
            this.Tmailetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tmailetxt_KeyDown);
            this.Tmailetxt.Leave += new System.EventHandler(this.Tmailetxt_Leave);
            // 
            // Tnametxt
            // 
            this.Tnametxt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tnametxt.Location = new System.Drawing.Point(261, 190);
            this.Tnametxt.Multiline = true;
            this.Tnametxt.Name = "Tnametxt";
            this.Tnametxt.Size = new System.Drawing.Size(219, 58);
            this.Tnametxt.TabIndex = 7;
            this.Tnametxt.TextChanged += new System.EventHandler(this.Tnametxt_TextChanged);
            this.Tnametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tnametxt_KeyDown);
            this.Tnametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tnametxt_KeyPress);
            // 
            // Genderr
            // 
            this.Genderr.AutoSize = true;
            this.Genderr.BackColor = System.Drawing.Color.Transparent;
            this.Genderr.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderr.ForeColor = System.Drawing.Color.Aquamarine;
            this.Genderr.Location = new System.Drawing.Point(1111, 176);
            this.Genderr.Name = "Genderr";
            this.Genderr.Size = new System.Drawing.Size(134, 41);
            this.Genderr.TabIndex = 21;
            this.Genderr.Text = "Gender";
            // 
            // Addresstxt
            // 
            this.Addresstxt.AutoSize = true;
            this.Addresstxt.BackColor = System.Drawing.Color.Transparent;
            this.Addresstxt.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresstxt.ForeColor = System.Drawing.Color.Aquamarine;
            this.Addresstxt.Location = new System.Drawing.Point(525, 176);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(271, 41);
            this.Addresstxt.TabIndex = 11;
            this.Addresstxt.Text = " Trainer Address";
            // 
            // Emailtxt
            // 
            this.Emailtxt.AutoSize = true;
            this.Emailtxt.BackColor = System.Drawing.Color.Transparent;
            this.Emailtxt.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailtxt.ForeColor = System.Drawing.Color.Aquamarine;
            this.Emailtxt.Location = new System.Drawing.Point(12, 467);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(238, 41);
            this.Emailtxt.TabIndex = 4;
            this.Emailtxt.Text = " Trainer Email";
            // 
            // MemberNametxt
            // 
            this.MemberNametxt.AutoSize = true;
            this.MemberNametxt.BackColor = System.Drawing.Color.Transparent;
            this.MemberNametxt.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNametxt.ForeColor = System.Drawing.Color.Aquamarine;
            this.MemberNametxt.Location = new System.Drawing.Point(12, 190);
            this.MemberNametxt.Name = "MemberNametxt";
            this.MemberNametxt.Size = new System.Drawing.Size(230, 41);
            this.MemberNametxt.TabIndex = 2;
            this.MemberNametxt.Text = "Trainer Name";
            // 
            // MemberIDtxt
            // 
            this.MemberIDtxt.AutoSize = true;
            this.MemberIDtxt.BackColor = System.Drawing.Color.Transparent;
            this.MemberIDtxt.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDtxt.ForeColor = System.Drawing.Color.Aquamarine;
            this.MemberIDtxt.Location = new System.Drawing.Point(33, 79);
            this.MemberIDtxt.Name = "MemberIDtxt";
            this.MemberIDtxt.Size = new System.Drawing.Size(153, 36);
            this.MemberIDtxt.TabIndex = 1;
            this.MemberIDtxt.Text = "TrainerID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(615, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TExperiencetxt
            // 
            this.TExperiencetxt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TExperiencetxt.FormattingEnabled = true;
            this.TExperiencetxt.Items.AddRange(new object[] {
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
            this.TExperiencetxt.Location = new System.Drawing.Point(1071, 377);
            this.TExperiencetxt.Name = "TExperiencetxt";
            this.TExperiencetxt.Size = new System.Drawing.Size(266, 40);
            this.TExperiencetxt.TabIndex = 18;
            this.TExperiencetxt.SelectedIndexChanged += new System.EventHandler(this.TExperiencetxt_SelectedIndexChanged);
            this.TExperiencetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TExperiencetxt_KeyDown);
            // 
            // mconditiontxt
            // 
            this.mconditiontxt.AutoSize = true;
            this.mconditiontxt.BackColor = System.Drawing.Color.Transparent;
            this.mconditiontxt.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mconditiontxt.ForeColor = System.Drawing.Color.Aquamarine;
            this.mconditiontxt.Location = new System.Drawing.Point(566, 363);
            this.mconditiontxt.Name = "mconditiontxt";
            this.mconditiontxt.Size = new System.Drawing.Size(311, 41);
            this.mconditiontxt.TabIndex = 13;
            this.mconditiontxt.Text = "Trainer Experience";
            // 
            // Joiningtxt
            // 
            this.Joiningtxt.AutoSize = true;
            this.Joiningtxt.BackColor = System.Drawing.Color.Transparent;
            this.Joiningtxt.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joiningtxt.ForeColor = System.Drawing.Color.Aquamarine;
            this.Joiningtxt.Location = new System.Drawing.Point(699, 498);
            this.Joiningtxt.Name = "Joiningtxt";
            this.Joiningtxt.Size = new System.Drawing.Size(222, 41);
            this.Joiningtxt.TabIndex = 14;
            this.Joiningtxt.Text = "Trainer Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aquamarine;
            this.label4.Location = new System.Drawing.Point(947, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 41);
            this.label4.TabIndex = 19;
            this.label4.Text = " Trainer Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aquamarine;
            this.label5.Location = new System.Drawing.Point(1255, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 41);
            this.label5.TabIndex = 25;
            this.label5.Text = " Trainer Weight";
            // 
            // Tclasstxt
            // 
            this.Tclasstxt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tclasstxt.FormattingEnabled = true;
            this.Tclasstxt.Items.AddRange(new object[] {
            "Gym",
            "Boxing",
            "Karate",
            "walkover",
            "Zumba",
            "Yoga",
            "Wrestling",
            "Mix Martial Arts",
            "Cardio"});
            this.Tclasstxt.Location = new System.Drawing.Point(666, 588);
            this.Tclasstxt.Name = "Tclasstxt";
            this.Tclasstxt.Size = new System.Drawing.Size(266, 40);
            this.Tclasstxt.TabIndex = 15;
            this.Tclasstxt.SelectedIndexChanged += new System.EventHandler(this.Tclasstxt_SelectedIndexChanged);
            this.Tclasstxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tclasstxt_KeyDown);
            // 
            // Twghtxt
            // 
            this.Twghtxt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Twghtxt.FormattingEnabled = true;
            this.Twghtxt.Items.AddRange(new object[] {
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
            this.Twghtxt.Location = new System.Drawing.Point(1236, 576);
            this.Twghtxt.Name = "Twghtxt";
            this.Twghtxt.Size = new System.Drawing.Size(245, 40);
            this.Twghtxt.TabIndex = 26;
            this.Twghtxt.SelectedIndexChanged += new System.EventHandler(this.Twghtxt_SelectedIndexChanged);
            this.Twghtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Twghtxt_KeyDown);
            // 
            // Thghtxt
            // 
            this.Thghtxt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thghtxt.FormattingEnabled = true;
            this.Thghtxt.Items.AddRange(new object[] {
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
            this.Thghtxt.Location = new System.Drawing.Point(963, 588);
            this.Thghtxt.Name = "Thghtxt";
            this.Thghtxt.Size = new System.Drawing.Size(218, 40);
            this.Thghtxt.TabIndex = 20;
            this.Thghtxt.SelectedIndexChanged += new System.EventHandler(this.Thghtxt_SelectedIndexChanged);
            this.Thghtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Thghtxt_KeyDown);
            // 
            // TDOBtxts
            // 
            this.TDOBtxts.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDOBtxts.Location = new System.Drawing.Point(1041, 272);
            this.TDOBtxts.Name = "TDOBtxts";
            this.TDOBtxts.Size = new System.Drawing.Size(472, 49);
            this.TDOBtxts.TabIndex = 17;
            this.TDOBtxts.ValueChanged += new System.EventHandler(this.TDOBtxts_ValueChanged);
            this.TDOBtxts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TDOBtxts_KeyDown);
            // 
            // DOBtxt
            // 
            this.DOBtxt.AutoSize = true;
            this.DOBtxt.BackColor = System.Drawing.Color.Transparent;
            this.DOBtxt.Cursor = System.Windows.Forms.Cursors.No;
            this.DOBtxt.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBtxt.ForeColor = System.Drawing.Color.Aquamarine;
            this.DOBtxt.Location = new System.Drawing.Point(487, 272);
            this.DOBtxt.Name = "DOBtxt";
            this.DOBtxt.Size = new System.Drawing.Size(534, 41);
            this.DOBtxt.TabIndex = 12;
            this.DOBtxt.Text = " Trainer Date Of Birth(ages +18)*";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgm1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(314, 668);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 379);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert";
            // 
            // dgm1
            // 
            this.dgm1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dgm1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgm1.GridColor = System.Drawing.Color.Black;
            this.dgm1.Location = new System.Drawing.Point(25, 46);
            this.dgm1.Name = "dgm1";
            this.dgm1.RowHeadersWidth = 62;
            this.dgm1.RowTemplate.Height = 28;
            this.dgm1.Size = new System.Drawing.Size(1032, 327);
            this.dgm1.TabIndex = 0;
            this.dgm1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgm1_CellContentClick);
            // 
            // Tidtxt
            // 
            this.Tidtxt.AutoSize = true;
            this.Tidtxt.BackColor = System.Drawing.Color.Transparent;
            this.Tidtxt.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tidtxt.ForeColor = System.Drawing.Color.Red;
            this.Tidtxt.Location = new System.Drawing.Point(306, 94);
            this.Tidtxt.Name = "Tidtxt";
            this.Tidtxt.Size = new System.Drawing.Size(0, 45);
            this.Tidtxt.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(1688, 636);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 68);
            this.button2.TabIndex = 27;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(1688, 825);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 68);
            this.button3.TabIndex = 29;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // AdminInsertafterview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Tidtxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Tclasstxt);
            this.Controls.Add(this.TPhonetxt);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.TDOBtxts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tdurationtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TExperiencetxt);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Twghtxt);
            this.Controls.Add(this.Thghtxt);
            this.Controls.Add(this.Taddtxt);
            this.Controls.Add(this.Tmailetxt);
            this.Controls.Add(this.Tnametxt);
            this.Controls.Add(this.mconditiontxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Genderr);
            this.Controls.Add(this.Joiningtxt);
            this.Controls.Add(this.Addresstxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.DOBtxt);
            this.Controls.Add(this.MemberNametxt);
            this.Controls.Add(this.MemberIDtxt);
            this.Controls.Add(this.label1);
            this.Name = "AdminInsertafterview";
            this.Text = "AdminInsertafterview";
            this.Load += new System.EventHandler(this.AdminInsertafterview_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgm1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TPhonetxt;
        private System.Windows.Forms.Label Passwordtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Tdurationtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.TextBox Taddtxt;
        private System.Windows.Forms.TextBox Tmailetxt;
        private System.Windows.Forms.TextBox Tnametxt;
        private System.Windows.Forms.Label Genderr;
        private System.Windows.Forms.Label Addresstxt;
        private System.Windows.Forms.Label Emailtxt;
        private System.Windows.Forms.Label MemberNametxt;
        private System.Windows.Forms.Label MemberIDtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TExperiencetxt;
        private System.Windows.Forms.Label mconditiontxt;
        private System.Windows.Forms.Label Joiningtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Tclasstxt;
        private System.Windows.Forms.ComboBox Twghtxt;
        private System.Windows.Forms.ComboBox Thghtxt;
        private System.Windows.Forms.DateTimePicker TDOBtxts;
        private System.Windows.Forms.Label DOBtxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgm1;
        private System.Windows.Forms.Label Tidtxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}