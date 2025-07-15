namespace SMSBusinessLogicLayer.Services;
public class NotificationService : ICommunicationService {
    private readonly IRepositoryFactory _repositoryFactory;
    private readonly Queue<string> _messageQueue = new();

    public NotificationService(IRepositoryFactory repositoryFactory) {
        _repositoryFactory = repositoryFactory;
    }

    public void EnqueueMessage(string message) {
        _messageQueue.Enqueue(message);
        _repositoryFactory.GetNotificationQueueRepository().Enqueue(message);
    }

    public void MarkDelivered(int id) 
        => _repositoryFactory.GetNotificationQueueRepository().MarkAsDelivered(id);

    public List<NotificationQueue> GetPendingMessages()
        => _repositoryFactory.GetNotificationQueueRepository().GetUndelivered();
}

