
namespace SMSDataLayer.Interfaces {
    public interface ITeacherRepository : IRepository<Teacher> {
        public Dictionary<NameKey, List<Teacher>> GetTeacherGridData();
        public string GetTeacherName(int teacherId);
        public void Update(Teacher  teacher, Teacher newTeacher);
    }
}
