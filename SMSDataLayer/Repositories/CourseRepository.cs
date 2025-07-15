namespace SMSDataLayer.Repositories;

public class CourseRepository : BaseRepository<Course>, ICourseRepository {
    public CourseRepository(SchoolContext context) : base(context) {}

    public Dictionary<Course, string> GetCourseGridData() {
        var data = new Dictionary<Course, string>();
        data = _dbSet
            .Include(course => course.Faculty)
            .ToDictionary(
                course => course,
                course => course.Faculty.FacultyName
            );
        return data;
    }

    public HashSet<string> GetCourseCodes() {
        var data = new HashSet<string>();
        data = _dbSet.Select(course => course.CourseCode).ToHashSet();
        return data;
    }
}
