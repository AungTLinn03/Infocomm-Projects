namespace BUCAssignment
{
    partial class AdminUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUpdate));
            this.UDOBtxts = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.UCoststxt = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Udurationtxt = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UConditiontxt = new System.Windows.Forms.ComboBox();
            this.Uwghtxt = new System.Windows.Forms.ComboBox();
            this.Uhghtxt = new System.Windows.Forms.ComboBox();
            this.Uaddtxt = new System.Windows.Forms.TextBox();
            this.Umailetxt = new System.Windows.Forms.TextBox();
            this.UCnumbertxt = new System.Windows.Forms.TextBox();
            this.UPguardtxt = new System.Windows.Forms.TextBox();
            this.UMnametxt = new System.Windows.Forms.TextBox();
            this.UMidtxt = new System.Windows.Forms.TextBox();
            this.mconditiontxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Addresstxt = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.Label();
            this.Contacttxt = new System.Windows.Forms.Label();
            this.Parenttxt = new System.Windows.Forms.Label();
            this.DOBtxt = new System.Windows.Forms.Label();
            this.MemberNametxt = new System.Windows.Forms.Label();
            this.MemberIDtxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgl1 = new System.Windows.Forms.DataGridView();
            this.Genderr = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgl1)).BeginInit();
            this.SuspendLayout();
            // 
            // UDOBtxts
            // 
            this.UDOBtxts.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDOBtxts.Location = new System.Drawing.Point(1343, 268);
            this.UDOBtxts.Name = "UDOBtxts";
            this.UDOBtxts.Size = new System.Drawing.Size(472, 49);
            this.UDOBtxts.TabIndex = 19;
            this.UDOBtxts.ValueChanged += new System.EventHandler(this.UDOBtxts_ValueChanged);
            this.UDOBtxts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UDOBtxts_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(1595, 764);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 68);
            this.button1.TabIndex = 36;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UCoststxt
            // 
            this.UCoststxt.BackColor = System.Drawing.Color.Black;
            this.UCoststxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCoststxt.ForeColor = System.Drawing.Color.White;
            this.UCoststxt.FormattingEnabled = true;
            this.UCoststxt.Items.AddRange(new object[] {
            "$60/month*10% discount",
            "$300/semiyearly*9% discount",
            "$999/year*5% discount",
            ""});
            this.UCoststxt.Location = new System.Drawing.Point(1208, 686);
            this.UCoststxt.Name = "UCoststxt";
            this.UCoststxt.Size = new System.Drawing.Size(464, 49);
            this.UCoststxt.TabIndex = 27;
            this.UCoststxt.SelectedIndexChanged += new System.EventHandler(this.UCoststxt_SelectedIndexChanged);
            this.UCoststxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UCoststxt_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1063, 690);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 45);
            this.label9.TabIndex = 28;
            this.label9.Text = "Costs";
            // 
            // Udurationtxt
            // 
            this.Udurationtxt.BackColor = System.Drawing.Color.Black;
            this.Udurationtxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Udurationtxt.ForeColor = System.Drawing.Color.White;
            this.Udurationtxt.FormattingEnabled = true;
            this.Udurationtxt.Items.AddRange(new object[] {
            "9:00Am-12:00Pm(Morning Workout)",
            "12:00Pm-1:00Pm(Lunch Break)",
            "1:00Pm-5:00Pm(Evening Workout)",
            "5:00Pm-8:00Pm(Music/Zumba Dance/Play interesting Games)",
            "8:30Pm(Close)..,No Weekend holiday."});
            this.Udurationtxt.Location = new System.Drawing.Point(245, 606);
            this.Udurationtxt.Name = "Udurationtxt";
            this.Udurationtxt.Size = new System.Drawing.Size(307, 49);
            this.Udurationtxt.TabIndex = 12;
            this.Udurationtxt.SelectedIndexChanged += new System.EventHandler(this.Udurationtxt_SelectedIndexChanged);
            this.Udurationtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Udurationtxt_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(51, 606);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 45);
            this.label8.TabIndex = 6;
            this.label8.Text = "Duration ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1380, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(438, 45);
            this.label7.TabIndex = 25;
            this.label7.Text = "Yes(Please enter Details)";
            // 
            // UConditiontxt
            // 
            this.UConditiontxt.BackColor = System.Drawing.Color.Black;
            this.UConditiontxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UConditiontxt.ForeColor = System.Drawing.Color.White;
            this.UConditiontxt.FormattingEnabled = true;
            this.UConditiontxt.Items.AddRange(new object[] {
            "Myocardial infarction",
            "Cancer(Leukemia)",
            "Disable",
            "others"});
            this.UConditiontxt.Location = new System.Drawing.Point(1388, 602);
            this.UConditiontxt.Name = "UConditiontxt";
            this.UConditiontxt.Size = new System.Drawing.Size(376, 49);
            this.UConditiontxt.TabIndex = 26;
            this.UConditiontxt.SelectedIndexChanged += new System.EventHandler(this.UConditiontxt_SelectedIndexChanged);
            this.UConditiontxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UConditiontxt_KeyDown);
            // 
            // Uwghtxt
            // 
            this.Uwghtxt.BackColor = System.Drawing.Color.Black;
            this.Uwghtxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uwghtxt.ForeColor = System.Drawing.Color.White;
            this.Uwghtxt.FormattingEnabled = true;
            this.Uwghtxt.Items.AddRange(new object[] {
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
            this.Uwghtxt.Location = new System.Drawing.Point(1614, 401);
            this.Uwghtxt.Name = "Uwghtxt";
            this.Uwghtxt.Size = new System.Drawing.Size(179, 49);
            this.Uwghtxt.TabIndex = 23;
            this.Uwghtxt.SelectedIndexChanged += new System.EventHandler(this.Uwghtxt_SelectedIndexChanged);
            this.Uwghtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Uwghtxt_KeyDown);
            // 
            // Uhghtxt
            // 
            this.Uhghtxt.BackColor = System.Drawing.Color.Black;
            this.Uhghtxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.Uhghtxt.ForeColor = System.Drawing.Color.White;
            this.Uhghtxt.FormattingEnabled = true;
            this.Uhghtxt.Items.AddRange(new object[] {
            "4\"3\' or 129.54 cm",
            "4\"4\' or 132.08 cm",
            "4\"5\' or 134.62 cm",
            "4\"6\' or 137.16 cm",
            "4\"7\' or 139.70 cm",
            "4\"8\' or 142.24 cm",
            "4\"9\' or 144.78 cm",
            "4\"10\' or 147.32 cm",
            "4\"11\' or 149.86 cm",
            "5\"0\' or 152.40 cm",
            "5\"1\' or 154.94 cm",
            "5\"2\' or 157.48 cm",
            "5\"3\' or 160.02 cm",
            "5\"4\' or 162.56 cm",
            "5\"5\' or 165.10 cm",
            "5\"6\' or 167.64 cm",
            "5\"7\' or 170.18 cm",
            "5\"8\' or 172.72 cm",
            "5\"9\' or 175.26 cm",
            "5\"10\' or 177.80 cm",
            "5\"11\' or 180.34 cm",
            "6\"0\' or 182.88 cm",
            "6\"1\' or 185.42 cm",
            "6\"2\' or 187.96 cm",
            "6\"3\' or 190.50 cm ",
            "6\"4\' or 193.04 cm ",
            "6\"5\' or 195.58 cm ",
            "6\"6\' or 198.12 cm ",
            "6\"7\' or 200.66 cm ",
            "other...."});
            this.Uhghtxt.Location = new System.Drawing.Point(1363, 401);
            this.Uhghtxt.Name = "Uhghtxt";
            this.Uhghtxt.Size = new System.Drawing.Size(169, 49);
            this.Uhghtxt.TabIndex = 22;
            this.Uhghtxt.SelectedIndexChanged += new System.EventHandler(this.Uhghtxt_SelectedIndexChanged);
            this.Uhghtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Uhghtxt_KeyDown);
            // 
            // Uaddtxt
            // 
            this.Uaddtxt.BackColor = System.Drawing.Color.Black;
            this.Uaddtxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uaddtxt.ForeColor = System.Drawing.Color.White;
            this.Uaddtxt.Location = new System.Drawing.Point(1406, 171);
            this.Uaddtxt.Multiline = true;
            this.Uaddtxt.Name = "Uaddtxt";
            this.Uaddtxt.Size = new System.Drawing.Size(434, 49);
            this.Uaddtxt.TabIndex = 17;
            this.Uaddtxt.TextChanged += new System.EventHandler(this.Uaddtxt_TextChanged);
            this.Uaddtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Uaddtxt_KeyDown);
            // 
            // Umailetxt
            // 
            this.Umailetxt.BackColor = System.Drawing.Color.Black;
            this.Umailetxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Umailetxt.ForeColor = System.Drawing.Color.White;
            this.Umailetxt.Location = new System.Drawing.Point(232, 515);
            this.Umailetxt.Multiline = true;
            this.Umailetxt.Name = "Umailetxt";
            this.Umailetxt.Size = new System.Drawing.Size(231, 45);
            this.Umailetxt.TabIndex = 11;
            this.Umailetxt.TextChanged += new System.EventHandler(this.Umailetxt_TextChanged);
            this.Umailetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Umailetxt_KeyDown);
            // 
            // UCnumbertxt
            // 
            this.UCnumbertxt.BackColor = System.Drawing.Color.Black;
            this.UCnumbertxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCnumbertxt.ForeColor = System.Drawing.Color.White;
            this.UCnumbertxt.Location = new System.Drawing.Point(346, 414);
            this.UCnumbertxt.Multiline = true;
            this.UCnumbertxt.Name = "UCnumbertxt";
            this.UCnumbertxt.Size = new System.Drawing.Size(219, 49);
            this.UCnumbertxt.TabIndex = 10;
            this.UCnumbertxt.TextChanged += new System.EventHandler(this.UCnumbertxt_TextChanged);
            this.UCnumbertxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UCnumbertxt_KeyDown);
            // 
            // UPguardtxt
            // 
            this.UPguardtxt.BackColor = System.Drawing.Color.Black;
            this.UPguardtxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPguardtxt.ForeColor = System.Drawing.Color.White;
            this.UPguardtxt.Location = new System.Drawing.Point(333, 307);
            this.UPguardtxt.Multiline = true;
            this.UPguardtxt.Name = "UPguardtxt";
            this.UPguardtxt.Size = new System.Drawing.Size(219, 49);
            this.UPguardtxt.TabIndex = 9;
            this.UPguardtxt.TextChanged += new System.EventHandler(this.UPguardtxt_TextChanged);
            this.UPguardtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UPguardtxt_KeyDown);
            this.UPguardtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UPguardtxt_KeyPress);
            // 
            // UMnametxt
            // 
            this.UMnametxt.BackColor = System.Drawing.Color.Black;
            this.UMnametxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.UMnametxt.ForeColor = System.Drawing.Color.White;
            this.UMnametxt.Location = new System.Drawing.Point(303, 206);
            this.UMnametxt.Multiline = true;
            this.UMnametxt.Name = "UMnametxt";
            this.UMnametxt.Size = new System.Drawing.Size(219, 49);
            this.UMnametxt.TabIndex = 8;
            this.UMnametxt.TextChanged += new System.EventHandler(this.UMnametxt_TextChanged);
            this.UMnametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UMnametxt_KeyDown);
            this.UMnametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UMnametxt_KeyPress);
            // 
            // UMidtxt
            // 
            this.UMidtxt.BackColor = System.Drawing.Color.Black;
            this.UMidtxt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UMidtxt.ForeColor = System.Drawing.Color.White;
            this.UMidtxt.Location = new System.Drawing.Point(312, 106);
            this.UMidtxt.Multiline = true;
            this.UMidtxt.Name = "UMidtxt";
            this.UMidtxt.Size = new System.Drawing.Size(219, 49);
            this.UMidtxt.TabIndex = 7;
            this.UMidtxt.TextChanged += new System.EventHandler(this.UMidtxt_TextChanged);
            this.UMidtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UMidtxt_KeyDown);
            // 
            // mconditiontxt
            // 
            this.mconditiontxt.AutoSize = true;
            this.mconditiontxt.BackColor = System.Drawing.Color.Transparent;
            this.mconditiontxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mconditiontxt.ForeColor = System.Drawing.Color.White;
            this.mconditiontxt.Location = new System.Drawing.Point(958, 459);
            this.mconditiontxt.Name = "mconditiontxt";
            this.mconditiontxt.Size = new System.Drawing.Size(1205, 45);
            this.mconditiontxt.TabIndex = 24;
            this.mconditiontxt.Text = "Do you have any medical conditions that could affect you to join Gym?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1637, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 45);
            this.label5.TabIndex = 21;
            this.label5.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1380, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 45);
            this.label4.TabIndex = 20;
            this.label4.Text = "Height";
            // 
            // Addresstxt
            // 
            this.Addresstxt.AutoSize = true;
            this.Addresstxt.BackColor = System.Drawing.Color.Transparent;
            this.Addresstxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresstxt.ForeColor = System.Drawing.Color.White;
            this.Addresstxt.Location = new System.Drawing.Point(1228, 175);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(160, 45);
            this.Addresstxt.TabIndex = 16;
            this.Addresstxt.Text = "Address";
            // 
            // Emailtxt
            // 
            this.Emailtxt.AutoSize = true;
            this.Emailtxt.BackColor = System.Drawing.Color.Transparent;
            this.Emailtxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailtxt.ForeColor = System.Drawing.Color.White;
            this.Emailtxt.Location = new System.Drawing.Point(51, 515);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(123, 45);
            this.Emailtxt.TabIndex = 5;
            this.Emailtxt.Text = "Email";
            // 
            // Contacttxt
            // 
            this.Contacttxt.AutoSize = true;
            this.Contacttxt.BackColor = System.Drawing.Color.Transparent;
            this.Contacttxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contacttxt.ForeColor = System.Drawing.Color.White;
            this.Contacttxt.Location = new System.Drawing.Point(19, 414);
            this.Contacttxt.Name = "Contacttxt";
            this.Contacttxt.Size = new System.Drawing.Size(305, 45);
            this.Contacttxt.TabIndex = 4;
            this.Contacttxt.Text = "Contact Number";
            // 
            // Parenttxt
            // 
            this.Parenttxt.AutoSize = true;
            this.Parenttxt.BackColor = System.Drawing.Color.Transparent;
            this.Parenttxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parenttxt.ForeColor = System.Drawing.Color.White;
            this.Parenttxt.Location = new System.Drawing.Point(19, 307);
            this.Parenttxt.Name = "Parenttxt";
            this.Parenttxt.Size = new System.Drawing.Size(308, 45);
            this.Parenttxt.TabIndex = 3;
            this.Parenttxt.Text = "Parent Guardian";
            // 
            // DOBtxt
            // 
            this.DOBtxt.AutoSize = true;
            this.DOBtxt.BackColor = System.Drawing.Color.Transparent;
            this.DOBtxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBtxt.ForeColor = System.Drawing.Color.White;
            this.DOBtxt.Location = new System.Drawing.Point(877, 271);
            this.DOBtxt.Name = "DOBtxt";
            this.DOBtxt.Size = new System.Drawing.Size(448, 45);
            this.DOBtxt.TabIndex = 18;
            this.DOBtxt.Text = "Date Of Birth(ages +10)*";
            // 
            // MemberNametxt
            // 
            this.MemberNametxt.AutoSize = true;
            this.MemberNametxt.BackColor = System.Drawing.Color.Transparent;
            this.MemberNametxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNametxt.ForeColor = System.Drawing.Color.White;
            this.MemberNametxt.Location = new System.Drawing.Point(19, 206);
            this.MemberNametxt.Name = "MemberNametxt";
            this.MemberNametxt.Size = new System.Drawing.Size(278, 45);
            this.MemberNametxt.TabIndex = 2;
            this.MemberNametxt.Text = "Member Name";
            // 
            // MemberIDtxt
            // 
            this.MemberIDtxt.AutoSize = true;
            this.MemberIDtxt.BackColor = System.Drawing.Color.Transparent;
            this.MemberIDtxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDtxt.ForeColor = System.Drawing.Color.White;
            this.MemberIDtxt.Location = new System.Drawing.Point(27, 101);
            this.MemberIDtxt.Name = "MemberIDtxt";
            this.MemberIDtxt.Size = new System.Drawing.Size(222, 45);
            this.MemberIDtxt.TabIndex = 1;
            this.MemberIDtxt.Text = "Member ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(51, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MistyRose;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Magenta;
            this.button5.Location = new System.Drawing.Point(1291, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 67);
            this.button5.TabIndex = 34;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MistyRose;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Magenta;
            this.button4.Location = new System.Drawing.Point(1098, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 67);
            this.button4.TabIndex = 33;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MistyRose;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Magenta;
            this.button6.Location = new System.Drawing.Point(885, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 67);
            this.button6.TabIndex = 32;
            this.button6.Text = "Insert";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Magenta;
            this.button3.Location = new System.Drawing.Point(684, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 67);
            this.button3.TabIndex = 31;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Magenta;
            this.button2.Location = new System.Drawing.Point(491, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 67);
            this.button2.TabIndex = 30;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MistyRose;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Magenta;
            this.button7.Location = new System.Drawing.Point(303, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 67);
            this.button7.TabIndex = 29;
            this.button7.Text = "Search";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.dgl1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(268, 792);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 273);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update display";
            // 
            // dgl1
            // 
            this.dgl1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dgl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgl1.GridColor = System.Drawing.Color.Red;
            this.dgl1.Location = new System.Drawing.Point(20, 52);
            this.dgl1.Name = "dgl1";
            this.dgl1.RowHeadersWidth = 62;
            this.dgl1.RowTemplate.Height = 28;
            this.dgl1.Size = new System.Drawing.Size(945, 215);
            this.dgl1.TabIndex = 0;
            this.dgl1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgl1_CellContentClick);
            // 
            // Genderr
            // 
            this.Genderr.AutoSize = true;
            this.Genderr.BackColor = System.Drawing.Color.Transparent;
            this.Genderr.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderr.ForeColor = System.Drawing.Color.White;
            this.Genderr.Location = new System.Drawing.Point(1268, 106);
            this.Genderr.Name = "Genderr";
            this.Genderr.Size = new System.Drawing.Size(148, 45);
            this.Genderr.TabIndex = 13;
            this.Genderr.Text = "Gender";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.BackColor = System.Drawing.Color.Transparent;
            this.Male.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male.Location = new System.Drawing.Point(1422, 106);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(110, 40);
            this.Male.TabIndex = 14;
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
            this.Female.Location = new System.Drawing.Point(1543, 106);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(140, 40);
            this.Female.TabIndex = 15;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = false;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.MidnightBlue;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Lime;
            this.button8.Location = new System.Drawing.Point(1334, 764);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(198, 68);
            this.button8.TabIndex = 35;
            this.button8.Text = "Reset";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.MidnightBlue;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Lime;
            this.button9.Location = new System.Drawing.Point(1485, 844);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(198, 68);
            this.button9.TabIndex = 38;
            this.button9.Text = "Back";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // AdminUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1827, 931);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Genderr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.UDOBtxts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UCoststxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Udurationtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UConditiontxt);
            this.Controls.Add(this.Uwghtxt);
            this.Controls.Add(this.Uhghtxt);
            this.Controls.Add(this.Uaddtxt);
            this.Controls.Add(this.Umailetxt);
            this.Controls.Add(this.UCnumbertxt);
            this.Controls.Add(this.UPguardtxt);
            this.Controls.Add(this.UMnametxt);
            this.Controls.Add(this.UMidtxt);
            this.Controls.Add(this.mconditiontxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Addresstxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Contacttxt);
            this.Controls.Add(this.Parenttxt);
            this.Controls.Add(this.DOBtxt);
            this.Controls.Add(this.MemberNametxt);
            this.Controls.Add(this.MemberIDtxt);
            this.Controls.Add(this.label1);
            this.Name = "AdminUpdate";
            this.Text = "AdminUpdate";
            this.Load += new System.EventHandler(this.AdminUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker UDOBtxts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox UCoststxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Udurationtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox UConditiontxt;
        private System.Windows.Forms.ComboBox Uwghtxt;
        private System.Windows.Forms.ComboBox Uhghtxt;
        private System.Windows.Forms.TextBox Uaddtxt;
        private System.Windows.Forms.TextBox Umailetxt;
        private System.Windows.Forms.TextBox UCnumbertxt;
        private System.Windows.Forms.TextBox UPguardtxt;
        private System.Windows.Forms.TextBox UMnametxt;
        private System.Windows.Forms.TextBox UMidtxt;
        private System.Windows.Forms.Label mconditiontxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Addresstxt;
        private System.Windows.Forms.Label Emailtxt;
        private System.Windows.Forms.Label Contacttxt;
        private System.Windows.Forms.Label Parenttxt;
        private System.Windows.Forms.Label DOBtxt;
        private System.Windows.Forms.Label MemberNametxt;
        private System.Windows.Forms.Label MemberIDtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgl1;
        private System.Windows.Forms.Label Genderr;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}