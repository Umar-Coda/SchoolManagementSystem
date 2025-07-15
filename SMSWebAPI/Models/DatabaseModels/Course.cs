namespace SMSWebAPI.Models.DatabaseModels {
    public class Course {
        public int CourseId { get; set; }
        public string CourseCode { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;

        // Related Table
        public int FacultyId { get; set; }
        public Faculty? Faculty { get; set; }
    }
}
