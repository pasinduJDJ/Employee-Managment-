namespace Employee_Managment
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            metroPanel2 = new MetroFramework.Controls.MetroPanel();
            button2 = new Button();
            label7 = new Label();
            button1 = new Button();
            label6 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            metroPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 277);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 6;
            label2.Text = "Employee";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 239);
            label1.Name = "label1";
            label1.Size = new Size(78, 38);
            label1.TabIndex = 5;
            label1.Text = "J D J";
            // 
            // metroPanel2
            // 
            metroPanel2.BackColor = Color.MidnightBlue;
            metroPanel2.Controls.Add(button2);
            metroPanel2.Controls.Add(label7);
            metroPanel2.Controls.Add(button1);
            metroPanel2.Controls.Add(label6);
            metroPanel2.Controls.Add(label3);
            metroPanel2.CustomBackground = false;
            metroPanel2.HorizontalScrollbar = false;
            metroPanel2.HorizontalScrollbarBarColor = true;
            metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel2.HorizontalScrollbarSize = 10;
            metroPanel2.Location = new Point(279, -1);
            metroPanel2.Name = "metroPanel2";
            metroPanel2.Size = new Size(402, 380);
            metroPanel2.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel2.StyleManager = null;
            metroPanel2.TabIndex = 7;
            metroPanel2.Theme = MetroFramework.MetroThemeStyle.Light;
            metroPanel2.VerticalScrollbar = false;
            metroPanel2.VerticalScrollbarBarColor = true;
            metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            metroPanel2.VerticalScrollbarSize = 10;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(344, 3);
            button2.Name = "button2";
            button2.Size = new Size(55, 29);
            button2.TabIndex = 14;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(12, 172);
            label7.Name = "label7";
            label7.Size = new Size(377, 50);
            label7.TabIndex = 12;
            label7.Text = "If Your Wanna Register This System Please \r\nContac Admin";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(256, 343);
            button1.Name = "button1";
            button1.Size = new Size(67, 36);
            button1.TabIndex = 9;
            button1.Text = "SignIn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(88, 351);
            label6.Name = "label6";
            label6.Size = new Size(173, 20);
            label6.TabIndex = 8;
            label6.Text = "If you Have an Account ?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(141, 78);
            label3.Name = "label3";
            label3.Size = new Size(120, 38);
            label3.TabIndex = 2;
            label3.Text = "Sign Up";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 379);
            panel1.TabIndex = 8;
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 380);
            Controls.Add(panel1);
            Controls.Add(metroPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            metroPanel2.ResumeLayout(false);
            metroPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private Label label7;
        private Button button1;
        private Label label6;
        private Label label3;
        private Panel panel1;
        private Button button2;
    }
}