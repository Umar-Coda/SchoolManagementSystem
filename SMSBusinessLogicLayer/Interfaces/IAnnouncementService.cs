namespace SMSBusinessLogicLayer.Interfaces;
public interface IAnnouncementService {
    public Announcement Create(int userId, string title, string message);
    public List<Announcement> GetRecent(int count = 10);
}

