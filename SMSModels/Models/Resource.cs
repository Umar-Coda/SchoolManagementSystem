
namespace SMSModels.Models {
    public class Resource {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string FileUrl { get; set; } = string.Empty;
        public DateTime UploadDate { get; set; }

        // Related Table
        public int TeacherClassId { get; set; }
        public TeacherClass? TeacherClass { get; set; }
    }
}
