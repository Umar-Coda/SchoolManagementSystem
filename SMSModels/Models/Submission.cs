
namespace SMSModels.Models {
    public class Submission {
        public int SubmissionId { get; set; }
        public string FileUrl { get; set; } = string.Empty;
        public DateTime SubmittedAt { get; set; }

        // Related Tables
        public int AssignmentId { get; set; }
        public Assignment? Assignment { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
