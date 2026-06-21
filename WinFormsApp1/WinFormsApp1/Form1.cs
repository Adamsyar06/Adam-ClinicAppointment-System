using WinFormsApp1.models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ClinicManagementSystemContext db = new ClinicManagementSystemContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            String GetEmail, GetPassword;
            Patient patient = new Patient()
            {
                IcNumber = Validtxt.Text,
                Password = Passwordtxt.Text,
                Email = Validtxt.Text,
            };

            Doctor doctor = new Doctor()
            {

                Email = Validtxt.Text
            };

            Admin admin = new Admin()
            {
                Username = Validtxt.Text,
                Password = Passwordtxt.Text
            };
            GetEmail = Validtxt.Text;
            GetPassword = Passwordtxt.Text;

            var patientLogin = db.Patients.FirstOrDefault(p => (p.Email == patient.Email || p.IcNumber == patient.IcNumber) && p.Password == patient.Password);
            var doctorLogin = db.Doctors.FirstOrDefault(d => d.Email == doctor.Email);
            var adminLogin = db.Admins.FirstOrDefault(a => a.Username == admin.Username && a.Password == admin.Password);

            if (patientLogin != null)
            {
                MessageBox.Show("Patient login successful!");
                PatientDashboard patientDash = new PatientDashboard(GetEmail, GetPassword);
                this.Hide();
                patientDash.ShowDialog();
                this.Show();
         

            }
            else if (doctorLogin != null)
            {
                MessageBox.Show("Doctor login successful!");
                DoctorDashboard doctorDash = new DoctorDashboard(GetEmail);
                this.Hide();
                doctorDash.ShowDialog();
                this.Show();
                //redirect to doctor dashboard
            }
            else if (adminLogin != null)
            {
                MessageBox.Show("Admin login successful!");
                AdminDashboard admins = new AdminDashboard(GetEmail, GetPassword);
                this.Hide();
                admins.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Login Failed. Please try again.");
            }
        }

        private void Validtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            Register registerform = new Register();
            this.Hide();
            registerform.ShowDialog();
            this.Show();

        }

        private void passwordchckbx_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordchckbx.Checked) { 
            Passwordtxt.UseSystemPasswordChar = false;
            
            }
            else
            {
                Passwordtxt.UseSystemPasswordChar=true;
            }
        }
    }
}
