
namespace SMSModels.Models {
    public class AnnouncementUser {
        public int AnnouncementUserId { get; set; }

        // Related Table
        public int AnnouncementId { get; set; }
        public Announcement? Announcement { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; } // Targeted User
    }
}
