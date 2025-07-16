using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSDataLayer.Repositories {
    /// <summary>
    /// Handles database operations for Teachers entity
    /// </summary>
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository {
        public TeacherRepository(SchoolContext context) : base(context) {}
        public Dictionary<NameKey, List<Teacher>> GetTeacherGridData() {
            return _dbSet
                .GroupBy(t => new NameKey(t.Firstname, t.Lastname))
                .ToDictionary(g => g.Key, g => g.ToList());
        }

        public string GetTeacherName(int teacherId) {
            return _dbSet
                .Where(t => t.TeacherId == teacherId)
                .Select(t => $"{t.Firstname} {t.Lastname}")
                .FirstOrDefault() ?? string.Empty;
        }
        public void Update(Teacher teacher, Teacher newTeacher) {
            throw new NotImplementedException();
        }
    }
}
