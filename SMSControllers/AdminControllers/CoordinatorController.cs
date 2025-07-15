
namespace SMSControllers.AdminControllers {
    public class CoordinatorController {
        private readonly IPersonRegistrationService _personRegistrationService;
        private readonly IRoleService _roleService;
        private readonly ISearchService _searchService;

        public CoordinatorController(IPersonRegistrationService personRegistrationService, 
            IRoleService roleService,
            ISearchService searchService) {
            _personRegistrationService = personRegistrationService;
            _roleService = roleService;
            _searchService = searchService;
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

            _searchService.RefreshCoordinatorSearch();

            return result;
        }

        public List<Coordinator> LoadCoordinatorData(string searchItem)
            => _searchService.SearchCoordinators(searchItem);
    }
}
