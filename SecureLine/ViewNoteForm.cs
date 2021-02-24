using SecureLine.Data_Access;
using SecureLine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SecureLine
{
    public partial class ViewNoteForm : Form
    {
        //Contains information of the student that the user is viewing
        private StudentModel student;

        //snl = Student Note Link
        private List<StudentNoteLinkModel> snl = new List<StudentNoteLinkModel>();
        private List<NoteModel> notes = new List<NoteModel>();

        //sml = Student Message Link
        private List<StudentMessageLinkModel> sml = new List<StudentMessageLinkModel>();
        private List<MessageModel> messages = new List<MessageModel>();

        public ViewNoteForm(StudentModel s)
        {
            student = s;
            InitializeComponent();
            TextBoxStudentName.Text = $"{student.StudentLastName}, {student.StudentFirstName}";

            InitaliseList();
        }

        /// <summary>
        /// Populate the listboxes.
        /// </summary>
        private void InitaliseList()
        {
            //First get the note IDs of the notes from the 
            //database that contain the correct student ID
            try
            {
                SqlConnector db = new SqlConnector();
                snl = db.GetStudentNoteLink_ByStudentID(student.StudentID);
            }
            catch
            {
                MyMessageBox.ShowMessage("Failed to load Student Note Link data from the database.");
                return;
            }
            //Display them in the appropriate listbox
            ListBoxNoteList.DataSource = snl;
            ListBoxNoteList.DisplayMember = "NoteNumber";

            //If the snl list contains items, get the note 
            //contents from the note IDs we just retrieved
            if (snl.Count() > 0)
            {
                try
                {
                    SqlConnector db = new SqlConnector();
                    notes = db.GetNote_ByNoteID(snl[ListBoxNoteList.SelectedIndex].NoteID);
                }
                catch
                {
                    MyMessageBox.ShowMessage("Failed to load notes from the database.");
                    return;
                }
                //Display the selected note in TextBoxNoteViewer
                TextBoxNoteViewer.Text = notes[0].NoteContents;
            }
            else
            {
                TextBoxNoteViewer.Clear();
            }

            //First get the message IDs of the messages from the 
            //database that contain the correct student ID
            try
            {
                SqlConnector db = new SqlConnector();
                sml = db.GetStudentMessageLink_ByStudentID(student.StudentID);
            }
            catch
            {
                MyMessageBox.ShowMessage("Failed to load Student Message Link data from the database.");
                return;
            }
            //Display these in the listbox 
            ListBoxMessageList.DataSource = sml;
            ListBoxMessageList.DisplayMember = "MessageNumber";

            //If sml list contains items, get the messages by 
            //their message ID we just retrieved
            if (sml.Count() > 0)
            {
                try
                {
                    SqlConnector db = new SqlConnector();
                    messages = db.GetMessage_ByMessageID(sml[ListBoxMessageList.SelectedIndex].MessageID);
                }
                catch
                {
                    MyMessageBox.ShowMessage("Failed to load pinned messages from the database.");
                    return;
                }
                //Display the selected message in the text box
                TextBoxMessageViewer.Text = messages[0].MessageContents;
            }
            else
            {
                TextBoxMessageViewer.Clear();
                TextBoxDate.Clear();
                TextBoxTime.Clear();
            }
        }
        
        /// <summary>
        /// When a new item is selected in ListBoxMessageList, 
        /// that message is to be displayed in TextBoxMessageViewer
        /// </summary>
        private void UpdateMessageViewer()
        {
            try
            {
                SqlConnector db = new SqlConnector();
                messages = db.GetMessage_ByMessageID(sml[ListBoxMessageList.SelectedIndex].MessageID);
            }
            catch
            {
                MyMessageBox.ShowMessage("Failed to load message from the database.");
                return;
            }

            TextBoxMessageViewer.Text = messages[0].MessageContents;
            TextBoxDate.Text = messages[0].MessageDate.ToString().Substring(0,10);
            TextBoxTime.Text = messages[0].MessageTime.ToString().Substring(0,5);
        }

        /// <summary>
        /// When a new item is selected in ListBoxNoteList, 
        /// that note is to be displayed in TextBoxNoteViewer.
        /// </summary>
        private void UpdateNoteViewer()
        {
            try
            {
                SqlConnector db = new SqlConnector();
                notes = db.GetNote_ByNoteID(snl[ListBoxNoteList.SelectedIndex].NoteID);
            }
            catch
            {
                MyMessageBox.ShowMessage("Failed to load notes from the database.");
                return;
            }

            TextBoxNoteViewer.Text = notes[0].NoteContents;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBoxNoteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNoteViewer();
        }
        private void ListBoxMessageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMessageViewer();
        }

        private void ButtonDeleteNote_Click(object sender, EventArgs e)
        {
            //If there are no notes to delete, display a message saying so
            if (snl.Count() == 0 || ListBoxNoteList.SelectedItem == null)
            {
                MyMessageBox.ShowMessage("No notes to delete.");
            }
            else
            {
                try
                {
                    SqlConnector db = new SqlConnector();
                    db.DeleteNote_ByNoteID(snl[ListBoxNoteList.SelectedIndex].NoteID);
                }
                catch
                {
                    MessageBox.Show("Action aborted. Access to database failed.");
                    return;
                }
                InitaliseList();
            }
        }

        // If there are no pinned messages left to delete, 
        //display a message saying so
        private void ButtonDeleteMessage_Click(object sender, EventArgs e)
        {
            if (sml.Count() == 0 || ListBoxMessageList.SelectedItem == null)
            {
                MyMessageBox.ShowMessage("No messages to delete.");
            }
            else
            {
                try
                {
                    SqlConnector db = new SqlConnector();
                    db.DeleteMessage_ByMessageID(sml[ListBoxMessageList.SelectedIndex].MessageID);
                }
                catch
                {
                    MessageBox.Show("Action aborted. Access to database failed.");
                    return;
                }
                InitaliseList();
            }
        }

    }
}
