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
    public partial class TestDashBoard : Form
    {
        public TestDashBoard()
        {
            InitializeComponent();
            LoadChildForm(new TestDefaultHome());
        }
        public void loadform(object Form)
        {

        }

        private void TestDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void LoadChildForm(Form childForm)
        {
            // Clear any existing controls in the panel
            pChildForm.Controls.Clear();

            // Configure the child form
            childForm.TopLevel = false;
            childForm.TopMost = true;
            childForm.FormBorderStyle = FormBorderStyle.None;

            // Add the child form to the panel
            pChildForm.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;

            // Show the child form
            childForm.Show();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            LoadChildForm(new TestChildDashboard());

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            LoadChildForm(new TestChildHome());
        }

        private void pChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
