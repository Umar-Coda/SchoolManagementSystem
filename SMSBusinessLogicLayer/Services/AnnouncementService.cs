
namespace SMSBusinessLogicLayer.Services;
public class AnnouncementService : IAnnouncementService {
    private readonly IRepositoryFactory _repositoryFactory;
    private readonly ICommunicationService _communicationService;

    public AnnouncementService(IRepositoryFactory repositoryFactory, ICommunicationService communicationService) {
        _repositoryFactory = repositoryFactory;
        _communicationService = communicationService;
    }

    public Announcement Create(int userId, string title, string message) {
        var announcement = new Announcement {
            UserId = userId, Title = title, Message = message, DatePosted = DateTime.Now
        };

        _repositoryFactory.GetAnnouncementRepository().Add(announcement);

        string notifcation = $"📢 New Announcement: {title} - {message}";
        _communicationService.EnqueueMessage(notifcation);

        return announcement;
    }

    public List<Announcement> GetRecent(int count = 10) 
        => _repositoryFactory.GetAnnouncementRepository().GetRecent(count);
}