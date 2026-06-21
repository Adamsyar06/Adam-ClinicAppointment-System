using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.models;

namespace WinFormsApp1
{
    public partial class AdminDashboard : Form
    {
        private String AdminId;
        ClinicManagementSystemContext db = new ClinicManagementSystemContext();
        public AdminDashboard(String Email, String Password)
        {
            InitializeComponent();

            var GetAdminname = db.Admins.FirstOrDefault(x=> x.Username == Email && x.Password == Password);
            label1.Text = $"Welcome Back Admin {GetAdminname.FullName}";

            LoadTodayData();
            LoadUpcomingData();
            LoadRequestedCancelAppointment();

        }

       

        private void LoadTodayData()
        {

        }

        private void LoadUpcomingData()
        {

        }

        private void LoadRequestedCancelAppointment()
        {

        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Page refreshed successfully.");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}