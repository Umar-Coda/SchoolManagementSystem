namespace SMSDataLayer {
    /// <summary>
    /// Handles database operations at design time using the CLI
    /// </summary>
    public class SchoolContextFactory : IDesignTimeDbContextFactory<SchoolContext> {
        public SchoolContext CreateDbContext(string[] args) {
            var optionsBuilder = new DbContextOptionsBuilder<SchoolContext>();
            optionsBuilder.UseSqlServer(DatabaseConfiguration.GetConnection());

            return new SchoolContext(optionsBuilder.Options);
        }
    }
}