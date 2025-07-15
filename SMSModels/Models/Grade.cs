
namespace SMSModels.Models {
    public class Grade {
        public int GradeId { get; set; }
        public double GradeValue { get; set; }
        public DateTime GradedAt { get; set; }

        // Related Table
        public int SubmissionId { get; set; }
        public Submission? Submission { get; set; }
    }
}
