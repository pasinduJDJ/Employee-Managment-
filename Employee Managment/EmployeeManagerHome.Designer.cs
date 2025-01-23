namespace Employee_Managment
{
    partial class EmployeeManagerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagerHome));
            pictureBox1 = new PictureBox();
            monthCalendar1 = new MonthCalendar();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Frame_368__1_;
            pictureBox1.Location = new Point(94, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(970, 149);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.Highlight;
            monthCalendar1.Location = new Point(94, 247);
            monthCalendar1.MaxDate = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            monthCalendar1.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.TitleBackColor = SystemColors.GradientActiveCaption;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 253, 249);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(402, 247);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 179);
            panel3.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(278, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(22, 119);
            label3.Name = "label3";
            label3.Size = new Size(145, 34);
            label3.TabIndex = 2;
            label3.Text = "Number Of Employees \r\nCuurently Work in Shop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 190, 166);
            label2.Location = new Point(243, 109);
            label2.Name = "label2";
            label2.Size = new Size(71, 54);
            label2.TabIndex = 1;
            label2.Text = "22";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 190, 166);
            label4.Location = new Point(21, 20);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 0;
            label4.Text = "Employess";
            // 
            // EmployeeManagerHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1168, 813);
            Controls.Add(panel3);
            Controls.Add(monthCalendar1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeManagerHome";
            Text = "EmployeeManagerHome";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private MonthCalendar monthCalendar1;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}