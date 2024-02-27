namespace QuizManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wrongLabel = new System.Windows.Forms.Label();
            this.txtUserName = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.btnLogin = new Guna.UI.WinForms.GunaButton();
            this.checkBoxShowHide = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEnrollmentNo = new Guna.UI.WinForms.GunaTextBox();
            this.btnStudentRegister = new Guna.UI.WinForms.GunaButton();
            this.btnStudentLogin = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(408, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz Mannagement System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(521, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Login";
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.Empty;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1181, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(51, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teacher Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(144, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // wrongLabel
            // 
            this.wrongLabel.AutoSize = true;
            this.wrongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongLabel.ForeColor = System.Drawing.Color.Red;
            this.wrongLabel.Location = new System.Drawing.Point(85, 378);
            this.wrongLabel.Name = "wrongLabel";
            this.wrongLabel.Size = new System.Drawing.Size(212, 16);
            this.wrongLabel.TabIndex = 3;
            this.wrongLabel.Text = "Wrong UserName \"OR\" Password";
            this.wrongLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BaseColor = System.Drawing.Color.White;
            this.txtUserName.BorderColor = System.Drawing.Color.Silver;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUserName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUserName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(28, 116);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(334, 36);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(28, 210);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(334, 36);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BaseColor = System.Drawing.Color.LimeGreen;
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = null;
            this.btnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin.Location = new System.Drawing.Point(28, 294);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.LimeGreen;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogin.Size = new System.Drawing.Size(334, 36);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // checkBoxShowHide
            // 
            this.checkBoxShowHide.AutoSize = true;
            this.checkBoxShowHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowHide.Location = new System.Drawing.Point(133, 260);
            this.checkBoxShowHide.Name = "checkBoxShowHide";
            this.checkBoxShowHide.Size = new System.Drawing.Size(114, 19);
            this.checkBoxShowHide.TabIndex = 7;
            this.checkBoxShowHide.Text = "Show Password";
            this.checkBoxShowHide.UseVisualStyleBackColor = true;
            this.checkBoxShowHide.CheckedChanged += new System.EventHandler(this.checkBoxShowHide_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStudentLogin);
            this.panel2.Controls.Add(this.btnStudentRegister);
            this.panel2.Controls.Add(this.txtEnrollmentNo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(414, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 410);
            this.panel2.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(124, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Student Login";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(98, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Student Enrollement No";
            // 
            // txtEnrollmentNo
            // 
            this.txtEnrollmentNo.BaseColor = System.Drawing.Color.White;
            this.txtEnrollmentNo.BorderColor = System.Drawing.Color.Silver;
            this.txtEnrollmentNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnrollmentNo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEnrollmentNo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEnrollmentNo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEnrollmentNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrollmentNo.ForeColor = System.Drawing.Color.Black;
            this.txtEnrollmentNo.Location = new System.Drawing.Point(28, 137);
            this.txtEnrollmentNo.Name = "txtEnrollmentNo";
            this.txtEnrollmentNo.PasswordChar = '\0';
            this.txtEnrollmentNo.SelectedText = "";
            this.txtEnrollmentNo.Size = new System.Drawing.Size(334, 36);
            this.txtEnrollmentNo.TabIndex = 4;
            this.txtEnrollmentNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStudentRegister
            // 
            this.btnStudentRegister.AnimationHoverSpeed = 0.07F;
            this.btnStudentRegister.AnimationSpeed = 0.03F;
            this.btnStudentRegister.BaseColor = System.Drawing.Color.LimeGreen;
            this.btnStudentRegister.BorderColor = System.Drawing.Color.Black;
            this.btnStudentRegister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStudentRegister.FocusedColor = System.Drawing.Color.Empty;
            this.btnStudentRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentRegister.ForeColor = System.Drawing.Color.White;
            this.btnStudentRegister.Image = null;
            this.btnStudentRegister.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStudentRegister.Location = new System.Drawing.Point(28, 274);
            this.btnStudentRegister.Name = "btnStudentRegister";
            this.btnStudentRegister.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnStudentRegister.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStudentRegister.OnHoverForeColor = System.Drawing.Color.LimeGreen;
            this.btnStudentRegister.OnHoverImage = null;
            this.btnStudentRegister.OnPressedColor = System.Drawing.Color.Black;
            this.btnStudentRegister.Size = new System.Drawing.Size(334, 36);
            this.btnStudentRegister.TabIndex = 6;
            this.btnStudentRegister.Text = "Register";
            this.btnStudentRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.AnimationHoverSpeed = 0.07F;
            this.btnStudentLogin.AnimationSpeed = 0.03F;
            this.btnStudentLogin.BaseColor = System.Drawing.Color.LimeGreen;
            this.btnStudentLogin.BorderColor = System.Drawing.Color.Black;
            this.btnStudentLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStudentLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnStudentLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentLogin.ForeColor = System.Drawing.Color.White;
            this.btnStudentLogin.Image = null;
            this.btnStudentLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStudentLogin.Location = new System.Drawing.Point(28, 210);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnStudentLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStudentLogin.OnHoverForeColor = System.Drawing.Color.LimeGreen;
            this.btnStudentLogin.OnHoverImage = null;
            this.btnStudentLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnStudentLogin.Size = new System.Drawing.Size(334, 36);
            this.btnStudentLogin.TabIndex = 7;
            this.btnStudentLogin.Text = "Login";
            this.btnStudentLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxShowHide);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.wrongLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(414, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 410);
            this.panel1.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label wrongLabel;
        private Guna.UI.WinForms.GunaTextBox txtUserName;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaButton btnLogin;
        private System.Windows.Forms.CheckBox checkBoxShowHide;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btnStudentLogin;
        private Guna.UI.WinForms.GunaButton btnStudentRegister;
        private Guna.UI.WinForms.GunaTextBox txtEnrollmentNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
    }
}

