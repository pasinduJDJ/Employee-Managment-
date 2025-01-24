namespace Employee_Managment
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            metroPanel2 = new MetroFramework.Controls.MetroPanel();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            btn_submit = new Button();
            txt_password = new TextBox();
            label5 = new Label();
            txt_username = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            metroPanel1.SuspendLayout();
            metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // metroPanel1
            // 
            metroPanel1.BackColor = Color.White;
            metroPanel1.Controls.Add(metroPanel2);
            metroPanel1.Controls.Add(label2);
            metroPanel1.Controls.Add(label1);
            metroPanel1.Controls.Add(pictureBox1);
            metroPanel1.CustomBackground = false;
            metroPanel1.HorizontalScrollbar = false;
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(-1, 0);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(680, 380);
            metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel1.StyleManager = null;
            metroPanel1.TabIndex = 0;
            metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroPanel1.VerticalScrollbar = false;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            metroPanel2.BackColor = Color.MidnightBlue;
            metroPanel2.Controls.Add(button2);
            metroPanel2.Controls.Add(button1);
            metroPanel2.Controls.Add(label6);
            metroPanel2.Controls.Add(btn_submit);
            metroPanel2.Controls.Add(txt_password);
            metroPanel2.Controls.Add(label5);
            metroPanel2.Controls.Add(txt_username);
            metroPanel2.Controls.Add(label4);
            metroPanel2.Controls.Add(label3);
            metroPanel2.CustomBackground = false;
            metroPanel2.HorizontalScrollbar = false;
            metroPanel2.HorizontalScrollbarBarColor = true;
            metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel2.HorizontalScrollbarSize = 10;
            metroPanel2.Location = new Point(278, 0);
            metroPanel2.Name = "metroPanel2";
            metroPanel2.Size = new Size(402, 380);
            metroPanel2.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel2.StyleManager = null;
            metroPanel2.TabIndex = 1;
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
            button2.TabIndex = 10;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(232, 343);
            button1.Name = "button1";
            button1.Size = new Size(67, 36);
            button1.TabIndex = 9;
            button1.Text = "SignUp";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(64, 351);
            label6.Name = "label6";
            label6.Size = new Size(162, 20);
            label6.TabIndex = 8;
            label6.Text = "If you wanna Register ?";
            // 
            // btn_submit
            // 
            btn_submit.BackColor = Color.Navy;
            btn_submit.ForeColor = Color.White;
            btn_submit.Location = new Point(119, 263);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(141, 35);
            btn_submit.TabIndex = 7;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = false;
            btn_submit.Click += btn_submit_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(74, 212);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(263, 27);
            txt_password.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(74, 189);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 5;
            label5.Text = "Password :";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(74, 147);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(263, 27);
            txt_username.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(74, 124);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "Username  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(151, 45);
            label3.Name = "label3";
            label3.Size = new Size(109, 38);
            label3.TabIndex = 2;
            label3.Text = "Sign In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 277);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "Employee";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 239);
            label1.Name = "label1";
            label1.Size = new Size(78, 38);
            label1.TabIndex = 3;
            label1.Text = "J D J";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 380);
            Controls.Add(metroPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
            metroPanel2.ResumeLayout(false);
            metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txt_password;
        private Label label5;
        private TextBox txt_username;
        private Label label4;
        private Label label3;
        private Button btn_submit;
        private Button button1;
        private Label label6;
        private Button button2;
    }
}