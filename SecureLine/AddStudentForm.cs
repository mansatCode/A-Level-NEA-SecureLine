using SecureLine.Models;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace SecureLine
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Verifies that all the user input data is valid. 
        /// </summary>
        /// <returns>A boolean indicating whether the 
        /// input data is valid or not.</returns>
        private bool ValidateForm()
        {
            bool isValid = true;
            //Lamda expression comparing the input to "" (null data). 
            //Returns true if they are equal.
            Func<string, bool> compareString = s => s == "";

            CheckIDIsValid();
            //If the error message is null (i.e. there is no error message), 
            //isValid remains the same.
            isValid = compareString(ErrorProvider.GetError(TextBoxStudentIDValue)) ? isValid : false;
            ClassLibrary.CheckNameIsValid(TextBoxFirstNameValue, ErrorProvider);
            isValid = compareString(ErrorProvider.GetError(TextBoxFirstNameValue)) ? isValid : false;
            ClassLibrary.CheckNameIsValid(TextBoxLastNameValue, ErrorProvider);
            isValid = compareString(ErrorProvider.GetError(TextBoxLastNameValue)) ? isValid : false;

            return isValid;
        }

        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            const string REPEATSTUDENTIDERROR = "Student ID is already present in the database";
            if (ValidateForm())
            {
                StudentModel model = new StudentModel(
                    TextBoxStudentIDValue.Text,
                    TextBoxFirstNameValue.Text,
                    TextBoxLastNameValue.Text,
                    TextBoxStudentIDValue.Text);

                try
                {
                    GlobalConfig.Connection.CreateStudent(model);
                }
                catch (SqlException)
                {
                    MyMessageBox.ShowMessage("Failed to add student to the database: the specified student ID is already present in the database.");
                    ErrorProvider.SetError(TextBoxStudentIDValue, REPEATSTUDENTIDERROR);
                    return;
                }
                catch
                {
                    MyMessageBox.ShowMessage("Failed to access the database. ");
                    return;
                }

                MyMessageBox.ShowMessage("Successfully added new student to the database.");
                TextBoxStudentIDValue.Clear();
                TextBoxFirstNameValue.Clear();
                TextBoxLastNameValue.Clear();
                SendEmail_AddStudent(model);
            }
            else
            {
                MyMessageBox.ShowMessage("Not all components validated successfully. Please check the flagged entries and try again.");
            }
        }

        private void SendEmail_AddStudent(StudentModel s)
        {
            StringBuilder body = new StringBuilder();
            string subject = "Welcome to SecureLine!";

            body.AppendLine("<h2>Your account has been created.</h2>");
            body.AppendLine("<p>Hi ");
            body.AppendLine(s.StudentFirstName);
            body.AppendLine(", ");
            body.AppendLine("your login details for SecureLine are listed below.</p>");
            body.AppendLine("Username: ");
            body.AppendLine(s.StudentID);
            body.AppendLine("<br />");
            body.AppendLine("Password: ");
            body.AppendLine(s.StudentPassword);
            body.AppendLine("<br />");

            body.AppendLine("<p>SecureLine can be used to book meetings with the Hills Road Well-Being Department, view upcoming meetings or to simply discuss your worries with the well-being staff.</p>");
            body.AppendLine("You can update your password from within the SecureLine application.");
            body.AppendLine("<br />");
            body.AppendLine("Remember to keep your information private.");
            body.AppendLine("<p>~SecureLine</p>");

            EmailLogic.SendEmail(s.StudentEmail, subject, body.ToString());
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckIDIsValid()
        {
            //Error messages
            const string NULLDATAERRORMESSAGE = "Field cannot be left empty";
            const string IDINCORRECTLENGTHERRORMESSAGE = "Student ID is incorrect length";
            const string IDINCORRECTFORMATERRORMESSAGE = "Entered student ID is in an incorrect format";

            //If there is null data
            if (string.IsNullOrEmpty(TextBoxStudentIDValue.Text))
            {
                ErrorProvider.SetError(TextBoxStudentIDValue, NULLDATAERRORMESSAGE);
            }
            //The text box has an upper limit of 8 characters, 
            //so we only have to check for less than 8
            else if (TextBoxStudentIDValue.Text.Length < 8)
            {
                ErrorProvider.SetError(TextBoxStudentIDValue, IDINCORRECTLENGTHERRORMESSAGE);
            }
            //Checks that the first 2 letters of the student ID are letters
            else if (!Char.IsLetter(char.Parse(TextBoxStudentIDValue.Text.Substring(0, 1))) || !Char.IsLetter(char.Parse(TextBoxStudentIDValue.Text.Substring(1, 1))))
            {
                ErrorProvider.SetError(TextBoxStudentIDValue, IDINCORRECTFORMATERRORMESSAGE);
            }
            //Checks that the remaining student ID is all numbers
            else if (!int.TryParse(TextBoxStudentIDValue.Text.Substring(2), out int i))
            {
                ErrorProvider.SetError(TextBoxStudentIDValue, IDINCORRECTFORMATERRORMESSAGE);
            }
            else
            {
                ErrorProvider.SetError(TextBoxStudentIDValue, null);
            }
        }

        //Events
        private void TextBoxFirstNameValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Input must be a character, control character, whitespace or hyphen (45)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 45)
            {
                e.Handled = true;
            }
        }

        private void TextBoxLastNameValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Input must be a character, control character, whitespace or hyphen (45)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 45)
            {
                e.Handled = true;
            }
        }

        private void TextBoxStudentIDValue_Validating(object sender, CancelEventArgs e)
        {
            CheckIDIsValid();
        }
        private void TextBoxFirstNameValue_Validating(object sender, CancelEventArgs e)
        {
            ClassLibrary.CheckNameIsValid(TextBoxFirstNameValue, ErrorProvider);
        }

        private void TextBoxLastNameValue_Validating(object sender, CancelEventArgs e)
        {
            ClassLibrary.CheckNameIsValid(TextBoxLastNameValue, ErrorProvider);
        }
    }
}
