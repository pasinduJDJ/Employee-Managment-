namespace Employee_Managment
{
    partial class EmployeeManagerDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagerDashboard));
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btn_logout = new Button();
            btn_mange_atend = new Button();
            btn_manage_Emp = new Button();
            btn_home = new Button();
            PChildPanel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1445, 82);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(996, 21);
            label3.Name = "label3";
            label3.Size = new Size(410, 38);
            label3.TabIndex = 5;
            label3.Text = "Employee Manage DashBoard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 11);
            label1.Name = "label1";
            label1.Size = new Size(101, 50);
            label1.TabIndex = 3;
            label1.Text = "J D J";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btn_logout);
            panel2.Controls.Add(btn_mange_atend);
            panel2.Controls.Add(btn_manage_Emp);
            panel2.Controls.Add(btn_home);
            panel2.Location = new Point(-1, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 817);
            panel2.TabIndex = 1;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Navy;
            btn_logout.Dock = DockStyle.Bottom;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(0, 766);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(271, 51);
            btn_logout.TabIndex = 5;
            btn_logout.Text = "Log Out";
            btn_logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_mange_atend
            // 
            btn_mange_atend.Dock = DockStyle.Top;
            btn_mange_atend.Image = (Image)resources.GetObject("btn_mange_atend.Image");
            btn_mange_atend.ImageAlign = ContentAlignment.MiddleLeft;
            btn_mange_atend.Location = new Point(0, 148);
            btn_mange_atend.Name = "btn_mange_atend";
            btn_mange_atend.Padding = new Padding(30, 0, 0, 0);
            btn_mange_atend.Size = new Size(271, 74);
            btn_mange_atend.TabIndex = 2;
            btn_mange_atend.Text = "      Manage Sallary";
            btn_mange_atend.TextAlign = ContentAlignment.MiddleLeft;
            btn_mange_atend.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_mange_atend.UseVisualStyleBackColor = true;
            btn_mange_atend.Click += btn_mange_atend_Click;
            // 
            // btn_manage_Emp
            // 
            btn_manage_Emp.Dock = DockStyle.Top;
            btn_manage_Emp.Image = Properties.Resources.Profile;
            btn_manage_Emp.ImageAlign = ContentAlignment.MiddleLeft;
            btn_manage_Emp.Location = new Point(0, 74);
            btn_manage_Emp.Name = "btn_manage_Emp";
            btn_manage_Emp.Padding = new Padding(30, 0, 0, 0);
            btn_manage_Emp.Size = new Size(271, 74);
            btn_manage_Emp.TabIndex = 1;
            btn_manage_Emp.Text = "      Manage Employee";
            btn_manage_Emp.TextAlign = ContentAlignment.MiddleLeft;
            btn_manage_Emp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_manage_Emp.UseVisualStyleBackColor = true;
            btn_manage_Emp.Click += btn_manage_Emp_Click;
            // 
            // btn_home
            // 
            btn_home.Dock = DockStyle.Top;
            btn_home.Image = Properties.Resources.Category1;
            btn_home.ImageAlign = ContentAlignment.MiddleLeft;
            btn_home.Location = new Point(0, 0);
            btn_home.Name = "btn_home";
            btn_home.Padding = new Padding(30, 0, 0, 0);
            btn_home.Size = new Size(271, 74);
            btn_home.TabIndex = 0;
            btn_home.Text = "      Home";
            btn_home.TextAlign = ContentAlignment.MiddleLeft;
            btn_home.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click;
            // 
            // PChildPanel
            // 
            PChildPanel.BackColor = Color.Brown;
            PChildPanel.Location = new Point(276, 87);
            PChildPanel.Name = "PChildPanel";
            PChildPanel.Size = new Size(1168, 813);
            PChildPanel.TabIndex = 2;
            // 
            // EmployeeManagerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 900);
            Controls.Add(PChildPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeManagerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeManagerDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private Button btn_home;
        private Button btn_mange_atend;
        private Button btn_manage_Emp;
        private Button btn_logout;
        private Panel PChildPanel;
    }
}