namespace SMSBusinessLogicLayer.Services {
    public class UpdateService : IUpdateService {
        private readonly IRepositoryFactory _repositoryFactory;

        public UpdateService(IRepositoryFactory repositoryFactory) {
            _repositoryFactory = repositoryFactory;
        }

        public string UpdateClass(Class newClass)
            => TryUpdate(_repositoryFactory.GetClassRepository(), newClass);

        public string UpdateCourse(Course newCourse)
            => TryUpdate(_repositoryFactory.GetCourseRepository(), newCourse);

        public string UpdateFaculty(Faculty newFaculty)
            => TryUpdate(_repositoryFactory.GetFacultyRepository(), newFaculty);

        public string UpdateFee(Fee newFee)
            => TryUpdate(_repositoryFactory.GetFeeRepository(), newFee);

        public string UpdateStudent(Student newStudent)
            => TryUpdate(_repositoryFactory.GetStudentRepository(), newStudent);

        public string UpdateTeacher(Teacher newTeacher)
            => TryUpdate(_repositoryFactory.GetTeacherRepository(), newTeacher);

        public string UpdateCoordinator(Coordinator newCoordinator)
            => TryUpdate(_repositoryFactory.GetCoordinatorRepository(), newCoordinator);

        public string UpdateSubject(Subject newSubject)
            => TryUpdate(_repositoryFactory.GetSubjectRepository(), newSubject);

        public string UpdateTimetable(Timetable newTimetable)
            => TryUpdate(_repositoryFactory.GetTimetableRepository(), newTimetable);

        public string UpdateAnnouncement(Announcement newAnnouncement)
            => TryUpdate(_repositoryFactory.GetAnnouncementRepository(), newAnnouncement);

        public string UpdateAttendance(Attendance newAttendance)
            => TryUpdate(_repositoryFactory.GetAttendanceRepository(), newAttendance);

        public string UpdateRole(Role newRole)
            => TryUpdate(_repositoryFactory.GetRoleRepository(), newRole);

        private string TryUpdate<T>(IRepository<T> repository, T entity) where T : class {
            string message = string.Empty;
            try {
                repository.Update(entity);
                message = $"{typeof(T).Name} updated successfully.";
            } catch (Exception ex) {
                message = $"Failed to update {typeof(T).Name}: {ex.Message}";
            }

            return message;
        }
    }


}
