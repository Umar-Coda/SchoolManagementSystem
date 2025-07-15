namespace SMSDataLayer.Repositories;
/// <summary>
/// Handles database operations for Students entity
/// </summary>
public class StudentRepository : BaseRepository<Student>, IStudentRepository {
    public StudentRepository(SchoolContext context) : base(context) { }

    public Dictionary<Student, StudentDTO> GetStudentGridData() {
        var data = new Dictionary<Student, StudentDTO>();

        data = _dbSet.Include(student => student.Class)
            .Include(student => student.Class.Course)
            .ToDictionary
            (
                student => student,
                student => new StudentDTO { ClassCode = student.Class.ClassCode,
                    CourseCode = student.Class.Course.CourseCode }
            );

        return data;
    }

    public void Update(Student student, Student newStudent) {
        throw new NotImplementedException();
    }
}