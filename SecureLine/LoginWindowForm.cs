using SecureLine.Data_Access;
using SecureLine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace SecureLine
{
    public partial class LoginWindowForm : Form
    {
        public LoginWindowForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks that the user input data is valid.
        /// </summary>
        /// <returns>A boolean indicating whether the input data is valid or not.</returns>
        private bool ValidateForm()
        {
            const string NULLDATAERRORMESSAGE = "Field cannot be left empty";
            bool isValid = true;
            //Lamda expression to compare the ErrorProviders error message with the 
            //constant NULLDATAERRORMESSAGE. If they are equal, compareString returns true.
            Func<string, bool> compareString = s => s == NULLDATAERRORMESSAGE;

            //Each control that has user input data must be checked. 
            ClassLibrary.CheckTextBoxNotNull(TextBoxUsername, ErrorProvider);
            //Alternative to writing IF statements that improves readability since they use far less lines. 
            //If compareString returns true, then isValid is set to false as this means the
            //ErrorProvider has set an error so the input is invalid. 
            isValid = compareString(ErrorProvider.GetError(TextBoxUsername)) ? false : isValid;
            ClassLibrary.CheckTextBoxNotNull(TextBoxPassword, ErrorProvider);
            isValid = compareString(ErrorProvider.GetError(TextBoxPassword)) ? false : isValid;

            return isValid;
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            //True if all the components validate successfully
            if (ValidateForm())
            {
                //Checks whether it is a student or staff member attempting to login
                if (RadioButtonStudent.Checked == true)
                {
                    List<StudentModel> studentLogInDetails = new List<StudentModel>();
                    try
                    {
                        //Attempt to retrieve the record from TblStudent in the database that exactly matches the data
                        //input to TextBoxUsername and TextBoxPassword.
                        SqlConnector db = new SqlConnector();
                        studentLogInDetails = db.GetStudent_ByLogInDetails(TextBoxUsername.Text, TextBoxPassword.Text);
                    }
                    catch
                    {
                        MyMessageBox.ShowMessage("Access to the database failed.");
                        return;
                    }

                    if (studentLogInDetails.Count() == 1)
                    {
                        this.Hide();
                        StudentMainForm studentMainForm = new StudentMainForm(studentLogInDetails[0]);
                        studentMainForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MyMessageBox.ShowMessage("Check your username and password.");
                    }
                }
                else if (RadioButtonStaff.Checked == true)
                {
                    List<StaffModel> staffLogInDetails = new List<StaffModel>();
                    try
                    {
                        SqlConnector db = new SqlConnector();
                        staffLogInDetails = db.GetStaff_ByLogInDetails(TextBoxUsername.Text, TextBoxPassword.Text);
                    }
                    catch
                    {
                        MyMessageBox.ShowMessage("Access to the database failed.");
                        return;
                    }

                    if (staffLogInDetails.Count() == 1)
                    {
                        this.Hide();
                        StaffMainForm staffMainForm = new StaffMainForm(staffLogInDetails[0]);
                        staffMainForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MyMessageBox.ShowMessage("Check your username and password.");
                    }
                }
            }
            else
            {
                MyMessageBox.ShowMessage("Not all components validated successfully. Please check the flagged entries and try again.");
            }
        }
            
        private void RadioButtonStudent_CheckedChanged(object sender, EventArgs e)
        {
            //The errors for the error providers are set to null,
            //otherwise an they prompt the user to enter data into the textboxes
            //even if they're yet to try. 
            ErrorProvider.SetError(TextBoxUsername, null);
            ErrorProvider.SetError(TextBoxPassword, null);

            //Depending on which radio button is checked, the label corresponding
            //to TextBoxUsername changes appropriately. 
            if (RadioButtonStudent.Checked == true)
            {
                LabelUsername.Text = "Student ID";
                TextBoxUsername.MaxLength = 8;
            }
            else if (RadioButtonStaff.Checked == true)
            {
                LabelUsername.Text = "Staff Email";
                TextBoxUsername.MaxLength = 100;
            }
        }

        private void TextBoxUsername_Validating(object sender, CancelEventArgs e)
        {
            //Checks that the TextBoxUsername contains data
            ClassLibrary.CheckTextBoxNotNull(TextBoxUsername, ErrorProvider);
        }

        private void TextBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            //Checks that the TextBoxPassword contains data
            ClassLibrary.CheckTextBoxNotNull(TextBoxPassword, ErrorProvider);
        }

        //Opens a new ForgotPasswordForm and hides this LoginWindowForm.
        private void ButtonForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPasswordForm f2 = new ForgotPasswordForm();
            f2.ShowDialog();
            this.Close();
        }
    }
}
