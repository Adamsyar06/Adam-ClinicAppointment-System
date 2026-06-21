namespace WinFormsApp1
{
    partial class DoctorDashboard
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
			Refreshbtn = new Button();
			ShowDoctorlbl = new Label();
			panel2 = new Panel();
			TodayPatientDGV = new DataGridView();
			label1 = new Label();
			panel3 = new Panel();
			ThisWeekPatientDGV = new DataGridView();
			label2 = new Label();
			panel4 = new Panel();
			CancellationRequestDGV = new DataGridView();
			label3 = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)TodayPatientDGV).BeginInit();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ThisWeekPatientDGV).BeginInit();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)CancellationRequestDGV).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.MidnightBlue;
			panel1.Controls.Add(Refreshbtn);
			panel1.Controls.Add(ShowDoctorlbl);
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1147, 128);
			panel1.TabIndex = 1;
			// 
			// Refreshbtn
			// 
			Refreshbtn.BackColor = SystemColors.ButtonHighlight;
			Refreshbtn.Cursor = Cursors.No;
			Refreshbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Refreshbtn.ForeColor = Color.MidnightBlue;
			Refreshbtn.Location = new Point(977, 72);
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
			// panel2
			// 
			panel2.Controls.Add(TodayPatientDGV);
			panel2.Controls.Add(label1);
			panel2.Location = new Point(11, 181);
			panel2.Name = "panel2";
			panel2.Size = new Size(1136, 253);
			panel2.TabIndex = 2;
			// 
			// TodayPatientDGV
			// 
			TodayPatientDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			TodayPatientDGV.Location = new Point(5, 61);
			TodayPatientDGV.Name = "TodayPatientDGV";
			TodayPatientDGV.RowHeadersWidth = 51;
			TodayPatientDGV.Size = new Size(1131, 187);
			TodayPatientDGV.TabIndex = 5;
			TodayPatientDGV.CellContentClick += TodayPatientDGV_CellContentClick;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.MidnightBlue;
			label1.Location = new Point(21, 11);
			label1.Name = "label1";
			label1.Size = new Size(192, 28);
			label1.TabIndex = 4;
			label1.Text = "Today Appointment";
			// 
			// panel3
			// 
			panel3.Controls.Add(ThisWeekPatientDGV);
			panel3.Controls.Add(label2);
			panel3.Location = new Point(11, 464);
			panel3.Name = "panel3";
			panel3.Size = new Size(1136, 259);
			panel3.TabIndex = 5;
			// 
			// ThisWeekPatientDGV
			// 
			ThisWeekPatientDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			ThisWeekPatientDGV.Location = new Point(1, 57);
			ThisWeekPatientDGV.Name = "ThisWeekPatientDGV";
			ThisWeekPatientDGV.RowHeadersWidth = 51;
			ThisWeekPatientDGV.Size = new Size(1131, 187);
			ThisWeekPatientDGV.TabIndex = 6;
			ThisWeekPatientDGV.CellContentClick += ThisWeekPatientDGV_CellContentClick;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.MidnightBlue;
			label2.Location = new Point(21, 11);
			label2.Name = "label2";
			label2.Size = new Size(233, 28);
			label2.TabIndex = 4;
			label2.Text = "Upcoming Appointment";
			// 
			// panel4
			// 
			panel4.Controls.Add(CancellationRequestDGV);
			panel4.Controls.Add(label3);
			panel4.Location = new Point(11, 757);
			panel4.Name = "panel4";
			panel4.Size = new Size(1136, 260);
			panel4.TabIndex = 6;
			// 
			// CancellationRequestDGV
			// 
			CancellationRequestDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			CancellationRequestDGV.Location = new Point(5, 55);
			CancellationRequestDGV.Name = "CancellationRequestDGV";
			CancellationRequestDGV.RowHeadersWidth = 51;
			CancellationRequestDGV.Size = new Size(1131, 187);
			CancellationRequestDGV.TabIndex = 6;
			CancellationRequestDGV.CellContentClick += CancellationRequestDGV_CellContentClick;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.MidnightBlue;
			label3.Location = new Point(21, 11);
			label3.Name = "label3";
			label3.Size = new Size(296, 28);
			label3.TabIndex = 4;
			label3.Text = "Requested Cancellation Update";
			// 
			// DoctorDashboard
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1265, 1055);
			Controls.Add(panel4);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "DoctorDashboard";
			Text = "DoctorDashboard";
			Load += DoctorDashboard_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)TodayPatientDGV).EndInit();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ThisWeekPatientDGV).EndInit();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)CancellationRequestDGV).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
        private Button Refreshbtn;
        private Label ShowDoctorlbl;
        private Panel panel2;
        private DataGridView TodayPatientDGV;
        private Label label1;
        private Panel panel3;
        private DataGridView ThisWeekPatientDGV;
        private Label label2;
        private Panel panel4;
        private DataGridView CancellationRequestDGV;
        private Label label3;
    }
}