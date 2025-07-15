using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SchoolManagementSystemDesktop.Controllers;
using SchoolManagementSystemDesktop.Controllers.AdminControllers;
using SchoolManagementSystemDesktop.UserControls.Admin;
using SchoolManagementSystemDesktop.Views.Dashboards;
using SMSBusinessLogicLayer;

namespace SchoolManagementSystemDesktop {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddBusinessServices();

                    // Registering other Utitlies
                    services.AddScoped<PersonRegistrationValidation>();

                    //Registering ViewModels
                    services.AddScoped<RegisterCoordinatorViewModel>();
                    // services.AddScoped<RegisterTeacherViewModel>():
                    // services.AddScoped<RegisterStudentViewModel>();

                    // Registering Admin Controllers
                    services.AddScoped<SubjectController>();
                    services.AddScoped<CoordinatorController>();
                    services.AddScoped<FacultyController>();
                    services.AddScoped<CourseController>();

                    // Registering Login Controller
                    services.AddScoped<LoginController>();
                    
                    // Registering Admin User Controls
                    services.AddScoped<SubjectControl>();
                    services.AddScoped<CoordinatorControl>();
                    services.AddScoped<FacultyControl>();
                    services.AddScoped<AdminDashboardControl>();
                    services.AddScoped<TeacherControl>();
                    services.AddScoped<StudentControl>();
                    services.AddScoped<CourseControl>();
                    services.AddScoped<ClassControl>();
                    services.AddScoped<FeeControl>();
                    services.AddScoped<AnnouncementControl>();

                    // Registering Login and Role-based Views
                    services.AddScoped<AdminDashboard>();
                    services.AddScoped<AdminView>();
                    // services.AddScoped<CoordinatorView>();
                    // services.AddScoped<Teacherview>();
                    services.AddScoped<LoginView>();
                    services.AddScoped<ILoginView, LoginForm>();
                }).Build();

            var serviceProvider = host.Services;

            ApplicationConfiguration.Initialize();
            var loginView = serviceProvider.GetRequiredService<ILoginView>();
            var authService = serviceProvider.GetRequiredService<IAuthenticationService>();
            var presenter = new AuthController(loginView, authService);
            Application.Run(loginView as Form);
        }
    } 
}