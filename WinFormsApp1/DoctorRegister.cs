using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Fullnametxt.Text) ||
                string.IsNullOrWhiteSpace(Phonenumtxt.Text) ||
                string.IsNullOrWhiteSpace(Emailtxt.Text) ||
                string.IsNullOrWhiteSpace(Passwordtxt.Text))
            {
                MessageBox.Show("Please fill in all the required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Passwordtxt.Text != Confirmtxt.Text)
            {
                MessageBox.Show("Confirm Password invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=MSI\\ADAMSERVER;Initial Catalog=ClinicManagementSystem;Integrated Security=True;Trust Server Certificate=True";
            string query = "INSERT INTO Doctor (doctor_id, full_name, phone_no, email, password, department_id) VALUES (@DoctorId, @FullName, @PhoneNo, @Email, @Password, @DepartmentId)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", Fullnametxt.Text);
                    cmd.Parameters.AddWithValue("@PhoneNo", Phonenumtxt.Text);
                    cmd.Parameters.AddWithValue("@Email", Emailtxt.Text);
                    cmd.Parameters.AddWithValue("@Password", Passwordtxt.Text);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Doctor Account Created Successfully! Please log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Data could not be inserted into the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database Error: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Fullnametxt.Text = string.Empty;
            Emailtxt.Text = string.Empty;
            Phonenumtxt.Text = string.Empty;
            Passwordtxt.Text = string.Empty;
            Confirmtxt.Text = string.Empty;
        }

        private void Register_Load(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void DOBdatetime_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Femalerdio_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}