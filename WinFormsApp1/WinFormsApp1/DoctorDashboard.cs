using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.models;

namespace WinFormsApp1
{

    public partial class DoctorDashboard : Form
    {
        private String _doctorId;
        ClinicManagementSystemContext db = new ClinicManagementSystemContext();
        public DoctorDashboard(string Email)
        {
            InitializeComponent();
            var GetDoctorName = db.Doctors.FirstOrDefault(x => x.Email == Email);
            if (GetDoctorName != null)
            {
                _doctorId = GetDoctorName.DoctorId;
                ShowDoctorlbl.Text = $"Welcome Back {GetDoctorName.FullName}";
            }
            LoadTodayAppointments();

        }

        private void LoadTodayAppointments()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);

            var appointments = db.Appointments
                .Where(x => x.DoctorId == _doctorId
                    && x.AppointmentDate == today
                    && (x.Status == "Approved" || x.Status == "Pending"))
                .Select(x => new
                {
                    Id = x.AppointmentId,
                    Patient = x.Patient.FullName,
                    Time = x.AppointmentTime,
                    Status = x.Status
                })
                .ToList();

            TodayPatientDGV.DataSource = appointments;

            TodayPatientDGV.Columns["Id"].Visible = false;

            if (!TodayPatientDGV.Columns.Contains("CompleteButton"))
            {
                DataGridViewButtonColumn completeBtn =
                    new DataGridViewButtonColumn();

                completeBtn.Name = "CompleteButton";
                completeBtn.HeaderText = "Complete";
                completeBtn.Text = "Complete";
                completeBtn.UseColumnTextForButtonValue = true;

                TodayPatientDGV.Columns.Add(completeBtn);
            }
            if (!TodayPatientDGV.Columns.Contains("CancelButton"))
            {
                DataGridViewButtonColumn cancelBtn =
                    new DataGridViewButtonColumn();

                cancelBtn.Name = "CancelButton";
                cancelBtn.HeaderText = "Cancel";
                cancelBtn.Text = "Cancel";
                cancelBtn.UseColumnTextForButtonValue = true;

                TodayPatientDGV.Columns.Add(cancelBtn);
            }

            TodayPatientDGV.AutoSizeColumnsMode =
                   DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void TodayPatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string appointmentId =
                TodayPatientDGV.Rows[e.RowIndex]
                .Cells["Id"]
                .Value
                .ToString();

            var appointment = db.Appointments
                .FirstOrDefault(x => x.AppointmentId == appointmentId);

            if (appointment == null)
                return;

            if (TodayPatientDGV.Columns[e.ColumnIndex].Name == "CompleteButton")
            {
                appointment.Status = "Completed";

                db.SaveChanges();

                MessageBox.Show("Appointment completed.");
            }

            if (TodayPatientDGV.Columns[e.ColumnIndex].Name == "CancelButton")
            {
                appointment.Status = "Requested";

                db.SaveChanges();

                MessageBox.Show("Appointment returned to requested.");
            }

            LoadTodayAppointments();
            LoadRequestedAppointments();

        }

        private void LoadRequestedAppointments()
        {
            var requests = db.Appointments
        .Where(x => x.DoctorId == _doctorId
            && x.Status == "Requested")
        .Select(x => new
        {
            Id = x.AppointmentId,
            Patient = x.Patient.FullName,
            Date = x.AppointmentDate,
            Time = x.AppointmentTime
        })
        .ToList();

            CancellationRequestDGV.DataSource = requests;
        }

        private void CancellationRequestDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadUpcomingAppointments()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var weekEnd = today.AddDays(7); // inclusive end of the week window

            var upcoming = db.Appointments
                .Where(x => x.DoctorId == _doctorId
                    && x.AppointmentDate > today
                    && x.AppointmentDate <= weekEnd
                    && (x.Status == "Approved" || x.Status == "Pending") )
                .Select(x => new
                {
                    Id = x.AppointmentId,
                    Patient = x.Patient.FullName,
                    Date = x.AppointmentDate,
                    Time = x.AppointmentTime,
                    Status = x.Status
                })
                .ToList();

            ThisWeekPatientDGV.DataSource = upcoming;

            if (ThisWeekPatientDGV.Columns.Contains("Id"))
                ThisWeekPatientDGV.Columns["Id"].Visible = false;

            ThisWeekPatientDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (!ThisWeekPatientDGV.Columns.Contains("CancelButton") && upcoming.Any())
            {
                var cancelBtn = new DataGridViewButtonColumn
                {
                    Name = "CancelButton",
                    HeaderText = "Action",
                    Text = "Cancel",
                    UseColumnTextForButtonValue = true
                };
                ThisWeekPatientDGV.Columns.Add(cancelBtn);
            }
        }

        private void ThisWeekPatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (ThisWeekPatientDGV.Columns[e.ColumnIndex].Name == "CancelButton")
            {
                string appointmentId =
                   ThisWeekPatientDGV.Rows[e.RowIndex]
                    .Cells["Id"]
                    .Value
                    .ToString();

                var appointment = db.Appointments
                    .FirstOrDefault(x => x.AppointmentId == appointmentId);

                if (appointment != null)
                {
                    DialogResult result = MessageBox.Show(
                        "Return this appointment to Requested status?",
                        "Confirm",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        appointment.Status = "Requested";

                        db.SaveChanges();

                        MessageBox.Show("Appointment cancelled.");

                        LoadUpcomingAppointments();
                        LoadRequestedAppointments();
                        LoadTodayAppointments();
                    }

                }
            }
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            LoadTodayAppointments ();
            LoadRequestedAppointments ();
            LoadUpcomingAppointments (); 
        }
    }
}