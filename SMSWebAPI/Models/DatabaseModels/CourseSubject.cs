namespace SMSWebAPI.Models.DatabaseModels {
    public class CourseSubject {
        public class CourseSubject {
            public int CourseSubjectId { get; set; }

            // Related Table
            public int CourseId { get; set; }
            public Course? Course { get; set; }
            public int SubjectId { get; set; }
            public Subject? Subject { get; set; }
        }
    }
}
