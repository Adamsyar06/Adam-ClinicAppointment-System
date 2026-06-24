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
    public partial class RegisterDepartment : Form
    {
        ClinicManagementSystemContext db = new ClinicManagementSystemContext();
        public RegisterDepartment()
        {
            InitializeComponent();
        }

        private string GenerateDepartmentId()
        {
            var Department = db.Departments.OrderByDescending(d => d.DepartmentId)
                .FirstOrDefault();
            if (Department == null)
                return "D0001";

            if (Department.DepartmentId.Length >= 3 && int.TryParse(Department.DepartmentId.Substring(2), out int number))
            {
                number++;
                return $"D{number + 1:D3}";
            }

            return "D0001";


        }

        private void Signinbtn_Click(object sender, EventArgs e)
        {
            AdminConfrmationi confirmation = new AdminConfrmationi();
            if (confirmation.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Admin verification failed.");
                return;
            }

            Department department = new Department() { 
            DepartmentId = GenerateDepartmentId(),
            DepartmentName = Fullnametxt.Text,
            Description = Descriptiontxt.Text
            };

           

            db.Departments.Add(department);
            db.SaveChanges();
           
            var check = db.Departments.FirstOrDefault(x => x.DepartmentId == department.DepartmentId);
            if (check != null)
            {
                MessageBox.Show("Department Established Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Due to some Logical Error, data couldn't be inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
