using Dapper;
using SecureLine.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SecureLine.Data_Access
{
    public class SqlConnector : IDataConnection
    {
        private const string DB = "SecureLineDatabase";

        /// <summary>
        /// Saves a new staff member to the database.
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The staff information, including the unique identifier.</returns>
        public void CreateStaff(StaffModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                //Parameters passed to the stored procedure
                var p = new DynamicParameters();
                p.Add("@StaffFirstName", model.StaffFirstName);
                p.Add("@StaffLastName", model.StaffLastName);
                p.Add("@StaffEmail", model.StaffEmail);
                p.Add("@StaffPassword", model.StaffPassword);
                p.Add("@StaffID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                //The stored procedure is executed
                connection.Execute("dbo.spTblStaff_Insert", p, commandType: CommandType.StoredProcedure);
                //The staff ID is retrieved from the database and added to the model
                model.StaffID = p.Get<int>("@StaffID");
            }
        }

        /// <summary>
        /// Saves a new student to the database.
        /// </summary>
        /// <param name="model">The student information.</param>
        /// <returns>The student information.</returns>
        public void CreateStudent(StudentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@StudentID", model.StudentID);
                p.Add("@StudentFirstName", model.StudentFirstName);
                p.Add("@StudentLastName", model.StudentLastName);
                p.Add("@StudentEmail", model.StudentEmail);
                p.Add("@StudentPassword", model.StudentPassword);

                connection.Execute("dbo.spTblStudent_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Saves a new meeting to the database.
        /// </summary>
        /// <param name="model">The meeting information.</param>
        /// <returns>The meeting information.</returns>
        public void CreateMeeting(MeetingModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@MeetingDate", model.MeetingDate);
                p.Add("@MeetingTime", model.MeetingTime);
                p.Add("@MeetingLength", model.MeetingLength);
                p.Add("@StudentID", model.StudentID);
                p.Add("@StaffID", model.StaffID);
                p.Add("@MeetingID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTblMeeting_Insert", p, commandType: CommandType.StoredProcedure);

                model.MeetingID = p.Get<int>("@MeetingID");
            }
        }

        /// <summary>
        /// Saves a new note to the database.
        /// </summary>
        /// <param name="model">The note information.</param>
        /// <param name="studentID">The unique identifier of the student whose notes are wanted.</param>
        public void CreateNote(NoteModel model, string studentID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                //Adding note to TblNote
                var p = new DynamicParameters();
                p.Add("@NoteContents", model.NoteContents);
                p.Add("@NoteID", 0, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTblNote_Insert", p, commandType: CommandType.StoredProcedure);
                model.NoteID = p.Get<int>("@NoteID");

                //Adding record to TblStudentNoteLink
                p = new DynamicParameters();
                p.Add("@NoteID", model.NoteID);
                p.Add("@StudentID", studentID);

                connection.Execute("dbo.spTblStudentNoteLink_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Saves a new message to the database.
        /// </summary>
        /// <param name="model">The message information.</param>
        /// <param name="studentID">The unique identifier of the student whose messages are wanted.</param>
        public void CreateMessage(MessageModel model, string studentID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                //Adding note to TblMessage
                var p = new DynamicParameters();
                p.Add("@MessageContents", model.MessageContents);
                p.Add("@MessageDate", model.MessageDate);
                p.Add("@MessageTime", model.MessageTime);
                p.Add("@MessageID", 0, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTblMessage_Insert", p, commandType: CommandType.StoredProcedure);
                model.MessageID = p.Get<int>("@MessageID");

                //Adding record to TblStudentMessageLink
                p = new DynamicParameters();
                p.Add("@MessageID", model.MessageID);
                p.Add("@StudentID", studentID);

                connection.Execute("dbo.spTblStudentMessageLink_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<StaffModel> GetStaffList_BySearch(string searchedName)
        {
            List<StaffModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@string", searchedName);

                output = connection.Query<StaffModel>("dbo.spTblStaff_GetByStaffFirstNameOrStaffLastName", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<StudentModel> GetStudentList_BySearch(string searchedName)
        {
            List<StudentModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@string", searchedName);

                output = connection.Query<StudentModel>("dbo.spTblStudent_GetByStudentFirstNameOrStudentLastName", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<StaffModel> GetStaff_ByLogInDetails(string staffEmail, string password)
        {
            List<StaffModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@StaffEmail", staffEmail);
                p.Add("@StaffPassword", password);

                output = connection.Query<StaffModel>("dbo.spTblStaff_GetByStaffLoginDetails", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<StudentModel> GetStudent_ByLogInDetails(string studentID, string password)
        {
            List<StudentModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@StudentID", studentID);
                p.Add("@StudentPassword", password);

                output = connection.Query<StudentModel>("dbo.spTblStudent_GetByStudentLoginDetails", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<MeetingModel> GetMeeting_ByStudentIDAndDate(string studentID, DateTime date)
        {
            List<MeetingModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@StudentID", studentID);
                p.Add("@Date", date);

                output = connection.Query<MeetingModel>("dbo.spTblMeeting_GetByStudentIDAndDate", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }
        public List<MeetingModel> GetMeeting_ByStaffIDAndDate(int staffID, DateTime date)
        {
            List<MeetingModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@StaffID", staffID);
                p.Add("@Date", date);

                output = connection.Query<MeetingModel>("dbo.spTblMeeting_GetByStaffIDAndDate", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }
        public List<MeetingModel> GetOldMeeting_ByStaffIDAndDate(int staffID, DateTime date)
        {
            List<MeetingModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@StaffID", staffID);
                p.Add("@Date", date);

                output = connection.Query<MeetingModel>("dbo.spTblMeeting_GetOldMeetingsByStaffIDAndDate", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<StudentNoteLinkModel> GetStudentNoteLink_ByStudentID(string studentID)
        {
            List<StudentNoteLinkModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@StudentID", studentID);

                output = connection.Query<StudentNoteLinkModel>("dbo.spTblStudentNoteLink_GetByStudentID", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<NoteModel> GetNote_ByNoteID(int noteID)
        {
            List<NoteModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@NoteID", noteID);

                output = connection.Query<NoteModel>("dbo.spTblNote_GetByNoteID", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<StudentMessageLinkModel> GetStudentMessageLink_ByStudentID(string studentID)
        {
            List<StudentMessageLinkModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@StudentID", studentID);

                output = connection.Query<StudentMessageLinkModel>("dbo.spTblStudentMessageLink_GetByStudentID", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<MessageModel> GetMessage_ByMessageID(int messageID)
        {
            List<MessageModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@MessageID", messageID);

                output = connection.Query<MessageModel>("dbo.spTblMessage_GetByMessageID", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<StaffModel> GetStaff_All()
        {
            List<StaffModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                output = connection.Query<StaffModel>("dbo.spTblStaff_GetAll", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<StudentModel> GetStudent_All()
        {
            List<StudentModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                output = connection.Query<StudentModel>("dbo.spTblStudent_GetAll", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public void DeleteExpiredMeetings()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                connection.Execute("dbo.spTblMeeting_DeleteExpired", commandType: CommandType.StoredProcedure);
            }
        }
        public void DeleteMeeting_ByMeetingID(int meetingID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@MeetingID", meetingID);
                connection.Execute("dbo.spTblMeeting_DeleteByMeetingID", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteStaffMember_ByStaffID(int staffID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@StaffID", staffID);
                connection.Execute("dbo.spTblStaff_DeleteByStaffID", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteStudent_ByStudentID(string studentID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@StudentID", studentID);
                connection.Execute("dbo.spTblStudent_DeleteByStudentID", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteNote_ByNoteID(int noteID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@NoteID", noteID);
                connection.Execute("dbo.spTblStudentNoteLink_DeleteByNoteID", p, commandType: CommandType.StoredProcedure);

                p = new DynamicParameters();
                p.Add("@NoteID", noteID);
                connection.Execute("dbo.spTblNote_DeleteByNoteID", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteMessage_ByMessageID(int messageID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@MessageID", messageID);
                connection.Execute("dbo.spTblStudentMessageLink_DeleteByMessageID", p, commandType: CommandType.StoredProcedure);

                p = new DynamicParameters();
                p.Add("@MessageID", messageID);
                connection.Execute("dbo.spTblMessage_DeleteByMessageID", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateStudentPassword(string studentID, string studentPassword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@StudentID", studentID);
                p.Add("@StudentPassword", studentPassword);
                connection.Execute("dbo.spTblStudent_UpdateStudentPassword", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateStaffPassword(int staffID, string staffPassword)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@StaffID", staffID);
                p.Add("@StaffPassword", staffPassword);
                connection.Execute("dbo.spTblStaff_UpdateStaffPassword", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateIsNewStudent(string studentID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@StudentID", studentID);
                connection.Execute("dbo.spTblStudent_UpdateIsNewStudent", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<StudentModel> GetStudent_ByStudentID(string studentID)
        {
            List<StudentModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@StudentID", studentID);

                output = connection.Query<StudentModel>("dbo.spTblStudent_GetByStudentID", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<StaffModel> GetStaff_ByStaffID(int staffID)
        {
            List<StaffModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(DB)))
            {
                var p = new DynamicParameters();
                p.Add("@StaffID", staffID);

                output = connection.Query<StaffModel>("dbo.spTblStaff_GetByStaffID", p, commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }
    }
}
