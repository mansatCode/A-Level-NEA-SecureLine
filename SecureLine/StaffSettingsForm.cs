using SecureLine.Data_Access;
using SecureLine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace SecureLine
{
    public partial class StaffSettingsForm : Form
    {
        private StaffModel staffMember;
        private List<MeetingModel> oldMeetings = new List<MeetingModel>();

        public StaffSettingsForm(StaffModel s)
        {
            staffMember = s;
            InitializeComponent();
            UpdateList();
        }

        public void UpdateList()
        {
            try
            {
                SqlConnector db = new SqlConnector();
                oldMeetings = db.GetOldMeeting_ByStaffIDAndDate(staffMember.StaffID, DateTime.Now.Date);
            }
            catch
            {
                MyMessageBox.ShowMessage("Failed to load meetings from the database.");
                return;
            }

            ListBoxOldMeetings.DataSource = oldMeetings;
            ListBoxOldMeetings.DisplayMember = "StaffPOVOldAppointment";
            TextBoxCounter.Text = oldMeetings.Count.ToString();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffMainForm f2 = new StaffMainForm(staffMember);
            f2.ShowDialog();
            this.Close();
        }

        private void ButtonClearOldMeetings_Click(object sender, EventArgs e)
        {
            if (oldMeetings.Count > 0)
            {
                try
                {
                    SqlConnector db = new SqlConnector();
                    db.DeleteExpiredMeetings();
                }
                catch
                {
                    MyMessageBox.ShowMessage("Action aborted. Access to database failed.");
                    return;
                }
                UpdateList();
                MyMessageBox.ShowMessage("Expired meetings successfully cleared.");
            }
            else
            {
                MyMessageBox.ShowMessage("No meetings to delete.");
            }
        }

        /// <summary>
        /// Checks that the user input data is valid.
        /// </summary>
        /// <returns>A boolean indicating whether the 
        /// input data is valid or not.</returns>
        private bool ValidateForm()
        {
            const string NULLDATAERRORMESSAGE = "Field cannot be left empty";
            bool isValid = true;
            //Lamda expression to compare the ErrorProviders error message with 
            //the constant NULLDATAERRORMESSAGE.
            //If they are equal, compareString returns true.
            Func<string, bool> compareString = s => s == NULLDATAERRORMESSAGE;

            //Each control that has user input data must be checked. 
            ClassLibrary.CheckTextBoxNotNull(TextBoxOldPassword, ErrorProvider);
            //Alternative to writing IF statements that improves 
            //readability since they use far less lines. 
            //If compareString returns true, then isValid is 
            //set to false as this means the
            //ErrorProvider has set an error so the input is invalid. 
            isValid = compareString(ErrorProvider.GetError(TextBoxOldPassword)) ? false : isValid;
            ClassLibrary.CheckTextBoxNotNull(TextBoxNewPassword, ErrorProvider);
            isValid = compareString(ErrorProvider.GetError(TextBoxNewPassword)) ? false : isValid;
            ClassLibrary.CheckTextBoxNotNull(TextBoxReTypePassword, ErrorProvider);
            isValid = compareString(ErrorProvider.GetError(TextBoxReTypePassword)) ? false : isValid;

            return isValid;
        }

        private void ButtonUpdatePassword_Click(object sender, EventArgs e)
        {
            //If the user input data validates correctly
            if (ValidateForm())
            {
                if (staffMember.StaffPassword == TextBoxOldPassword.Text)
                {
                    if (TextBoxNewPassword.Text == TextBoxReTypePassword.Text)
                    {
                        try
                        {
                            SqlConnector db = new SqlConnector();
                            db.UpdateStaffPassword(staffMember.StaffID, TextBoxReTypePassword.Text);  
                        }
                        catch
                        {
                            MyMessageBox.ShowMessage("Action aborted. Access to database failed.");
                            return;
                        }

                        staffMember.StaffPassword = TextBoxReTypePassword.Text;
                        ClearAllFields();
                        MyMessageBox.ShowMessage("Password successfully changed.");
                    }
                    else
                    {
                        MyMessageBox.ShowMessage("New passwords do not match. Check your spelling and try again.");
                        ClearAllFields();
                    }
                }
                else
                {
                    MyMessageBox.ShowMessage("The password you entered was incorrect.");
                    ClearAllFields();
                }
            }
            else
            {
                MyMessageBox.ShowMessage("Not all components validated successfully.");
                ClearAllFields();
            }

        }

        /// <summary>
        /// Clears all user input fields and sets the ErrorProvider errors to null.
        /// </summary>
        private void ClearAllFields()
        {
            TextBoxOldPassword.Clear();
            TextBoxNewPassword.Clear();
            TextBoxReTypePassword.Clear();

            ErrorProvider.SetError(TextBoxOldPassword, null);
            ErrorProvider.SetError(TextBoxNewPassword, null);
            ErrorProvider.SetError(TextBoxReTypePassword, null);
        }

        private void TextBoxOldPassword_Validating(object sender, CancelEventArgs e)
        {
            //Checks that the TextBoxOldPassword contains data
            ClassLibrary.CheckTextBoxNotNull(TextBoxOldPassword, ErrorProvider);
        }

        private void TextBoxNewPassword_Validating(object sender, CancelEventArgs e)
        {
            //Checks that the TextBoxNewPassword contains data
            ClassLibrary.CheckTextBoxNotNull(TextBoxNewPassword, ErrorProvider);
        }

        private void TextBoxReTypePassword_Validating(object sender, CancelEventArgs e)
        {
            //Checks that the TextBoxReTypePassword contains data
            ClassLibrary.CheckTextBoxNotNull(TextBoxReTypePassword, ErrorProvider);
        }
    }
}
