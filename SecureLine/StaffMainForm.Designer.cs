namespace SecureLine
{
    partial class StaffMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffMainForm));
            this.LabelUpcomingMeetings = new System.Windows.Forms.Label();
            this.ListBoxUpcomingMeetings = new System.Windows.Forms.ListBox();
            this.LabelWelcomeBack = new System.Windows.Forms.Label();
            this.ButtonSelectStudent = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelUpcomingMeetings
            // 
            this.LabelUpcomingMeetings.AutoSize = true;
            this.LabelUpcomingMeetings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUpcomingMeetings.Location = new System.Drawing.Point(15, 9);
            this.LabelUpcomingMeetings.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelUpcomingMeetings.Name = "LabelUpcomingMeetings";
            this.LabelUpcomingMeetings.Size = new System.Drawing.Size(204, 30);
            this.LabelUpcomingMeetings.TabIndex = 6;
            this.LabelUpcomingMeetings.Text = "Upcoming meetings:";
            // 
            // ListBoxUpcomingMeetings
            // 
            this.ListBoxUpcomingMeetings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxUpcomingMeetings.FormattingEnabled = true;
            this.ListBoxUpcomingMeetings.ItemHeight = 30;
            this.ListBoxUpcomingMeetings.Location = new System.Drawing.Point(20, 46);
            this.ListBoxUpcomingMeetings.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ListBoxUpcomingMeetings.Name = "ListBoxUpcomingMeetings";
            this.ListBoxUpcomingMeetings.Size = new System.Drawing.Size(341, 394);
            this.ListBoxUpcomingMeetings.TabIndex = 7;
            // 
            // LabelWelcomeBack
            // 
            this.LabelWelcomeBack.AutoSize = true;
            this.LabelWelcomeBack.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWelcomeBack.Location = new System.Drawing.Point(415, 9);
            this.LabelWelcomeBack.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelWelcomeBack.Name = "LabelWelcomeBack";
            this.LabelWelcomeBack.Size = new System.Drawing.Size(154, 30);
            this.LabelWelcomeBack.TabIndex = 8;
            this.LabelWelcomeBack.Text = "Welcome back!";
            // 
            // ButtonSelectStudent
            // 
            this.ButtonSelectStudent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSelectStudent.Location = new System.Drawing.Point(420, 46);
            this.ButtonSelectStudent.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonSelectStudent.Name = "ButtonSelectStudent";
            this.ButtonSelectStudent.Size = new System.Drawing.Size(149, 39);
            this.ButtonSelectStudent.TabIndex = 9;
            this.ButtonSelectStudent.Text = "Select student";
            this.ButtonSelectStudent.UseVisualStyleBackColor = true;
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSettings.Location = new System.Drawing.Point(420, 89);
            this.ButtonSettings.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(149, 39);
            this.ButtonSettings.TabIndex = 10;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.UseVisualStyleBackColor = true;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(420, 401);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(149, 39);
            this.ButtonExit.TabIndex = 13;
            this.ButtonExit.Text = "Log out";
            this.ButtonExit.UseVisualStyleBackColor = true;
            // 
            // StaffMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.ButtonSelectStudent);
            this.Controls.Add(this.LabelWelcomeBack);
            this.Controls.Add(this.ListBoxUpcomingMeetings);
            this.Controls.Add(this.LabelUpcomingMeetings);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "StaffMainForm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUpcomingMeetings;
        private System.Windows.Forms.ListBox ListBoxUpcomingMeetings;
        private System.Windows.Forms.Label LabelWelcomeBack;
        private System.Windows.Forms.Button ButtonSelectStudent;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button ButtonExit;
    }
}