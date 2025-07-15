namespace SMSBusinessLogicLayer.Interfaces;
public interface ICheckDuplicateService {
    public bool CheckDuplicateSubjectCode(string subjectCode);
    public bool CheckDuplicateUsername(string username);
    public bool CheckDuplicateFacultyName(string facultyName);
    public bool CheckDuplicateCourseCode(string courseCode);
}

