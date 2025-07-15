namespace SMSWebAPI.Models.DatabaseModels {
    public class Coordinator : Person {
        public int CoordinatorId { get; set; }
        public DateTime HireDate { get; set; }
    }
}
