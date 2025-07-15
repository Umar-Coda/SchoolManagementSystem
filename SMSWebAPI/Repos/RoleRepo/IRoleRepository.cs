using SMSWebAPI.Models.DatabaseModels;

namespace SMSWebAPI.Repos.RoleRepo {
    public interface IRoleRepository : IRepository<Role> {
        public string GetRoleName(int roleId);
        public void UpdateRole(Role role, string newRoleName);
        public int GetRoleIdByRoleName(string roleName);
    }
}
