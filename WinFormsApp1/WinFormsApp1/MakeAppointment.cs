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
    public partial class MakeAppointment : Form
    {
        private String _patientid;
        ClinicManagementSystemContext db = new ClinicManagementSystemContext();
        public MakeAppointment(String Id)
        {
            InitializeComponent();
            _patientid = Id;
            LoadDoctors();
            SetupTimePicker();
            SetupDatePicker();
        }

        private void LoadDoctors()
        {
            var doctors = db.Doctors.Select(d => new
            {
                d.DoctorId,
                d.FullName,
                DisplayName = d.FullName
            }).ToList();

            DoctorCombo.DataSource = doctors;
            DoctorCombo.DisplayMember = "DisplayName";
            DoctorCombo.ValueMember = "DoctorId";
            DoctorCombo.SelectedIndex = -1;
        }

        private void SetupTimePicker()
        {
            TimeDTP.Format = DateTimePickerFormat.Time;
            TimeDTP.ShowUpDown = true;
        }

        private void SetupDatePicker()
        {
            DateDTP.Format = DateTimePickerFormat.Short;
            DateDTP.MinDate = DateTime.Today;
        }

        private String GenerateAppointmentId()
        {
            var lastAppointment = db.Appointments
                .OrderByDescending(a => a.AppointmentId)
                .FirstOrDefault();

            if (lastAppointment == null)
            {
                return "AP0001";
            }
            int lastNumber = int.Parse(lastAppointment.AppointmentId.Substring(2));
            int newNumber = lastNumber + 1;
            return $"AP{newNumber:D4}";
        }

        private void DoctorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MakeAppbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void MakeAppbtn_Click_1(object sender, EventArgs e)
        {
            if (DoctorCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a doctor.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Appointment appointment = new Appointment()
                {
                    AppointmentId = GenerateAppointmentId(),
                    PatientId = _patientid,
                    DoctorId = DoctorCombo.SelectedValue.ToString(),
                    AppointmentDate = DateOnly.FromDateTime(DateDTP.Value),
                    AppointmentTime = TimeOnly.FromDateTime(TimeDTP.Value),
                    Status = "Pending"
                };

                db.Appointments.Add(appointment);
                db.SaveChanges();
                MessageBox.Show($"Appointment booked successfully!\nAppointment ID: {appointment.AppointmentId}",
                              "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error booking appointment: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
