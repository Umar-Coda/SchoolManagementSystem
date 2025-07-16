using Microsoft.Extensions.DependencyInjection;
using SMSDataLayer;
using SMSDataLayer.Contexts;

namespace SMSBusinessLogicLayer {
    public static class ServiceRegistration {
        public static void AddBusinessServices(this IServiceCollection services) {
            services.AddDbContext<SchoolContext>(options
                => options.UseSqlServer(DatabaseConfiguration.GetConnection(),
                    sqlOptions => sqlOptions.MigrationsAssembly("SMSDataLayer")));

            // Register repos
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<ICoordinatorRepository, CoordinatorRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<IFacultyRepository , FacultyRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IClassRepository, ClassRepository>();
            services.AddScoped<IFeeRepository, FeeRepository>();
            services.AddScoped<ITimetableRepository, TimetableRepository>();
            services.AddScoped<INotificationQueueRepository, NotificationQueueRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();

            // Register Repo Factory
            services.AddScoped<IRepositoryFactory, RepositoryFactory>();

            // Register Services
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUserAccountService, UserAccountService>();
            services.AddScoped<IPersonRegistrationService, PersonRegistrationService>();
            services.AddScoped<IEntityCreationService, EntityCreationService>();
            services.AddScoped<ICheckDuplicateService, CheckDuplicateService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<ISubjectService, SubjectService>();
            services.AddScoped<ICoordinatorService, CoordinatorService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IFacultyService, FacultyService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IEntityDeletionService, EntityDeletionService>();
            services.AddScoped<IClassService, ClassService>();
            services.AddScoped<IFeeService, FeeService>();
            services.AddScoped<ITimetableService, TimetableService>();
            services.AddScoped<ICommunicationService, NotificationService>();
        }
    }
}
