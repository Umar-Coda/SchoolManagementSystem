namespace SMSDataLayer.Interfaces;
public interface INotificationQueueRepository : IRepository<NotificationQueue> {
    public void Enqueue(string message);
    public List<NotificationQueue> GetUndelivered();
    public void MarkAsDelivered(int id);
}