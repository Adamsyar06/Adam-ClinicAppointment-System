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
    public partial class AdminConfrmationi : Form
    {
        ClinicManagementSystemContext db = new ClinicManagementSystemContext();
        public bool IsVerified { get; private set; }

        public AdminConfrmationi()
        {
            InitializeComponent();
            IsVerified = false;
        }

        private void Verifybtn_Click(object sender, EventArgs e)
        {
            var verify = db.Admins.FirstOrDefault(x => x.Password == Passwordtxt.Text);

            if (verify != null)
            {
                IsVerified = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }

        private void AdminConfrmationi_Load(object sender, EventArgs e)
        {

        }
    }
}
