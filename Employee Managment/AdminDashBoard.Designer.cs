namespace Employee_Managment
{
    partial class AdminDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashBoard));
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            btn_logout = new Button();
            btn_employee_manges = new Button();
            btn_employee_manager = new Button();
            btn_dashboard = new Button();
            AdminChildPanel = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1445, 82);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(770, 19);
            label3.Name = "label3";
            label3.Size = new Size(647, 38);
            label3.TabIndex = 4;
            label3.Text = "Employee Mangemnt System Admin DashBoard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 13);
            label1.Name = "label1";
            label1.Size = new Size(101, 50);
            label1.TabIndex = 2;
            label1.Text = "J D J";
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 823);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(btn_logout);
            panel3.Controls.Add(btn_employee_manges);
            panel3.Controls.Add(btn_employee_manager);
            panel3.Controls.Add(btn_dashboard);
            panel3.Location = new Point(1, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(271, 817);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Location = new Point(267, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1172, 820);
            panel4.TabIndex = 2;
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
            btn_logout.TabIndex = 4;
            btn_logout.Text = "Log Out";
            btn_logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_employee_manges
            // 
            btn_employee_manges.BackColor = Color.Transparent;
            btn_employee_manges.Dock = DockStyle.Top;
            btn_employee_manges.FlatAppearance.BorderSize = 0;
            btn_employee_manges.FlatStyle = FlatStyle.Flat;
            btn_employee_manges.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_employee_manges.ForeColor = Color.Navy;
            btn_employee_manges.Image = (Image)resources.GetObject("btn_employee_manges.Image");
            btn_employee_manges.ImageAlign = ContentAlignment.MiddleLeft;
            btn_employee_manges.Location = new Point(0, 148);
            btn_employee_manges.Name = "btn_employee_manges";
            btn_employee_manges.Padding = new Padding(30, 0, 0, 0);
            btn_employee_manges.Size = new Size(271, 74);
            btn_employee_manges.TabIndex = 3;
            btn_employee_manges.Text = "   Employees Manage";
            btn_employee_manges.TextAlign = ContentAlignment.MiddleLeft;
            btn_employee_manges.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_employee_manges.UseVisualStyleBackColor = false;
            btn_employee_manges.Click += btn_employee_manges_Click;
            // 
            // btn_employee_manager
            // 
            btn_employee_manager.BackColor = Color.Transparent;
            btn_employee_manager.Dock = DockStyle.Top;
            btn_employee_manager.FlatAppearance.BorderSize = 0;
            btn_employee_manager.FlatStyle = FlatStyle.Flat;
            btn_employee_manager.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_employee_manager.ForeColor = Color.Navy;
            btn_employee_manager.Image = (Image)resources.GetObject("btn_employee_manager.Image");
            btn_employee_manager.ImageAlign = ContentAlignment.MiddleLeft;
            btn_employee_manager.Location = new Point(0, 74);
            btn_employee_manager.Name = "btn_employee_manager";
            btn_employee_manager.Padding = new Padding(30, 0, 0, 0);
            btn_employee_manager.Size = new Size(271, 74);
            btn_employee_manager.TabIndex = 1;
            btn_employee_manager.Text = "   Employee Manager";
            btn_employee_manager.TextAlign = ContentAlignment.MiddleLeft;
            btn_employee_manager.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_employee_manager.UseVisualStyleBackColor = false;
            btn_employee_manager.Click += btn_employee_manager_Click;
            // 
            // btn_dashboard
            // 
            btn_dashboard.BackColor = Color.Transparent;
            btn_dashboard.Dock = DockStyle.Top;
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btn_dashboard.ForeColor = Color.Navy;
            btn_dashboard.Image = Properties.Resources.Category;
            btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.Location = new Point(0, 0);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Padding = new Padding(30, 0, 0, 0);
            btn_dashboard.Size = new Size(271, 74);
            btn_dashboard.TabIndex = 0;
            btn_dashboard.Text = "   Home";
            btn_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_dashboard.UseVisualStyleBackColor = false;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // AdminChildPanel
            // 
            AdminChildPanel.BackColor = Color.Brown;
            AdminChildPanel.Location = new Point(275, 83);
            AdminChildPanel.Name = "AdminChildPanel";
            AdminChildPanel.Size = new Size(1162, 814);
            AdminChildPanel.TabIndex = 2;
            // 
            // AdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 900);
            Controls.Add(AdminChildPanel);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashBoard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button btn_dashboard;
        private Button btn_employee_manager;
        private Button btn_logout;
        private Button btn_employee_manges;
        private Panel panel4;
        private Panel AdminChildPanel;
        private Label label3;
    }
}