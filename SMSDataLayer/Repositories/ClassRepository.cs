namespace SMSDataLayer.Repositories;

public class ClassRepository : BaseRepository<Class> , IClassRepository {
    public ClassRepository(SchoolContext context) : base(context) { }

    public HashSet<string> GetClassCodes() {
        return _dbSet.Select(@class => @class.ClassCode).ToHashSet();
    }

    public Dictionary<Class, ClassDTO> GetClassGridData() {
        return _dbSet.Include(@class => @class.Course)
            .ToDictionary(
                @class => @class, 
                @class => new ClassDTO { 
                    CourseCode = @class.Course.CourseCode, 
                    CourseName = @class.Course.CourseName
                }
            );
    }

    public void Update(Class @class) {
        throw new NotImplementedException();
    }
}
