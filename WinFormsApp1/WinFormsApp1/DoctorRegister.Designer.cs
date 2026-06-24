namespace WinFormsApp1
{
    partial class DoctorRegister
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
            Fullnametxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Phonenumtxt = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            Signinbtn = new Button();
            DepartmentCombo = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 798);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(19, 370);
            label1.Name = "label1";
            label1.Size = new Size(315, 46);
            label1.TabIndex = 0;
            label1.Text = "DOCTOR REGISTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(342, 32);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "Full Name: ";
            // 
            // Fullnametxt
            // 
            Fullnametxt.Location = new Point(342, 66);
            Fullnametxt.Name = "Fullnametxt";
            Fullnametxt.Size = new Size(404, 27);
            Fullnametxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(342, 176);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 6;
            label3.Text = "Select Department: ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(342, 330);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 8;
            label4.Text = "Email: ";
            // 
            // Phonenumtxt
            // 
            Phonenumtxt.Location = new Point(342, 362);
            Phonenumtxt.Name = "Phonenumtxt";
            Phonenumtxt.Size = new Size(404, 27);
            Phonenumtxt.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(342, 491);
            label9.Name = "label9";
            label9.Size = new Size(119, 20);
            label9.TabIndex = 21;
            label9.Text = "Phone Number:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(342, 525);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(404, 27);
            textBox2.TabIndex = 22;
            // 
            // Signinbtn
            // 
            Signinbtn.BackColor = Color.MidnightBlue;
            Signinbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signinbtn.ForeColor = SystemColors.ButtonHighlight;
            Signinbtn.Location = new Point(635, 691);
            Signinbtn.Name = "Signinbtn";
            Signinbtn.Size = new Size(138, 31);
            Signinbtn.TabIndex = 24;
            Signinbtn.Text = "Register Doctor";
            Signinbtn.UseVisualStyleBackColor = false;
            Signinbtn.Click += Signinbtn_Click;
            // 
            // DepartmentCombo
            // 
            DepartmentCombo.FormattingEnabled = true;
            DepartmentCombo.Location = new Point(342, 225);
            DepartmentCombo.Name = "DepartmentCombo";
            DepartmentCombo.Size = new Size(404, 28);
            DepartmentCombo.TabIndex = 25;
            // 
            // DoctorRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 774);
            Controls.Add(DepartmentCombo);
            Controls.Add(Signinbtn);
            Controls.Add(textBox2);
            Controls.Add(label9);
            Controls.Add(Phonenumtxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Fullnametxt);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "DoctorRegister";
            Text = "DoctorRegister";
            Load += DoctorRegister_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox Fullnametxt;
        private Label label3;
        private Label label4;
        private TextBox Phonenumtxt;
        private Label label9;
        private TextBox textBox2;
        private Button Signinbtn;
        private ComboBox DepartmentCombo;
    }
}