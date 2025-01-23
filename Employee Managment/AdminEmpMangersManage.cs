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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Employee_Managment
{
    public partial class AdminEmpMangersManage : Form
    {

        public AdminEmpMangersManage()
        {
            InitializeComponent();
            ManagerDGV.CellContentClick += ManagerDGV_CellContentClick;
            displayMangers();
            CountColumns();
        }

        private void AdminEmpMangersManage_Load(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            txt_name.Text = "";
            txt_nicNo.Text = "";
            txt_username.Text = "";
            txt_pwd.Text = "";

        }

        private void CountColumns()
        {
            string query = $"SELECT COUNT(*) FROM EmpManager ";
            DatabaseHelper db = new DatabaseHelper();
            int countMangers = Convert.ToInt32(db.ExecuteScalar(query));
            lbl_mangerCount.Text = countMangers.ToString();
        }

        private bool IsNICRegistered(string nicNo)
        {
            string query = $"SELECT COUNT(*) FROM EmpManager WHERE ManagerNic = '{nicNo}'";
            DatabaseHelper db = new DatabaseHelper();

            try
            {
                int count = Convert.ToInt32(db.ExecuteScalar(query));
                return count > 0; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string oldNicPattern = @"^[0-9]{9}[vVxX]$";
            string newNicPattern = @"^[0-9]{7}[0][0-9]{4}$";

            if (string.IsNullOrEmpty(txt_name.Text))
            {
                MessageBox.Show("Please Enter Manager Full Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_nicNo.Text))
            {
                MessageBox.Show("Please Enter Manager NIC number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(txt_nicNo.Text, oldNicPattern) && !Regex.IsMatch(txt_nicNo.Text, newNicPattern))
            {
                MessageBox.Show("Invalid NIC number. Please enter a valid NIC number (old or new format).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_username.Text))
            {
                MessageBox.Show("Please Enter Manger System Login User name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_username.Text.Length < 4)
            {
                MessageBox.Show("The username must be at least 5 characters  .", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_username.Text.Length > 10)
            {
                MessageBox.Show("The username must be a maximum 10 characters  .", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_pwd.Text))
            {
                MessageBox.Show("Please Enter Manger System Login Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_pwd.Text.Length < 4)
            {
                MessageBox.Show("The Password must be at least 5 characters  .", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_pwd.Text.Length > 10)
            {
                MessageBox.Show("The Password must be a maximum 10 characters  .", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = txt_name.Text.Trim();
                string nicNo = txt_nicNo.Text.Trim();
                string username = txt_username.Text.Trim();
                string password = txt_pwd.Text.Trim();

                bool isRegistered = IsNICRegistered(nicNo);

                try
                {
                    DatabaseHelper db = new DatabaseHelper();
                    if (isRegistered)
                    {
                        string updateQuery = $"UPDATE EmpManager SET ManagerName = '{name}', UserName = '{username}', UserPwd = '{password}' WHERE ManagerNic = '{nicNo}'";
                        db.ExecuteNonQuery(updateQuery);

                        MessageBox.Show("Manager details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string insertQuery = $"INSERT INTO EmpManager (ManagerName, ManagerNic, UserName, UserPwd) VALUES ('{name}', '{nicNo}', '{username}', '{password}')";
                        db.ExecuteNonQuery(insertQuery);

                        MessageBox.Show("New manager registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    displayMangers();
                    CountColumns();
                    clear();
                }
                catch
                {

                }
            }
        }


        private void displayMangers()
        {
            string query = "SELECT * FROM EmpManager";
            DatabaseHelper db = new DatabaseHelper();

            try
            {
                DataTable data = db.ExecuteQuery(query);
                ManagerDGV.DataSource = data;

                DataGridViewButtonColumn actionButtonColumn = new DataGridViewButtonColumn();
                actionButtonColumn.Name = "ActionButton";
                actionButtonColumn.HeaderText = "Action";
                actionButtonColumn.Text = "Click";
                actionButtonColumn.UseColumnTextForButtonValue = true;
                ManagerDGV.Columns.Add(actionButtonColumn);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManagerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && ManagerDGV.Columns["ActionButton"] != null &&
                e.ColumnIndex == ManagerDGV.Columns["ActionButton"].Index)
            {
                DataGridViewRow row = ManagerDGV.Rows[e.RowIndex];

                txt_name.Text = row.Cells["ManagerName"].Value?.ToString() ?? string.Empty;
                txt_nicNo.Text = row.Cells["ManagerNic"].Value?.ToString() ?? string.Empty;
                txt_username.Text = row.Cells["UserName"].Value?.ToString() ?? string.Empty;
                txt_pwd.Text = row.Cells["UserPwd"].Value?.ToString() ?? string.Empty;
            }
            else
            {
                MessageBox.Show("Invalid cell clicked or ActionButton column not found.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string nicNo = txt_nicNo.Text;
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the record with NIC: {nicNo}?","Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = $"DELETE FROM EmpManager WHERE ManagerNic = '{nicNo}'";
                    DatabaseHelper db = new DatabaseHelper();
                    db.ExecuteNonQuery(query);
                    CountColumns();
                    displayMangers();

                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clear();
            }
        }
    }
}
