namespace Employee_Managment
{
    partial class EmployeeMangerSallaryManage
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
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            txt_EmpName = new TextBox();
            label3 = new Label();
            txt_EmpNic = new TextBox();
            label4 = new Label();
            txt_EmpBasicSalary = new TextBox();
            label8 = new Label();
            txt_Allowance = new TextBox();
            label9 = new Label();
            txt_salary = new TextBox();
            label10 = new Label();
            btn_calculateSalary = new Button();
            button2 = new Button();
            label5 = new Label();
            cmb_month = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(347, 6);
            label1.Name = "label1";
            label1.Size = new Size(362, 23);
            label1.TabIndex = 0;
            label1.Text = "Employee Sallary Detail Manage Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(43, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 34);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(725, 91);
            button1.Name = "button1";
            button1.Size = new Size(164, 38);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(193, 98);
            label2.Name = "label2";
            label2.Size = new Size(240, 23);
            label2.TabIndex = 3;
            label2.Text = "Enter Employee NIC Number :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(454, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 30);
            textBox1.TabIndex = 4;
            // 
            // txt_EmpName
            // 
            txt_EmpName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_EmpName.Location = new Point(43, 196);
            txt_EmpName.Name = "txt_EmpName";
            txt_EmpName.Size = new Size(247, 30);
            txt_EmpName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 170);
            label3.Name = "label3";
            label3.Size = new Size(144, 23);
            label3.TabIndex = 5;
            label3.Text = "Employee Name :";
            // 
            // txt_EmpNic
            // 
            txt_EmpNic.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_EmpNic.Location = new Point(43, 276);
            txt_EmpNic.Name = "txt_EmpNic";
            txt_EmpNic.Size = new Size(247, 30);
            txt_EmpNic.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 250);
            label4.Name = "label4";
            label4.Size = new Size(127, 23);
            label4.TabIndex = 7;
            label4.Text = "Employee NIC :";
            // 
            // txt_EmpBasicSalary
            // 
            txt_EmpBasicSalary.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_EmpBasicSalary.Location = new Point(43, 358);
            txt_EmpBasicSalary.Name = "txt_EmpBasicSalary";
            txt_EmpBasicSalary.Size = new Size(247, 30);
            txt_EmpBasicSalary.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(43, 332);
            label8.Name = "label8";
            label8.Size = new Size(107, 23);
            label8.TabIndex = 15;
            label8.Text = "Basic Salary :";
            // 
            // txt_Allowance
            // 
            txt_Allowance.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Allowance.Location = new Point(43, 436);
            txt_Allowance.Name = "txt_Allowance";
            txt_Allowance.Size = new Size(247, 30);
            txt_Allowance.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(43, 410);
            label9.Name = "label9";
            label9.Size = new Size(96, 23);
            label9.TabIndex = 17;
            label9.Text = "Allowence :";
            // 
            // txt_salary
            // 
            txt_salary.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_salary.Location = new Point(43, 568);
            txt_salary.Name = "txt_salary";
            txt_salary.Size = new Size(247, 30);
            txt_salary.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(43, 542);
            label10.Name = "label10";
            label10.Size = new Size(64, 23);
            label10.TabIndex = 19;
            label10.Text = "Salary :";
            // 
            // btn_calculateSalary
            // 
            btn_calculateSalary.BackColor = Color.CornflowerBlue;
            btn_calculateSalary.FlatAppearance.BorderSize = 0;
            btn_calculateSalary.FlatStyle = FlatStyle.Flat;
            btn_calculateSalary.ForeColor = Color.Black;
            btn_calculateSalary.Location = new Point(68, 486);
            btn_calculateSalary.Name = "btn_calculateSalary";
            btn_calculateSalary.Size = new Size(164, 38);
            btn_calculateSalary.TabIndex = 21;
            btn_calculateSalary.Text = "calculate ";
            btn_calculateSalary.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(68, 708);
            button2.Name = "button2";
            button2.Size = new Size(164, 38);
            button2.TabIndex = 22;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 622);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 23;
            label5.Text = "Month :";
            // 
            // cmb_month
            // 
            cmb_month.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_month.FormattingEnabled = true;
            cmb_month.Location = new Point(43, 648);
            cmb_month.Name = "cmb_month";
            cmb_month.Size = new Size(247, 31);
            cmb_month.TabIndex = 24;
            // 
            // EmployeeMangerSallaryManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1168, 813);
            Controls.Add(cmb_month);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(btn_calculateSalary);
            Controls.Add(txt_salary);
            Controls.Add(label10);
            Controls.Add(txt_Allowance);
            Controls.Add(label9);
            Controls.Add(txt_EmpBasicSalary);
            Controls.Add(label8);
            Controls.Add(txt_EmpNic);
            Controls.Add(label4);
            Controls.Add(txt_EmpName);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeMangerSallaryManage";
            Text = "EmployeeMangerSallaryManage";
            Load += EmployeeMangerSallaryManage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private TextBox txt_EmpName;
        private Label label3;
        private TextBox txt_EmpNic;
        private Label label4;
        private TextBox txt_EmpBasicSalary;
        private Label label8;
        private TextBox txt_Allowance;
        private Label label9;
        private TextBox txt_salary;
        private Label label10;
        private Button btn_calculateSalary;
        private Button button2;
        private Label label5;
        private ComboBox cmb_month;
    }
}