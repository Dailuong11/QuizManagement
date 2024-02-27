namespace QuizManagement.Teacher
{
    partial class UpdateQuestion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateQuestion));
            this.label1 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboSet = new Guna.UI.WinForms.GunaComboBox();
            this.comboQuestion = new Guna.UI.WinForms.GunaComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuestion = new Guna.UI.WinForms.GunaTextBox();
            this.txtOption1 = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOption3 = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOption2 = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOption4 = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnswer = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnReset = new Guna.UI.WinForms.GunaButton();
            this.btnSyn = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update Questions";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Set";
            // 
            // comboSet
            // 
            this.comboSet.BackColor = System.Drawing.Color.Transparent;
            this.comboSet.BaseColor = System.Drawing.Color.White;
            this.comboSet.BorderColor = System.Drawing.Color.Black;
            this.comboSet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSet.FocusedColor = System.Drawing.Color.Empty;
            this.comboSet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSet.ForeColor = System.Drawing.Color.Black;
            this.comboSet.FormattingEnabled = true;
            this.comboSet.Location = new System.Drawing.Point(159, 164);
            this.comboSet.Name = "comboSet";
            this.comboSet.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboSet.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboSet.Size = new System.Drawing.Size(340, 30);
            this.comboSet.TabIndex = 24;
            this.comboSet.SelectedIndexChanged += new System.EventHandler(this.comboSet_SelectedIndexChanged);
            // 
            // comboQuestion
            // 
            this.comboQuestion.BackColor = System.Drawing.Color.Transparent;
            this.comboQuestion.BaseColor = System.Drawing.Color.White;
            this.comboQuestion.BorderColor = System.Drawing.Color.Black;
            this.comboQuestion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboQuestion.FocusedColor = System.Drawing.Color.Empty;
            this.comboQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboQuestion.ForeColor = System.Drawing.Color.Black;
            this.comboQuestion.FormattingEnabled = true;
            this.comboQuestion.Location = new System.Drawing.Point(582, 164);
            this.comboQuestion.Name = "comboQuestion";
            this.comboQuestion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboQuestion.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboQuestion.Size = new System.Drawing.Size(340, 30);
            this.comboQuestion.TabIndex = 26;
            this.comboQuestion.SelectedIndexChanged += new System.EventHandler(this.comboQuestion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(577, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Question No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(490, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Question :";
            // 
            // txtQuestion
            // 
            this.txtQuestion.BaseColor = System.Drawing.Color.White;
            this.txtQuestion.BorderColor = System.Drawing.Color.Black;
            this.txtQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuestion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQuestion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtQuestion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.ForeColor = System.Drawing.Color.Black;
            this.txtQuestion.Location = new System.Drawing.Point(159, 278);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.PasswordChar = '\0';
            this.txtQuestion.SelectedText = "";
            this.txtQuestion.Size = new System.Drawing.Size(763, 36);
            this.txtQuestion.TabIndex = 28;
            // 
            // txtOption1
            // 
            this.txtOption1.BaseColor = System.Drawing.Color.White;
            this.txtOption1.BorderColor = System.Drawing.Color.Black;
            this.txtOption1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOption1.FocusedBaseColor = System.Drawing.Color.White;
            this.txtOption1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtOption1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtOption1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOption1.ForeColor = System.Drawing.Color.Black;
            this.txtOption1.Location = new System.Drawing.Point(159, 386);
            this.txtOption1.Name = "txtOption1";
            this.txtOption1.PasswordChar = '\0';
            this.txtOption1.SelectedText = "";
            this.txtOption1.Size = new System.Drawing.Size(340, 36);
            this.txtOption1.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Option 1:";
            // 
            // txtOption3
            // 
            this.txtOption3.BaseColor = System.Drawing.Color.White;
            this.txtOption3.BorderColor = System.Drawing.Color.Black;
            this.txtOption3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOption3.FocusedBaseColor = System.Drawing.Color.White;
            this.txtOption3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtOption3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtOption3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOption3.ForeColor = System.Drawing.Color.Black;
            this.txtOption3.Location = new System.Drawing.Point(582, 386);
            this.txtOption3.Name = "txtOption3";
            this.txtOption3.PasswordChar = '\0';
            this.txtOption3.SelectedText = "";
            this.txtOption3.Size = new System.Drawing.Size(340, 36);
            this.txtOption3.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(578, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Option 3:";
            // 
            // txtOption2
            // 
            this.txtOption2.BaseColor = System.Drawing.Color.White;
            this.txtOption2.BorderColor = System.Drawing.Color.Black;
            this.txtOption2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOption2.FocusedBaseColor = System.Drawing.Color.White;
            this.txtOption2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtOption2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtOption2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOption2.ForeColor = System.Drawing.Color.Black;
            this.txtOption2.Location = new System.Drawing.Point(159, 492);
            this.txtOption2.Name = "txtOption2";
            this.txtOption2.PasswordChar = '\0';
            this.txtOption2.SelectedText = "";
            this.txtOption2.Size = new System.Drawing.Size(340, 36);
            this.txtOption2.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(155, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "Option 2:";
            // 
            // txtOption4
            // 
            this.txtOption4.BaseColor = System.Drawing.Color.White;
            this.txtOption4.BorderColor = System.Drawing.Color.Black;
            this.txtOption4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOption4.FocusedBaseColor = System.Drawing.Color.White;
            this.txtOption4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtOption4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtOption4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOption4.ForeColor = System.Drawing.Color.Black;
            this.txtOption4.Location = new System.Drawing.Point(582, 492);
            this.txtOption4.Name = "txtOption4";
            this.txtOption4.PasswordChar = '\0';
            this.txtOption4.SelectedText = "";
            this.txtOption4.Size = new System.Drawing.Size(340, 36);
            this.txtOption4.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(578, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "Option 4:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.BaseColor = System.Drawing.Color.White;
            this.txtAnswer.BorderColor = System.Drawing.Color.Black;
            this.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnswer.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAnswer.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAnswer.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.ForeColor = System.Drawing.Color.Black;
            this.txtAnswer.Location = new System.Drawing.Point(160, 605);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.PasswordChar = '\0';
            this.txtAnswer.SelectedText = "";
            this.txtAnswer.Size = new System.Drawing.Size(763, 36);
            this.txtAnswer.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(490, 558);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 24);
            this.label9.TabIndex = 37;
            this.label9.Text = "Answer :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BaseColor = System.Drawing.Color.Blue;
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.BorderSize = 1;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = null;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(388, 681);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Size = new System.Drawing.Size(123, 48);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.AnimationHoverSpeed = 0.07F;
            this.btnReset.AnimationSpeed = 0.03F;
            this.btnReset.BaseColor = System.Drawing.Color.Blue;
            this.btnReset.BorderColor = System.Drawing.Color.Black;
            this.btnReset.BorderSize = 1;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReset.FocusedColor = System.Drawing.Color.Empty;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReset.Location = new System.Drawing.Point(544, 681);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Size = new System.Drawing.Size(123, 48);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSyn
            // 
            this.btnSyn.AnimationHoverSpeed = 0.07F;
            this.btnSyn.AnimationSpeed = 0.03F;
            this.btnSyn.BaseColor = System.Drawing.Color.White;
            this.btnSyn.BorderColor = System.Drawing.Color.Black;
            this.btnSyn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSyn.FocusedColor = System.Drawing.Color.Empty;
            this.btnSyn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSyn.ForeColor = System.Drawing.Color.White;
            this.btnSyn.Image = ((System.Drawing.Image)(resources.GetObject("btnSyn.Image")));
            this.btnSyn.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSyn.Location = new System.Drawing.Point(316, 23);
            this.btnSyn.Name = "btnSyn";
            this.btnSyn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSyn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSyn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSyn.OnHoverImage = null;
            this.btnSyn.OnPressedColor = System.Drawing.Color.Black;
            this.btnSyn.Size = new System.Drawing.Size(48, 42);
            this.btnSyn.TabIndex = 41;
            this.btnSyn.Click += new System.EventHandler(this.btnSyn_Click);
            // 
            // UpdateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSyn);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOption4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOption2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOption3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOption1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboSet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateQuestion";
            this.Size = new System.Drawing.Size(1095, 768);
            this.Load += new System.EventHandler(this.UpdateQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtOption3;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtOption1;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtQuestion;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox comboQuestion;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox comboSet;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaTextBox txtAnswer;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtOption4;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox txtOption2;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaButton btnSyn;
        private Guna.UI.WinForms.GunaButton btnReset;
    }
}
