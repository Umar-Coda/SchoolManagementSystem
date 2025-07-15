
namespace SMSModels.Models {
    public class Timetable {
        public int TimetableId { get; set; }
        public int WeekNumber { get; set; }
        public DateTime Date { get; set; }
        public string DayOfWeek { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Related Table
        public int TeacherClassId { get; set; }
        public TeacherClass? TeacherClass { get; set; }
        public int SemesterId { get; set; }
    }
}
