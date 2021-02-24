using System;

namespace SecureLine.Models
{
    public class MessageModel
    {
        /// <summary>
        /// Represents the ID of the pinned message.
        /// </summary>
        public int MessageID { get; set; }
        /// <summary>
        /// Represents the contents of the pinned message.
        /// </summary>
        public string MessageContents { get; set; }
        /// <summary>
        /// Represents the date the message was pinned.
        /// </summary>
        public DateTime MessageDate { get; set; }
        /// <summary>
        /// Represents the time the message was pinned.
        /// </summary>
        public TimeSpan MessageTime { get; set; }

        public MessageModel()
        {

        }

        public MessageModel(string messageContents, DateTime date, DateTime time)
        {
            //Date and time need to be formatted in a way that the database can interpret
            DateTime formattedDate;
            TimeSpan formattedTime;
            string formattedString;

            formattedString = messageContents.Substring(0, messageContents.Length - 2);
            MessageContents = formattedString;

            formattedDate = date.Date;
            MessageDate = formattedDate;

            formattedTime = time.TimeOfDay;
            MessageTime = formattedTime;
        }
    }
}
