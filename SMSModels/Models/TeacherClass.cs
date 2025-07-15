
namespace SMSModels.Models {
    public class TeacherClass {
        public int TeacherClassId { get; set; }

        // Related Tables
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public int ClassId { get; set; }
        public Class? Class { get; set; }
    }
}
