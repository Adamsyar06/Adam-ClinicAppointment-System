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
    
    public partial class Register : Form
    {  ClinicManagementSystemContext db = new ClinicManagementSystemContext();
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient patient;
            String Password;
            String Gender;
            String verified;
            verified = Fullnametxt.Text;
            DateOnly Dob = DateOnly.FromDateTime(DOBdatetime.Value);
            if (Malerdio.Checked == true && Femalerdio.Checked == false)
            {
                Gender = Malerdio.Text;
            }
            else
            {
                Gender = Femalerdio.Text;
            }
            if (Passwordtxt.Text == Confirmtxt.Text)
            {

                Password = Passwordtxt.Text;
                patient = new Patient()
                {
                    PatientId = GeneratePatientId(),
                    FullName = Fullnametxt.Text,
                    Gender = Gender,
                    DateOfBirth = Dob,
                    Email = Emailtxt.Text,
                    IcNumber = ICnumbertxt.Text,
                    PhoneNo = Phonenumtxt.Text,
                    Password = Password

                };
                db.Patients.Add(patient);
                db.SaveChanges();
                var check = db.Patients.FirstOrDefault(x => x.PatientId == patient.PatientId);
                
                if (check != null)
                {
                    MessageBox.Show("Patient Created. Please Log in");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Due to some Logical Error, Mr/Mrs { Fullnametxt.Text} data couldn't be inserted into the database");
                }
                
                
            }
            else
            {
                MessageBox.Show("Confirm Password invalid");
            }
     




        }

        private string GeneratePatientId()
        {
            var lastPatient = db.Patients
                .OrderByDescending(p => p.PatientId)
                .FirstOrDefault();

            if (lastPatient == null)
                return "PT0001";

            int number = int.Parse(lastPatient.PatientId.Substring(2));
            number++;

            return $"PT{number + 1:D3}";
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Fullnametxt.Text = string.Empty;
            ICnumbertxt.Text = string.Empty;
            Emailtxt.Text= string.Empty;
            Phonenumtxt.Text = string.Empty;
            Passwordtxt.Text= string.Empty;
            Confirmtxt.Text = string.Empty;
            DOBdatetime.Value = DateTime.Now;
            Malerdio.Checked = false;
            Femalerdio.Checked = false;
        }

        private void DOBdatetime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
