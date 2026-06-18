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
    public partial class PatientDashboard : Form
    {
        private String _patientid;
        ClinicManagementSystemContext db = new ClinicManagementSystemContext();
        public PatientDashboard(string email, string password)
        {

            InitializeComponent();

            var patientnames = db.Patients.FirstOrDefault(x => x.Email == email && x.Password == password);
            if (patientnames != null)
            {
                _patientid = patientnames.PatientId;
                String Gender = "";
                if (patientnames.Gender == "Male")
                {
                    Gender = "Mr";
                }


                else if (patientnames.Gender == "Female")
                {
                    Gender = "Mrs";
                }

                PatientNamelbl.Text = $"Welcome Back {Gender} {patientnames.FullName}";
                LoadPastAppointment();
                LoadCurrentAppointment();
            }

        }

        private void PatientNamelbl_Click(object sender, EventArgs e)
        {

        }

        private void CurrentAppointmentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == CurrentAppointmentDGV.Columns["CancelButton"].Index && e.RowIndex >= 0)
            {
                // Get the appointment ID from the hidden column
                string appointmentId = CurrentAppointmentDGV.Rows[e.RowIndex].Cells["Id"].Value.ToString();



                // Show confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to cancel this appointment?",
                                                      "Confirm Cancellation",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                 
                    try
                    {
                        // Find and update the appointment
                        var appointment = db.Appointments.FirstOrDefault(x => x.AppointmentId ==  appointmentId);
                        if (appointment != null)
                        {
                            appointment.Status = "Cancelled";
                            db.SaveChanges();

                            MessageBox.Show("Appointment cancelled successfully!", "Success",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh both grids
                            LoadCurrentAppointment();
                            LoadPastAppointment();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error cancelling appointment: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void PastAppointmentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadPastAppointment()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var appointment = db.Appointments.Where(x => x.PatientId == _patientid && (x.Status == "Completed" || x.Status == "Cancelled" || x.AppointmentDate < today ) )
                .Select(x => new
                {
                    Date = x.AppointmentDate,
                    Time = x.AppointmentTime,
                    Doctor = x.Doctor.FullName,
                    Status = x.Status
                })
                .ToList();
            PastAppointmentDGV.DataSource = appointment;
            PastAppointmentDGV.AutoGenerateColumns = true;
            PastAppointmentDGV.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void LoadCurrentAppointment()
        {

            
            var curappointment = db.Appointments.Where(x => x.PatientId == _patientid && (x.Status == "Pending" || x.Status == "Approved"))
                .Select(x => new
                {
                    Id = x.AppointmentId,
                    Date = x.AppointmentDate,
                    Time = x.AppointmentTime,
                    Doctor = x.Doctor.FullName,
                    Status = x.Status
                }).ToList();


            CurrentAppointmentDGV.DataSource = curappointment;

            CurrentAppointmentDGV.Columns["Id"].Visible = false;
            CurrentAppointmentDGV.AutoGenerateColumns = true;
            CurrentAppointmentDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (CurrentAppointmentDGV.Columns["CancelButton"] == null && curappointment.Any())
            {
                DataGridViewButtonColumn cancelButton = new DataGridViewButtonColumn();
                cancelButton.Text = "Cancel";
                cancelButton.HeaderText = "Action";
                cancelButton.Name = "CancelButton";
                cancelButton.UseColumnTextForButtonValue = true;
                CurrentAppointmentDGV.Columns.Add(cancelButton);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeAppointment makeappoint = new MakeAppointment(_patientid);
            makeappoint.ShowDialog();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            LoadCurrentAppointment();
            LoadPastAppointment();
        }
    }
}
