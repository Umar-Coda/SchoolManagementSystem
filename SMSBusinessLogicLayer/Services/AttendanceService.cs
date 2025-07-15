using SMSModels.Models;

namespace SMSBusinessLogicLayer.Services;
public class AttendanceService : IAttendanceService {
    private readonly IRepositoryFactory _repositoryFactory;

    public AttendanceService(IRepositoryFactory repositoryFactory) {
        _repositoryFactory = repositoryFactory;
    }

    public void AddAttendance(Attendance attendance) {
        _repositoryFactory.GetAttendanceRepository().Add(attendance);
    }

    public void BulkAddOrUpdate(List<Attendance> attendances) {
        _repositoryFactory.GetAttendanceRepository().BulkAddOrUpdate(attendances);
    }

    public void DeleteAttendance(int attendanceId) {
        var attendance = _repositoryFactory.GetAttendanceRepository().Get(attendanceId);
        if (attendance != null) {
            _repositoryFactory.GetAttendanceRepository().Delete(attendance);
        }
    }

    public List<Attendance> GetAllAttendance()
        => _repositoryFactory.GetAttendanceRepository().GetAllWithStudent();

    public List<Attendance> GetAttendanceByClass(int classId)
        => _repositoryFactory.GetAttendanceRepository().GetByClassId(classId);

    public List<Attendance> GetAttendanceByDateRange(DateTime startDate, DateTime endDate)
        => _repositoryFactory.GetAttendanceRepository().GetByDateRange(startDate, endDate);

    public Dictionary<int, double> GetAttendancePercentagePerStudent(int classId)
        => _repositoryFactory.GetAttendanceRepository().GetAttendancePercentagePerStudent(classId);

    public Attendance? GetByStudentAndTimetable(int studentId, int timetableId)
        => _repositoryFactory.GetAttendanceRepository().GetByStudentAndTimetable(studentId, timetableId);

    public void UpdateAttendanceStatus(int studentId, int timetableId, string status) {
        var existing = _repositoryFactory.GetAttendanceRepository().GetByStudentAndTimetable(studentId, timetableId);
        if (existing != null) {
            existing.Status = status;
            _repositoryFactory.GetAttendanceRepository().UpdateFields(existing, a => a.Status);
        }
    }
}

