namespace SMSWebAPI.Models.DatabaseModels {
    public class SlotTracking {
        public int SlotTrackingId { get; set; }
        public int TeacherId { get; set; }
        public string SubjectName { get; set; } = string.Empty;
        public string DayOfWeek { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Teacher? Teacher { get; set; }
    }
}
