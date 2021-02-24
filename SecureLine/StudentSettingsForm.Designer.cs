namespace SecureLine
{
    partial class StudentSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentSettingsForm));
            this.LabelHeader = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonUpdatePassword = new System.Windows.Forms.Button();
            this.TextBoxOldPassword = new System.Windows.Forms.TextBox();
            this.LabelEnterPassword = new System.Windows.Forms.Label();
            this.LabelEnterNewPassword = new System.Windows.Forms.Label();
            this.TextBoxNewPassword = new System.Windows.Forms.TextBox();
            this.LabelRetypePassword = new System.Windows.Forms.Label();
            this.TextBoxReTypePassword = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(17, 9);
            this.LabelHeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(112, 37);
            this.LabelHeader.TabIndex = 6;
            this.LabelHeader.Text = "Settings";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(24, 187);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(177, 39);
            this.ButtonExit.TabIndex = 11;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonUpdatePassword
            // 
            this.ButtonUpdatePassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdatePassword.Location = new System.Drawing.Point(236, 187);
            this.ButtonUpdatePassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonUpdatePassword.Name = "ButtonUpdatePassword";
            this.ButtonUpdatePassword.Size = new System.Drawing.Size(259, 39);
            this.ButtonUpdatePassword.TabIndex = 12;
            this.ButtonUpdatePassword.Text = "Update Password";
            this.ButtonUpdatePassword.UseVisualStyleBackColor = true;
            this.ButtonUpdatePassword.Click += new System.EventHandler(this.ButtonUpdatePassword_Click);
            // 
            // TextBoxOldPassword
            // 
            this.TextBoxOldPassword.Location = new System.Drawing.Point(236, 53);
            this.TextBoxOldPassword.MaxLength = 50;
            this.TextBoxOldPassword.Name = "TextBoxOldPassword";
            this.TextBoxOldPassword.Size = new System.Drawing.Size(259, 35);
            this.TextBoxOldPassword.TabIndex = 13;
            this.TextBoxOldPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxOldPassword_Validating);
            // 
            // LabelEnterPassword
            // 
            this.LabelEnterPassword.AutoSize = true;
            this.LabelEnterPassword.Location = new System.Drawing.Point(19, 56);
            this.LabelEnterPassword.Name = "LabelEnterPassword";
            this.LabelEnterPassword.Size = new System.Drawing.Size(194, 30);
            this.LabelEnterPassword.TabIndex = 14;
            this.LabelEnterPassword.Text = "Enter old password:";
            // 
            // LabelEnterNewPassword
            // 
            this.LabelEnterNewPassword.AutoSize = true;
            this.LabelEnterNewPassword.Location = new System.Drawing.Point(19, 102);
            this.LabelEnterNewPassword.Name = "LabelEnterNewPassword";
            this.LabelEnterNewPassword.Size = new System.Drawing.Size(203, 30);
            this.LabelEnterNewPassword.TabIndex = 15;
            this.LabelEnterNewPassword.Text = "Enter new password:";
            // 
            // TextBoxNewPassword
            // 
            this.TextBoxNewPassword.Location = new System.Drawing.Point(236, 99);
            this.TextBoxNewPassword.MaxLength = 50;
            this.TextBoxNewPassword.Name = "TextBoxNewPassword";
            this.TextBoxNewPassword.Size = new System.Drawing.Size(259, 35);
            this.TextBoxNewPassword.TabIndex = 16;
            this.TextBoxNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNewPassword_Validating);
            // 
            // LabelRetypePassword
            // 
            this.LabelRetypePassword.AutoSize = true;
            this.LabelRetypePassword.Location = new System.Drawing.Point(19, 145);
            this.LabelRetypePassword.Name = "LabelRetypePassword";
            this.LabelRetypePassword.Size = new System.Drawing.Size(182, 30);
            this.LabelRetypePassword.TabIndex = 17;
            this.LabelRetypePassword.Text = "Re-type password:";
            // 
            // TextBoxReTypePassword
            // 
            this.TextBoxReTypePassword.Location = new System.Drawing.Point(236, 142);
            this.TextBoxReTypePassword.MaxLength = 50;
            this.TextBoxReTypePassword.Name = "TextBoxReTypePassword";
            this.TextBoxReTypePassword.Size = new System.Drawing.Size(259, 35);
            this.TextBoxReTypePassword.TabIndex = 18;
            this.TextBoxReTypePassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxReTypePassword_Validating);
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
            this.panel2.Location = new System.Drawing.Point(0, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 35);
            this.panel2.TabIndex = 19;
            // 
            // StudentSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 271);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TextBoxReTypePassword);
            this.Controls.Add(this.LabelRetypePassword);
            this.Controls.Add(this.TextBoxNewPassword);
            this.Controls.Add(this.LabelEnterNewPassword);
            this.Controls.Add(this.LabelEnterPassword);
            this.Controls.Add(this.TextBoxOldPassword);
            this.Controls.Add(this.ButtonUpdatePassword);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.LabelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "StudentSettingsForm";
            this.Text = "Student Settings";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonUpdatePassword;
        private System.Windows.Forms.TextBox TextBoxOldPassword;
        private System.Windows.Forms.Label LabelEnterPassword;
        private System.Windows.Forms.Label LabelEnterNewPassword;
        private System.Windows.Forms.TextBox TextBoxNewPassword;
        private System.Windows.Forms.Label LabelRetypePassword;
        private System.Windows.Forms.TextBox TextBoxReTypePassword;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel panel2;
    }
}