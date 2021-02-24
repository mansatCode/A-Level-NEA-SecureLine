using SecureLine.Data_Access;
using SecureLine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecureLine
{
    public partial class SelectStudentForm : Form
    {
        //List that holds the records retrieved from TblStudent in the database
        private List<StudentModel> students = new List<StudentModel>();
        //List that holds the records retrieved from TblStaff in the database
        private List<StaffModel> staffMembers = new List<StaffModel>();

        //Holds the information for the logged in staff member
        private StaffModel staffMember;
        //Holds the information for the student selected in ListBoxStudentList
        private StudentModel selectedStudent;

        private const string NULLDATAERRORMESSAGE = "Field cannot be left empty";

        //A list of meeting lengths used to populate ListBoxMeetingLengths
        private List<int> timeOptions = new List<int>()
        {
            10,
            15,
            20,
            30,
            45,
            60
        };

        public SelectStudentForm(StaffModel s)
        {
            staffMember = s;
            InitializeComponent();
            InitaliseLists();
        }

        /// <summary>
        /// Retrieves the required records from TblStudent and TblStaff from the database
        /// and stores them in separate lists. These lists are used to populate the 
        /// ListBoxes. 
        /// </summary>
        private void InitaliseLists()
        {
            try
            {
                //Gets a list of all the students
                SqlConnector db = new SqlConnector();
                students = db.GetStudent_All();
            }
            catch
            {
                MyMessageBox.ShowMessage("Failed to load student list from the database.");
                return;
            }
            //Populates the listbox and defines how to format them
            ListBoxStudentList.DataSource = students;
            ListBoxStudentList.DisplayMember = "FullNameReversed";

            try
            {
                SqlConnector db = new SqlConnector();
                staffMembers = db.GetStaff_All();
            }
            catch
            {
                MyMessageBox.ShowMessage("Failed to load staff members from the database.");
                return;
            }
            ListBoxStaffList.DataSource = staffMembers;
            ListBoxStaffList.DisplayMember = "FullNameReversed";
            ListBoxMeetingLengths.DataSource = timeOptions;
        }

        /// <summary>
        /// When the user searches for a student in the search box, ListBoxStudentList needs to be 
        /// updated to display the new list of students. 
        /// </summary>
        private void UpdateStudentList()
        {
            ListBoxStudentList.DataSource = students;
            ListBoxStudentList.DisplayMember = "FullNameReversed";
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Updates the list of students according to what was input in the search box
                SqlConnector db = new SqlConnector();
                students = db.GetStudentList_BySearch(TextBoxSearchBar.Text);
            }
            catch
            {
                MyMessageBox.ShowMessage("Failed to load student list from the database.");
                return;
            }
            UpdateStudentList();
        }

        /// <summary>
        /// Function called when the user attempts to create a meeting.
        /// The ErrorProvider only set an error if the event TextBox_Validating is fired. If the user presses
        /// the schedule meeting button before this event can be triggered, it would appear as though the data is valid as
        /// there would be no ErrorProvider message. Therefore, when that button is pressed, each control 
        /// must be validated.
        /// </summary>
        /// <returns>A boolean indicating whether the input data is valid or not.</returns>
        private bool ValidateForm_CreateMeeting()
        {
            bool isValid = true;
            //Lamda expression to compare the ErrorProviders error message with the constant ERRORMESSAGE.
            //If they are equal, compareString returns true.
            Func<string, bool> compareString = s => s == NULLDATAERRORMESSAGE;

            //Alternative to writing IF statements that improve readability since the use far less lines
            ClassLibrary.CheckTextBoxNotNull(TextBoxSelectedStudent, ErrorProvider);
            isValid = compareString(ErrorProvider.GetError(TextBoxSelectedStudent)) ? false : isValid;
            CheckDateTimePickerNotNull(DateTimePickerDate);
            isValid = compareString(ErrorProvider.GetError(DateTimePickerDate)) ? false : isValid;
            CheckDateTimePickerNotNull(DateTimePickerTime);
            isValid = compareString(ErrorProvider.GetError(DateTimePickerTime)) ? false : isValid;
            CheckListBoxNotNull(ListBoxStaffList);
            isValid = compareString(ErrorProvider.GetError(ListBoxStaffList)) ? false : isValid;

            //Whether the checkbox is checked or not determines which control to validate
            if (CheckBoxCustomLength.Checked)
            {
                ClassLibrary.CheckTextBoxNotNull(TextBoxCustomLength, ErrorProvider);
                isValid = compareString(ErrorProvider.GetError(TextBoxCustomLength)) ? false : isValid;
            }
            else
            {
                CheckListBoxNotNull(ListBoxMeetingLengths);
                isValid = compareString(ErrorProvider.GetError(ListBoxMeetingLengths)) ? false : isValid;
            }

            return isValid;
        }

        private void ButtonCreateMeeting_Click(object sender, EventArgs e)
        {
            //If all the controls validated correctly
            if (ValidateForm_CreateMeeting())
            {
                int meetingLength;

                if (CheckBoxCustomLength.Checked)
                {
                    meetingLength = int.Parse(TextBoxCustomLength.Text);
                }
                else
                {
                    meetingLength = timeOptions[ListBoxMeetingLengths.SelectedIndex];
                }

                //Get the staff member selected in the listbox
                StaffModel selectedStaffMember = staffMembers[ListBoxStaffList.SelectedIndex];

                //Create a new meeting
                MeetingModel meeting = new MeetingModel(
                    selectedStudent.StudentID,
                    DateTimePickerDate.Value,
                    DateTimePickerTime.Value,
                    meetingLength,
                    selectedStaffMember.StaffID);

                try
                {
                    GlobalConfig.Connection.CreateMeeting(meeting);
                }
                catch
                {
                    MyMessageBox.ShowMessage("Failed to add meeting to the database.");
                    return;
                }
                MyMessageBox.ShowMessage("Successfully scheduled the meeting");
            
                try
                {
                    //Update the selected student's record in the database to show they have had a meeting before
                    SqlConnector db = new SqlConnector();
                    db.UpdateIsNewStudent(selectedStudent.StudentID);
                }
                catch
                {
                    MyMessageBox.ShowMessage("Failed to update student's status.");
                    return;
                }

                TextBoxCustomLength.Clear();

                //Email the participants
                SendEmail_ScheduleMeeting(meeting, selectedStudent.StudentEmail, selectedStaffMember.StaffFirstName, selectedStaffMember.StaffLastName);
                SendEmail_ScheduleMeeting(meeting, selectedStaffMember.StaffEmail, selectedStudent.StudentFirstName, selectedStudent.StudentLastName);
            }
            else
            {
                MyMessageBox.ShowMessage("Not all components validated successfully. Please check the flagged entries and try again.");
            }
        }

        private void SendEmail_ScheduleMeeting(MeetingModel m, string recipientAddress, string firstName, string lastName) 
        {
            //Using a StringBuilder is much more memory efficient than repeated concatenation.
            StringBuilder body = new StringBuilder(); 
            string subject = "New meeting scheduled";

            body.AppendLine("<h1>You have a new meeting</h1>");
            body.AppendLine("<p>Secheduled with ");
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
            body.AppendLine(" minutes.</p>");
            body.AppendLine("<br />");
            body.AppendLine("<p>Excited to see you there!</p>");
            body.AppendLine("<p>~SecureLine</p>");

            EmailLogic.SendEmail(recipientAddress, subject, body.ToString());
        }

        private void CheckBoxCustomLength_Click(object sender, EventArgs e)
        {
            //Depending on whether the checkbox is checked or not, certain 
            //controls need enabling/disabling
            if (TextBoxCustomLength.Enabled == false)
            {
                CheckBoxCustomLength.Checked = true;
                TextBoxCustomLength.Enabled = true;
                ListBoxMeetingLengths.ClearSelected();
                ListBoxMeetingLengths.Enabled = false;
            }
            else if (TextBoxCustomLength.Enabled == true)
            {
                CheckBoxCustomLength.Checked = false;
                TextBoxCustomLength.Text = "";
                TextBoxCustomLength.Enabled = false;
                ListBoxMeetingLengths.Enabled = true;
                ErrorProvider.SetError(TextBoxCustomLength, null);
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffMainForm f2 = new StaffMainForm(staffMember);
            f2.ShowDialog();
            this.Close();
        }

        //Event for when the selected value in ListBoxStudentList is changed
        private void ListBoxStudentList_SelectedValueChanged(object sender, EventArgs e)
        {
            int index;
            string selectedStudentName;

            index = ListBoxStudentList.SelectedIndex;
            selectedStudent = students[index];
            selectedStudentName = $"{selectedStudent.StudentLastName}, {selectedStudent.StudentFirstName}";
            TextBoxSelectedStudent.Text = selectedStudentName;

            //Change colour of indicator textbox    
            if (selectedStudent.IsNewStudent)
            {
                TextBoxIndicator.ForeColor = Color.White;
                TextBoxIndicator.BackColor = Color.IndianRed;
                TextBoxIndicator.Text = "First time";
            }
            else
            {
                TextBoxIndicator.ForeColor = Color.White;
                TextBoxIndicator.BackColor = Color.Green;
                TextBoxIndicator.Text = "Repeat";
            }

        }

        private void ButtonAddNotes_Click(object sender, EventArgs e)
        {
            //If no student is selected, then display a message.
            //Otherwise, open a new AddNoteForm.
            if (ListBoxStudentList.SelectedItem == null)
            {
                MyMessageBox.ShowMessage("No student selected.");
            }
            else
            {
                AddNoteForm addNoteForm = new AddNoteForm(selectedStudent);
                addNoteForm.ShowDialog();
            }
        }

        private void ButtonViewNotes_Click(object sender, EventArgs e)
        {
            ViewNoteForm viewNoteForm = new ViewNoteForm(selectedStudent);
            viewNoteForm.ShowDialog();
        }

        //When the user tries to enter a key, system checks whether it is a valid key or not.
        //If it is invalid, it is not permitted by the control.
        private void TextBoxSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Input must be a character, control, whitespace or hyphen
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 45) 
            {
                e.Handled = true;
            }
        }

        private void TextBoxCustomLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Input must be a digit or control character
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Checks whether a DateTimePicker control contains null data. 
        /// If it does, the ErrorProvider sets an error.
        /// </summary>
        /// <param name="d"></param>
        private void CheckDateTimePickerNotNull(DateTimePicker d)
        {
            if (d.Value == null)
            {
                ErrorProvider.SetError(d, NULLDATAERRORMESSAGE);
            }
            else
            {
                ErrorProvider.SetError(d, null);
            }
        }

        /// <summary>
        /// Checks whether the selected item of a listbox is null.
        /// If it is, the ErrorProvider sets an error.
        /// </summary>
        /// <param name="l"></param>
        private void CheckListBoxNotNull(ListBox l)
        {
            if (l.SelectedItem == null)
            {
                ErrorProvider.SetError(l, NULLDATAERRORMESSAGE);
            }
            else
            {
                ErrorProvider.SetError(l, null);
            }
        }

        //Events
        private void TextBoxCustomLength_Validating(object sender, CancelEventArgs e)
        {
            ClassLibrary.CheckTextBoxNotNull(TextBoxCustomLength, ErrorProvider);
        }

        private void TextBoxSelectedStudent_Validating(object sender, CancelEventArgs e)
        {
            ClassLibrary.CheckTextBoxNotNull(TextBoxSelectedStudent, ErrorProvider);
        }

        private void DateTimePickerDate_Validating(object sender, CancelEventArgs e)
        {
            CheckDateTimePickerNotNull(DateTimePickerDate);
        }

        private void DateTimePickerTime_Validating(object sender, CancelEventArgs e)
        {
            CheckDateTimePickerNotNull(DateTimePickerTime);
        }

        private void ListBoxMeetingLengths_Validating(object sender, CancelEventArgs e)
        {
            CheckListBoxNotNull(ListBoxMeetingLengths);
        }

        private void ListBoxStaffList_Validating(object sender, CancelEventArgs e)
        {
            CheckListBoxNotNull(ListBoxStaffList);
        }

    }
}
