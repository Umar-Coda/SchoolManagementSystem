
using Microsoft.Extensions.DependencyInjection;

namespace SMSDataLayer.Repositories {
    /// <summary>
    /// handles the creation of instances of repositories
    /// </summary>
    public class RepositoryFactory : IRepositoryFactory {
        private readonly IServiceProvider _provider;

        public RepositoryFactory(IServiceProvider provider) {
            _provider = provider;
        }

        public IAnnouncementRepository GetAnnouncementRepository()
            => _provider.GetRequiredService<IAnnouncementRepository>();

        public IAttendanceRepository GetAttendanceRepository()
            => _provider.GetRequiredService<IAttendanceRepository>();

        public IClassRepository GetClassRepository()
            => _provider.GetRequiredService<IClassRepository>();

        public ICoordinatorRepository GetCoordinatorRepository()
            => _provider.GetRequiredService<ICoordinatorRepository>();

        public ICourseRepository GetCourseRepository()
            => _provider.GetRequiredService<ICourseRepository>();
        public IFacultyRepository GetFacultyRepository()
            => _provider.GetRequiredService<IFacultyRepository>();

        public IFeeRepository GetFeeRepository()
            => _provider.GetRequiredService<IFeeRepository>();

        public ILoginRepository GetLoginRepository()
            => _provider.GetRequiredService<ILoginRepository>();

        public INotificationQueueRepository GetNotificationQueueRepository()
            => _provider.GetRequiredService<INotificationQueueRepository>();

        public IRoleRepository GetRoleRepository()
            => _provider.GetRequiredService<IRoleRepository>();

        public IStudentRepository GetStudentRepository()
            => _provider.GetRequiredService<IStudentRepository>();

        public ISubjectRepository GetSubjectRepository()
             => _provider.GetRequiredService<ISubjectRepository>();

        public ITeacherRepository GetTeacherRepository()
            => _provider.GetRequiredService<ITeacherRepository>();

        public ITimetableRepository GetTimetableRepository()
            => _provider.GetRequiredService<ITimetableRepository>();

        public IUserRepository GetUserRepository()
            => _provider.GetRequiredService<IUserRepository>();

    }
}
