using System.Collections.Generic;
using System;
using System.Globalization;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Diagnostics;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;

namespace SMSBusinessLogicLayer.Services;
public class TimetableService : ITimetableService {
    private readonly IRepositoryFactory _repositoryFactory;
    private readonly ISubjectService _subjectService;

    public TimetableService(IRepositoryFactory repositoryFactory, ISubjectService subjectService) {
        _repositoryFactory = repositoryFactory;
        _subjectService = subjectService;
    }

    public List<Timetable> GenerateTimetable(TimetableRequestDTO request) {
        // Fetches the list of teacher-class assignments for the selected teachers.
        List<TeacherClass> assignments = _repositoryFactory.GetTimetableRepository()
            .GetTeacherClassAssignment(request.TeacherIds);

        // Retrieves a dictionary that maps subject codes to subject names (e.g., "MATH101" => "Mathematics")
        Dictionary<string, string> subjectMap = _subjectService.GetSubjectGridData();

        //Randomizes available time slots to avoid assigning the same slot every time(for fair distribution).
        List <TimeSlot> slots = request.AvailableTimeSlots
        .OrderBy(_ => Guid.NewGuid()).ToList();

        //Generates a list of weekdays(Mon–Fri) for the next 90 days.
        List <DateTime> weekdays = Enumerable.Range(0, 90)
            .Select(offset => DateTime.Today.AddDays(offset))
            .Where(date => date.DayOfWeek is >= DayOfWeek.Monday and DayOfWeek.Friday)
        .ToList();

        //Tracks class scheduling clashes using a unique key like "Monday-08:00-Class5".
        HashSet<string> clashSet = new();

        //Prepares a dictionary for each teacher to keep track of which time slots they are already assigned.
        Dictionary<int, List<TimeSlot>> teacherSchedules = request.TeacherIds
            .ToDictionary(t => t, _ => new List<TimeSlot>());

        var generated = (
                    //  Loop over each weekday and randomly ordered teacher-class assignments.
                from date in weekdays
                from assignment in assignments.OrderBy(_ => Guid.NewGuid())
                    //  Extract the teacher ID and subject code for this assignment.
                let teacherId = assignment.TeacherId
                let subjectCode = assignment.Teacher?.Subject?.SubjectCode ?? string.Empty
                    // Look up the subject name from the subjectMap. If not found, default to "Unknown".
                let subjectName = subjectMap.TryGetValue(subjectCode, out var name) ? name : "Unknown"
                    // Pick one available time slot that the teacher hasn't been assigned yet.
                from slot in slots
                    .Where(s => !teacherSchedules[teacherId].Contains(s))
                    .Take(1)
                let clashKey = $"{date.DayOfWeek}-{slot.StartTime}-{assignment.ClassId}"
                where !clashSet.Contains(clashKey)
                    // Avoid assigning the same slot to multiple classes on the same day. This prevents conflicts.
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
