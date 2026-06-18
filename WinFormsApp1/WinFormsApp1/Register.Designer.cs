namespace WinFormsApp1
{
    partial class Register
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Fullnametxt = new TextBox();
            ICnumbertxt = new TextBox();
            Emailtxt = new TextBox();
            label5 = new Label();
            DOBdatetime = new DateTimePicker();
            Malerdio = new RadioButton();
            Femalerdio = new RadioButton();
            label6 = new Label();
            label7 = new Label();
            Passwordtxt = new TextBox();
            label8 = new Label();
            Confirmtxt = new TextBox();
            Signinbtn = new Button();
            cancelbtn = new Button();
            label9 = new Label();
            Phonenumtxt = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 798);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(55, 343);
            label1.Name = "label1";
            label1.Size = new Size(170, 46);
            label1.TabIndex = 0;
            label1.Text = "REGISTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(341, 28);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Full Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(341, 103);
            label3.Name = "label3";
            label3.Size = new Size(190, 20);
            label3.TabIndex = 2;
            label3.Text = "IC  Number(12345671892): ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(341, 189);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Email: ";
            // 
            // Fullnametxt
            // 
            Fullnametxt.Location = new Point(341, 51);
            Fullnametxt.Name = "Fullnametxt";
            Fullnametxt.Size = new Size(404, 27);
            Fullnametxt.TabIndex = 4;
            // 
            // ICnumbertxt
            // 
            ICnumbertxt.Location = new Point(341, 140);
            ICnumbertxt.Name = "ICnumbertxt";
            ICnumbertxt.Size = new Size(404, 27);
            ICnumbertxt.TabIndex = 5;
            // 
            // Emailtxt
            // 
            Emailtxt.Location = new Point(341, 220);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.Size = new Size(404, 27);
            Emailtxt.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(341, 274);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 7;
            label5.Text = "Date Of Birth: ";
            // 
            // DOBdatetime
            // 
            DOBdatetime.Location = new Point(341, 307);
            DOBdatetime.Name = "DOBdatetime";
            DOBdatetime.Size = new Size(293, 27);
            DOBdatetime.TabIndex = 8;
            DOBdatetime.ValueChanged += DOBdatetime_ValueChanged;
            // 
            // Malerdio
            // 
            Malerdio.AutoSize = true;
            Malerdio.Location = new Point(350, 483);
            Malerdio.Name = "Malerdio";
            Malerdio.Size = new Size(63, 24);
            Malerdio.TabIndex = 9;
            Malerdio.TabStop = true;
            Malerdio.Text = "Male";
            Malerdio.UseVisualStyleBackColor = true;
            // 
            // Femalerdio
            // 
            Femalerdio.AutoSize = true;
            Femalerdio.Location = new Point(441, 483);
            Femalerdio.Name = "Femalerdio";
            Femalerdio.Size = new Size(78, 24);
            Femalerdio.TabIndex = 10;
            Femalerdio.TabStop = true;
            Femalerdio.Text = "Female";
            Femalerdio.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(345, 444);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 11;
            label6.Text = "Gender: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(341, 528);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 12;
            label7.Text = "Password: ";
            // 
            // Passwordtxt
            // 
            Passwordtxt.Location = new Point(341, 575);
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.Size = new Size(404, 27);
            Passwordtxt.TabIndex = 13;
            Passwordtxt.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(341, 618);
            label8.Name = "label8";
            label8.Size = new Size(140, 20);
            label8.TabIndex = 14;
            label8.Text = "Confirm Password: ";
            // 
            // Confirmtxt
            // 
            Confirmtxt.Location = new Point(341, 667);
            Confirmtxt.Name = "Confirmtxt";
            Confirmtxt.Size = new Size(404, 27);
            Confirmtxt.TabIndex = 15;
            // 
            // Signinbtn
            // 
            Signinbtn.BackColor = Color.MidnightBlue;
            Signinbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signinbtn.ForeColor = SystemColors.ButtonHighlight;
            Signinbtn.Location = new Point(635, 717);
            Signinbtn.Name = "Signinbtn";
            Signinbtn.Size = new Size(110, 31);
            Signinbtn.TabIndex = 16;
            Signinbtn.Text = "SIGN IN";
            Signinbtn.UseVisualStyleBackColor = false;
            Signinbtn.Click += button1_Click;
            // 
            // cancelbtn
            // 
            cancelbtn.BackColor = Color.MidnightBlue;
            cancelbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelbtn.ForeColor = SystemColors.ButtonHighlight;
            cancelbtn.Location = new Point(341, 717);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(110, 31);
            cancelbtn.TabIndex = 17;
            cancelbtn.Text = "CANCEL";
            cancelbtn.UseVisualStyleBackColor = false;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(341, 364);
            label9.Name = "label9";
            label9.Size = new Size(119, 20);
            label9.TabIndex = 18;
            label9.Text = "Phone Number:";
            // 
            // Phonenumtxt
            // 
            Phonenumtxt.Location = new Point(341, 400);
            Phonenumtxt.Name = "Phonenumtxt";
            Phonenumtxt.Size = new Size(404, 27);
            Phonenumtxt.TabIndex = 19;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 774);
            Controls.Add(Phonenumtxt);
            Controls.Add(label9);
            Controls.Add(cancelbtn);
            Controls.Add(Signinbtn);
            Controls.Add(Confirmtxt);
            Controls.Add(label8);
            Controls.Add(Passwordtxt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Femalerdio);
            Controls.Add(Malerdio);
            Controls.Add(DOBdatetime);
            Controls.Add(label5);
            Controls.Add(Emailtxt);
            Controls.Add(ICnumbertxt);
            Controls.Add(Fullnametxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Fullnametxt;
        private TextBox ICnumbertxt;
        private TextBox Emailtxt;
        private Label label5;
        private DateTimePicker DOBdatetime;
        private RadioButton Malerdio;
        private RadioButton Femalerdio;
        private Label label6;
        private Label label7;
        private TextBox Passwordtxt;
        private Label label8;
        private TextBox Confirmtxt;
        private Button Signinbtn;
        private Button cancelbtn;
        private Label label9;
        private TextBox Phonenumtxt;
    }
}