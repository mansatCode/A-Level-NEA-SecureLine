using SecureLine.Data_Access;
using SecureLine.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SecureLine
{
    public partial class StudentMainForm : Form
    {
        //List of type MeetingModel that stores all the 
        //upcoming meetings of the logged in student
        private List<MeetingModel> meetings = new List<MeetingModel>();
        //Stores the information of the logged in student. 
        private StudentModel student;

        public StudentMainForm(StudentModel s)
        {
            //The LoginWindowForm passes the StudentModel of the 
            //logged in student to the this form
            student = s;
            InitializeComponent();
            InitaliseList();
        }

        /// <summary>
        /// Retrieves the relevant records from TblMeeting in the database and 
        /// stores them in the meetings list.
        /// The ListBoxUpcomingMeetings is then populated using the meetings list.
        /// </summary>
        private void InitaliseList()
        {
            //If access to the database fails, display a message to the user.
            try
            {
                SqlConnector db = new SqlConnector();
                meetings = db.GetMeeting_ByStudentIDAndDate(student.StudentID, DateTime.Now.Date);
            }
            catch
            {
                MyMessageBox.ShowMessage("Failed to load meetings from the database.");
                return;
            }
            ListBoxUpcomingMeetings.DataSource = meetings;
            ListBoxUpcomingMeetings.DisplayMember = "StudentPOVUpcomingAppointment";
        }


        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Passes the StudentModel to the next form
            StudentSettingsForm studentSettingsForm = new StudentSettingsForm(student);
            studentSettingsForm.ShowDialog();
            this.Close();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindowForm logInForm = new LoginWindowForm();
            logInForm.ShowDialog();
            this.Close();
        }

        private void ButtonButtonOpenChat_Click(object sender, EventArgs e)
        {
            //Passes the StudentModel to the next form
            StudentChatForm studentChatForm = new StudentChatForm(student);
            studentChatForm.ShowDialog();
        }
    }
}
