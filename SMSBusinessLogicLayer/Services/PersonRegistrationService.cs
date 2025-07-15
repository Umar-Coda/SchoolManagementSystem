using SMSModels.Models;

namespace SMSBusinessLogicLayer.Services {
    /// <summary>
    /// Responsibility -- Registering Coordinators, Teachers, and Students
    /// </summary>
    public class PersonRegistrationService : IPersonRegistrationService {
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly IUserAccountService _userAccountService;
        private readonly ICoordinatorService _coordinatorService;

        public PersonRegistrationService(IRepositoryFactory repositoryFactory,
            IUserAccountService userAccountService,
            ICoordinatorService coordinatorService) {
            _repositoryFactory = repositoryFactory;
            _userAccountService = userAccountService;
            _coordinatorService = coordinatorService;
        }

        public OperationResult RegisterCoordinator(Coordinator coordinator) {
            var coordinatorRepo = _repositoryFactory.GetCoordinatorRepository();
            string message = string.Empty;

            try {
                _userAccountService.CreateAccount(coordinator.User!);

                coordinatorRepo.Add(new Coordinator {
                    Firstname = coordinator.Firstname,
                    Lastname = coordinator.Lastname,
                    Gender = coordinator.Gender,
                    BirthDate = coordinator.BirthDate,
                    PhoneNumber = coordinator.PhoneNumber,
                    Email = coordinator.Email,
                    Address = coordinator.Address,
                    HireDate = coordinator.HireDate,
                    UserId = _userAccountService.GetUserId(coordinator.User!.Username)
                });

                _userAccountService.Refresh();
                _coordinatorService.Refresh();
                message = "Coordinator registered successfully";
            } catch (Exception ex) {
                message = $"Failed to register coordinator : {ex.Message}";
            }

            return new OperationResult { Message = message };
        }

        public OperationResult RegisterStudent(Student student) {
            var studentRepo = _repositoryFactory.GetStudentRepository();
            string message = string.Empty;

            try {
                _userAccountService.CreateAccount(student.User!);
                student.UserId = _userAccountService.GetUserId(student.User!.Username);
                studentRepo.Add(student);

                _userAccountService.Refresh();
                // Refresh student service.
                message = "Student registered successfully";
            } catch (Exception ex) {
                message = $"Failed to register student : {ex.Message}";
            }

            return new OperationResult { Message = message };
        }

        public OperationResult RegisterTeacher(Teacher teacher) {
            var teacherRepo = _repositoryFactory.GetTeacherRepository();
            string message = string.Empty;

            try {
                _userAccountService.CreateAccount(teacher.User!);
                teacher.UserId = _userAccountService.GetUserId(teacher.User!.Username);
                teacherRepo.Add(teacher);

                _userAccountService.Refresh();
                // Refresh teacher service.
                message = "Teacher registered successfully";
            } catch (Exception ex) {
                message = $"Failed to register teacher : {ex.Message}";
            }

            return new OperationResult { Message = message };
        }
    }
}
