namespace QuizManagement
{
    partial class Teachers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.btnViewDeleteQuestion = new Guna.UI.WinForms.GunaButton();
            this.btnUpdateQuestion = new Guna.UI.WinForms.GunaButton();
            this.btnAddNewQuestion = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewAndDeleteQuestion1 = new QuizManagement.Teachered.ViewAndDeleteQuestion();
            this.updateQuestion1 = new QuizManagement.Teacher.UpdateQuestion();
            this.addNewQuestions1 = new QuizManagement.Teacher.addNewQuestions();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.gunaButton5);
            this.panel1.Controls.Add(this.btnViewDeleteQuestion);
            this.panel1.Controls.Add(this.btnUpdateQuestion);
            this.panel1.Controls.Add(this.btnAddNewQuestion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 768);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.LimeGreen;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(12, 547);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(42, 42);
            this.btnExit.TabIndex = 7;
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BaseColor = System.Drawing.Color.LimeGreen;
            this.gunaButton5.BorderColor = System.Drawing.Color.White;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.Color.Black;
            this.gunaButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton5.Image")));
            this.gunaButton5.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton5.Location = new System.Drawing.Point(12, 465);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Size = new System.Drawing.Size(263, 45);
            this.gunaButton5.TabIndex = 6;
            this.gunaButton5.Text = "Log Out";
            this.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // btnViewDeleteQuestion
            // 
            this.btnViewDeleteQuestion.AnimationHoverSpeed = 0.07F;
            this.btnViewDeleteQuestion.AnimationSpeed = 0.03F;
            this.btnViewDeleteQuestion.BaseColor = System.Drawing.Color.LimeGreen;
            this.btnViewDeleteQuestion.BorderColor = System.Drawing.Color.White;
            this.btnViewDeleteQuestion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewDeleteQuestion.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewDeleteQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDeleteQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnViewDeleteQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDeleteQuestion.Image")));
            this.btnViewDeleteQuestion.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewDeleteQuestion.Location = new System.Drawing.Point(12, 396);
            this.btnViewDeleteQuestion.Name = "btnViewDeleteQuestion";
            this.btnViewDeleteQuestion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnViewDeleteQuestion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewDeleteQuestion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnViewDeleteQuestion.OnHoverImage = null;
            this.btnViewDeleteQuestion.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewDeleteQuestion.Size = new System.Drawing.Size(263, 45);
            this.btnViewDeleteQuestion.TabIndex = 4;
            this.btnViewDeleteQuestion.Text = "View & Delete Question";
            this.btnViewDeleteQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewDeleteQuestion.Click += new System.EventHandler(this.btnViewDeleteQuestion_Click);
            // 
            // btnUpdateQuestion
            // 
            this.btnUpdateQuestion.AnimationHoverSpeed = 0.07F;
            this.btnUpdateQuestion.AnimationSpeed = 0.03F;
            this.btnUpdateQuestion.BaseColor = System.Drawing.Color.LimeGreen;
            this.btnUpdateQuestion.BorderColor = System.Drawing.Color.White;
            this.btnUpdateQuestion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateQuestion.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateQuestion.Image")));
            this.btnUpdateQuestion.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateQuestion.Location = new System.Drawing.Point(12, 335);
            this.btnUpdateQuestion.Name = "btnUpdateQuestion";
            this.btnUpdateQuestion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdateQuestion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdateQuestion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdateQuestion.OnHoverImage = null;
            this.btnUpdateQuestion.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateQuestion.Size = new System.Drawing.Size(263, 45);
            this.btnUpdateQuestion.TabIndex = 3;
            this.btnUpdateQuestion.Text = "Update Question";
            this.btnUpdateQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdateQuestion.Click += new System.EventHandler(this.btnUpdateQuestion_Click);
            // 
            // btnAddNewQuestion
            // 
            this.btnAddNewQuestion.AnimationHoverSpeed = 0.07F;
            this.btnAddNewQuestion.AnimationSpeed = 0.03F;
            this.btnAddNewQuestion.BaseColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewQuestion.BorderColor = System.Drawing.Color.White;
            this.btnAddNewQuestion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewQuestion.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewQuestion.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewQuestion.Image")));
            this.btnAddNewQuestion.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewQuestion.Location = new System.Drawing.Point(12, 274);
            this.btnAddNewQuestion.Name = "btnAddNewQuestion";
            this.btnAddNewQuestion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddNewQuestion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewQuestion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewQuestion.OnHoverImage = null;
            this.btnAddNewQuestion.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewQuestion.Size = new System.Drawing.Size(263, 45);
            this.btnAddNewQuestion.TabIndex = 2;
            this.btnAddNewQuestion.Text = "Add New Question";
            this.btnAddNewQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNewQuestion.Click += new System.EventHandler(this.btnAddNewQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teacher";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.viewAndDeleteQuestion1);
            this.panel2.Controls.Add(this.updateQuestion1);
            this.panel2.Controls.Add(this.addNewQuestions1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(275, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1098, 768);
            this.panel2.TabIndex = 1;
            // 
            // viewAndDeleteQuestion1
            // 
            this.viewAndDeleteQuestion1.BackColor = System.Drawing.Color.White;
            this.viewAndDeleteQuestion1.Location = new System.Drawing.Point(0, 0);
            this.viewAndDeleteQuestion1.Name = "viewAndDeleteQuestion1";
            this.viewAndDeleteQuestion1.Size = new System.Drawing.Size(1095, 768);
            this.viewAndDeleteQuestion1.TabIndex = 3;
            // 
            // updateQuestion1
            // 
            this.updateQuestion1.BackColor = System.Drawing.Color.White;
            this.updateQuestion1.Location = new System.Drawing.Point(0, 0);
            this.updateQuestion1.Name = "updateQuestion1";
            this.updateQuestion1.Size = new System.Drawing.Size(1095, 768);
            this.updateQuestion1.TabIndex = 2;
            // 
            // addNewQuestions1
            // 
            this.addNewQuestions1.BackColor = System.Drawing.Color.White;
            this.addNewQuestions1.Location = new System.Drawing.Point(0, 0);
            this.addNewQuestions1.Name = "addNewQuestions1";
            this.addNewQuestions1.Size = new System.Drawing.Size(1098, 768);
            this.addNewQuestions1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 768);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.panel2;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.panel2;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this.panel2;
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(280, 0);
            this.Name = "Teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teachers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnAddNewQuestion;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaButton btnViewDeleteQuestion;
        private Guna.UI.WinForms.GunaButton btnUpdateQuestion;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Teacher.addNewQuestions addNewQuestions1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Teacher.UpdateQuestion updateQuestion1;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Teachered.ViewAndDeleteQuestion viewAndDeleteQuestion1;
    }
}