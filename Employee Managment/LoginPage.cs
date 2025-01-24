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
            if(String.IsNullOrEmpty(txt_username.Text))
            {
                MessageBox.Show("Please Enter User Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(String.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Please Enter User Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = txt_username.Text.Trim();
                string password = txt_password.Text.Trim();
                if(username == "adminjdjhr" )
                {
                    if(password == "jdj1234")
                    {
                        AdminDashBoard adminform = new AdminDashBoard();
                        adminform.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please Check Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    String query = "SELECT UserName, Userpwd FROM EmpManager";
                    DatabaseHelper db = new DatabaseHelper();
                    try
                    {
                        DataTable managers = db.ExecuteQuery(query);
                        foreach (DataRow row in managers.Rows)
                        {
                            string dbusername = row["UserName"].ToString();
                            string dbpassword = row["UserPwd"].ToString();

                            if (dbusername == username && dbpassword == password)
                            {
                                EmployeeManagerDashboard empform = new EmployeeManagerDashboard();
                                empform.ShowDialog();
                                this.Close();
                            }

                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Please Check Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                


                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
