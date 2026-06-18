namespace WinFormsApp1
{
    partial class MakeAppointment
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
            TimeDTP = new DateTimePicker();
            label4 = new Label();
            DateDTP = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            DoctorCombo = new ComboBox();
            label1 = new Label();
            MakeAppbtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(TimeDTP);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(DateDTP);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(DoctorCombo);
            panel1.Location = new Point(7, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 544);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // TimeDTP
            // 
            TimeDTP.Location = new Point(29, 403);
            TimeDTP.Name = "TimeDTP";
            TimeDTP.Size = new Size(345, 27);
            TimeDTP.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(29, 357);
            label4.Name = "label4";
            label4.Size = new Size(170, 25);
            label4.TabIndex = 4;
            label4.Text = "Choose Your Time: ";
            // 
            // DateDTP
            // 
            DateDTP.Location = new Point(29, 242);
            DateDTP.Name = "DateDTP";
            DateDTP.Size = new Size(345, 27);
            DateDTP.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(29, 197);
            label3.Name = "label3";
            label3.Size = new Size(168, 25);
            label3.TabIndex = 2;
            label3.Text = "Choose Your Date: ";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(29, 58);
            label2.Name = "label2";
            label2.Size = new Size(191, 25);
            label2.TabIndex = 1;
            label2.Text = "Choose Your Doctor : ";
            // 
            // DoctorCombo
            // 
            DoctorCombo.FormattingEnabled = true;
            DoctorCombo.Location = new Point(29, 86);
            DoctorCombo.Name = "DoctorCombo";
            DoctorCombo.Size = new Size(345, 28);
            DoctorCombo.TabIndex = 0;
            DoctorCombo.SelectedIndexChanged += DoctorCombo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(369, 46);
            label1.TabIndex = 1;
            label1.Text = "Make An Appointment";
            // 
            // MakeAppbtn
            // 
            MakeAppbtn.BackColor = Color.MidnightBlue;
            MakeAppbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MakeAppbtn.ForeColor = SystemColors.ButtonHighlight;
            MakeAppbtn.Location = new Point(224, 664);
            MakeAppbtn.Name = "MakeAppbtn";
            MakeAppbtn.Size = new Size(168, 31);
            MakeAppbtn.TabIndex = 2;
            MakeAppbtn.Text = "Make Appointment";
            MakeAppbtn.UseVisualStyleBackColor = false;
            MakeAppbtn.Click += MakeAppbtn_Click_1;
            // 
            // MakeAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 730);
            Controls.Add(MakeAppbtn);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "MakeAppointment";
            Text = "MakeAppointment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox DoctorCombo;
        private Label label3;
        private DateTimePicker TimeDTP;
        private Label label4;
        private DateTimePicker DateDTP;
        private Button MakeAppbtn;
    }
}