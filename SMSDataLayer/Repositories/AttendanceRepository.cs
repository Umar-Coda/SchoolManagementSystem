
using SMSModels.Models;

namespace SMSDataLayer.Repositories;
public class AttendanceRepository : BaseRepository<Attendance>, IAttendanceRepository{
    public AttendanceRepository(SchoolContext context) : base(context) {
    }

    public List<Attendance> GetAllWithStudent()
        => _dbSet.Include(a => a.Student).ToList();

    public Attendance? GetByStudentAndTimetable(int studentId, int timetableId)
        => _dbSet.FirstOrDefault(
                a => a.StudentId == studentId &&
                a.TimetableId == timetableId
            );

    public void AddOrUpdate(Attendance attendance) {
        var existing = GetByStudentAndTimetable(attendance.StudentId, attendance.TimetableId);

        if (existing != null) {
            existing.Status = attendance.Status;
            _context.SaveChanges();
        } else {
            Add(attendance);
        }
    }

    public void BulkAddOrUpdate(List<Attendance> attendances) {
        foreach (var att in attendances) {
            var existing = GetByStudentAndTimetable(att.StudentId, att.TimetableId);

            if (existing != null) {
                existing.Status = att.Status;
                _context.SaveChanges();
            } else {
                Add(att);
            }
        }
    }

    public List<Attendance> GetByDateRange(DateTime startDate, DateTime endDate)
        => _dbSet
            .Where(a => a.Timetable != null && 
                        a.Timetable.Date >= startDate 
                    && a.Timetable.Date <= endDate)
            .Include(a => a.Timetable)
            .Include(a => a.Student)
            .ToList();

    public List<Attendance> GetByClassId(int classId)
        => _dbSet
            .Include(a => a.Student)
            .Where(a => a.Student != null && a.Student.ClassId == classId)
            .ToList();

    public Dictionary<int, double> GetAttendancePercentagePerStudent(int classId) {
        return _dbSet.Include(a => a.Student)
            .Where(a => a.Student != null && a.Student.ClassId == classId)
            .GroupBy(a => a.StudentId)
            .Select(g => new {
                StudentId = g.Key,
                Total = g.Count(),
                Present = g.Count(a => a.Status.ToLower() == "present")
            }).ToDictionary(
                x => x.StudentId,
                x => x.Total == 0 ? 0 : (double)x.Present / x.Total * 100
            );
    }
}
