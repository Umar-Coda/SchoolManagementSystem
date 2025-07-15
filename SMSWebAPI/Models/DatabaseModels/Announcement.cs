namespace SMSWebAPI.Models.DatabaseModels {
    public class Announcement {
        public int AnnouncementId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime DatePosted { get; set; }

        // Related Table
        public int UserId { get; set; }
        public User? User { get; set; } // Sender
    }
}
