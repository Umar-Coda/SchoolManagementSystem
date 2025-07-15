namespace SMSWebAPI.Context {
    public class SchoolContext : DbContext {
        public SchoolContext(DbContextOptions<SchoolContext> options)
        : base(options) { }

        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<CourseSubject> CourseSubjects { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<TeacherClass> TeacherClasses { get; set; }
        public DbSet<Timetable> Timetables { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Fee> Fees { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<SlotTracking> SlotTrackings { get; set; }
        public DbSet<NotificationQueue> NotificationQueues { get; set; }
    }
}
