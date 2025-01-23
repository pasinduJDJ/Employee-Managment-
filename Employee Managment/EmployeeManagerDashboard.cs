using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Managment
{
    public partial class EmployeeManagerDashboard : Form
    {
        public EmployeeManagerDashboard()
        {
            InitializeComponent();
            LoadChildForm(new EmployeeManagerHome());
        }
        private void LoadChildForm(Form childForm)
        {

            PChildPanel.Controls.Clear();

            childForm.TopLevel = false;
            childForm.TopMost = true;
            childForm.FormBorderStyle = FormBorderStyle.None;

            PChildPanel.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;

            childForm.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            LoadChildForm(new EmployeeManagerHome());
        }

        private void btn_manage_Emp_Click(object sender, EventArgs e)
        {
            LoadChildForm(new EmployeeMangerEmpDetails());
        }

        private void btn_mange_atend_Click(object sender, EventArgs e)
        {
            LoadChildForm(new EmployeeMangerSallaryManage());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginPage form2 = new LoginPage();
            form2.Show();
            this.Hide();
        }
    }
}
