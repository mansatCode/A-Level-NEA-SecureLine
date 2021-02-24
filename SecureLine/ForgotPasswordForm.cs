using SecureLine.Data_Access;
using SecureLine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace SecureLine
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ButtonSendEmail_Click(object sender, EventArgs e)
        {
            ClassLibrary.CheckEmailIsValid(TextBoxEmail, ErrorProvider);

            //If the ErrorProvider has an error set, then display a message
            if (ErrorProvider.GetError(TextBoxEmail) != "")
            {
                MyMessageBox.ShowMessage("Not all components validated successfully. Please check the flagged entries and try again.");
                return;
            }
            else if (RadioButtonStudent.Checked == true)
            {
                List<StudentModel> students = new List<StudentModel>();

                try
                {
                    SqlConnector db = new SqlConnector();
                    students = db.GetStudent_All();
                }
                catch
                {
                    MyMessageBox.ShowMessage("Access to database failed.");
                    return;
                }
                
                //Search each StudentModel in the student list.
                //If the email the user input matches an email in the 
                //database, send the email.
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].StudentEmail == TextBoxEmail.Text)
                    {
                        ErrorProvider.SetError(TextBoxEmail, null);
                        //Send email
                        SendEmail(students[i].StudentEmail, students[i].StudentFirstName, students[i].StudentID, students[i].StudentPassword);
                        MyMessageBox.ShowMessage("Email successfully sent.");
                        return;
                    }
                }
            }
            else if (RadioButtonStaff.Checked)
            {
                List<StaffModel> staffMembers = new List<StaffModel>();

                try
                {
                    SqlConnector db = new SqlConnector();
                    staffMembers = db.GetStaff_All();
                }
                catch
                {
                    MyMessageBox.ShowMessage("Access to database failed.");
                    return;
                }

                for (int i = 0; i < staffMembers.Count; i++)
                {
                    if (staffMembers[i].StaffEmail == TextBoxEmail.Text)
                    {
                        ErrorProvider.SetError(TextBoxEmail, null);
                        //Send email
                        SendEmail(staffMembers[i].StaffEmail, staffMembers[i].StaffFirstName, staffMembers[i].StaffEmail, staffMembers[i].StaffPassword);
                        MyMessageBox.ShowMessage("Email successfully sent.");
                        return;
                    }
                }
            }

            MyMessageBox.ShowMessage("This email doesn't exist in the database.");
        }

        private void SendEmail(string recipientAddress, string name, string userName, string password)
        {
            StringBuilder body = new StringBuilder();
            string subject = "SecureLine Password Reminder";

            body.AppendLine("<h2>You recently requested a password reminder for your SecureLine account.</h2>");
            body.AppendLine("<p>Hi ");
            body.AppendLine(name);
            body.AppendLine(", ");
            body.AppendLine("your login details for SecureLine are listed below.</p>");
            body.AppendLine("Username: ");
            body.AppendLine(userName);
            body.AppendLine("<br />");
            body.AppendLine("Password: ");
            body.AppendLine(password);
            body.AppendLine("<br />");

            body.AppendLine("<p>Remember to keep your information private.</p>");
            body.AppendLine("<p>~SecureLine</p>");

            EmailLogic.SendEmail(recipientAddress, subject, body.ToString());
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindowForm f2 = new LoginWindowForm();
            f2.ShowDialog();
            this.Close();
        }

        private void TextBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            ClassLibrary.CheckEmailIsValid(TextBoxEmail, ErrorProvider);
        }
    }
}
