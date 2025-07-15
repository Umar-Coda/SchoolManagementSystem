
namespace SMSDataLayer.Interfaces {
    public interface IRepositoryFactory {
        IUserRepository GetUserRepository();
        IRoleRepository GetRoleRepository();
        ILoginRepository GetLoginRepository();
        ICoordinatorRepository GetCoordinatorRepository();
        ITeacherRepository GetTeacherRepository();
        IStudentRepository GetStudentRepository();
        ISubjectRepository GetSubjectRepository();
        IFacultyRepository GetFacultyRepository(); 
        ICourseRepository GetCourseRepository();
        IClassRepository GetClassRepository();
        IFeeRepository GetFeeRepository();
        ITimetableRepository GetTimetableRepository();
        IAttendanceRepository GetAttendanceRepository();
        INotificationQueueRepository GetNotificationQueueRepository();
        IAnnouncementRepository GetAnnouncementRepository();
    }
}
