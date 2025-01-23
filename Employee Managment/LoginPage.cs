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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterPage form1 = new RegisterPage();
            form1.ShowDialog();
            this.Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            EmployeeManagerDashboard form2 = new EmployeeManagerDashboard();
            form2.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
