namespace SMSDataLayer.Interfaces {
    public interface ICourseRepository : IRepository<Course> {
        public Dictionary<Course, string> GetCourseGridData();
        public HashSet<string> GetCourseCodes();
    }
}
