namespace SMSWebAPI.Models.DatabaseModels {
    public class Faculty {
        public class Faculty {
            public int FacultyId { get; set; }
            public string FacultyName { get; set; } = string.Empty;

            // Related Table
            public int CoordinatorId { get; set; }
            public Coordinator? Coordinator { get; set; }
        }
    }
}
