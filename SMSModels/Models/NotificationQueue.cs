namespace SMSModels.Models;
public class NotificationQueue {
    public int Id { get; set; }
    public string Message { get; set; } = string.Empty;
    public bool IsDelivered { get; set; } = false;
    public DateTime EnqueuedAt { get; set; } = DateTime.Now;
}

