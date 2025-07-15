namespace SMSDataLayer.Repositories;
public class NotificationQueueRepository : BaseRepository<NotificationQueue>, INotificationQueueRepository {
    public NotificationQueueRepository(SchoolContext context) : base(context) {
    }

    public void Enqueue(string message) {
        Add(new NotificationQueue {
            Message = message,
            EnqueuedAt = DateTime.Now,
            IsDelivered = false
        });
    }

    public List<NotificationQueue> GetUndelivered()
        => _dbSet.Where(n => !n.IsDelivered).ToList();

    public void MarkAsDelivered(int id) {
        var notif = Get(id);
        if (notif != null) {
            notif.IsDelivered = true;
            UpdateFields(notif, n => n.IsDelivered);
        }
    }
}
