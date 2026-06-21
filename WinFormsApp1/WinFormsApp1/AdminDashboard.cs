using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
	public partial class AdminDashboard : Form
	{
		public AdminDashboard()
		{
			InitializeComponent();
			LoadDashboardData();
		}

		private void LoadDashboardData()
		{
			lblTotalDoctorsValue.Text = "12";
			lblTotalPatientsValue.Text = "248";

			dgvTodayAppointments.Rows.Clear();
			dgvTodayAppointments.Rows.Add("A001", "Adam Rosdi", "Dr. Ahmad", "21/06/2026", "09:00 AM", "Scheduled");
			dgvTodayAppointments.Rows.Add("A002", "Siti Aminah", "Dr. Lim", "21/06/2026", "10:30 AM", "Completed");

			dgvUpcomingAppointments.Rows.Clear();
			dgvUpcomingAppointments.Rows.Add("A003", "Ali Hassan", "Dr. Tan", "23/06/2026", "02:00 PM", "Upcoming");
			dgvUpcomingAppointments.Rows.Add("A004", "Nur Aina", "Dr. Sarah", "24/06/2026", "11:00 AM", "Upcoming");

			dgvCancellationRequests.Rows.Clear();
			dgvCancellationRequests.Rows.Add("R001", "Aiman Hakim", "Dr. Ahmad", "22/06/2026", "Family emergency", "Pending");
			dgvCancellationRequests.Rows.Add("R002", "Farah", "Dr. Lim", "23/06/2026", "Not feeling well", "Pending");
		}

		private void Refreshbtn_Click(object sender, EventArgs e)
		{
			LoadDashboardData();
			MessageBox.Show("Page refreshed successfully.");
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			LoadDashboardData();
			MessageBox.Show("Cancellation requests refreshed.");
		}

		private void btnApprove_Click(object sender, EventArgs e)
		{
			if (dgvCancellationRequests.SelectedRows.Count > 0)
			{
				dgvCancellationRequests.SelectedRows[0].Cells["colStatus"].Value = "Approved";
				MessageBox.Show("Cancellation approved.");
			}
			else
			{
				MessageBox.Show("Please select a cancellation request first.");
			}
		}

		private void btnReject_Click(object sender, EventArgs e)
		{
			if (dgvCancellationRequests.SelectedRows.Count > 0)
			{
				dgvCancellationRequests.SelectedRows[0].Cells["colStatus"].Value = "Rejected";
				MessageBox.Show("Cancellation rejected.");
			}
			else
			{
				MessageBox.Show("Please select a cancellation request first.");
			}
		}
	}
}