namespace SecureLine.Models
{
    public class StudentModel
    {
        /// <summary>
        /// The unique identifer for the student.
        /// </summary>
        public string StudentID { get; set; }
        /// <summary>
        /// Student's first name.
        /// </summary>
        public string StudentFirstName { get; set; }
        /// <summary>
        /// Student's last name.
        /// </summary>
        public string StudentLastName { get; set;  }
        /// <summary>
        /// Student's email address.
        /// </summary>
        public string StudentEmail { get; set; }
        /// <summary>
        /// Boolean specifying whether student has had a meeting before or not.
        /// </summary>
        public bool IsNewStudent { get; set; }
        /// <summary>
        /// Student's password.
        /// </summary>
        public string StudentPassword { get; set; }

        /// <summary>
        /// Student's combined last name and first name.
        /// </summary>
        public string FullNameReversed
        {
            get 
            {
                //How the students are displayed in the list boxes
                return $"{StudentLastName}, {StudentFirstName}";
            }
        }

        //Empty constructor
        public StudentModel()
        {
        }

        //StudentModel constructor 
        public StudentModel(string studentID, string studentFirstName, string studentLastName, string studentEmail)
        {
            StudentID = studentID;
            StudentFirstName = ClassLibrary.FormatName(studentFirstName);
            StudentLastName = ClassLibrary.FormatName(studentLastName);
            StudentEmail = $"{studentEmail}@hillsroad.ac.uk";
            StudentPassword = ClassLibrary.GenerateRandomPassword(10);
        }
    }
}
