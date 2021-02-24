using SecureLine.Data_Access;
using SecureLine.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SecureLine
{
    public partial class UpdateStaffListForm : Form
    {
        private StaffModel staffMember;
        private List<StaffModel> staffMembers = new List<StaffModel>();

        public UpdateStaffListForm(StaffModel s)
        {
            staffMember = s;
            InitializeComponent();
            InitaliseList();
        }

        /// <summary>
        /// Retrieves the relevant records from TblStaff in the 
        /// database and stores them in the staffMembers list.
        /// </summary>
        private void InitaliseList()
        {
            try
            {
                SqlConnector db = new SqlConnector();
                staffMembers = db.GetStaff_All();
            }
            catch
            {
                MyMessageBox.ShowMessage("Access to the database failed.");
                return;
            }
            UpdateStaffMemberList();
        }

        /// <summary>
        /// ListBoxStaffList is populated using the staffMembers list.
        /// </summary>
        private void UpdateStaffMemberList()
        {
            ListBoxStaffList.DataSource = staffMembers;
            ListBoxStaffList.DisplayMember = "FullNameReversed";
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAddStaff_Click(object sender, EventArgs e)
        {
            AddStaffForm addStaffForm = new AddStaffForm();
            addStaffForm.ShowDialog();
            InitaliseList();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try 
            {
                SqlConnector db = new SqlConnector();
                staffMembers = db.GetStaffList_BySearch(TextBoxSearchBar.Text);
            }
            catch
            {
                MyMessageBox.ShowMessage("Access to the database failed.");
                return;
            }
            UpdateStaffMemberList();
        }

        private void ButtonDeleteStaff_Click(object sender, EventArgs e)
        {
            if (ListBoxStaffList.SelectedItem == null)
            {
                MyMessageBox.ShowMessage("No staff members to delete.");
            }
            else if (staffMembers[ListBoxStaffList.SelectedIndex].StaffID == staffMember.StaffID)
            {
                MyMessageBox.ShowMessage("Action aborted: cannot delete your own account.");
            }
            else
            {
                try
                {
                    SqlConnector db = new SqlConnector();
                    db.DeleteStaffMember_ByStaffID(staffMembers[ListBoxStaffList.SelectedIndex].StaffID);
                }
                catch
                {
                    MyMessageBox.ShowMessage("Action aborted: attempted to delete a staff member who is present in multiple tables.");
                    return;
                }
                InitaliseList();
            }
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
