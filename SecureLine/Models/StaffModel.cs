namespace SecureLine.Models
{
    public class StaffModel
    {
        /// <summary>
        /// Represents the ID of the staff member.
        /// </summary>
        public int StaffID { get; set; }
        /// <summary>
        /// Represents the first name of the staff member.
        /// </summary>
        public string StaffFirstName { get; set; }
        /// <summary>
        /// Represents the last name of the staff member.
        /// </summary>
        public string StaffLastName { get; set; }
        /// <summary>
        /// Represents the email address of the staff member.
        /// </summary>
        public string StaffEmail { get; set; }
        /// <summary>
        /// Represents the staff member's password.
        /// </summary>
        public string StaffPassword { get; set; }
        /// <summary>
        /// The staff member's combined last name and first name.
        /// </summary>
        public string FullNameReversed
        {
            get
            {
                return $"{StaffLastName}, {StaffFirstName}";
            }
        }

        //Empty constructor
        public StaffModel ()
        {
        }

        //Constructor used to build a new StaffModel
        public StaffModel(string staffFirstName, string staffLastName, string staffEmail)
        {
            //StaffID is handled by the database
            StaffFirstName = ClassLibrary.FormatName(staffFirstName);
            StaffLastName = ClassLibrary.FormatName(staffLastName);
            StaffEmail = staffEmail;
            StaffPassword = ClassLibrary.GenerateRandomPassword(10);
        }
    }
}
