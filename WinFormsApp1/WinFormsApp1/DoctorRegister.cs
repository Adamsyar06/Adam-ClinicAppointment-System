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
    public partial class DoctorRegister : Form
    {
        ClinicManagementSystemContext db = new ClinicManagementSystemContext();

        public DoctorRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Doctor newDoctor = new Doctor();
                newDoctor.DoctorId = GenerateDoctorId();

                var textBoxes = this.Controls.OfType<TextBox>()
                                    .OrderBy(t => t.Top)
                                    .ToList();

                if (textBoxes.Count >= 4)
                {
                    newDoctor.FullName = textBoxes[0].Text;
                    newDoctor.DepartmentId = textBoxes[1].Text;
                    newDoctor.Email = textBoxes[2].Text;
                    newDoctor.PhoneNo = textBoxes[3].Text;
                }
                else
                {
                    MessageBox.Show("Sila pastikan semua kotak input diisi dengan betul.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.Doctors.Add(newDoctor);
                db.SaveChanges();

                var check = db.Doctors.FirstOrDefault(x => x.DoctorId == newDoctor.DoctorId);

                if (check != null)
                {
                    MessageBox.Show("Doctor Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Due to some Logical Error, data couldn't be inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}\n{ex.InnerException?.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateDoctorId()
        {
            var lastDoctor = db.Doctors
                .OrderByDescending(d => d.DoctorId)
                .FirstOrDefault();

            if (lastDoctor == null)
                return "DR0001";

            if (lastDoctor.DoctorId.Length >= 3 && int.TryParse(lastDoctor.DoctorId.Substring(2), out int number))
            {
                number++;
                return $"DR{number:D4}";
            }

            return "DR0001";
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            foreach (var tb in this.Controls.OfType<TextBox>())
            {
                tb.Text = string.Empty;
            }
        }
    }
}