namespace SecureLine
{
    partial class SelectStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectStudentForm));
            this.ListBoxStudentList = new System.Windows.Forms.ListBox();
            this.TextBoxSearchBar = new System.Windows.Forms.TextBox();
            this.ButtonViewNotes = new System.Windows.Forms.Button();
            this.ButtonAddNotes = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonCreateMeeting = new System.Windows.Forms.Button();
            this.GroupBoxCreateMeeting = new System.Windows.Forms.GroupBox();
            this.LabelMinutes = new System.Windows.Forms.Label();
            this.CheckBoxCustomLength = new System.Windows.Forms.CheckBox();
            this.ListBoxStaffList = new System.Windows.Forms.ListBox();
            this.LabelStaffMember = new System.Windows.Forms.Label();
            this.TextBoxSelectedStudent = new System.Windows.Forms.TextBox();
            this.LabelSelectedStudent = new System.Windows.Forms.Label();
            this.TextBoxCustomLength = new System.Windows.Forms.TextBox();
            this.LabelOr = new System.Windows.Forms.Label();
            this.ListBoxMeetingLengths = new System.Windows.Forms.ListBox();
            this.LabelMeetingLength = new System.Windows.Forms.Label();
            this.DateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.LabelMeetingTime = new System.Windows.Forms.Label();
            this.LabelMeetingDate = new System.Windows.Forms.Label();
            this.DateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TextBoxIndicator = new System.Windows.Forms.TextBox();
            this.LabelStudentNewIndicator = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GroupBoxCreateMeeting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxStudentList
            // 
            this.ListBoxStudentList.FormattingEnabled = true;
            this.ListBoxStudentList.ItemHeight = 30;
            this.ListBoxStudentList.Location = new System.Drawing.Point(12, 12);
            this.ListBoxStudentList.Name = "ListBoxStudentList";
            this.ListBoxStudentList.Size = new System.Drawing.Size(341, 454);
            this.ListBoxStudentList.TabIndex = 13;
            this.ListBoxStudentList.SelectedValueChanged += new System.EventHandler(this.ListBoxStudentList_SelectedValueChanged);
            // 
            // TextBoxSearchBar
            // 
            this.TextBoxSearchBar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearchBar.Location = new System.Drawing.Point(370, 12);
            this.TextBoxSearchBar.MaxLength = 50;
            this.TextBoxSearchBar.Name = "TextBoxSearchBar";
            this.TextBoxSearchBar.Size = new System.Drawing.Size(214, 33);
            this.TextBoxSearchBar.TabIndex = 0;
            this.TextBoxSearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearchBar_KeyPress);
            // 
            // ButtonViewNotes
            // 
            this.ButtonViewNotes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonViewNotes.Location = new System.Drawing.Point(370, 143);
            this.ButtonViewNotes.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonViewNotes.Name = "ButtonViewNotes";
            this.ButtonViewNotes.Size = new System.Drawing.Size(214, 39);
            this.ButtonViewNotes.TabIndex = 4;
            this.ButtonViewNotes.Text = "View notes/messages";
            this.ButtonViewNotes.UseVisualStyleBackColor = true;
            this.ButtonViewNotes.Click += new System.EventHandler(this.ButtonViewNotes_Click);
            // 
            // ButtonAddNotes
            // 
            this.ButtonAddNotes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddNotes.Location = new System.Drawing.Point(370, 98);
            this.ButtonAddNotes.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonAddNotes.Name = "ButtonAddNotes";
            this.ButtonAddNotes.Size = new System.Drawing.Size(214, 39);
            this.ButtonAddNotes.TabIndex = 3;
            this.ButtonAddNotes.Text = "Add note";
            this.ButtonAddNotes.UseVisualStyleBackColor = true;
            this.ButtonAddNotes.Click += new System.EventHandler(this.ButtonAddNotes_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(370, 419);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(211, 39);
            this.ButtonExit.TabIndex = 12;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Location = new System.Drawing.Point(370, 55);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(214, 39);
            this.ButtonSearch.TabIndex = 1;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonCreateMeeting
            // 
            this.ButtonCreateMeeting.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCreateMeeting.Location = new System.Drawing.Point(156, 407);
            this.ButtonCreateMeeting.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonCreateMeeting.Name = "ButtonCreateMeeting";
            this.ButtonCreateMeeting.Size = new System.Drawing.Size(214, 39);
            this.ButtonCreateMeeting.TabIndex = 11;
            this.ButtonCreateMeeting.Text = "Schedule meeting";
            this.ButtonCreateMeeting.UseVisualStyleBackColor = true;
            this.ButtonCreateMeeting.Click += new System.EventHandler(this.ButtonCreateMeeting_Click);
            // 
            // GroupBoxCreateMeeting
            // 
            this.GroupBoxCreateMeeting.Controls.Add(this.LabelMinutes);
            this.GroupBoxCreateMeeting.Controls.Add(this.CheckBoxCustomLength);
            this.GroupBoxCreateMeeting.Controls.Add(this.ListBoxStaffList);
            this.GroupBoxCreateMeeting.Controls.Add(this.LabelStaffMember);
            this.GroupBoxCreateMeeting.Controls.Add(this.TextBoxSelectedStudent);
            this.GroupBoxCreateMeeting.Controls.Add(this.LabelSelectedStudent);
            this.GroupBoxCreateMeeting.Controls.Add(this.TextBoxCustomLength);
            this.GroupBoxCreateMeeting.Controls.Add(this.LabelOr);
            this.GroupBoxCreateMeeting.Controls.Add(this.ListBoxMeetingLengths);
            this.GroupBoxCreateMeeting.Controls.Add(this.LabelMeetingLength);
            this.GroupBoxCreateMeeting.Controls.Add(this.DateTimePickerTime);
            this.GroupBoxCreateMeeting.Controls.Add(this.LabelMeetingTime);
            this.GroupBoxCreateMeeting.Controls.Add(this.LabelMeetingDate);
            this.GroupBoxCreateMeeting.Controls.Add(this.DateTimePickerDate);
            this.GroupBoxCreateMeeting.Controls.Add(this.ButtonCreateMeeting);
            this.GroupBoxCreateMeeting.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCreateMeeting.Location = new System.Drawing.Point(618, 12);
            this.GroupBoxCreateMeeting.Name = "GroupBoxCreateMeeting";
            this.GroupBoxCreateMeeting.Size = new System.Drawing.Size(544, 454);
            this.GroupBoxCreateMeeting.TabIndex = 17;
            this.GroupBoxCreateMeeting.TabStop = false;
            this.GroupBoxCreateMeeting.Text = "Schedule a Meeting";
            // 
            // LabelMinutes
            // 
            this.LabelMinutes.AutoSize = true;
            this.LabelMinutes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMinutes.Location = new System.Drawing.Point(400, 178);
            this.LabelMinutes.Name = "LabelMinutes";
            this.LabelMinutes.Size = new System.Drawing.Size(122, 30);
            this.LabelMinutes.TabIndex = 30;
            this.LabelMinutes.Text = "(in minutes)";
            // 
            // CheckBoxCustomLength
            // 
            this.CheckBoxCustomLength.AutoCheck = false;
            this.CheckBoxCustomLength.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxCustomLength.Location = new System.Drawing.Point(12, 255);
            this.CheckBoxCustomLength.Name = "CheckBoxCustomLength";
            this.CheckBoxCustomLength.Size = new System.Drawing.Size(176, 71);
            this.CheckBoxCustomLength.TabIndex = 8;
            this.CheckBoxCustomLength.Text = "Custom Length (in minutes)";
            this.CheckBoxCustomLength.UseVisualStyleBackColor = true;
            this.CheckBoxCustomLength.Click += new System.EventHandler(this.CheckBoxCustomLength_Click);
            // 
            // ListBoxStaffList
            // 
            this.ListBoxStaffList.FormattingEnabled = true;
            this.ListBoxStaffList.ItemHeight = 30;
            this.ListBoxStaffList.Location = new System.Drawing.Point(212, 342);
            this.ListBoxStaffList.Name = "ListBoxStaffList";
            this.ListBoxStaffList.Size = new System.Drawing.Size(310, 34);
            this.ListBoxStaffList.TabIndex = 10;
            this.ListBoxStaffList.Validating += new System.ComponentModel.CancelEventHandler(this.ListBoxStaffList_Validating);
            // 
            // LabelStaffMember
            // 
            this.LabelStaffMember.AutoSize = true;
            this.LabelStaffMember.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStaffMember.Location = new System.Drawing.Point(7, 346);
            this.LabelStaffMember.Name = "LabelStaffMember";
            this.LabelStaffMember.Size = new System.Drawing.Size(139, 30);
            this.LabelStaffMember.TabIndex = 29;
            this.LabelStaffMember.Text = "Staff Member";
            // 
            // TextBoxSelectedStudent
            // 
            this.TextBoxSelectedStudent.Enabled = false;
            this.TextBoxSelectedStudent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSelectedStudent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxSelectedStudent.Location = new System.Drawing.Point(212, 47);
            this.TextBoxSelectedStudent.MaxLength = 50;
            this.TextBoxSelectedStudent.Name = "TextBoxSelectedStudent";
            this.TextBoxSelectedStudent.Size = new System.Drawing.Size(310, 33);
            this.TextBoxSelectedStudent.TabIndex = 14;
            this.TextBoxSelectedStudent.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxSelectedStudent_Validating);
            // 
            // LabelSelectedStudent
            // 
            this.LabelSelectedStudent.AutoSize = true;
            this.LabelSelectedStudent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSelectedStudent.Location = new System.Drawing.Point(7, 52);
            this.LabelSelectedStudent.Name = "LabelSelectedStudent";
            this.LabelSelectedStudent.Size = new System.Drawing.Size(168, 30);
            this.LabelSelectedStudent.TabIndex = 27;
            this.LabelSelectedStudent.Text = "Selected Student";
            // 
            // TextBoxCustomLength
            // 
            this.TextBoxCustomLength.Enabled = false;
            this.TextBoxCustomLength.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCustomLength.Location = new System.Drawing.Point(212, 266);
            this.TextBoxCustomLength.MaxLength = 3;
            this.TextBoxCustomLength.Name = "TextBoxCustomLength";
            this.TextBoxCustomLength.Size = new System.Drawing.Size(310, 33);
            this.TextBoxCustomLength.TabIndex = 9;
            this.TextBoxCustomLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCustomLength_KeyPress);
            this.TextBoxCustomLength.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxCustomLength_Validating);
            // 
            // LabelOr
            // 
            this.LabelOr.AutoSize = true;
            this.LabelOr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOr.Location = new System.Drawing.Point(169, 227);
            this.LabelOr.Name = "LabelOr";
            this.LabelOr.Size = new System.Drawing.Size(33, 25);
            this.LabelOr.TabIndex = 23;
            this.LabelOr.Text = "Or";
            // 
            // ListBoxMeetingLengths
            // 
            this.ListBoxMeetingLengths.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxMeetingLengths.FormattingEnabled = true;
            this.ListBoxMeetingLengths.ItemHeight = 30;
            this.ListBoxMeetingLengths.Location = new System.Drawing.Point(212, 174);
            this.ListBoxMeetingLengths.Name = "ListBoxMeetingLengths";
            this.ListBoxMeetingLengths.Size = new System.Drawing.Size(158, 34);
            this.ListBoxMeetingLengths.TabIndex = 22;
            this.ListBoxMeetingLengths.Validating += new System.ComponentModel.CancelEventHandler(this.ListBoxMeetingLengths_Validating);
            // 
            // LabelMeetingLength
            // 
            this.LabelMeetingLength.AutoSize = true;
            this.LabelMeetingLength.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMeetingLength.Location = new System.Drawing.Point(6, 178);
            this.LabelMeetingLength.Name = "LabelMeetingLength";
            this.LabelMeetingLength.Size = new System.Drawing.Size(160, 30);
            this.LabelMeetingLength.TabIndex = 21;
            this.LabelMeetingLength.Text = "Meeting Length";
            // 
            // DateTimePickerTime
            // 
            this.DateTimePickerTime.CustomFormat = "HH:mm";
            this.DateTimePickerTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerTime.Location = new System.Drawing.Point(212, 131);
            this.DateTimePickerTime.Name = "DateTimePickerTime";
            this.DateTimePickerTime.Size = new System.Drawing.Size(310, 35);
            this.DateTimePickerTime.TabIndex = 6;
            this.DateTimePickerTime.Validating += new System.ComponentModel.CancelEventHandler(this.DateTimePickerTime_Validating);
            // 
            // LabelMeetingTime
            // 
            this.LabelMeetingTime.AutoSize = true;
            this.LabelMeetingTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMeetingTime.Location = new System.Drawing.Point(6, 135);
            this.LabelMeetingTime.Name = "LabelMeetingTime";
            this.LabelMeetingTime.Size = new System.Drawing.Size(141, 30);
            this.LabelMeetingTime.TabIndex = 19;
            this.LabelMeetingTime.Text = "Meeting Time";
            // 
            // LabelMeetingDate
            // 
            this.LabelMeetingDate.AutoSize = true;
            this.LabelMeetingDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMeetingDate.Location = new System.Drawing.Point(6, 91);
            this.LabelMeetingDate.Name = "LabelMeetingDate";
            this.LabelMeetingDate.Size = new System.Drawing.Size(140, 30);
            this.LabelMeetingDate.TabIndex = 18;
            this.LabelMeetingDate.Text = "Meeting Date";
            // 
            // DateTimePickerDate
            // 
            this.DateTimePickerDate.AllowDrop = true;
            this.DateTimePickerDate.CalendarFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerDate.CustomFormat = "yyyy-MM-dd";
            this.DateTimePickerDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerDate.Location = new System.Drawing.Point(212, 86);
            this.DateTimePickerDate.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerDate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerDate.Name = "DateTimePickerDate";
            this.DateTimePickerDate.Size = new System.Drawing.Size(310, 35);
            this.DateTimePickerDate.TabIndex = 5;
            this.DateTimePickerDate.Validating += new System.ComponentModel.CancelEventHandler(this.DateTimePickerDate_Validating);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // TextBoxIndicator
            // 
            this.TextBoxIndicator.Location = new System.Drawing.Point(370, 222);
            this.TextBoxIndicator.Multiline = true;
            this.TextBoxIndicator.Name = "TextBoxIndicator";
            this.TextBoxIndicator.Size = new System.Drawing.Size(161, 48);
            this.TextBoxIndicator.TabIndex = 18;
            // 
            // LabelStudentNewIndicator
            // 
            this.LabelStudentNewIndicator.AutoSize = true;
            this.LabelStudentNewIndicator.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentNewIndicator.Location = new System.Drawing.Point(365, 194);
            this.LabelStudentNewIndicator.Name = "LabelStudentNewIndicator";
            this.LabelStudentNewIndicator.Size = new System.Drawing.Size(166, 25);
            this.LabelStudentNewIndicator.TabIndex = 31;
            this.LabelStudentNewIndicator.Text = "First time student?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(228)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 63);
            this.panel2.TabIndex = 32;
            // 
            // SelectStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LabelStudentNewIndicator);
            this.Controls.Add(this.TextBoxIndicator);
            this.Controls.Add(this.GroupBoxCreateMeeting);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonAddNotes);
            this.Controls.Add(this.ButtonViewNotes);
            this.Controls.Add(this.TextBoxSearchBar);
            this.Controls.Add(this.ListBoxStudentList);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "SelectStudentForm";
            this.Text = "Select Student";
            this.GroupBoxCreateMeeting.ResumeLayout(false);
            this.GroupBoxCreateMeeting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxStudentList;
        private System.Windows.Forms.TextBox TextBoxSearchBar;
        private System.Windows.Forms.Button ButtonViewNotes;
        private System.Windows.Forms.Button ButtonAddNotes;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonCreateMeeting;
        private System.Windows.Forms.GroupBox GroupBoxCreateMeeting;
        private System.Windows.Forms.TextBox TextBoxSelectedStudent;
        private System.Windows.Forms.Label LabelSelectedStudent;
        private System.Windows.Forms.TextBox TextBoxCustomLength;
        private System.Windows.Forms.Label LabelOr;
        private System.Windows.Forms.ListBox ListBoxMeetingLengths;
        private System.Windows.Forms.Label LabelMeetingLength;
        private System.Windows.Forms.DateTimePicker DateTimePickerTime;
        private System.Windows.Forms.Label LabelMeetingTime;
        private System.Windows.Forms.Label LabelMeetingDate;
        private System.Windows.Forms.DateTimePicker DateTimePickerDate;
        private System.Windows.Forms.ListBox ListBoxStaffList;
        private System.Windows.Forms.Label LabelStaffMember;
        private System.Windows.Forms.CheckBox CheckBoxCustomLength;
        private System.Windows.Forms.Label LabelMinutes;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Label LabelStudentNewIndicator;
        private System.Windows.Forms.TextBox TextBoxIndicator;
        private System.Windows.Forms.Panel panel2;
    }
}