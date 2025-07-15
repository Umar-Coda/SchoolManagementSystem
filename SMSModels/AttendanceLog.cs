namespace SMSModels;
public class AttendanceLog {
    public int StudentId { get; set; }
    public int TimetableId { get; set; }
    public string PreviousStatus { get; set; } = string.Empty;
    public string NewStatus { get; set; } = string.Empty;
    public DateTime ChangedAt { get; set; } = DateTime.Now;
}

