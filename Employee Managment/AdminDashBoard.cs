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
    public partial class AdminDashBoard : Form
    {
        public AdminDashBoard()
        {
            InitializeComponent();
            LoadChildForm(new AdminHome());
        }

        private void LoadChildForm(Form childForm)
        {

            AdminChildPanel.Controls.Clear();

            childForm.TopLevel = false;
            childForm.TopMost = true;
            childForm.FormBorderStyle = FormBorderStyle.None;

            AdminChildPanel.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;

            childForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            LoadChildForm(new AdminHome());
        }

        private void btn_employee_manager_Click(object sender, EventArgs e)
        {
            LoadChildForm(new AdminEmpMangersManage());
        }

        //private void btn_finance_manger_Click(object sender, EventArgs e)
        //{
        //    LoadChildForm(new AdminFinanceMangersManage());
        //}

        private void btn_employee_manges_Click(object sender, EventArgs e)
        {
            LoadChildForm(new AdminEmployeeMange());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginPage form2 = new LoginPage();
            form2.Show();
            this.Hide();
        }
    }
}
