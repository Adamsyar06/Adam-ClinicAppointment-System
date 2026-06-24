namespace WinFormsApp1
{
    partial class RegisterDepartment
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
            Descriptiontxt = new RichTextBox();
            Signinbtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 798);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(41, 356);
            label1.Name = "label1";
            label1.Size = new Size(236, 92);
            label1.TabIndex = 0;
            label1.Text = "DEPARTMENT\r\n REGISTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(353, 105);
            label2.Name = "label2";
            label2.Size = new Size(179, 20);
            label2.TabIndex = 3;
            label2.Text = "New Department Name: ";
            // 
            // Fullnametxt
            // 
            Fullnametxt.Location = new Point(353, 150);
            Fullnametxt.Name = "Fullnametxt";
            Fullnametxt.Size = new Size(404, 27);
            Fullnametxt.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(353, 266);
            label3.Name = "label3";
            label3.Size = new Size(216, 20);
            label3.TabIndex = 7;
            label3.Text = "New Department Description: ";
            // 
            // Descriptiontxt
            // 
            Descriptiontxt.Location = new Point(353, 313);
            Descriptiontxt.Name = "Descriptiontxt";
            Descriptiontxt.Size = new Size(404, 120);
            Descriptiontxt.TabIndex = 8;
            Descriptiontxt.Text = "";
            // 
            // Signinbtn
            // 
            Signinbtn.BackColor = Color.MidnightBlue;
            Signinbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signinbtn.ForeColor = SystemColors.ButtonHighlight;
            Signinbtn.Location = new Point(594, 696);
            Signinbtn.Name = "Signinbtn";
            Signinbtn.Size = new Size(163, 31);
            Signinbtn.TabIndex = 25;
            Signinbtn.Text = "Register Department";
            Signinbtn.UseVisualStyleBackColor = false;
            Signinbtn.Click += Signinbtn_Click;
            // 
            // RegisterDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 739);
            Controls.Add(Signinbtn);
            Controls.Add(Descriptiontxt);
            Controls.Add(label3);
            Controls.Add(Fullnametxt);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "RegisterDepartment";
            Text = "RegisterDepartment";
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
        private RichTextBox Descriptiontxt;
        private Button Signinbtn;
    }
}