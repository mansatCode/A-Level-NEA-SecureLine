namespace SecureLine.Models
{
    public class NoteModel
    {
        /// <summary>
        /// Represents the unique ID of the note being added.
        /// </summary>
        public int NoteID { get; set; }
        /// <summary>
        /// Represents the contents of the note being added.
        /// </summary>
        public string NoteContents { get; set; }

        public NoteModel(string noteContents)
        {
            NoteContents = noteContents;
        }
        public NoteModel ()
        {

        }
    }
}
