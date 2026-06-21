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
            label4 = new Label();
            Fullnametxt = new TextBox();
            Emailtxt = new TextBox();
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
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 998);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(23, 431);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(369, 54);
            label1.TabIndex = 0;
            label1.Text = "DOCTOR REGISTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(428, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "Full Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(428, 180);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 3;
            label4.Text = "Email: ";
            label4.Click += label4_Click;
            // 
            // Fullnametxt
            // 
            Fullnametxt.Location = new Point(428, 67);
            Fullnametxt.Margin = new Padding(4);
            Fullnametxt.Name = "Fullnametxt";
            Fullnametxt.Size = new Size(504, 31);
            Fullnametxt.TabIndex = 4;
            // 
            // Emailtxt
            // 
            Emailtxt.Location = new Point(426, 222);
            Emailtxt.Margin = new Padding(4);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.Size = new Size(504, 31);
            Emailtxt.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(426, 514);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 25);
            label7.TabIndex = 12;
            label7.Text = "Password: ";
            // 
            // Passwordtxt
            // 
            Passwordtxt.Location = new Point(426, 562);
            Passwordtxt.Margin = new Padding(4);
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.Size = new Size(504, 31);
            Passwordtxt.TabIndex = 13;
            Passwordtxt.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(428, 686);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(171, 25);
            label8.TabIndex = 14;
            label8.Text = "Confirm Password: ";
            // 
            // Confirmtxt
            // 
            Confirmtxt.Location = new Point(426, 738);
            Confirmtxt.Margin = new Padding(4);
            Confirmtxt.Name = "Confirmtxt";
            Confirmtxt.Size = new Size(504, 31);
            Confirmtxt.TabIndex = 15;
            // 
            // Signinbtn
            // 
            Signinbtn.BackColor = Color.MidnightBlue;
            Signinbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signinbtn.ForeColor = SystemColors.ButtonHighlight;
            Signinbtn.Location = new Point(794, 896);
            Signinbtn.Margin = new Padding(4);
            Signinbtn.Name = "Signinbtn";
            Signinbtn.Size = new Size(138, 39);
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
            cancelbtn.Location = new Point(426, 896);
            cancelbtn.Margin = new Padding(4);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(138, 39);
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
            label9.Location = new Point(426, 335);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(144, 25);
            label9.TabIndex = 18;
            label9.Text = "Phone Number:";
            // 
            // Phonenumtxt
            // 
            Phonenumtxt.Location = new Point(428, 374);
            Phonenumtxt.Margin = new Padding(4);
            Phonenumtxt.Name = "Phonenumtxt";
            Phonenumtxt.Size = new Size(504, 31);
            Phonenumtxt.TabIndex = 19;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 968);
            Controls.Add(Phonenumtxt);
            Controls.Add(label9);
            Controls.Add(cancelbtn);
            Controls.Add(Signinbtn);
            Controls.Add(Confirmtxt);
            Controls.Add(label8);
            Controls.Add(Passwordtxt);
            Controls.Add(label7);
            Controls.Add(Emailtxt);
            Controls.Add(Fullnametxt);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(4);
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
        private Label label4;
        private TextBox Fullnametxt;
        private TextBox Emailtxt;
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