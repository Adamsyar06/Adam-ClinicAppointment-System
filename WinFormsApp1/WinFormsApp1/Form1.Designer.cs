namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Registerbtn = new Button();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            Loginbtn = new Button();
            passwordchckbx = new CheckBox();
            Passwordtxt = new TextBox();
            label5 = new Label();
            Validtxt = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(Registerbtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.Cyan;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 568);
            panel1.TabIndex = 0;
            // 
            // Registerbtn
            // 
            Registerbtn.BackColor = SystemColors.ButtonHighlight;
            Registerbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registerbtn.ForeColor = Color.MidnightBlue;
            Registerbtn.Location = new Point(103, 434);
            Registerbtn.Name = "Registerbtn";
            Registerbtn.Size = new Size(164, 29);
            Registerbtn.TabIndex = 3;
            Registerbtn.Text = "REGISTER";
            Registerbtn.UseVisualStyleBackColor = false;
            Registerbtn.Click += Registerbtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(52, 398);
            label6.Name = "label6";
            label6.Size = new Size(301, 20);
            label6.TabIndex = 2;
            label6.Text = "First time using our services? Register Now";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(82, 320);
            label3.Name = "label3";
            label3.Size = new Size(216, 50);
            label3.TabIndex = 1;
            label3.Text = "Your Health, Our Priority\r\n\r\n";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 270);
            label2.Name = "label2";
            label2.Size = new Size(428, 35);
            label2.TabIndex = 0;
            label2.Text = "Welcome To IAA Clinic Appointment";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(Loginbtn);
            panel2.Controls.Add(passwordchckbx);
            panel2.Controls.Add(Passwordtxt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(Validtxt);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(444, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 566);
            panel2.TabIndex = 1;
            // 
            // Loginbtn
            // 
            Loginbtn.BackColor = Color.MidnightBlue;
            Loginbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbtn.ForeColor = SystemColors.ButtonHighlight;
            Loginbtn.Location = new Point(15, 508);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(303, 40);
            Loginbtn.TabIndex = 9;
            Loginbtn.Text = "LOGIN";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // passwordchckbx
            // 
            passwordchckbx.AutoSize = true;
            passwordchckbx.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordchckbx.ForeColor = Color.MidnightBlue;
            passwordchckbx.Location = new Point(16, 286);
            passwordchckbx.Name = "passwordchckbx";
            passwordchckbx.Size = new Size(136, 24);
            passwordchckbx.TabIndex = 8;
            passwordchckbx.Text = "Show Password";
            passwordchckbx.UseVisualStyleBackColor = true;
            passwordchckbx.CheckedChanged += passwordchckbx_CheckedChanged;
            // 
            // Passwordtxt
            // 
            Passwordtxt.BorderStyle = BorderStyle.FixedSingle;
            Passwordtxt.Location = new Point(15, 253);
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.Size = new Size(303, 27);
            Passwordtxt.TabIndex = 7;
            Passwordtxt.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(16, 225);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 6;
            label5.Text = "Password: ";
            // 
            // Validtxt
            // 
            Validtxt.BorderStyle = BorderStyle.FixedSingle;
            Validtxt.Location = new Point(16, 130);
            Validtxt.Name = "Validtxt";
            Validtxt.Size = new Size(303, 27);
            Validtxt.TabIndex = 5;
            Validtxt.TextChanged += Validtxt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(15, 95);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 4;
            label4.Text = "Email or IC Number: ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(label1);
            panel3.ImeMode = ImeMode.Off;
            panel3.Location = new Point(1, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(337, 72);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(27, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 46);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(801, 592);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Validtxt;
        private TextBox Passwordtxt;
        private Label label5;
        private CheckBox passwordchckbx;
        private Label label6;
        private Button Loginbtn;
        private Button Registerbtn;
    }
}
