namespace SecureLine
{
    partial class StaffSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffSettingsForm));
            this.LabelHeader = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonClearOldMeetings = new System.Windows.Forms.Button();
            this.ListBoxOldMeetings = new System.Windows.Forms.ListBox();
            this.TextBoxCounter = new System.Windows.Forms.TextBox();
            this.LabelOldMeetings = new System.Windows.Forms.Label();
            this.LabelEnterPassword = new System.Windows.Forms.Label();
            this.TextBoxOldPassword = new System.Windows.Forms.TextBox();
            this.LabelEnterNewPassword = new System.Windows.Forms.Label();
            this.TextBoxNewPassword = new System.Windows.Forms.TextBox();
            this.LabelRetypePassword = new System.Windows.Forms.Label();
            this.TextBoxReTypePassword = new System.Windows.Forms.TextBox();
            this.ButtonUpdatePassword = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(15, 9);
            this.LabelHeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(112, 37);
            this.LabelHeader.TabIndex = 7;
            this.LabelHeader.Text = "Settings";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(22, 359);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(177, 39);
            this.ButtonExit.TabIndex = 12;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonClearOldMeetings
            // 
            this.ButtonClearOldMeetings.Location = new System.Drawing.Point(1002, 356);
            this.ButtonClearOldMeetings.Name = "ButtonClearOldMeetings";
            this.ButtonClearOldMeetings.Size = new System.Drawing.Size(218, 37);
            this.ButtonClearOldMeetings.TabIndex = 13;
            this.ButtonClearOldMeetings.Text = "Clear past meetings";
            this.ButtonClearOldMeetings.UseVisualStyleBackColor = true;
            this.ButtonClearOldMeetings.Click += new System.EventHandler(this.ButtonClearOldMeetings_Click);
            // 
            // ListBoxOldMeetings
            // 
            this.ListBoxOldMeetings.FormattingEnabled = true;
            this.ListBoxOldMeetings.HorizontalScrollbar = true;
            this.ListBoxOldMeetings.ItemHeight = 30;
            this.ListBoxOldMeetings.Location = new System.Drawing.Point(549, 9);
            this.ListBoxOldMeetings.Name = "ListBoxOldMeetings";
            this.ListBoxOldMeetings.ScrollAlwaysVisible = true;
            this.ListBoxOldMeetings.Size = new System.Drawing.Size(671, 334);
            this.ListBoxOldMeetings.TabIndex = 14;
            // 
            // TextBoxCounter
            // 
            this.TextBoxCounter.Enabled = false;
            this.TextBoxCounter.Location = new System.Drawing.Point(549, 356);
            this.TextBoxCounter.Name = "TextBoxCounter";
            this.TextBoxCounter.Size = new System.Drawing.Size(127, 35);
            this.TextBoxCounter.TabIndex = 15;
            // 
            // LabelOldMeetings
            // 
            this.LabelOldMeetings.AutoSize = true;
            this.LabelOldMeetings.Location = new System.Drawing.Point(682, 359);
            this.LabelOldMeetings.Name = "LabelOldMeetings";
            this.LabelOldMeetings.Size = new System.Drawing.Size(133, 30);
            this.LabelOldMeetings.TabIndex = 16;
            this.LabelOldMeetings.Text = "old meetings";
            // 
            // LabelEnterPassword
            // 
            this.LabelEnterPassword.AutoSize = true;
            this.LabelEnterPassword.Location = new System.Drawing.Point(17, 57);
            this.LabelEnterPassword.Name = "LabelEnterPassword";
            this.LabelEnterPassword.Size = new System.Drawing.Size(194, 30);
            this.LabelEnterPassword.TabIndex = 17;
            this.LabelEnterPassword.Text = "Enter old password:";
            // 
            // TextBoxOldPassword
            // 
            this.TextBoxOldPassword.Location = new System.Drawing.Point(237, 57);
            this.TextBoxOldPassword.MaxLength = 50;
            this.TextBoxOldPassword.Name = "TextBoxOldPassword";
            this.TextBoxOldPassword.Size = new System.Drawing.Size(259, 35);
            this.TextBoxOldPassword.TabIndex = 18;
            this.TextBoxOldPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxOldPassword_Validating);
            // 
            // LabelEnterNewPassword
            // 
            this.LabelEnterNewPassword.AutoSize = true;
            this.LabelEnterNewPassword.Location = new System.Drawing.Point(17, 106);
            this.LabelEnterNewPassword.Name = "LabelEnterNewPassword";
            this.LabelEnterNewPassword.Size = new System.Drawing.Size(203, 30);
            this.LabelEnterNewPassword.TabIndex = 19;
            this.LabelEnterNewPassword.Text = "Enter new password:";
            // 
            // TextBoxNewPassword
            // 
            this.TextBoxNewPassword.Location = new System.Drawing.Point(237, 101);
            this.TextBoxNewPassword.MaxLength = 50;
            this.TextBoxNewPassword.Name = "TextBoxNewPassword";
            this.TextBoxNewPassword.Size = new System.Drawing.Size(259, 35);
            this.TextBoxNewPassword.TabIndex = 20;
            this.TextBoxNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNewPassword_Validating);
            // 
            // LabelRetypePassword
            // 
            this.LabelRetypePassword.AutoSize = true;
            this.LabelRetypePassword.Location = new System.Drawing.Point(17, 149);
            this.LabelRetypePassword.Name = "LabelRetypePassword";
            this.LabelRetypePassword.Size = new System.Drawing.Size(182, 30);
            this.LabelRetypePassword.TabIndex = 21;
            this.LabelRetypePassword.Text = "Re-type password:";
            // 
            // TextBoxReTypePassword
            // 
            this.TextBoxReTypePassword.Location = new System.Drawing.Point(237, 149);
            this.TextBoxReTypePassword.MaxLength = 50;
            this.TextBoxReTypePassword.Name = "TextBoxReTypePassword";
            this.TextBoxReTypePassword.Size = new System.Drawing.Size(259, 35);
            this.TextBoxReTypePassword.TabIndex = 22;
            this.TextBoxReTypePassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxReTypePassword_Validating);
            // 
            // ButtonUpdatePassword
            // 
            this.ButtonUpdatePassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdatePassword.Location = new System.Drawing.Point(237, 194);
            this.ButtonUpdatePassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonUpdatePassword.Name = "ButtonUpdatePassword";
            this.ButtonUpdatePassword.Size = new System.Drawing.Size(259, 39);
            this.ButtonUpdatePassword.TabIndex = 23;
            this.ButtonUpdatePassword.Text = "Update Password";
            this.ButtonUpdatePassword.UseVisualStyleBackColor = true;
            this.ButtonUpdatePassword.Click += new System.EventHandler(this.ButtonUpdatePassword_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(228)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 413);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1232, 62);
            this.panel2.TabIndex = 33;
            // 
            // StaffSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonUpdatePassword);
            this.Controls.Add(this.TextBoxReTypePassword);
            this.Controls.Add(this.LabelRetypePassword);
            this.Controls.Add(this.TextBoxNewPassword);
            this.Controls.Add(this.LabelEnterNewPassword);
            this.Controls.Add(this.TextBoxOldPassword);
            this.Controls.Add(this.LabelEnterPassword);
            this.Controls.Add(this.LabelOldMeetings);
            this.Controls.Add(this.TextBoxCounter);
            this.Controls.Add(this.ListBoxOldMeetings);
            this.Controls.Add(this.ButtonClearOldMeetings);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.LabelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "StaffSettingsForm";
            this.Text = "Staff Settings";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonClearOldMeetings;
        private System.Windows.Forms.ListBox ListBoxOldMeetings;
        private System.Windows.Forms.TextBox TextBoxCounter;
        private System.Windows.Forms.Label LabelOldMeetings;
        private System.Windows.Forms.Label LabelEnterPassword;
        private System.Windows.Forms.TextBox TextBoxOldPassword;
        private System.Windows.Forms.Label LabelEnterNewPassword;
        private System.Windows.Forms.TextBox TextBoxNewPassword;
        private System.Windows.Forms.Label LabelRetypePassword;
        private System.Windows.Forms.TextBox TextBoxReTypePassword;
        private System.Windows.Forms.Button ButtonUpdatePassword;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel panel2;
    }
}