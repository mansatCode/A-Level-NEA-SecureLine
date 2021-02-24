namespace SecureLine.Models
{
    public class StudentNoteLinkModel
    {
        /// <summary>
        /// The unique identifer for the student.
        /// </summary>
        public string StudentID { get; set; }

        /// <summary>
        /// Represents the unique ID of the note being added.
        /// </summary>
        public int NoteID { get; set; }

        /// <summary>
        /// The row number of the record from the table.
        /// </summary>
        public int RowNumber { get; set; }

        //Defines how this information should be displayed in the list box 
        public string NoteNumber
        {
            get
            { 
                return $"Note {RowNumber}";
            }
        }
    }
}
