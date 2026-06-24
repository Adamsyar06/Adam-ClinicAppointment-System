namespace WinFormsApp1
{
    partial class AdminDashboard
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
            ViewDoctorbtn = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            Refreshbtn = new Button();
            ShowDoctorlbl = new Label();
            panel5 = new Panel();
            CancellationRequestDGV = new DataGridView();
            label5 = new Label();
            dgvTodayAppointments = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            pnlTotalDoctors = new Panel();
            lblTotalDoctorsValue = new Label();
            lblTotalDoctorsTitle = new Label();
            pnlTotalPatients = new Panel();
            lblTotalPatientsValue = new Label();
            lblTotalPatientsTitle = new Label();
            panel3 = new Panel();
            label3 = new Label();
            dgvUpcomingAppointments = new DataGridView();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CancellationRequestDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTodayAppointments).BeginInit();
            panel2.SuspendLayout();
            pnlTotalDoctors.SuspendLayout();
            pnlTotalPatients.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpcomingAppointments).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(ViewDoctorbtn);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Refreshbtn);
            panel1.Controls.Add(ShowDoctorlbl);
            panel1.Location = new Point(-129, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1515, 145);
            panel1.TabIndex = 2;
            // 
            // ViewDoctorbtn
            // 
            ViewDoctorbtn.BackColor = SystemColors.ButtonHighlight;
            ViewDoctorbtn.Cursor = Cursors.No;
            ViewDoctorbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewDoctorbtn.ForeColor = Color.MidnightBlue;
            ViewDoctorbtn.Location = new Point(880, 84);
            ViewDoctorbtn.Name = "ViewDoctorbtn";
            ViewDoctorbtn.Size = new Size(139, 35);
            ViewDoctorbtn.TabIndex = 5;
            ViewDoctorbtn.Text = "View Doctor";
            ViewDoctorbtn.UseVisualStyleBackColor = false;
            ViewDoctorbtn.Click += ViewDoctorbtn_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Cursor = Cursors.No;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.MidnightBlue;
            button2.Location = new Point(1190, 84);
            button2.Name = "button2";
            button2.Size = new Size(139, 35);
            button2.TabIndex = 4;
            button2.Text = "Add Department";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Cursor = Cursors.No;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(1035, 84);
            button1.Name = "button1";
            button1.Size = new Size(139, 35);
            button1.TabIndex = 3;
            button1.Text = "Add Doctor";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(155, 57);
            label1.Name = "label1";
            label1.Size = new Size(99, 35);
            label1.TabIndex = 2;
            label1.Text = "ADMIN";
            label1.Click += label1_Click;
            // 
            // Refreshbtn
            // 
            Refreshbtn.BackColor = SystemColors.ButtonHighlight;
            Refreshbtn.Cursor = Cursors.No;
            Refreshbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Refreshbtn.ForeColor = Color.MidnightBlue;
            Refreshbtn.Location = new Point(1349, 84);
            Refreshbtn.Name = "Refreshbtn";
            Refreshbtn.Size = new Size(139, 35);
            Refreshbtn.TabIndex = 1;
            Refreshbtn.Text = "Refresh Page";
            Refreshbtn.UseVisualStyleBackColor = false;
            Refreshbtn.Click += Refreshbtn_Click;
            // 
            // ShowDoctorlbl
            // 
            ShowDoctorlbl.AutoSize = true;
            ShowDoctorlbl.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            ShowDoctorlbl.ForeColor = SystemColors.ButtonHighlight;
            ShowDoctorlbl.Location = new Point(11, 67);
            ShowDoctorlbl.Name = "ShowDoctorlbl";
            ShowDoctorlbl.Size = new Size(116, 35);
            ShowDoctorlbl.TabIndex = 0;
            ShowDoctorlbl.Text = "DOCTOR";
            // 
            // panel5
            // 
            panel5.Controls.Add(CancellationRequestDGV);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(20, 724);
            panel5.Name = "panel5";
            panel5.Size = new Size(1136, 203);
            panel5.TabIndex = 6;
            // 
            // CancellationRequestDGV
            // 
            CancellationRequestDGV.BackgroundColor = SystemColors.Control;
            CancellationRequestDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CancellationRequestDGV.Location = new Point(3, 61);
            CancellationRequestDGV.Name = "CancellationRequestDGV";
            CancellationRequestDGV.RowHeadersWidth = 51;
            CancellationRequestDGV.Size = new Size(1133, 142);
            CancellationRequestDGV.TabIndex = 6;
            CancellationRequestDGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(24, 15);
            label5.Name = "label5";
            label5.Size = new Size(351, 28);
            label5.TabIndex = 4;
            label5.Text = "Requested Appointment Cancellation";
            // 
            // dgvTodayAppointments
            // 
            dgvTodayAppointments.AllowUserToAddRows = false;
            dgvTodayAppointments.AllowUserToDeleteRows = false;
            dgvTodayAppointments.AllowUserToResizeRows = false;
            dgvTodayAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTodayAppointments.BackgroundColor = SystemColors.Control;
            dgvTodayAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodayAppointments.Location = new Point(0, 55);
            dgvTodayAppointments.MultiSelect = false;
            dgvTodayAppointments.Name = "dgvTodayAppointments";
            dgvTodayAppointments.RowHeadersVisible = false;
            dgvTodayAppointments.RowHeadersWidth = 51;
            dgvTodayAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTodayAppointments.Size = new Size(1133, 156);
            dgvTodayAppointments.TabIndex = 9;
            dgvTodayAppointments.CellContentClick += dgvTodayAppointments_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dgvTodayAppointments);
            panel2.Location = new Point(20, 290);
            panel2.Name = "panel2";
            panel2.Size = new Size(1136, 205);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(10, 15);
            label2.Name = "label2";
            label2.Size = new Size(214, 28);
            label2.TabIndex = 4;
            label2.Text = "Today's Appointments";
            // 
            // pnlTotalDoctors
            // 
            pnlTotalDoctors.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalDoctors.Controls.Add(lblTotalDoctorsValue);
            pnlTotalDoctors.Controls.Add(lblTotalDoctorsTitle);
            pnlTotalDoctors.Location = new Point(29, 149);
            pnlTotalDoctors.Name = "pnlTotalDoctors";
            pnlTotalDoctors.Size = new Size(250, 125);
            pnlTotalDoctors.TabIndex = 9;
            // 
            // lblTotalDoctorsValue
            // 
            lblTotalDoctorsValue.AutoSize = true;
            lblTotalDoctorsValue.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalDoctorsValue.Location = new Point(102, 45);
            lblTotalDoctorsValue.Name = "lblTotalDoctorsValue";
            lblTotalDoctorsValue.Size = new Size(38, 46);
            lblTotalDoctorsValue.TabIndex = 11;
            lblTotalDoctorsValue.Text = "0";
            // 
            // lblTotalDoctorsTitle
            // 
            lblTotalDoctorsTitle.AutoSize = true;
            lblTotalDoctorsTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDoctorsTitle.Location = new Point(15, 11);
            lblTotalDoctorsTitle.Name = "lblTotalDoctorsTitle";
            lblTotalDoctorsTitle.Size = new Size(195, 23);
            lblTotalDoctorsTitle.TabIndex = 10;
            lblTotalDoctorsTitle.Text = "Total Doctors Available";
            // 
            // pnlTotalPatients
            // 
            pnlTotalPatients.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalPatients.Controls.Add(lblTotalPatientsValue);
            pnlTotalPatients.Controls.Add(lblTotalPatientsTitle);
            pnlTotalPatients.Location = new Point(331, 149);
            pnlTotalPatients.Name = "pnlTotalPatients";
            pnlTotalPatients.Size = new Size(250, 125);
            pnlTotalPatients.TabIndex = 12;
            // 
            // lblTotalPatientsValue
            // 
            lblTotalPatientsValue.AutoSize = true;
            lblTotalPatientsValue.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPatientsValue.Location = new Point(102, 45);
            lblTotalPatientsValue.Name = "lblTotalPatientsValue";
            lblTotalPatientsValue.Size = new Size(38, 46);
            lblTotalPatientsValue.TabIndex = 11;
            lblTotalPatientsValue.Text = "0";
            // 
            // lblTotalPatientsTitle
            // 
            lblTotalPatientsTitle.AutoSize = true;
            lblTotalPatientsTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPatientsTitle.Location = new Point(15, 11);
            lblTotalPatientsTitle.Name = "lblTotalPatientsTitle";
            lblTotalPatientsTitle.Size = new Size(170, 23);
            lblTotalPatientsTitle.TabIndex = 10;
            lblTotalPatientsTitle.Text = "Total Patients Today";
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dgvUpcomingAppointments);
            panel3.Location = new Point(23, 507);
            panel3.Name = "panel3";
            panel3.Size = new Size(1136, 205);
            panel3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(10, 15);
            label3.Name = "label3";
            label3.Size = new Size(242, 28);
            label3.TabIndex = 4;
            label3.Text = "Upcoming Appointments";
            // 
            // dgvUpcomingAppointments
            // 
            dgvUpcomingAppointments.AllowUserToAddRows = false;
            dgvUpcomingAppointments.AllowUserToDeleteRows = false;
            dgvUpcomingAppointments.AllowUserToResizeRows = false;
            dgvUpcomingAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUpcomingAppointments.BackgroundColor = SystemColors.Control;
            dgvUpcomingAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpcomingAppointments.Location = new Point(0, 55);
            dgvUpcomingAppointments.MultiSelect = false;
            dgvUpcomingAppointments.Name = "dgvUpcomingAppointments";
            dgvUpcomingAppointments.RowHeadersVisible = false;
            dgvUpcomingAppointments.RowHeadersWidth = 51;
            dgvUpcomingAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUpcomingAppointments.Size = new Size(1133, 156);
            dgvUpcomingAppointments.TabIndex = 9;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1387, 1055);
            Controls.Add(panel3);
            Controls.Add(pnlTotalPatients);
            Controls.Add(pnlTotalDoctors);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CancellationRequestDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTodayAppointments).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlTotalDoctors.ResumeLayout(false);
            pnlTotalDoctors.PerformLayout();
            pnlTotalPatients.ResumeLayout(false);
            pnlTotalPatients.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpcomingAppointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
		private Button Refreshbtn;
		private Label ShowDoctorlbl;
		private Label label1;
		private Panel panel5;
		private Label label5;
		private DataGridView dgvTodayAppointments;
		private Panel panel2;
		private Label label2;
		private Panel pnlTotalDoctors;
		private Label lblTotalDoctorsTitle;
		private Label lblTotalDoctorsValue;
		private Panel pnlTotalPatients;
		private Label lblTotalPatientsValue;
		private Label lblTotalPatientsTitle;
		private Panel panel3;
		private Label label3;
		private DataGridView dgvUpcomingAppointments;
        private Button button2;
        private Button button1;
        private DataGridView CancellationRequestDGV;
        private Button ViewDoctorbtn;
    }
}