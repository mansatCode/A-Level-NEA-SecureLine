using SecureLine.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SecureLine
{
    public partial class AddNoteForm : Form
    {
        //Stores the information about the student who the user is adding a note to.
        private StudentModel student;
        private const string NULLDATAERRORMESSAGE = "Field cannot be left empty";

        public AddNoteForm(StudentModel s)
        {
            student = s;
            InitializeComponent();
            TextBoxStudentName.Text = $"{student.StudentLastName}, {student.StudentFirstName}";
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAddNote_Click(object sender, EventArgs e)
        {
            //If the TextBoxAddNote contains valid data
            if (ValidateForm_AddNote())
            {
                NoteModel n = new NoteModel(TextBoxNote.Text);
                try
                {
                    //Add the note to the database
                    GlobalConfig.Connection.CreateNote(n, student.StudentID);
                }
                catch
                {
                    MyMessageBox.ShowMessage("Failed to add note.");
                    return;
                }
                MyMessageBox.ShowMessage($"Note successfully added to {student.StudentFirstName} {student.StudentLastName}.");
                TextBoxNote.Text = "";
            }
        }

        /// <summary>
        /// Checks that the user input data is valid.
        /// </summary>
        /// <returns>A boolean indicating whether the 
        /// input data is valid or not.</returns>
        private bool ValidateForm_AddNote()
        {
            bool isValid = true;
            //Lamda expression to compare the ErrorProviders 
            //error message with the constant NULLDATAERRORMESSAGE.
            //If they are equal, compareString returns true.
            Func<string, bool> compareString = s => s == NULLDATAERRORMESSAGE;

            ClassLibrary.CheckTextBoxNotNull(TextBoxNote, ErrorProvider);
            //Alternative to writing IF statements that improves 
            //readability since they use far less lines. 
            isValid = compareString(ErrorProvider.GetError(TextBoxNote)) ? false : isValid;

            return isValid;
        }

        private void TextBoxNote_Validating(object sender, CancelEventArgs e)
        {
            ClassLibrary.CheckTextBoxNotNull(TextBoxNote, ErrorProvider);
        }
    }
}
