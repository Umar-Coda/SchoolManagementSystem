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

        public void Update(Teacher teacher, Teacher newTeacher) {
            throw new NotImplementedException();
        }
    }
}
