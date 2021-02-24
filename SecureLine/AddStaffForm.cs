using SecureLine.Models;
using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace SecureLine
{
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
        }

        private void ButtonAddStaff_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                StaffModel model = new StaffModel(
                    TextBoxFirstNameValue.Text.Trim(),
                    TextBoxLastNameValue.Text.Trim(),
                    TextBoxStaffEmailValue.Text);

                try
                {
                    GlobalConfig.Connection.CreateStaff(model);
                }
                catch
                {
                    MyMessageBox.ShowMessage("Failed to access the database.");
                    return;
                }

                MyMessageBox.ShowMessage("Successfully added new staff member to the database.");
                TextBoxFirstNameValue.Clear();
                TextBoxLastNameValue.Clear();
                TextBoxStaffEmailValue.Clear();
                SendEmail_AddStaff(model);
            }
            else
            {
                MyMessageBox.ShowMessage("Not all components validated successfully. Please check the flagged entries and try again.");
            }
        }

        private void SendEmail_AddStaff(StaffModel s)
        {
            StringBuilder body = new StringBuilder();
            string subject = "Welcome to SecureLine!";

            body.AppendLine("<h2>Your account has been created.</h2>");
            body.AppendLine("<p>Welcome ");
            body.AppendLine(s.StaffFirstName);
            body.AppendLine(", ");
            body.AppendLine("your login details for SecureLine are listed below.</p>");
            body.AppendLine("Username: ");
            body.AppendLine(s.StaffEmail);
            body.AppendLine("<br />");
            body.AppendLine("Password: ");
            body.AppendLine(s.StaffPassword);
            body.AppendLine("<br />");

            body.AppendLine("<p>Remember to keep your information private.</p>");
            body.AppendLine("<p>~SecureLine</p>");

            EmailLogic.SendEmail(s.StaffEmail, subject, body.ToString());
        }

        /// <summary>
        /// Verifys that the user input data is valid.
        /// </summary>
        /// <returns>A boolean indicating whether the components 
        /// have validated correctly or not.</returns>
        private bool ValidateForm()
        {
            bool isValid = true;
            //Lamda expression that compares an input to null data. 
            //Returns true if the supplied input is null.
            Func<string, bool> compareString = s => s == "";

            ClassLibrary.CheckNameIsValid(TextBoxFirstNameValue, ErrorProvider);
            //Alternative to writing IF statements to improve readability.
            //isValid remains the same (in this case, TRUE) if the ErrorProvider 
            //has no error set, otherwise it is set to false
            isValid = compareString(ErrorProvider.GetError(TextBoxFirstNameValue)) ? isValid : false;
            ClassLibrary.CheckNameIsValid(TextBoxLastNameValue, ErrorProvider);
            isValid = compareString(ErrorProvider.GetError(TextBoxLastNameValue)) ? isValid : false;
            ClassLibrary.CheckEmailIsValid(TextBoxStaffEmailValue, ErrorProvider);
            isValid = compareString(ErrorProvider.GetError(TextBoxStaffEmailValue)) ? isValid : false;

            //Returns true if all components validate successfully
            return isValid;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Events
        private void TextBoxFirstNameValue_Validating(object sender, CancelEventArgs e)
        {
            ClassLibrary.CheckNameIsValid(TextBoxFirstNameValue, ErrorProvider);
        }

        private void TextBoxLastNameValue_Validating(object sender, CancelEventArgs e)
        {
            ClassLibrary.CheckNameIsValid(TextBoxLastNameValue, ErrorProvider);
        }

        private void TextBoxStaffEmailValue_Validating(object sender, CancelEventArgs e)
        {
            ClassLibrary.CheckEmailIsValid(TextBoxStaffEmailValue, ErrorProvider);
        }

        //Event fired when the user presses a key in the TextBoxFirstNameValue text box
        private void TextBoxFirstNameValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Input must be a character, control character, whitespace or hyphen
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 45)
            {
                e.Handled = true;
            }
        }

        private void TextBoxLastNameValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Input must be a character, control character, whitespace or hyphen
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 45)
            {
                e.Handled = true;
            }

        }
    }
}
