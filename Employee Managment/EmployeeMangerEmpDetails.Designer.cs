namespace Employee_Managment
{
    partial class EmployeeMangerEmpDetails
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
            label1 = new Label();
            panel2 = new Panel();
            txt_Empsalary = new TextBox();
            label8 = new Label();
            btn_delete = new Button();
            btn_add = new Button();
            txt_FamilyMobileNumber = new TextBox();
            label7 = new Label();
            txt_EmpAddress = new TextBox();
            label6 = new Label();
            txt_EmpAge = new TextBox();
            label5 = new Label();
            txt_EmpNo = new TextBox();
            label4 = new Label();
            txt_EmpNic = new TextBox();
            label3 = new Label();
            txt_EmpName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(36, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 34);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(381, 4);
            label1.Name = "label1";
            label1.Size = new Size(302, 23);
            label1.TabIndex = 0;
            label1.Text = "Employee Detail Manage Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(235, 243, 255);
            panel2.Controls.Add(txt_Empsalary);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btn_delete);
            panel2.Controls.Add(btn_add);
            panel2.Controls.Add(txt_FamilyMobileNumber);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_EmpAddress);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_EmpAge);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txt_EmpNo);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_EmpNic);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_EmpName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(77, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(995, 259);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // txt_Empsalary
            // 
            txt_Empsalary.Location = new Point(685, 56);
            txt_Empsalary.Name = "txt_Empsalary";
            txt_Empsalary.Size = new Size(264, 27);
            txt_Empsalary.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(685, 33);
            label8.Name = "label8";
            label8.Size = new Size(130, 20);
            label8.TabIndex = 14;
            label8.Text = "Employee Sallary :";
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(192, 0, 0);
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(685, 190);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(276, 39);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Green;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(685, 134);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(276, 41);
            btn_add.TabIndex = 12;
            btn_add.Text = "Submit";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // txt_FamilyMobileNumber
            // 
            txt_FamilyMobileNumber.Location = new Point(353, 190);
            txt_FamilyMobileNumber.Name = "txt_FamilyMobileNumber";
            txt_FamilyMobileNumber.Size = new Size(264, 27);
            txt_FamilyMobileNumber.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(353, 167);
            label7.Name = "label7";
            label7.Size = new Size(193, 20);
            label7.TabIndex = 10;
            label7.Text = "Family Member Mobile No :";
            // 
            // txt_EmpAddress
            // 
            txt_EmpAddress.Location = new Point(353, 124);
            txt_EmpAddress.Name = "txt_EmpAddress";
            txt_EmpAddress.Size = new Size(264, 27);
            txt_EmpAddress.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(353, 101);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 8;
            label6.Text = "Employee Address :";
            // 
            // txt_EmpAge
            // 
            txt_EmpAge.Location = new Point(353, 56);
            txt_EmpAge.Name = "txt_EmpAge";
            txt_EmpAge.Size = new Size(264, 27);
            txt_EmpAge.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(353, 33);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 6;
            label5.Text = "Employee Age :";
            // 
            // txt_EmpNo
            // 
            txt_EmpNo.Location = new Point(26, 190);
            txt_EmpNo.Name = "txt_EmpNo";
            txt_EmpNo.Size = new Size(264, 27);
            txt_EmpNo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 167);
            label4.Name = "label4";
            label4.Size = new Size(191, 20);
            label4.TabIndex = 4;
            label4.Text = "Employee Mobile Number :";
            // 
            // txt_EmpNic
            // 
            txt_EmpNic.Location = new Point(26, 124);
            txt_EmpNic.Name = "txt_EmpNic";
            txt_EmpNic.Size = new Size(264, 27);
            txt_EmpNic.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 101);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Employee NIC :";
            label3.Click += label3_Click;
            // 
            // txt_EmpName
            // 
            txt_EmpName.Location = new Point(26, 56);
            txt_EmpName.Name = "txt_EmpName";
            txt_EmpName.Size = new Size(264, 27);
            txt_EmpName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 33);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 0;
            label2.Text = "Employee Name :";
            // 
            // EmployeeMangerEmpDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1168, 813);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeMangerEmpDetails";
            Text = "EmployeeMangerEmpDetails";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox txt_EmpNic;
        private Label label3;
        private TextBox txt_EmpName;
        private Label label2;
        private TextBox txt_EmpAddress;
        private Label label6;
        private TextBox txt_EmpAge;
        private Label label5;
        private TextBox txt_EmpNo;
        private Label label4;
        private TextBox txt_FamilyMobileNumber;
        private Label label7;
        private Button btn_add;
        private Button btn_delete;
        private TextBox txt_Empsalary;
        private Label label8;
    }
}