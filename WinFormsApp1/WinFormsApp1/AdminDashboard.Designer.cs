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
			label1 = new Label();
			Refreshbtn = new Button();
			ShowDoctorlbl = new Label();
			panel5 = new Panel();
			dgvCancellationRequests = new DataGridView();
			colRequestID = new DataGridViewTextBoxColumn();
			colPatientName = new DataGridViewTextBoxColumn();
			colDoctorName = new DataGridViewTextBoxColumn();
			colAppointmentDate = new DataGridViewTextBoxColumn();
			colReason = new DataGridViewTextBoxColumn();
			colStatus = new DataGridViewTextBoxColumn();
			label5 = new Label();
			btnApprove = new Button();
			btnReject = new Button();
			btnRefresh = new Button();
			dgvTodayAppointments = new DataGridView();
			colAppointmentID = new DataGridViewTextBoxColumn();
			colTodayPatientName = new DataGridViewTextBoxColumn();
			colTodayDoctorName = new DataGridViewTextBoxColumn();
			colTodayAppointmentDate = new DataGridViewTextBoxColumn();
			colTodayAppointmentTime = new DataGridViewTextBoxColumn();
			colTodayStatus = new DataGridViewTextBoxColumn();
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
			colUpcomingAppointmentID = new DataGridViewTextBoxColumn();
			colUpcomingPatientName = new DataGridViewTextBoxColumn();
			colUpcomingDoctorName = new DataGridViewTextBoxColumn();
			colUpcomingAppointmentDate = new DataGridViewTextBoxColumn();
			colUpcomingAppointmentTime = new DataGridViewTextBoxColumn();
			colUpcomingStatus = new DataGridViewTextBoxColumn();
			panel1.SuspendLayout();
			panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvCancellationRequests).BeginInit();
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
			panel1.Controls.Add(label1);
			panel1.Controls.Add(Refreshbtn);
			panel1.Controls.Add(ShowDoctorlbl);
			panel1.Location = new Point(-113, -1);
			panel1.Margin = new Padding(3, 2, 3, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(1326, 109);
			panel1.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(136, 43);
			label1.Name = "label1";
			label1.Size = new Size(78, 28);
			label1.TabIndex = 2;
			label1.Text = "ADMIN";
			// 
			// Refreshbtn
			// 
			Refreshbtn.BackColor = SystemColors.ButtonHighlight;
			Refreshbtn.Cursor = Cursors.No;
			Refreshbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Refreshbtn.ForeColor = Color.MidnightBlue;
			Refreshbtn.Location = new Point(1180, 63);
			Refreshbtn.Margin = new Padding(3, 2, 3, 2);
			Refreshbtn.Name = "Refreshbtn";
			Refreshbtn.Size = new Size(122, 26);
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
			ShowDoctorlbl.Location = new Point(10, 50);
			ShowDoctorlbl.Name = "ShowDoctorlbl";
			ShowDoctorlbl.Size = new Size(90, 28);
			ShowDoctorlbl.TabIndex = 0;
			ShowDoctorlbl.Text = "DOCTOR";
			// 
			// panel5
			// 
			panel5.Controls.Add(dgvCancellationRequests);
			panel5.Controls.Add(label5);
			panel5.Location = new Point(20, 620);
			panel5.Margin = new Padding(3, 2, 3, 2);
			panel5.Name = "panel5";
			panel5.Size = new Size(994, 152);
			panel5.TabIndex = 6;
			// 
			// dgvCancellationRequests
			// 
			dgvCancellationRequests.AllowUserToAddRows = false;
			dgvCancellationRequests.AllowUserToDeleteRows = false;
			dgvCancellationRequests.AllowUserToOrderColumns = true;
			dgvCancellationRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvCancellationRequests.BackgroundColor = SystemColors.ActiveBorder;
			dgvCancellationRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCancellationRequests.Columns.AddRange(new DataGridViewColumn[] { colRequestID, colPatientName, colDoctorName, colAppointmentDate, colReason, colStatus });
			dgvCancellationRequests.Location = new Point(0, 46);
			dgvCancellationRequests.MultiSelect = false;
			dgvCancellationRequests.Name = "dgvCancellationRequests";
			dgvCancellationRequests.ReadOnly = true;
			dgvCancellationRequests.RowHeadersVisible = false;
			dgvCancellationRequests.RowHeadersWidth = 51;
			dgvCancellationRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvCancellationRequests.Size = new Size(994, 106);
			dgvCancellationRequests.TabIndex = 5;
			// 
			// colRequestID
			// 
			colRequestID.HeaderText = "Request ID";
			colRequestID.MinimumWidth = 6;
			colRequestID.Name = "colRequestID";
			colRequestID.ReadOnly = true;
			// 
			// colPatientName
			// 
			colPatientName.HeaderText = "Patient Name";
			colPatientName.MinimumWidth = 6;
			colPatientName.Name = "colPatientName";
			colPatientName.ReadOnly = true;
			// 
			// colDoctorName
			// 
			colDoctorName.HeaderText = "Doctor Name";
			colDoctorName.MinimumWidth = 6;
			colDoctorName.Name = "colDoctorName";
			colDoctorName.ReadOnly = true;
			// 
			// colAppointmentDate
			// 
			colAppointmentDate.HeaderText = "Appointment Date";
			colAppointmentDate.MinimumWidth = 6;
			colAppointmentDate.Name = "colAppointmentDate";
			colAppointmentDate.ReadOnly = true;
			// 
			// colReason
			// 
			colReason.HeaderText = "Cancellation Reason";
			colReason.MinimumWidth = 6;
			colReason.Name = "colReason";
			colReason.ReadOnly = true;
			// 
			// colStatus
			// 
			colStatus.HeaderText = "Status";
			colStatus.MinimumWidth = 6;
			colStatus.Name = "colStatus";
			colStatus.ReadOnly = true;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.MidnightBlue;
			label5.Location = new Point(21, 11);
			label5.Name = "label5";
			label5.Size = new Size(284, 21);
			label5.TabIndex = 4;
			label5.Text = "Requested Appointment Cancellation";
			// 
			// btnApprove
			// 
			btnApprove.Location = new Point(1030, 658);
			btnApprove.Name = "btnApprove";
			btnApprove.Size = new Size(75, 23);
			btnApprove.TabIndex = 6;
			btnApprove.Text = "Approve";
			btnApprove.UseVisualStyleBackColor = true;
			btnApprove.Click += btnApprove_Click;
			// 
			// btnReject
			// 
			btnReject.Location = new Point(1030, 698);
			btnReject.Name = "btnReject";
			btnReject.Size = new Size(75, 23);
			btnReject.TabIndex = 7;
			btnReject.Text = "Reject";
			btnReject.UseVisualStyleBackColor = true;
			btnReject.Click += btnReject_Click;
			// 
			// btnRefresh
			// 
			btnRefresh.Location = new Point(1030, 738);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(75, 23);
			btnRefresh.TabIndex = 8;
			btnRefresh.Text = "Refresh";
			btnRefresh.UseVisualStyleBackColor = true;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// dgvTodayAppointments
			// 
			dgvTodayAppointments.AllowUserToAddRows = false;
			dgvTodayAppointments.AllowUserToDeleteRows = false;
			dgvTodayAppointments.AllowUserToResizeRows = false;
			dgvTodayAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvTodayAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvTodayAppointments.Columns.AddRange(new DataGridViewColumn[] { colAppointmentID, colTodayPatientName, colTodayDoctorName, colTodayAppointmentDate, colTodayAppointmentTime, colTodayStatus });
			dgvTodayAppointments.Location = new Point(0, 41);
			dgvTodayAppointments.Margin = new Padding(3, 2, 3, 2);
			dgvTodayAppointments.MultiSelect = false;
			dgvTodayAppointments.Name = "dgvTodayAppointments";
			dgvTodayAppointments.ReadOnly = true;
			dgvTodayAppointments.RowHeadersVisible = false;
			dgvTodayAppointments.RowHeadersWidth = 51;
			dgvTodayAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvTodayAppointments.Size = new Size(991, 117);
			dgvTodayAppointments.TabIndex = 9;
			// 
			// colAppointmentID
			// 
			colAppointmentID.HeaderText = "Appointment ID";
			colAppointmentID.MinimumWidth = 6;
			colAppointmentID.Name = "colAppointmentID";
			colAppointmentID.ReadOnly = true;
			// 
			// colTodayPatientName
			// 
			colTodayPatientName.HeaderText = "Patient Name";
			colTodayPatientName.MinimumWidth = 6;
			colTodayPatientName.Name = "colTodayPatientName";
			colTodayPatientName.ReadOnly = true;
			// 
			// colTodayDoctorName
			// 
			colTodayDoctorName.HeaderText = "Doctor Name";
			colTodayDoctorName.MinimumWidth = 6;
			colTodayDoctorName.Name = "colTodayDoctorName";
			colTodayDoctorName.ReadOnly = true;
			// 
			// colTodayAppointmentDate
			// 
			colTodayAppointmentDate.HeaderText = "Appointment Date";
			colTodayAppointmentDate.MinimumWidth = 6;
			colTodayAppointmentDate.Name = "colTodayAppointmentDate";
			colTodayAppointmentDate.ReadOnly = true;
			// 
			// colTodayAppointmentTime
			// 
			colTodayAppointmentTime.HeaderText = "Appointment Time";
			colTodayAppointmentTime.MinimumWidth = 6;
			colTodayAppointmentTime.Name = "colTodayAppointmentTime";
			colTodayAppointmentTime.ReadOnly = true;
			// 
			// colTodayStatus
			// 
			colTodayStatus.HeaderText = "Status";
			colTodayStatus.MinimumWidth = 6;
			colTodayStatus.Name = "colTodayStatus";
			colTodayStatus.ReadOnly = true;
			// 
			// panel2
			// 
			panel2.Controls.Add(label2);
			panel2.Controls.Add(dgvTodayAppointments);
			panel2.Location = new Point(20, 247);
			panel2.Margin = new Padding(3, 2, 3, 2);
			panel2.Name = "panel2";
			panel2.Size = new Size(994, 154);
			panel2.TabIndex = 7;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.MidnightBlue;
			label2.Location = new Point(9, 11);
			label2.Name = "label2";
			label2.Size = new Size(172, 21);
			label2.TabIndex = 4;
			label2.Text = "Today's Appointments";
			// 
			// pnlTotalDoctors
			// 
			pnlTotalDoctors.BorderStyle = BorderStyle.FixedSingle;
			pnlTotalDoctors.Controls.Add(lblTotalDoctorsValue);
			pnlTotalDoctors.Controls.Add(lblTotalDoctorsTitle);
			pnlTotalDoctors.Location = new Point(25, 112);
			pnlTotalDoctors.Margin = new Padding(3, 2, 3, 2);
			pnlTotalDoctors.Name = "pnlTotalDoctors";
			pnlTotalDoctors.Size = new Size(219, 94);
			pnlTotalDoctors.TabIndex = 9;
			// 
			// lblTotalDoctorsValue
			// 
			lblTotalDoctorsValue.AutoSize = true;
			lblTotalDoctorsValue.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTotalDoctorsValue.Location = new Point(89, 34);
			lblTotalDoctorsValue.Name = "lblTotalDoctorsValue";
			lblTotalDoctorsValue.Size = new Size(32, 37);
			lblTotalDoctorsValue.TabIndex = 11;
			lblTotalDoctorsValue.Text = "0";
			// 
			// lblTotalDoctorsTitle
			// 
			lblTotalDoctorsTitle.AutoSize = true;
			lblTotalDoctorsTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTotalDoctorsTitle.Location = new Point(13, 8);
			lblTotalDoctorsTitle.Name = "lblTotalDoctorsTitle";
			lblTotalDoctorsTitle.Size = new Size(165, 19);
			lblTotalDoctorsTitle.TabIndex = 10;
			lblTotalDoctorsTitle.Text = "Total Doctors Available";
			// 
			// pnlTotalPatients
			// 
			pnlTotalPatients.BorderStyle = BorderStyle.FixedSingle;
			pnlTotalPatients.Controls.Add(lblTotalPatientsValue);
			pnlTotalPatients.Controls.Add(lblTotalPatientsTitle);
			pnlTotalPatients.Location = new Point(290, 112);
			pnlTotalPatients.Margin = new Padding(3, 2, 3, 2);
			pnlTotalPatients.Name = "pnlTotalPatients";
			pnlTotalPatients.Size = new Size(219, 94);
			pnlTotalPatients.TabIndex = 12;
			// 
			// lblTotalPatientsValue
			// 
			lblTotalPatientsValue.AutoSize = true;
			lblTotalPatientsValue.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTotalPatientsValue.Location = new Point(89, 34);
			lblTotalPatientsValue.Name = "lblTotalPatientsValue";
			lblTotalPatientsValue.Size = new Size(32, 37);
			lblTotalPatientsValue.TabIndex = 11;
			lblTotalPatientsValue.Text = "0";
			// 
			// lblTotalPatientsTitle
			// 
			lblTotalPatientsTitle.AutoSize = true;
			lblTotalPatientsTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTotalPatientsTitle.Location = new Point(13, 8);
			lblTotalPatientsTitle.Name = "lblTotalPatientsTitle";
			lblTotalPatientsTitle.Size = new Size(99, 19);
			lblTotalPatientsTitle.TabIndex = 10;
			lblTotalPatientsTitle.Text = "Total Patients";
			// 
			// panel3
			// 
			panel3.Controls.Add(label3);
			panel3.Controls.Add(dgvUpcomingAppointments);
			panel3.Location = new Point(20, 433);
			panel3.Margin = new Padding(3, 2, 3, 2);
			panel3.Name = "panel3";
			panel3.Size = new Size(994, 154);
			panel3.TabIndex = 10;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.MidnightBlue;
			label3.Location = new Point(9, 11);
			label3.Name = "label3";
			label3.Size = new Size(195, 21);
			label3.TabIndex = 4;
			label3.Text = "Upcoming Appointments";
			// 
			// dgvUpcomingAppointments
			// 
			dgvUpcomingAppointments.AllowUserToAddRows = false;
			dgvUpcomingAppointments.AllowUserToDeleteRows = false;
			dgvUpcomingAppointments.AllowUserToResizeRows = false;
			dgvUpcomingAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvUpcomingAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvUpcomingAppointments.Columns.AddRange(new DataGridViewColumn[] { colUpcomingAppointmentID, colUpcomingPatientName, colUpcomingDoctorName, colUpcomingAppointmentDate, colUpcomingAppointmentTime, colUpcomingStatus });
			dgvUpcomingAppointments.Location = new Point(0, 41);
			dgvUpcomingAppointments.Margin = new Padding(3, 2, 3, 2);
			dgvUpcomingAppointments.MultiSelect = false;
			dgvUpcomingAppointments.Name = "dgvUpcomingAppointments";
			dgvUpcomingAppointments.ReadOnly = true;
			dgvUpcomingAppointments.RowHeadersVisible = false;
			dgvUpcomingAppointments.RowHeadersWidth = 51;
			dgvUpcomingAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvUpcomingAppointments.Size = new Size(991, 117);
			dgvUpcomingAppointments.TabIndex = 9;
			// 
			// colUpcomingAppointmentID
			// 
			colUpcomingAppointmentID.HeaderText = "Appointment ID";
			colUpcomingAppointmentID.MinimumWidth = 6;
			colUpcomingAppointmentID.Name = "colUpcomingAppointmentID";
			colUpcomingAppointmentID.ReadOnly = true;
			// 
			// colUpcomingPatientName
			// 
			colUpcomingPatientName.HeaderText = "Patient Name";
			colUpcomingPatientName.MinimumWidth = 6;
			colUpcomingPatientName.Name = "colUpcomingPatientName";
			colUpcomingPatientName.ReadOnly = true;
			// 
			// colUpcomingDoctorName
			// 
			colUpcomingDoctorName.HeaderText = "Doctor Name";
			colUpcomingDoctorName.MinimumWidth = 6;
			colUpcomingDoctorName.Name = "colUpcomingDoctorName";
			colUpcomingDoctorName.ReadOnly = true;
			// 
			// colUpcomingAppointmentDate
			// 
			colUpcomingAppointmentDate.HeaderText = "Appointment Date";
			colUpcomingAppointmentDate.MinimumWidth = 6;
			colUpcomingAppointmentDate.Name = "colUpcomingAppointmentDate";
			colUpcomingAppointmentDate.ReadOnly = true;
			// 
			// colUpcomingAppointmentTime
			// 
			colUpcomingAppointmentTime.HeaderText = "Appointment Time";
			colUpcomingAppointmentTime.MinimumWidth = 6;
			colUpcomingAppointmentTime.Name = "colUpcomingAppointmentTime";
			colUpcomingAppointmentTime.ReadOnly = true;
			// 
			// colUpcomingStatus
			// 
			colUpcomingStatus.HeaderText = "Status";
			colUpcomingStatus.MinimumWidth = 6;
			colUpcomingStatus.Name = "colUpcomingStatus";
			colUpcomingStatus.ReadOnly = true;
			// 
			// AdminDashboard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(1124, 526);
			Controls.Add(panel3);
			Controls.Add(pnlTotalPatients);
			Controls.Add(pnlTotalDoctors);
			Controls.Add(panel2);
			Controls.Add(btnRefresh);
			Controls.Add(btnReject);
			Controls.Add(btnApprove);
			Controls.Add(panel5);
			Controls.Add(panel1);
			Name = "AdminDashboard";
			Text = "AdminDashboard";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvCancellationRequests).EndInit();
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
		private DataGridView dgvCancellationRequests;
		private DataGridViewTextBoxColumn colRequestID;
		private DataGridViewTextBoxColumn colPatientName;
		private DataGridViewTextBoxColumn colDoctorName;
		private DataGridViewTextBoxColumn colAppointmentDate;
		private DataGridViewTextBoxColumn colReason;
		private DataGridViewTextBoxColumn colStatus;
		private Button btnApprove;
		private Button btnReject;
		private Button btnRefresh;
		private DataGridView dgvTodayAppointments;
		private Panel panel2;
		private Label label2;
		private DataGridViewTextBoxColumn colAppointmentID;
		private DataGridViewTextBoxColumn colTodayPatientName;
		private DataGridViewTextBoxColumn colTodayDoctorName;
		private DataGridViewTextBoxColumn colTodayAppointmentDate;
		private DataGridViewTextBoxColumn colTodayAppointmentTime;
		private DataGridViewTextBoxColumn colTodayStatus;
		private Panel pnlTotalDoctors;
		private Label lblTotalDoctorsTitle;
		private Label lblTotalDoctorsValue;
		private Panel pnlTotalPatients;
		private Label lblTotalPatientsValue;
		private Label lblTotalPatientsTitle;
		private Panel panel3;
		private Label label3;
		private DataGridView dgvUpcomingAppointments;
		private DataGridViewTextBoxColumn colUpcomingAppointmentID;
		private DataGridViewTextBoxColumn colUpcomingPatientName;
		private DataGridViewTextBoxColumn colUpcomingDoctorName;
		private DataGridViewTextBoxColumn colUpcomingAppointmentDate;
		private DataGridViewTextBoxColumn colUpcomingAppointmentTime;
		private DataGridViewTextBoxColumn colUpcomingStatus;
	}
}