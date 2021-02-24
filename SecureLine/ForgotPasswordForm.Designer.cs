namespace SecureLine
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.ButtonSendEmail = new System.Windows.Forms.Button();
            this.LabelEnterEmail = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.LabelText = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonStudent = new System.Windows.Forms.RadioButton();
            this.RadioButtonStaff = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxEmail.Location = new System.Drawing.Point(199, 100);
            this.TextBoxEmail.MaxLength = 100;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TextBoxEmail.Size = new System.Drawing.Size(506, 35);
            this.TextBoxEmail.TabIndex = 3;
            this.TextBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxEmail_Validating);
            // 
            // ButtonSendEmail
            // 
            this.ButtonSendEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSendEmail.Location = new System.Drawing.Point(199, 148);
            this.ButtonSendEmail.Name = "ButtonSendEmail";
            this.ButtonSendEmail.Size = new System.Drawing.Size(160, 39);
            this.ButtonSendEmail.TabIndex = 6;
            this.ButtonSendEmail.Text = "Send email";
            this.ButtonSendEmail.UseVisualStyleBackColor = true;
            this.ButtonSendEmail.Click += new System.EventHandler(this.ButtonSendEmail_Click);
            // 
            // LabelEnterEmail
            // 
            this.LabelEnterEmail.AutoSize = true;
            this.LabelEnterEmail.Location = new System.Drawing.Point(27, 100);
            this.LabelEnterEmail.Name = "LabelEnterEmail";
            this.LabelEnterEmail.Size = new System.Drawing.Size(117, 30);
            this.LabelEnterEmail.TabIndex = 9;
            this.LabelEnterEmail.Text = "Enter Email";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(752, 274);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(121, 39);
            this.ButtonExit.TabIndex = 10;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // LabelText
            // 
            this.LabelText.Location = new System.Drawing.Point(15, 9);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(689, 60);
            this.LabelText.TabIndex = 11;
            this.LabelText.Text = "Enter your email below to receive an email reminding you of your login details.";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.RadioButtonStudent);
            this.GroupBox1.Controls.Add(this.RadioButtonStaff);
            this.GroupBox1.Location = new System.Drawing.Point(752, 84);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(121, 92);
            this.GroupBox1.TabIndex = 12;
            this.GroupBox1.TabStop = false;
            // 
            // RadioButtonStudent
            // 
            this.RadioButtonStudent.AutoSize = true;
            this.RadioButtonStudent.Checked = true;
            this.RadioButtonStudent.Location = new System.Drawing.Point(6, 16);
            this.RadioButtonStudent.Name = "RadioButtonStudent";
            this.RadioButtonStudent.Size = new System.Drawing.Size(102, 34);
            this.RadioButtonStudent.TabIndex = 1;
            this.RadioButtonStudent.TabStop = true;
            this.RadioButtonStudent.Text = "Student";
            this.RadioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // RadioButtonStaff
            // 
            this.RadioButtonStaff.AutoSize = true;
            this.RadioButtonStaff.Location = new System.Drawing.Point(6, 56);
            this.RadioButtonStaff.Name = "RadioButtonStaff";
            this.RadioButtonStaff.Size = new System.Drawing.Size(73, 34);
            this.RadioButtonStaff.TabIndex = 0;
            this.RadioButtonStaff.Text = "Staff";
            this.RadioButtonStaff.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 325);
            this.panel2.TabIndex = 13;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(228)))));
            this.panel1.Controls.Add(this.LabelText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(179, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 81);
            this.panel1.TabIndex = 14;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 325);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.LabelEnterEmail);
            this.Controls.Add(this.ButtonSendEmail);
            this.Controls.Add(this.TextBoxEmail);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ForgotPasswordForm";
            this.Text = "Forgot Password";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Button ButtonSendEmail;
        private System.Windows.Forms.Label LabelEnterEmail;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.RadioButton RadioButtonStudent;
        private System.Windows.Forms.RadioButton RadioButtonStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelHeader;
    }
}