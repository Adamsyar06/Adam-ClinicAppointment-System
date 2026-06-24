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
    public partial class ViewDoctor : Form
    {
        ClinicManagementSystemContext db = new ClinicManagementSystemContext(); 
        public ViewDoctor()
        {
            InitializeComponent();
            LoadViewDoctor();
        }

        public void LoadViewDoctor()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);

            var doctorStats = db.Doctors
        .Select(d => new
        {
           Id= d.DoctorId,
           Doctor=d.FullName,
            Department = d.Department.DepartmentName,
            TotalAppointments = d.Appointments.Count(),

             TodayAppointments = d.Appointments
                .Count(a => a.AppointmentDate == today),

            TodayPatients = d.Appointments
                .Where(a => a.AppointmentDate == today)
                .Select(a => a.PatientId)
                .Distinct()
                .Count()
        })
        .ToList();

        ViewDoctordgv.DataSource = doctorStats;
        ViewDoctordgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
