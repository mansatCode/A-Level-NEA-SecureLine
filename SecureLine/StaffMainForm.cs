using SecureLine.Data_Access;
using SecureLine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecureLine
{
    public partial class StaffMainForm : Form
    {
        private List<MeetingModel> meetings = new List<MeetingModel>();
        private StaffModel staffMember;

        public StaffMainForm(StaffModel s)
        {
            staffMember = s;
            InitializeComponent();
            InitaliseList();
        }

        /// <summary>
        /// Retrieves the relevant records from TblMeeting in the database and 
        /// stores them in the meetings list.
        /// The ListBoxUpcomingMeetings is then populated using the meetings list.
        /// </summary>
        public void InitaliseList()
        {
            try
            {
                SqlConnector db = new SqlConnector();
                meetings = db.GetMeeting_ByStaffIDAndDate(staffMember.StaffID, DateTime.Now.Date);
            }
            catch
            {
                MyMessageBox.ShowMessage("Failed to load meetings from the database.");
                return;
            }
            ListBoxUpcomingMeetings.DataSource = meetings;
            ListBoxUpcomingMeetings.DisplayMember = "StaffPOVUpcomingAppointment";
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffSettingsForm staffSettingsForm = new StaffSettingsForm(staffMember);
            staffSettingsForm.ShowDialog();
            this.Close();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindowForm logInForm = new LoginWindowForm();
            logInForm.ShowDialog();
            this.Close();
        }

        private void ButtonUpdateStudentsList_Click(object sender, EventArgs e)
        {
            UpdateStudentListForm updateStudentListForm = new UpdateStudentListForm();
            updateStudentListForm.ShowDialog();
        }

        private void ButtonUpdateStaffList_Click(object sender, EventArgs e)
        {
            UpdateStaffListForm updateStaffListForm = new UpdateStaffListForm(staffMember);
            updateStaffListForm.ShowDialog();
        }

        private void ButtonSelectStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectStudentForm selectStudentForm = new SelectStudentForm(staffMember);
            selectStudentForm.ShowDialog();
            this.Close();
        }

        private void ButtonDeleteMeeting_Click(object sender, EventArgs e)
        {
            if(meetings.Count() == 0 || ListBoxUpcomingMeetings.SelectedItem == null)
            {
                MyMessageBox.ShowMessage("No meetings to delete.");
            }
            else
            {
                MeetingModel meeting = meetings[ListBoxUpcomingMeetings.SelectedIndex];
                string studentID = meeting.StudentID;
                int staffID = meeting.StaffID;
                List<StudentModel> studentToEmail;

                try
                {
                    SqlConnector db = new SqlConnector();
                    db.DeleteMeeting_ByMeetingID(meeting.MeetingID);
                }
                catch
                {
                    MyMessageBox.ShowMessage("Action aborted. Access to database failed.");
                    return;
                }

                InitaliseList();

                //Find participating student
                try
                {
                    SqlConnector db = new SqlConnector();
                    studentToEmail = db.GetStudent_ByStudentID(studentID);
                }
                catch
                {
                    MyMessageBox.ShowMessage("Action aborted. Access to database failed.");
                    return;
                }

                //Email the participants
                SendEmail_CancelMeeting(studentToEmail[0].StudentEmail, staffMember.StaffFirstName, staffMember.StaffLastName, meeting);
                SendEmail_CancelMeeting(staffMember.StaffEmail, studentToEmail[0].StudentFirstName, studentToEmail[0].StudentLastName, meeting);
            }
        }

        private void SendEmail_CancelMeeting(string recipientAddress, string firstName, string lastName, MeetingModel m)
        {
            //StringBuilder is used as it is much more 
            //memory efficient than concatenation
            StringBuilder body = new StringBuilder(); 
            string subject = "Upcoming meeting cancelled";

            //HTML tags used to format the e-mail
            body.AppendLine("<h1>Meeting cancelled</h1>");
            body.AppendLine("<p>Your meeting scheduled with ");
            body.AppendLine(firstName);
            body.AppendLine(" ");
            body.AppendLine(lastName);
            body.AppendLine(", on ");
            body.AppendLine(m.MeetingDate.DayOfWeek.ToString());
            body.AppendLine(" (");
            body.AppendLine(m.MeetingDate.ToShortDateString());
            body.AppendLine(") at ");
            body.AppendLine(m.MeetingTime.ToString().Substring(0, 5));
            body.AppendLine(" lasting ");
            body.AppendLine(m.MeetingLength.ToString());
            body.AppendLine(" minutes has been <strong>cancelled</strong>.</p>");
            body.AppendLine("<br />");
            body.AppendLine("<p>Apologies for the inconvenience!</p>");
            body.AppendLine("<p>~SecureLine</p>");

            EmailLogic.SendEmail(recipientAddress, subject, body.ToString());
        }

        private void ButtonOpenChat_Click(object sender, EventArgs e)
        {
            StaffChatForm staffChatForm = new StaffChatForm(staffMember);
            staffChatForm.ShowDialog();
        }
    }
}
