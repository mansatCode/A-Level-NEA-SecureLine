namespace SecureLine
{
    partial class LoginWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindowForm));
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ButtonLogIn = new System.Windows.Forms.Button();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.ButtonForgotPassword = new System.Windows.Forms.Button();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonStudent = new System.Windows.Forms.RadioButton();
            this.RadioButtonStaff = new System.Windows.Forms.RadioButton();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(309, 97);
            this.TextBoxUsername.MaxLength = 8;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(337, 35);
            this.TextBoxUsername.TabIndex = 2;
            this.TextBoxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxUsername_Validating);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(309, 138);
            this.TextBoxPassword.MaxLength = 50;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxPassword.Size = new System.Drawing.Size(337, 35);
            this.TextBoxPassword.TabIndex = 3;
            this.TextBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxPassword_Validating);
            // 
            // ButtonLogIn
            // 
            this.ButtonLogIn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogIn.Location = new System.Drawing.Point(309, 179);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.Size = new System.Drawing.Size(160, 39);
            this.ButtonLogIn.TabIndex = 5;
            this.ButtonLogIn.Text = "Log in";
            this.ButtonLogIn.UseVisualStyleBackColor = true;
            this.ButtonLogIn.Click += new System.EventHandler(this.ButtonLogIn_Click);
            // 
            // LabelHeader
            // 
            this.LabelHeader.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
            this.LabelHeader.Location = new System.Drawing.Point(34, 1);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(106, 66);
            this.LabelHeader.TabIndex = 6;
            this.LabelHeader.Text = "SL";
            // 
            // ButtonForgotPassword
            // 
            this.ButtonForgotPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonForgotPassword.Location = new System.Drawing.Point(475, 179);
            this.ButtonForgotPassword.Name = "ButtonForgotPassword";
            this.ButtonForgotPassword.Size = new System.Drawing.Size(171, 39);
            this.ButtonForgotPassword.TabIndex = 7;
            this.ButtonForgotPassword.Text = "Forgot password";
            this.ButtonForgotPassword.UseVisualStyleBackColor = true;
            this.ButtonForgotPassword.Click += new System.EventHandler(this.ButtonForgotPassword_Click);
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(198, 97);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(111, 30);
            this.LabelUsername.TabIndex = 8;
            this.LabelUsername.Text = "Student ID";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(198, 141);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(99, 30);
            this.LabelPassword.TabIndex = 9;
            this.LabelPassword.Text = "Password";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.RadioButtonStudent);
            this.GroupBox1.Controls.Add(this.RadioButtonStaff);
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ErrorProvider.SetIconAlignment(this.GroupBox1, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.GroupBox1.Location = new System.Drawing.Point(679, 81);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(127, 97);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            // 
            // RadioButtonStudent
            // 
            this.RadioButtonStudent.AutoSize = true;
            this.RadioButtonStudent.Checked = true;
            this.RadioButtonStudent.ForeColor = System.Drawing.Color.Black;
            this.RadioButtonStudent.Location = new System.Drawing.Point(6, 16);
            this.RadioButtonStudent.Name = "RadioButtonStudent";
            this.RadioButtonStudent.Size = new System.Drawing.Size(102, 34);
            this.RadioButtonStudent.TabIndex = 1;
            this.RadioButtonStudent.TabStop = true;
            this.RadioButtonStudent.Text = "Student";
            this.RadioButtonStudent.UseVisualStyleBackColor = true;
            this.RadioButtonStudent.CheckedChanged += new System.EventHandler(this.RadioButtonStudent_CheckedChanged);
            // 
            // RadioButtonStaff
            // 
            this.RadioButtonStaff.AutoSize = true;
            this.RadioButtonStaff.ForeColor = System.Drawing.Color.Black;
            this.RadioButtonStaff.Location = new System.Drawing.Point(6, 56);
            this.RadioButtonStaff.Name = "RadioButtonStaff";
            this.RadioButtonStaff.Size = new System.Drawing.Size(73, 34);
            this.RadioButtonStaff.TabIndex = 0;
            this.RadioButtonStaff.Text = "Staff";
            this.RadioButtonStaff.UseVisualStyleBackColor = true;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 353);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SecureLine.Properties.Resources.SecureLine;
            this.pictureBox1.Location = new System.Drawing.Point(12, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(99)))), ((int)(((byte)(213)))));
            this.panel3.Controls.Add(this.LabelHeader);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 81);
            this.panel3.TabIndex = 0;
            // 
            // LoginWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(830, 353);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.ButtonForgotPassword);
            this.Controls.Add(this.ButtonLogIn);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.Name = "LoginWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Line";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button ButtonLogIn;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Button ButtonForgotPassword;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.RadioButton RadioButtonStudent;
        private System.Windows.Forms.RadioButton RadioButtonStaff;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

