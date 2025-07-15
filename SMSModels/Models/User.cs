﻿
namespace SMSModels.Models {
    public class User {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        // Related Table 
        public int RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
