namespace SMSDataLayer.Interfaces;
public interface IAttendanceRepository : IRepository<Attendance> {
    public List<Attendance> GetAllWithStudent();
    public Attendance? GetByStudentAndTimetable(int studentId, int timetableId);
    public void AddOrUpdate(Attendance attendance);

    public void BulkAddOrUpdate(List<Attendance> attendances);

    public List<Attendance> GetByDateRange(DateTime startDate, DateTime endDate);
    public List<Attendance> GetByClassId(int classId);
    public Dictionary<int, double> GetAttendancePercentagePerStudent(int classId);
}

