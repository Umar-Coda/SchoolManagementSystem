
namespace SMSDataLayer.Interfaces;

public interface IStudentRepository : IRepository<Student> {
    public Dictionary<Student, StudentDTO> GetStudentGridData();
    public string GetStudentName(int studentId);
    public void Update(Student student, Student newStudent);
}
