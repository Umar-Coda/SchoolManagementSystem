
using System.Security.Claims;

namespace SMSModels.Models {
    public class AnnouncementClass {
        public int AnnouncementClassId { get; set; }

        // Related table
        public int AnnouncementId { get; set; }
        public Announcement? Announcement { get; set; }
        public int ClassId { get; set; }
        public Class? Class { get; set; } // Targeted class
    }
}
