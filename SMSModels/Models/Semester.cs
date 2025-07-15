
namespace SMSModels.Models {
    public class Semester {
        public int SemesterId { get; private set; }
        public string AcademicYear { get; set; } = string.Empty;
        public int SemesterNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
