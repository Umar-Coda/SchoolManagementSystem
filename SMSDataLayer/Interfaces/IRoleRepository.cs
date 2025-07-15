
namespace SMSDataLayer.Interfaces {
    public interface IRoleRepository : IRepository<Role> {
        public string GetRoleName(int roleId);
        public void UpdateRole(Role role, string newRoleName);
        public int GetRoleIdByRoleName(string roleName);
    }
}
