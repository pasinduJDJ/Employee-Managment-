namespace Employee_Managment
{
    partial class AdminEmployeeMange
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
            label10 = new Label();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(457, 4);
            label10.Name = "label10";
            label10.Size = new Size(148, 23);
            label10.TabIndex = 0;
            label10.Text = "Employee Details";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(label10);
            panel2.Location = new Point(40, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1085, 34);
            panel2.TabIndex = 17;
            // 
            // AdminEmployeeMange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 241, 255);
            ClientSize = new Size(1162, 814);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminEmployeeMange";
            Text = "AdminEmployeeMange";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label10;
        private Panel panel2;
    }
}