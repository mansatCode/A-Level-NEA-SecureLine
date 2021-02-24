using SecureLine.Data_Access;
using SecureLine.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SecureLine
{
    public partial class UpdateStudentListForm : Form
    {
        private List<StudentModel> students = new List<StudentModel>();

        public UpdateStudentListForm()
        {
            InitializeComponent();
            InitaliseList();
        }

        /// <summary>
        /// Retrieves the relevant records from TblStudent in the 
        /// database and stores them in the students list.
        /// </summary>
        private void InitaliseList()
        {
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

            UpdateStudentList();
        }

        /// <summary>
        /// ListBoxStudentList is populated using the students list.
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
                SqlConnector db = new SqlConnector();
                students = db.GetStudentList_BySearch(TextBoxSearchBar.Text);
            }
            catch
            {
                MyMessageBox.ShowMessage("Access to database failed.");
                return;
            }
            UpdateStudentList();
        }

        private void ButtonDeleteStudent_Click(object sender, EventArgs e)
        {
            if (ListBoxStudentList.SelectedItem == null)
            {
                MyMessageBox.ShowMessage("No students to delete.");
            }
            else
            {
                try
                {
                    SqlConnector db = new SqlConnector();
                    db.DeleteStudent_ByStudentID(students[ListBoxStudentList.SelectedIndex].StudentID);
                }
                catch
                {
                    MyMessageBox.ShowMessage("Action aborted: attempted to delete a student present in multiple tables.");
                    return;
                }
                InitaliseList();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
            InitaliseList();
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
    }
}
