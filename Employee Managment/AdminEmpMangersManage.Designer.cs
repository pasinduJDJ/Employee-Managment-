namespace Employee_Managment
{
    partial class AdminEmpMangersManage
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
            btn_Clear = new Button();
            label6 = new Label();
            txt_nicNo = new TextBox();
            label1 = new Label();
            btn_delete = new Button();
            txt_username = new TextBox();
            btn_add = new Button();
            label3 = new Label();
            txt_pwd = new TextBox();
            txt_name = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            lbl_mangerCount = new Label();
            label9 = new Label();
            panel4 = new Panel();
            ManagerDGV = new DataGridView();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ManagerDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 243, 255);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btn_Clear);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_nicNo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_pwd);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(43, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 475);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.Gainsboro;
            btn_Clear.FlatAppearance.BorderSize = 0;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.ForeColor = Color.Black;
            btn_Clear.Location = new Point(19, 413);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(309, 44);
            btn_Clear.TabIndex = 23;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 143);
            label6.Name = "label6";
            label6.Size = new Size(115, 23);
            label6.TabIndex = 21;
            label6.Text = "User NIC No :";
            // 
            // txt_nicNo
            // 
            txt_nicNo.Location = new Point(19, 170);
            txt_nicNo.Name = "txt_nicNo";
            txt_nicNo.Size = new Size(309, 27);
            txt_nicNo.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(257, 28);
            label1.TabIndex = 20;
            label1.Text = "Employee Managers Form";
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Maroon;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(183, 360);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(145, 43);
            btn_delete.TabIndex = 19;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(19, 246);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(309, 27);
            txt_username.TabIndex = 15;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Green;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(19, 359);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(144, 44);
            btn_add.TabIndex = 18;
            btn_add.Text = "Submit";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 70);
            label3.Name = "label3";
            label3.Size = new Size(136, 23);
            label3.TabIndex = 12;
            label3.Text = "User Full Name :";
            // 
            // txt_pwd
            // 
            txt_pwd.Location = new Point(19, 318);
            txt_pwd.Name = "txt_pwd";
            txt_pwd.Size = new Size(309, 27);
            txt_pwd.TabIndex = 17;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(19, 97);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(309, 27);
            txt_name.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 291);
            label5.Name = "label5";
            label5.Size = new Size(130, 23);
            label5.TabIndex = 16;
            label5.Text = "User Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 219);
            label4.Name = "label4";
            label4.Size = new Size(104, 23);
            label4.TabIndex = 14;
            label4.Text = "User Name :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(21, 103);
            label7.Name = "label7";
            label7.Size = new Size(195, 17);
            label7.TabIndex = 2;
            label7.Text = "Number Of Employee Mangers \r\n";
            // 
            // lbl_mangerCount
            // 
            lbl_mangerCount.AutoSize = true;
            lbl_mangerCount.BackColor = Color.Transparent;
            lbl_mangerCount.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_mangerCount.ForeColor = Color.Navy;
            lbl_mangerCount.Location = new Point(257, 72);
            lbl_mangerCount.Name = "lbl_mangerCount";
            lbl_mangerCount.Size = new Size(71, 54);
            lbl_mangerCount.TabIndex = 1;
            lbl_mangerCount.Text = "22";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(21, 20);
            label9.Name = "label9";
            label9.Size = new Size(181, 28);
            label9.TabIndex = 0;
            label9.Text = "Employe Mangers";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(235, 243, 255);
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(lbl_mangerCount);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(429, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(362, 139);
            panel4.TabIndex = 13;
            // 
            // ManagerDGV
            // 
            ManagerDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ManagerDGV.BackgroundColor = Color.White;
            ManagerDGV.BorderStyle = BorderStyle.Fixed3D;
            ManagerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ManagerDGV.Location = new Point(43, 541);
            ManagerDGV.Name = "ManagerDGV";
            ManagerDGV.RowHeadersWidth = 51;
            ManagerDGV.Size = new Size(1040, 238);
            ManagerDGV.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.undraw_done_checking_ra6c;
            pictureBox1.Location = new Point(752, 217);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // AdminEmpMangersManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1162, 814);
            Controls.Add(pictureBox1);
            Controls.Add(ManagerDGV);
            Controls.Add(panel1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminEmpMangersManage";
            Text = "AdminEmpMangersManage";
            Load += AdminEmpMangersManage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ManagerDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_delete;
        private TextBox txt_username;
        private Button btn_add;
        private Label label3;
        private TextBox txt_pwd;
        private TextBox txt_name;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label lbl_mangerCount;
        private Label label9;
        private Panel panel4;
        private Label label6;
        private TextBox txt_nicNo;
        private DataGridView ManagerDGV;
        private PictureBox pictureBox1;
        private Button btn_Clear;
    }
}