namespace BUCAssignment
{
    partial class AdminInsertafterview1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInsertafterview1));
            this.SPhonetxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SMale = new System.Windows.Forms.RadioButton();
            this.SFemale = new System.Windows.Forms.RadioButton();
            this.Saddtxt = new System.Windows.Forms.TextBox();
            this.Smailetxt = new System.Windows.Forms.TextBox();
            this.Snametxt = new System.Windows.Forms.TextBox();
            this.Genderr = new System.Windows.Forms.Label();
            this.Addresstxt = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.Label();
            this.MemberNametxt = new System.Windows.Forms.Label();
            this.MemberIDtxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SAgee = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dfg1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Sdurationtxt = new System.Windows.Forms.ComboBox();
            this.Sidtxt = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dfg1)).BeginInit();
            this.SuspendLayout();
            // 
            // SPhonetxt
            // 
            this.SPhonetxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPhonetxt.Location = new System.Drawing.Point(264, 311);
            this.SPhonetxt.Multiline = true;
            this.SPhonetxt.Name = "SPhonetxt";
            this.SPhonetxt.Size = new System.Drawing.Size(219, 49);
            this.SPhonetxt.TabIndex = 7;
            this.SPhonetxt.TextChanged += new System.EventHandler(this.SPhonetxt_TextChanged);
            this.SPhonetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SPhonetxt_KeyDown);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.AutoSize = true;
            this.Passwordtxt.BackColor = System.Drawing.Color.Transparent;
            this.Passwordtxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.ForeColor = System.Drawing.Color.White;
            this.Passwordtxt.Location = new System.Drawing.Point(12, 315);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(217, 45);
            this.Passwordtxt.TabIndex = 2;
            this.Passwordtxt.Text = "Staff Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 526);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 45);
            this.label8.TabIndex = 4;
            this.label8.Text = "Staff Duration";
            // 
            // SMale
            // 
            this.SMale.AutoSize = true;
            this.SMale.BackColor = System.Drawing.Color.Transparent;
            this.SMale.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMale.ForeColor = System.Drawing.Color.White;
            this.SMale.Location = new System.Drawing.Point(767, 229);
            this.SMale.Name = "SMale";
            this.SMale.Size = new System.Drawing.Size(110, 40);
            this.SMale.TabIndex = 14;
            this.SMale.TabStop = true;
            this.SMale.Text = "Male";
            this.SMale.UseVisualStyleBackColor = false;
            this.SMale.CheckedChanged += new System.EventHandler(this.SMale_CheckedChanged);
            this.SMale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SMale_KeyDown);
            // 
            // SFemale
            // 
            this.SFemale.AutoSize = true;
            this.SFemale.BackColor = System.Drawing.Color.Transparent;
            this.SFemale.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFemale.ForeColor = System.Drawing.Color.White;
            this.SFemale.Location = new System.Drawing.Point(900, 228);
            this.SFemale.Name = "SFemale";
            this.SFemale.Size = new System.Drawing.Size(140, 40);
            this.SFemale.TabIndex = 15;
            this.SFemale.TabStop = true;
            this.SFemale.Text = "Female";
            this.SFemale.UseVisualStyleBackColor = false;
            this.SFemale.CheckedChanged += new System.EventHandler(this.SFemale_CheckedChanged);
            // 
            // Saddtxt
            // 
            this.Saddtxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saddtxt.Location = new System.Drawing.Point(780, 126);
            this.Saddtxt.Multiline = true;
            this.Saddtxt.Name = "Saddtxt";
            this.Saddtxt.Size = new System.Drawing.Size(219, 49);
            this.Saddtxt.TabIndex = 13;
            this.Saddtxt.TextChanged += new System.EventHandler(this.Saddtxt_TextChanged);
            this.Saddtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Saddtxt_KeyDown);
            // 
            // Smailetxt
            // 
            this.Smailetxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Smailetxt.Location = new System.Drawing.Point(264, 415);
            this.Smailetxt.Multiline = true;
            this.Smailetxt.Name = "Smailetxt";
            this.Smailetxt.Size = new System.Drawing.Size(350, 49);
            this.Smailetxt.TabIndex = 8;
            this.Smailetxt.TextChanged += new System.EventHandler(this.Smailetxt_TextChanged);
            this.Smailetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Smailetxt_KeyDown);
            this.Smailetxt.Leave += new System.EventHandler(this.Smailetxt_Leave);
            // 
            // Snametxt
            // 
            this.Snametxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.Snametxt.Location = new System.Drawing.Point(264, 215);
            this.Snametxt.Multiline = true;
            this.Snametxt.Name = "Snametxt";
            this.Snametxt.Size = new System.Drawing.Size(219, 49);
            this.Snametxt.TabIndex = 6;
            this.Snametxt.TextChanged += new System.EventHandler(this.Snametxt_TextChanged);
            this.Snametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snametxt_KeyDown);
            this.Snametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Snametxt_KeyPress);
            this.Snametxt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Snametxt_PreviewKeyDown);
            // 
            // Genderr
            // 
            this.Genderr.AutoSize = true;
            this.Genderr.BackColor = System.Drawing.Color.Transparent;
            this.Genderr.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderr.ForeColor = System.Drawing.Color.White;
            this.Genderr.Location = new System.Drawing.Point(501, 215);
            this.Genderr.Name = "Genderr";
            this.Genderr.Size = new System.Drawing.Size(241, 45);
            this.Genderr.TabIndex = 11;
            this.Genderr.Text = "Staff Gender";
            // 
            // Addresstxt
            // 
            this.Addresstxt.AutoSize = true;
            this.Addresstxt.BackColor = System.Drawing.Color.Transparent;
            this.Addresstxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresstxt.ForeColor = System.Drawing.Color.White;
            this.Addresstxt.Location = new System.Drawing.Point(491, 126);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(251, 45);
            this.Addresstxt.TabIndex = 10;
            this.Addresstxt.Text = "Staff Address";
            // 
            // Emailtxt
            // 
            this.Emailtxt.AutoSize = true;
            this.Emailtxt.BackColor = System.Drawing.Color.Transparent;
            this.Emailtxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailtxt.ForeColor = System.Drawing.Color.White;
            this.Emailtxt.Location = new System.Drawing.Point(10, 419);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(216, 45);
            this.Emailtxt.TabIndex = 3;
            this.Emailtxt.Text = "Staff Email";
            // 
            // MemberNametxt
            // 
            this.MemberNametxt.AutoSize = true;
            this.MemberNametxt.BackColor = System.Drawing.Color.Transparent;
            this.MemberNametxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNametxt.ForeColor = System.Drawing.Color.White;
            this.MemberNametxt.Location = new System.Drawing.Point(12, 209);
            this.MemberNametxt.Name = "MemberNametxt";
            this.MemberNametxt.Size = new System.Drawing.Size(214, 45);
            this.MemberNametxt.TabIndex = 1;
            this.MemberNametxt.Text = "Staff Name";
            // 
            // MemberIDtxt
            // 
            this.MemberIDtxt.AutoSize = true;
            this.MemberIDtxt.BackColor = System.Drawing.Color.Transparent;
            this.MemberIDtxt.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDtxt.ForeColor = System.Drawing.Color.White;
            this.MemberIDtxt.Location = new System.Drawing.Point(12, 105);
            this.MemberIDtxt.Name = "MemberIDtxt";
            this.MemberIDtxt.Size = new System.Drawing.Size(158, 45);
            this.MemberIDtxt.TabIndex = 0;
            this.MemberIDtxt.Text = "Staff ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(523, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "Staff Age";
            // 
            // SAgee
            // 
            this.SAgee.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAgee.Location = new System.Drawing.Point(780, 315);
            this.SAgee.Multiline = true;
            this.SAgee.Name = "SAgee";
            this.SAgee.Size = new System.Drawing.Size(219, 49);
            this.SAgee.TabIndex = 16;
            this.SAgee.TextChanged += new System.EventHandler(this.SAgee_TextChanged);
            this.SAgee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SAgee_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.dfg1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(67, 658);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1100, 307);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert";
            // 
            // dfg1
            // 
            this.dfg1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dfg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dfg1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dfg1.Location = new System.Drawing.Point(20, 52);
            this.dfg1.Name = "dfg1";
            this.dfg1.RowHeadersWidth = 62;
            this.dfg1.RowTemplate.Height = 28;
            this.dfg1.Size = new System.Drawing.Size(1047, 202);
            this.dfg1.TabIndex = 0;
            this.dfg1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dfg1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(640, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 68);
            this.button1.TabIndex = 18;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sdurationtxt
            // 
            this.Sdurationtxt.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sdurationtxt.FormattingEnabled = true;
            this.Sdurationtxt.Items.AddRange(new object[] {
            "9:00Am to 11:00Am",
            "11:00Am to 1:00Pm",
            "1:00Pm to 3:00Pm",
            "3:00Pm to 5:00Pm",
            "5:00Pm to 7:00Pm",
            "7:00Pm to 9:00Pm",
            "",
            ""});
            this.Sdurationtxt.Location = new System.Drawing.Point(281, 543);
            this.Sdurationtxt.Name = "Sdurationtxt";
            this.Sdurationtxt.Size = new System.Drawing.Size(237, 44);
            this.Sdurationtxt.TabIndex = 9;
            this.Sdurationtxt.SelectedIndexChanged += new System.EventHandler(this.Sdurationtxt_SelectedIndexChanged);
            this.Sdurationtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sdurationtxt_KeyDown);
            // 
            // Sidtxt
            // 
            this.Sidtxt.AutoSize = true;
            this.Sidtxt.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sidtxt.ForeColor = System.Drawing.Color.Red;
            this.Sidtxt.Location = new System.Drawing.Point(244, 122);
            this.Sidtxt.Name = "Sidtxt";
            this.Sidtxt.Size = new System.Drawing.Size(0, 41);
            this.Sidtxt.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(873, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 68);
            this.button2.TabIndex = 19;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(482, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 53);
            this.label2.TabIndex = 20;
            this.label2.Text = "Get Started";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(744, 562);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 68);
            this.button3.TabIndex = 21;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminInsertafterview1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1547, 783);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Sidtxt);
            this.Controls.Add(this.Sdurationtxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SAgee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SPhonetxt);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SMale);
            this.Controls.Add(this.SFemale);
            this.Controls.Add(this.Saddtxt);
            this.Controls.Add(this.Smailetxt);
            this.Controls.Add(this.Snametxt);
            this.Controls.Add(this.Genderr);
            this.Controls.Add(this.Addresstxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.MemberNametxt);
            this.Controls.Add(this.MemberIDtxt);
            this.Name = "AdminInsertafterview1";
            this.Text = "AdminInsertafterview1";
            this.Load += new System.EventHandler(this.AdminInsertafterview1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dfg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SPhonetxt;
        private System.Windows.Forms.Label Passwordtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton SMale;
        private System.Windows.Forms.RadioButton SFemale;
        private System.Windows.Forms.TextBox Saddtxt;
        private System.Windows.Forms.TextBox Smailetxt;
        private System.Windows.Forms.TextBox Snametxt;
        private System.Windows.Forms.Label Genderr;
        private System.Windows.Forms.Label Addresstxt;
        private System.Windows.Forms.Label Emailtxt;
        private System.Windows.Forms.Label MemberNametxt;
        private System.Windows.Forms.Label MemberIDtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SAgee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dfg1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Sdurationtxt;
        private System.Windows.Forms.Label Sidtxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}