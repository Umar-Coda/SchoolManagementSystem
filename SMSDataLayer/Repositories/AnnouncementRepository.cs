

namespace SMSDataLayer.Repositories;
public class AnnouncementRepository : BaseRepository<Announcement>, IAnnouncementRepository {
    public AnnouncementRepository(SchoolContext context) : base(context) {
    }

    public List<Announcement> GetRecent(int count)
        => _dbSet.OrderByDescending(a => a.DatePosted)
        .Take(count)
        .Include(a => a.User)
        .ToList();
}

