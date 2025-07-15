
namespace SMSDataLayer.Interfaces {
    public interface ITeacherRepository : IRepository<Teacher> {
        public void Update(Teacher  teacher, Teacher newTeacher);
    }
}
