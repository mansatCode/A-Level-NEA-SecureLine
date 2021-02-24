namespace SecureLine
{
    partial class StudentMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMainForm));
            this.ListBoxUpcomingMeetings = new System.Windows.Forms.ListBox();
            this.LabelUpcomingMeetings = new System.Windows.Forms.Label();
            this.LabelWelcomeBack = new System.Windows.Forms.Label();
            this.ButtonOpenChat = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
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
            this.ListBoxUpcomingMeetings.Size = new System.Drawing.Size(568, 394);
            this.ListBoxUpcomingMeetings.TabIndex = 2;
            // 
            // LabelUpcomingMeetings
            // 
            this.LabelUpcomingMeetings.AutoSize = true;
            this.LabelUpcomingMeetings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUpcomingMeetings.Location = new System.Drawing.Point(15, 9);
            this.LabelUpcomingMeetings.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelUpcomingMeetings.Name = "LabelUpcomingMeetings";
            this.LabelUpcomingMeetings.Size = new System.Drawing.Size(204, 30);
            this.LabelUpcomingMeetings.TabIndex = 5;
            this.LabelUpcomingMeetings.Text = "Upcoming meetings:";
            // 
            // LabelWelcomeBack
            // 
            this.LabelWelcomeBack.AutoSize = true;
            this.LabelWelcomeBack.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWelcomeBack.Location = new System.Drawing.Point(595, 9);
            this.LabelWelcomeBack.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelWelcomeBack.Name = "LabelWelcomeBack";
            this.LabelWelcomeBack.Size = new System.Drawing.Size(154, 30);
            this.LabelWelcomeBack.TabIndex = 6;
            this.LabelWelcomeBack.Text = "Welcome back!";
            // 
            // ButtonOpenChat
            // 
            this.ButtonOpenChat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOpenChat.Location = new System.Drawing.Point(600, 46);
            this.ButtonOpenChat.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonOpenChat.Name = "ButtonOpenChat";
            this.ButtonOpenChat.Size = new System.Drawing.Size(149, 39);
            this.ButtonOpenChat.TabIndex = 7;
            this.ButtonOpenChat.Text = "Open chat";
            this.ButtonOpenChat.UseVisualStyleBackColor = true;
            this.ButtonOpenChat.Click += new System.EventHandler(this.ButtonButtonOpenChat_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSettings.Location = new System.Drawing.Point(600, 89);
            this.ButtonSettings.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(149, 39);
            this.ButtonSettings.TabIndex = 8;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(600, 401);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(149, 39);
            this.ButtonExit.TabIndex = 12;
            this.ButtonExit.Text = "Log out";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(228)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 63);
            this.panel2.TabIndex = 13;
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 513);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.ButtonOpenChat);
            this.Controls.Add(this.LabelWelcomeBack);
            this.Controls.Add(this.LabelUpcomingMeetings);
            this.Controls.Add(this.ListBoxUpcomingMeetings);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "StudentMainForm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxUpcomingMeetings;
        private System.Windows.Forms.Label LabelUpcomingMeetings;
        private System.Windows.Forms.Label LabelWelcomeBack;
        private System.Windows.Forms.Button ButtonOpenChat;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Panel panel2;
    }
}