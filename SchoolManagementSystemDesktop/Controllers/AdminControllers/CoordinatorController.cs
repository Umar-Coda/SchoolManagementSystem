namespace SchoolManagementSystemDesktop.AdminControllers {
    public class CoordinatorController {
        private readonly IPersonRegistrationService _personRegistrationService;
        private readonly IRoleService _roleService;
        private readonly ICoordinatorService _coordinatorService;

        public CoordinatorController(IPersonRegistrationService personRegistrationService, 
            IRoleService roleService,
            ICoordinatorService coordinatorService) {
            _personRegistrationService = personRegistrationService;
            _roleService = roleService;
            _coordinatorService = coordinatorService;
        }

        public OperationResult CreateCoordinator(string firstname, string lastname, string gender,
            DateTime birthDate, string phoneNumber, string email, string address, DateTime hireDate,
            string username, string password, DateTime createdAt) {

            var userAccount = new User {
                Username = username,
                PasswordHash = password,
                CreatedAt = createdAt,
                RoleId = _roleService.GetRoleId("Coordinator")
            };

            var result = _personRegistrationService.RegisterCoordinator(new Coordinator {
                Firstname = firstname,
                Lastname = lastname,
                Gender = gender,
                BirthDate = birthDate,
                PhoneNumber = phoneNumber,
                Email = email,
                Address = address,
                HireDate = hireDate,
                User = userAccount
            });

            return result;
        }

        public List<Coordinator> LoadCoordinatorData(string searchItem) {
            var coordinatorGroups = _coordinatorService.GetCoordinatorGridData();

            var result = coordinatorGroups
                .SelectMany(kv => kv.Value) // Flatten the lists of Coordinators
                .Where(coordinator =>
                    string.IsNullOrEmpty(searchItem) ||
                    coordinator.Firstname.Contains(searchItem, StringComparison.OrdinalIgnoreCase) ||
                    coordinator.Lastname.Contains(searchItem, StringComparison.OrdinalIgnoreCase) ||
                    coordinator.Email.Contains(searchItem, StringComparison.OrdinalIgnoreCase) ||
                    coordinator.Address.Contains(searchItem, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return result;
        }  
    }
}
