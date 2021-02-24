using SecureLine.Data_Access;
using System;
using System.Collections.Generic;

namespace SecureLine.Models
{
    public class MeetingModel
    {
        /// <summary>
        /// Represents the ID of the meeting.
        /// </summary>
        public int MeetingID { get; set; }
        /// <summary>
        /// Represents the date of the meeting.
        /// </summary>
        public DateTime MeetingDate { get; set; }
        /// <summary>
        /// Represents the time of the meeting.
        /// </summary>
        public TimeSpan MeetingTime { get; set; } //causing a bug
        /// <summary>
        /// Represents the length of the meeting in minutes.
        /// </summary>
        public int MeetingLength { get; set; }
        /// <summary>
        /// Represents the ID of the student attending the meeting.
        /// </summary>
        public string StudentID { get; set; }
        /// <summary>
        /// Represents the ID of the staff member attending the meeting.
        /// </summary>
        public int StaffID { get; set; }

        //Defines how the information about upcoming meetings should be displayed in the listbox
        public string StaffPOVOldAppointment
        {
            
            get
            {
                List<StudentModel> students = new List<StudentModel>();
                StudentModel s = null;
                string dayOfTheWeek = MeetingDate.DayOfWeek.ToString();
                string date = MeetingDate.ToShortDateString();
                string time = MeetingTime.ToString().Substring(0,5);
                string appointmentLength = $"{MeetingLength} minute";

                try
                {
                    SqlConnector db = new SqlConnector();
                    students = db.GetStudent_All();
                }
                catch
                {
                    MyMessageBox.ShowMessage("Access to the database failed: couldn't retrieve the list of students.");
                }

                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].StudentID == StudentID)
                    {
                        s = students[i];
                    }
                }

                return $"{dayOfTheWeek}, {date} {time} with {s.StudentLastName}, {s.StudentFirstName}";
            }
        }

        //Defines how the information about upcoming meetings should be displayed in the listbox
        public string StaffPOVUpcomingAppointment
        {
            get
            {
                List<StudentModel> students = new List<StudentModel>();
                StudentModel s = null;
                string dayOfTheWeek = MeetingDate.DayOfWeek.ToString();
                string date = MeetingDate.ToShortDateString();
                string time = MeetingTime.ToString().Substring(0, 5);

                try
                {
                    SqlConnector db = new SqlConnector();
                    students = db.GetStudent_All();
                }
                catch
                {
                    MyMessageBox.ShowMessage("Access to the database failed: couldn't retrieve the list of students.");
                }

                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].StudentID == StudentID)
                    {
                        s = students[i];
                    }
                }

                return $"{dayOfTheWeek}, {date} {time} - {MeetingLength} minutes with {s.StudentLastName}, {s.StudentFirstName}";
            }
        }

        //Defines how the information about upcoming meetings should be displayed in the listbox
        public string StudentPOVUpcomingAppointment
        {
            get
            {
                List<StaffModel> staffMembers = new List<StaffModel>();
                StaffModel s = null;
                string dayOfTheWeek = MeetingDate.DayOfWeek.ToString();
                string date = MeetingDate.ToShortDateString();
                string time = MeetingTime.ToString().Substring(0, 5);

                try
                {
                    SqlConnector db = new SqlConnector();
                    staffMembers = db.GetStaff_All();
                }
                catch
                {
                    MyMessageBox.ShowMessage("Access to database failed: failed to retrive the staff members list.");
                }

                for (int i = 0; i < staffMembers.Count; i++)
                {
                    if (staffMembers[i].StaffID == StaffID)
                    {
                        s = staffMembers[i];
                    }
                }

                return $"{dayOfTheWeek}, {date} {time} - {MeetingLength} minutes with {s.StaffFirstName}, {s.StaffLastName}";
            }
        }


        public MeetingModel()
        {

        }

        //Constructor to create new MeetingModel
        public MeetingModel(string studentID, DateTime date, DateTime time, int meetingLength, int staffID)
        {
            DateTime formattedDate;
            TimeSpan formattedTime;

            StudentID = studentID;

            //Format the date so it's compaitble with the format used in the database
            formattedDate = date.Date;
            MeetingDate = formattedDate;

            //Format the time so it's compatible with the format used in the database
            formattedTime = time.TimeOfDay;
            MeetingTime = formattedTime;
            MeetingLength = meetingLength;
            StaffID = staffID;
        }
    }
}
