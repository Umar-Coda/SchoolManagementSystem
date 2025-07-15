using System.Globalization;

namespace SMSBusinessLogicLayer.Services;
public class TimetableService : ITimetableService {
    private readonly IRepositoryFactory _repositoryFactory;
    private readonly ISubjectService _subjectService;

    public TimetableService(IRepositoryFactory repositoryFactory, ISubjectService subjectService) {
        _repositoryFactory = repositoryFactory;
        _subjectService = subjectService;
    }

    public List<Timetable> GenerateTimetable(TimetableRequestDTO request) {
        List<TeacherClass> assignments = _repositoryFactory.GetTimetableRepository()
            .GetTeacherClassAssignment(request.TeacherIds);
        Dictionary<string, string> subjectMap = _subjectService.GetSubjectGridData();

        List<TimeSlot> slots = request.AvailableTimeSlots
            .OrderBy(_ => Guid.NewGuid()).ToList();
        List<DateTime> weekdays = Enumerable.Range(0, 90)
            .Select(offset => DateTime.Today.AddDays(offset))
            .Where(date => date.DayOfWeek is >= DayOfWeek.Monday and DayOfWeek.Friday)
            .ToList();

        HashSet<string> clashSet = new();
        Dictionary<int, List<TimeSlot>> teacherSchedules = request.TeacherIds
            .ToDictionary(t => t, _ => new List<TimeSlot>());

        var generated = (
                from date in weekdays
                from assignment in assignments.OrderBy(_ => Guid.NewGuid())
                let teacherId = assignment.TeacherId
                let subjectCode = assignment.Teacher?.Subject?.SubjectCode ?? string.Empty
                let subjectName = subjectMap.TryGetValue(subjectCode, out var name) ? name : "Unknown"
                from slot in slots
                    .Where(s => !teacherSchedules[teacherId].Contains(s))
                    .Take(1)
                let clashKey = $"{date.DayOfWeek}-{slot.StartTime}-{assignment.ClassId}"
                where !clashSet.Contains(clashKey)
                let timetable = new Timetable {
                    TeacherClassId = assignment.TeacherClassId,
                    DayOfWeek = date.DayOfWeek.ToString(),
                    Date = date,
                    StartTime = date.Date.Add(slot.StartTime),
                    EndTime = date.Date.Add(slot.EndTime),
                    WeekNumber = ISOWeek.GetWeekOfYear(date),
                    SemesterId = request.SemesterId
                }
                let tracking = new SlotTracking {
                    TeacherId = teacherId,
                    SubjectName = subjectName,
                    DayOfWeek = date.DayOfWeek.ToString(),
                    Date = date,
                    StartTime = timetable.StartTime,
                    EndTime = timetable.EndTime
                }
                select new { timetable, tracking, teacherId, slot, clashKey }
            ).ToList();

        _repositoryFactory.GetTimetableRepository()
            .SaveTimetable(generated.Select(g => g.timetable).ToList());
        _repositoryFactory.GetTimetableRepository()
            .SaveSlotTracking(generated.Select(g => g.tracking).ToList());

        return generated.Select(g => g.timetable).ToList();
    }
}
