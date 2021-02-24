using SecureLine.Models;
using System;
using System.Collections.Generic;

namespace SecureLine.Data_Access
{
    //Interface that defines what functions must be declared in the classes that implement it.
    public interface IDataConnection
    {
        void CreateStudent(StudentModel model);
        void CreateStaff(StaffModel model);
        void CreateMeeting(MeetingModel model);
        void CreateNote(NoteModel note, string studentID);
        void CreateMessage(MessageModel message, string studentID);

        void UpdateStudentPassword(string studentID, string studentPassword);
        void UpdateStaffPassword(int staffID, string staffPassword);
        void UpdateIsNewStudent(string studentID);

        List<StudentModel> GetStudentList_BySearch(string searchedName);
        List<StaffModel> GetStaffList_BySearch(string searchedName);
        List<StaffModel> GetStaff_All();
        List<StudentModel> GetStudent_All();
        List<StudentModel> GetStudent_ByStudentID(string studentID);
        List<StaffModel> GetStaff_ByStaffID(int staffID);
        List<StudentNoteLinkModel> GetStudentNoteLink_ByStudentID(string studentID);
        List<NoteModel> GetNote_ByNoteID(int noteID);
        List<StudentMessageLinkModel> GetStudentMessageLink_ByStudentID(string studentID);
        List<MessageModel> GetMessage_ByMessageID(int messageID);
        List<MeetingModel> GetMeeting_ByStudentIDAndDate(string studentID, DateTime date);
        List<MeetingModel> GetMeeting_ByStaffIDAndDate(int staffID, DateTime date);
        List<MeetingModel> GetOldMeeting_ByStaffIDAndDate(int staffID, DateTime date);

        List<StudentModel> GetStudent_ByLogInDetails(string studentID, string password);
        List<StaffModel> GetStaff_ByLogInDetails(string staffEmail, string password);

        void DeleteExpiredMeetings();
        void DeleteMeeting_ByMeetingID(int meetingID);
        void DeleteStaffMember_ByStaffID(int staffID);
        void DeleteStudent_ByStudentID(string studentID);
        void DeleteNote_ByNoteID(int noteID);
        void DeleteMessage_ByMessageID(int messageID);
    }
}
