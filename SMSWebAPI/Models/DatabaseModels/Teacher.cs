namespace SMSWebAPI.Models.DatabaseModels {
    public class Teacher : Person {
            public int TeacherId { get; set; }
            public DateTime HireDate { get; set; }
            public string Qualification { get; set; } = string.Empty;

            // Related Table
            public int SubjectId { get; set; }
            public Subject? Subject { get; set; }
    }
}
