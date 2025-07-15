namespace SMSWebAPI.Models.DatabaseModels {
    public class Attendance {
        public class Attendance {
            public int AttendanceId { get; set; }
            public string Status { get; set; } = string.Empty;

            // Related Tables
            public int TimetableId { get; set; }
            public Timetable? Timetable { get; set; }
            public int StudentId { get; set; }
            public Student? Student { get; set; }
        }
    }
}
