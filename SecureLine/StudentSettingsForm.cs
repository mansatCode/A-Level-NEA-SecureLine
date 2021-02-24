using SecureLine.Data_Access;
using SecureLine.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SecureLine
{
    public partial class StudentSettingsForm : Form
    {
        private StudentModel student;

        public StudentSettingsForm(StudentModel s)
        {
            student = s;
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentMainForm f2 = new StudentMainForm(student);
            f2.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Checks that the user input data is valid.
        /// </summary>
        /// <returns>A boolean indicating whether the input data is 
        /// valid or not.</returns>
        private bool ValidateForm()
        {
            const string NULLDATAERRORMESSAGE = "Field cannot be left empty";
            bool isValid = true;
            Func<string, bool> compareString = s => s == NULLDATAERRORMESSAGE;

            ClassLibrary.CheckTextBoxNotNull(TextBoxOldPassword, ErrorProvider);
            isValid = compareString(ErrorProvider.GetError(TextBoxOldPassword)) ? false : isValid;
            ClassLibrary.CheckTextBoxNotNull(TextBoxNewPassword, ErrorProvider);
            isValid = compareString(ErrorProvider.GetError(TextBoxNewPassword)) ? false : isValid;
            ClassLibrary.CheckTextBoxNotNull(TextBoxReTypePassword, ErrorProvider);
            isValid = compareString(ErrorProvider.GetError(TextBoxReTypePassword)) ? false : isValid;

            return isValid;
        }

        private void ButtonUpdatePassword_Click(object sender, EventArgs e)
        {
            //If the input data is valid
            if (ValidateForm())
            {   //If the current password is correct
                if (student.StudentPassword == TextBoxOldPassword.Text)
                {
                    //If the 2 new passwords match each other
                    if (TextBoxNewPassword.Text == TextBoxReTypePassword.Text)
                    {
                        try
                        {
                            SqlConnector db = new SqlConnector();
                            db.UpdateStudentPassword(student.StudentID, TextBoxReTypePassword.Text);
                        }
                        catch
                        {
                            MyMessageBox.ShowMessage("Action aborted. Access to database failed.");
                            ClearAllFields();
                            return;
                        }

                        student.StudentPassword = TextBoxReTypePassword.Text;
                        MyMessageBox.ShowMessage("Password successfully changed.");
                        ClearAllFields();
                    }
                    else
                    {
                        MyMessageBox.ShowMessage("New passwords do not match. Check your spelling and try again.");
                        ClearAllFields();
                    }
                }
                else
                {
                    MyMessageBox.ShowMessage("Incorrect password input.");
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

        //Events
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
