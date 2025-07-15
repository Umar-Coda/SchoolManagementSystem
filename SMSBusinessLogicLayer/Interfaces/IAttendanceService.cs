namespace SMSBusinessLogicLayer.Interfaces;
public interface IAttendanceService {
    public void AddAttendance(Attendance attendance);
    public void UpdateAttendanceStatus(int studentId, int timetableId, string status);
    public Attendance? GetByStudentAndTimetable(int studentId, int timetableId);
    public List<Attendance> GetAllAttendance();
    public List<Attendance> GetAttendanceByClass(int classId);
    public List<Attendance> GetAttendanceByDateRange(DateTime startDate, DateTime endDate);
    public Dictionary<int, double> GetAttendancePercentagePerStudent(int classId);
    public void BulkAddOrUpdate(List<Attendance> attendances);
    public void DeleteAttendance(int attendanceId);
}
