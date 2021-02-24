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
            this.ButtonUpdateStudentsList = new System.Windows.Forms.Button();
            this.ButtonUpdateStaffList = new System.Windows.Forms.Button();
            this.ButtonDeleteMeeting = new System.Windows.Forms.Button();
            this.ButtonOpenChat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.ListBoxUpcomingMeetings.ScrollAlwaysVisible = true;
            this.ListBoxUpcomingMeetings.Size = new System.Drawing.Size(577, 364);
            this.ListBoxUpcomingMeetings.TabIndex = 5;
            // 
            // LabelWelcomeBack
            // 
            this.LabelWelcomeBack.AutoSize = true;
            this.LabelWelcomeBack.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWelcomeBack.Location = new System.Drawing.Point(604, 9);
            this.LabelWelcomeBack.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelWelcomeBack.Name = "LabelWelcomeBack";
            this.LabelWelcomeBack.Size = new System.Drawing.Size(154, 30);
            this.LabelWelcomeBack.TabIndex = 8;
            this.LabelWelcomeBack.Text = "Welcome back!";
            // 
            // ButtonSelectStudent
            // 
            this.ButtonSelectStudent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSelectStudent.Location = new System.Drawing.Point(609, 46);
            this.ButtonSelectStudent.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonSelectStudent.Name = "ButtonSelectStudent";
            this.ButtonSelectStudent.Size = new System.Drawing.Size(149, 39);
            this.ButtonSelectStudent.TabIndex = 0;
            this.ButtonSelectStudent.Text = "Select student";
            this.ButtonSelectStudent.UseVisualStyleBackColor = true;
            this.ButtonSelectStudent.Click += new System.EventHandler(this.ButtonSelectStudent_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSettings.Location = new System.Drawing.Point(609, 89);
            this.ButtonSettings.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(149, 39);
            this.ButtonSettings.TabIndex = 1;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(609, 371);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(149, 39);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Log out";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonUpdateStudentsList
            // 
            this.ButtonUpdateStudentsList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdateStudentsList.Location = new System.Drawing.Point(609, 249);
            this.ButtonUpdateStudentsList.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonUpdateStudentsList.Name = "ButtonUpdateStudentsList";
            this.ButtonUpdateStudentsList.Size = new System.Drawing.Size(149, 59);
            this.ButtonUpdateStudentsList.TabIndex = 2;
            this.ButtonUpdateStudentsList.Text = "Update Students List";
            this.ButtonUpdateStudentsList.UseVisualStyleBackColor = true;
            this.ButtonUpdateStudentsList.Click += new System.EventHandler(this.ButtonUpdateStudentsList_Click);
            // 
            // ButtonUpdateStaffList
            // 
            this.ButtonUpdateStaffList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdateStaffList.Location = new System.Drawing.Point(609, 310);
            this.ButtonUpdateStaffList.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonUpdateStaffList.Name = "ButtonUpdateStaffList";
            this.ButtonUpdateStaffList.Size = new System.Drawing.Size(149, 59);
            this.ButtonUpdateStaffList.TabIndex = 3;
            this.ButtonUpdateStaffList.Text = "Update Staff List";
            this.ButtonUpdateStaffList.UseVisualStyleBackColor = true;
            this.ButtonUpdateStaffList.Click += new System.EventHandler(this.ButtonUpdateStaffList_Click);
            // 
            // ButtonDeleteMeeting
            // 
            this.ButtonDeleteMeeting.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteMeeting.Location = new System.Drawing.Point(20, 414);
            this.ButtonDeleteMeeting.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonDeleteMeeting.Name = "ButtonDeleteMeeting";
            this.ButtonDeleteMeeting.Size = new System.Drawing.Size(237, 39);
            this.ButtonDeleteMeeting.TabIndex = 9;
            this.ButtonDeleteMeeting.Text = "Delete Selected Meeting";
            this.ButtonDeleteMeeting.UseVisualStyleBackColor = true;
            this.ButtonDeleteMeeting.Click += new System.EventHandler(this.ButtonDeleteMeeting_Click);
            // 
            // ButtonOpenChat
            // 
            this.ButtonOpenChat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOpenChat.Location = new System.Drawing.Point(609, 132);
            this.ButtonOpenChat.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonOpenChat.Name = "ButtonOpenChat";
            this.ButtonOpenChat.Size = new System.Drawing.Size(149, 39);
            this.ButtonOpenChat.TabIndex = 10;
            this.ButtonOpenChat.Text = "Open chat";
            this.ButtonOpenChat.UseVisualStyleBackColor = true;
            this.ButtonOpenChat.Click += new System.EventHandler(this.ButtonOpenChat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(228)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 462);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 63);
            this.panel2.TabIndex = 14;
            // 
            // StaffMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonOpenChat);
            this.Controls.Add(this.ButtonDeleteMeeting);
            this.Controls.Add(this.ButtonUpdateStaffList);
            this.Controls.Add(this.ButtonUpdateStudentsList);
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
        private System.Windows.Forms.Label LabelWelcomeBack;
        private System.Windows.Forms.Button ButtonSelectStudent;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonUpdateStudentsList;
        private System.Windows.Forms.Button ButtonUpdateStaffList;
        private System.Windows.Forms.ListBox ListBoxUpcomingMeetings;
        private System.Windows.Forms.Button ButtonDeleteMeeting;
        private System.Windows.Forms.Button ButtonOpenChat;
        private System.Windows.Forms.Panel panel2;
    }
}