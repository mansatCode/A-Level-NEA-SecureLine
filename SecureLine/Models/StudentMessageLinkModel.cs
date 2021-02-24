namespace SecureLine.Models
{
    public class StudentMessageLinkModel
    {
        /// <summary>
        /// The unique identifer for the student.
        /// </summary>
        public string StudentID { get; set; }
        /// <summary>
        /// Represents the ID of the pinned message.
        /// </summary>
        public int MessageID { get; set; }
        /// <summary>
        /// The row number of the record in the table
        /// </summary>
        public int RowNumber { get; set; }

        public string MessageNumber
        {
            get
            {
                return $"Message {RowNumber}";
            }
        }
    }
}
