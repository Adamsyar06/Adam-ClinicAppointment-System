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

            var GetAdminname = db.Admins.FirstOrDefault(x => x.Username == Email && x.Password == Password);
            if (GetAdminname != null)
            {
                label1.Text = $"Welcome Back Admin {GetAdminname.FullName}";
            }
            else
            {
                MessageBox.Show("Admin not found.");
                this.Close();
                return;
            }

            LoadTodayData();
            LoadUpcomingData();
            LoadRequestedCancelAppointment();
            gettotaldoctor();
            getpatienttoday();
            LoadRequestCancel();
        }

        private void gettotaldoctor()
        {
            int totaldoctors = db.Doctors.Count();
            lblTotalDoctorsValue.Text = totaldoctors.ToString();
        }

        private void getpatienttoday()
        {
            int totalPatientsToday = db.Appointments
                              .Where(a => a.AppointmentDate == DateOnly.FromDateTime(DateTime.Today))
                              .Select(a => a.PatientId)
                              .Distinct()
                              .Count();

            lblTotalPatientsValue.Text = totalPatientsToday.ToString();
        }


        private void LoadTodayData()
        {
            dgvTodayAppointments.Columns.Clear();
            dgvTodayAppointments.AutoGenerateColumns = true;

            var today = DateOnly.FromDateTime(DateTime.Today);

            var appointments = db.Appointments.Where(x => x.AppointmentDate == today)
                .Select(x => new
                {
                    Id = x.AppointmentId,
                    Doctor = x.Doctor.FullName,
                    Patient = x.Patient.FullName,
                    Time = x.AppointmentTime,
                    Status = x.Status
                }).ToList();

            dgvTodayAppointments.DataSource = appointments;
            dgvTodayAppointments.Columns["Id"].Visible = false;
            dgvTodayAppointments.AutoSizeColumnsMode =
               DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadUpcomingData()
        {
            dgvUpcomingAppointments.Columns.Clear();
            dgvUpcomingAppointments.AutoGenerateColumns = true;
            var today = DateOnly.FromDateTime(DateTime.Today);
            var appointments = db.Appointments.Where(x => x.AppointmentDate > today)
               .Select(x => new
               {
                   Id = x.AppointmentId,
                   Doctor = x.Doctor.FullName,
                   Patient = x.Patient.FullName,
                   Date = x.AppointmentDate,
                   Time = x.AppointmentTime,
                   Status = x.Status
               }).ToList();

            dgvUpcomingAppointments.DataSource = appointments;
            dgvUpcomingAppointments.Columns["Id"].Visible = false;
            dgvUpcomingAppointments.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadRequestedCancelAppointment()
        {

            //dgvCancellationRequests.Columns.Clear();
            //dgvCancellationRequests.AutoGenerateColumns = true;
            //var today = DateOnly.FromDateTime(DateTime.Today);
            //var appointments = db.Appointments.Where(x => x.AppointmentDate >= today && x.Status == "Requested")
            //    .Select(x => new
            //    {
            //        Id = x.AppointmentId,
            //        Patient = x.Patient.FullName,
            //        Doctor = x.Doctor.FullName,
            //        Date = x.AppointmentDate,
            //        Time = x.AppointmentTime,
            //        Status = x.Status
            //    }).ToList();

            //dgvCancellationRequests.DataSource = appointments;
            //dgvCancellationRequests.Columns["Id"].Visible = false;

            //if (!dgvCancellationRequests.Columns.Contains("ApprovedButton"))
            //{
            //    DataGridViewButtonColumn ApprovedBtn =
            //    new DataGridViewButtonColumn();

            //    ApprovedBtn.Name = "ApprovedButton";
            //    ApprovedBtn.HeaderText = "Approval";
            //    ApprovedBtn.Text = "Approved";
            //    ApprovedBtn.UseColumnTextForButtonValue = true;

            //    dgvCancellationRequests.Columns.Add(ApprovedBtn);
            //}
            //dgvCancellationRequests.AutoSizeColumnsMode =
            //         DataGridViewAutoSizeColumnsMode.Fill;

        }
           
        private void LoadRequestCancel()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var appointments = db.Appointments.Where(x => x.AppointmentDate >= today && x.Status == "Requested")
                .Select(x => new
                {
                    Id = x.AppointmentId,
                    Patient = x.Patient.FullName,
                    Doctor = x.Doctor.FullName,
                    Date = x.AppointmentDate,
                    Time = x.AppointmentTime,
                    Status = x.Status
                }).ToList();

            CancellationRequestDGV.DataSource = appointments;
            CancellationRequestDGV.Columns["Id"].Visible = false;

            if (!CancellationRequestDGV.Columns.Contains("ApprovedButton"))
            {
                DataGridViewButtonColumn ApprovedBtn =
              new DataGridViewButtonColumn();

                ApprovedBtn.Name = "ApprovedButton";
                ApprovedBtn.HeaderText = "Approval";
                ApprovedBtn.Text = "Approved";
                ApprovedBtn.UseColumnTextForButtonValue = true;

                CancellationRequestDGV.Columns.Add(ApprovedBtn);
            }
            CancellationRequestDGV.AutoSizeColumnsMode =
                     DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            LoadTodayData();
            LoadUpcomingData();
            LoadRequestedCancelAppointment();
            LoadRequestCancel();
            gettotaldoctor();
            getpatienttoday();

            MessageBox.Show("Page refreshed successfully.");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Cancellation requests refreshed.");
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorRegister NewDoctor = new DoctorRegister();
            NewDoctor.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterDepartment newDepartment = new RegisterDepartment();
            newDepartment.ShowDialog();
        }

        private void dgvTodayAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUpcomingAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCancellationRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string appointmentId =
                CancellationRequestDGV.Rows[e.RowIndex]
                .Cells["Id"]
                .Value
                .ToString();

            var appointment = db.Appointments
                .FirstOrDefault(x => x.AppointmentId == appointmentId);

            if (appointment == null)
                return;

            if (CancellationRequestDGV.Columns[e.ColumnIndex].Name == "ApprovedButton")
            {
                appointment.Status = "Cancelled";

                db.SaveChanges();

                MessageBox.Show("Appointment Cancelled");
                LoadTodayData();
                LoadUpcomingData();
                LoadRequestCancel();
            }
        }
    }
}