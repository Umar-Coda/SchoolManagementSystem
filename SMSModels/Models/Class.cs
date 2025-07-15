
namespace SMSModels.Models {
    public class Class {
        public int ClassId { get; set; }
        public string ClassCode { get; set; } = string.Empty;

        // Related Tables
        public int CourseId { get; set; }
        public Course? Course { get; set; }
    }
}
