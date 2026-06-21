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
            textBox1 = new TextBox();
            label4 = new Label();
            Phonenumtxt = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            cancelbtn = new Button();
            Signinbtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 998);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(24, 462);
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
            label2.Location = new Point(428, 40);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 2;
            label2.Text = "Full Name: ";
            // 
            // Fullnametxt
            // 
            Fullnametxt.Location = new Point(428, 83);
            Fullnametxt.Margin = new Padding(4);
            Fullnametxt.Name = "Fullnametxt";
            Fullnametxt.Size = new Size(504, 31);
            Fullnametxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(428, 220);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(260, 25);
            label3.TabIndex = 6;
            label3.Text = "Department Id(12345671892): ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(428, 266);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(504, 31);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(428, 412);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 8;
            label4.Text = "Email: ";
            // 
            // Phonenumtxt
            // 
            Phonenumtxt.Location = new Point(428, 452);
            Phonenumtxt.Margin = new Padding(4);
            Phonenumtxt.Name = "Phonenumtxt";
            Phonenumtxt.Size = new Size(504, 31);
            Phonenumtxt.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(428, 614);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(144, 25);
            label9.TabIndex = 21;
            label9.Text = "Phone Number:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(428, 656);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(504, 31);
            textBox2.TabIndex = 22;
            // 
            // cancelbtn
            // 
            cancelbtn.BackColor = Color.MidnightBlue;
            cancelbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelbtn.ForeColor = SystemColors.ButtonHighlight;
            cancelbtn.Location = new Point(434, 864);
            cancelbtn.Margin = new Padding(4);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(138, 39);
            cancelbtn.TabIndex = 23;
            cancelbtn.Text = "CANCEL";
            cancelbtn.UseVisualStyleBackColor = false;
            // 
            // Signinbtn
            // 
            Signinbtn.BackColor = Color.MidnightBlue;
            Signinbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signinbtn.ForeColor = SystemColors.ButtonHighlight;
            Signinbtn.Location = new Point(794, 864);
            Signinbtn.Margin = new Padding(4);
            Signinbtn.Name = "Signinbtn";
            Signinbtn.Size = new Size(138, 39);
            Signinbtn.TabIndex = 24;
            Signinbtn.Text = "SIGN IN";
            Signinbtn.UseVisualStyleBackColor = false;
            // 
            // DoctorRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 968);
            Controls.Add(Signinbtn);
            Controls.Add(cancelbtn);
            Controls.Add(textBox2);
            Controls.Add(label9);
            Controls.Add(Phonenumtxt);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(Fullnametxt);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "DoctorRegister";
            Text = "DoctorRegister";
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
        private TextBox textBox1;
        private Label label4;
        private TextBox Phonenumtxt;
        private Label label9;
        private TextBox textBox2;
        private Button cancelbtn;
        private Button Signinbtn;
    }
}