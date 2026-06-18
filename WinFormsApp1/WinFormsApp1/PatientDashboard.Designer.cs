namespace WinFormsApp1
{
    partial class PatientDashboard
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
            Appointmentbtn = new Button();
            PatientNamelbl = new Label();
            refreshbtn = new Button();
            CurrentAppointmentDGV = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            PastAppointmentDGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CurrentAppointmentDGV).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PastAppointmentDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(Appointmentbtn);
            panel1.Controls.Add(PatientNamelbl);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 125);
            panel1.TabIndex = 0;
            // 
            // Appointmentbtn
            // 
            Appointmentbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Appointmentbtn.ForeColor = Color.MidnightBlue;
            Appointmentbtn.Location = new Point(939, 66);
            Appointmentbtn.Name = "Appointmentbtn";
            Appointmentbtn.Size = new Size(211, 39);
            Appointmentbtn.TabIndex = 1;
            Appointmentbtn.Text = "Book An Appointment";
            Appointmentbtn.UseVisualStyleBackColor = true;
            Appointmentbtn.Click += button1_Click;
            // 
            // PatientNamelbl
            // 
            PatientNamelbl.AutoSize = true;
            PatientNamelbl.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            PatientNamelbl.ForeColor = SystemColors.ButtonHighlight;
            PatientNamelbl.Location = new Point(11, 66);
            PatientNamelbl.Name = "PatientNamelbl";
            PatientNamelbl.Size = new Size(110, 35);
            PatientNamelbl.TabIndex = 0;
            PatientNamelbl.Text = "PATIENT";
            PatientNamelbl.Click += PatientNamelbl_Click;
            // 
            // refreshbtn
            // 
            refreshbtn.BackColor = Color.MidnightBlue;
            refreshbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            refreshbtn.ForeColor = SystemColors.ButtonHighlight;
            refreshbtn.Location = new Point(994, 144);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(102, 35);
            refreshbtn.TabIndex = 1;
            refreshbtn.Text = "Refresh";
            refreshbtn.UseVisualStyleBackColor = false;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // CurrentAppointmentDGV
            // 
            CurrentAppointmentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CurrentAppointmentDGV.Location = new Point(17, 58);
            CurrentAppointmentDGV.Name = "CurrentAppointmentDGV";
            CurrentAppointmentDGV.RowHeadersWidth = 51;
            CurrentAppointmentDGV.Size = new Size(1099, 191);
            CurrentAppointmentDGV.TabIndex = 2;
            CurrentAppointmentDGV.CellContentClick += CurrentAppointmentDGV_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(CurrentAppointmentDGV);
            panel2.Location = new Point(12, 206);
            panel2.Name = "panel2";
            panel2.Size = new Size(1139, 267);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(19, 15);
            label1.Name = "label1";
            label1.Size = new Size(207, 28);
            label1.TabIndex = 3;
            label1.Text = "Current Appointment";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(PastAppointmentDGV);
            panel3.Location = new Point(12, 543);
            panel3.Name = "panel3";
            panel3.Size = new Size(1139, 267);
            panel3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(19, 18);
            label2.Name = "label2";
            label2.Size = new Size(176, 28);
            label2.TabIndex = 4;
            label2.Text = "Past Appointment";
            // 
            // PastAppointmentDGV
            // 
            PastAppointmentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PastAppointmentDGV.Location = new Point(19, 58);
            PastAppointmentDGV.Name = "PastAppointmentDGV";
            PastAppointmentDGV.RowHeadersWidth = 51;
            PastAppointmentDGV.Size = new Size(1099, 191);
            PastAppointmentDGV.TabIndex = 2;
            PastAppointmentDGV.CellContentClick += PastAppointmentDGV_CellContentClick;
            // 
            // PatientDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 842);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(refreshbtn);
            Controls.Add(panel1);
            Name = "PatientDashboard";
            Text = "PatientDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CurrentAppointmentDGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PastAppointmentDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label PatientNamelbl;
        private Button Appointmentbtn;
        private Button refreshbtn;
        private DataGridView CurrentAppointmentDGV;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private DataGridView PastAppointmentDGV;
    }
}