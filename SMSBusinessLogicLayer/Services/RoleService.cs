
namespace SMSBusinessLogicLayer.Services {
    public class RoleService : IRoleService {
        private readonly IRepositoryFactory _repositoryFactory;
        // private readonly IRoleRepository _roleRepository;

        public RoleService(IRepositoryFactory repositoryFactory) {
            _repositoryFactory = repositoryFactory;
            //_roleRepository = repositoryFactory.GetRoleRepository();
        }

        public int GetRoleId(string roleName)
            => _repositoryFactory.GetRoleRepository().GetRoleIdByRoleName(roleName);

        public bool HasPermission(User user, string permission) {
            return user.RoleId switch {
                (int)RoleType.Administrator => true,
                (int)RoleType.Coordinator => permission != "ManageSystem",
                (int)RoleType.Teacher => permission == "ManageClasses",
                _ => false
            };
        }
    }
}
