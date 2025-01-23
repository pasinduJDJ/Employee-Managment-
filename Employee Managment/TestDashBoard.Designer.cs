namespace Employee_Managment
{
    partial class TestDashBoard
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
            panel1 = new Panel();
            btn_home = new Button();
            btn_dashboard = new Button();
            panel2 = new Panel();
            pChildForm = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btn_home);
            panel1.Controls.Add(btn_dashboard);
            panel1.Location = new Point(1, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 337);
            panel1.TabIndex = 0;
            // 
            // btn_home
            // 
            btn_home.Location = new Point(-1, 99);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(250, 45);
            btn_home.TabIndex = 1;
            btn_home.Text = "Home";
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Location = new Point(-1, 48);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(250, 45);
            btn_dashboard.TabIndex = 0;
            btn_dashboard.Text = "DashBoard";
            btn_dashboard.UseVisualStyleBackColor = true;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Location = new Point(1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(797, 119);
            panel2.TabIndex = 1;
            // 
            // pChildForm
            // 
            pChildForm.Location = new Point(257, 124);
            pChildForm.Name = "pChildForm";
            pChildForm.Size = new Size(541, 328);
            pChildForm.TabIndex = 2;
            pChildForm.Paint += pChildForm_Paint;
            // 
            // TestDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pChildForm);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TestDashBoard";
            Text = "TestDashBoard";
            Load += TestDashBoard_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_home;
        private Button btn_dashboard;
        private Panel panel2;
        private Panel pChildForm;
    }
}