namespace SMSDataLayer.Interfaces;
public interface IAnnouncementRepository : IRepository<Announcement> {
    public List<Announcement> GetRecent(int count);
}

