namespace SMSWebAPI.Models.DatabaseModels {
    public class Student : Person {
        public int StudentId { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Related Table
        public int ClassId { get; set; }
        public Class? Class { get; set; }
    }
}
