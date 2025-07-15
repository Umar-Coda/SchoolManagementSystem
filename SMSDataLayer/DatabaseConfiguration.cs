
using Microsoft.Extensions.Configuration;

namespace SMSDataLayer {
    /// <summary>
    /// Handles all configuration for database
    /// </summary>
    public static class DatabaseConfiguration {
        public static string GetConnection() {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory) // Important for CLI
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            return config.GetConnectionString("DefaultConnection")!;
        }
    }
}
