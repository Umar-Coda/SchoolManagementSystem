using SMSDataLayer.Repositories;
using System.Reflection.Metadata;

/// <summary>
/// Handles database operations related to entity Roles
/// </summary>
public class RoleRepository : BaseRepository<Role>, IRoleRepository {
    public RoleRepository(SchoolContext context) : base(context) { }

    public int GetRoleIdByRoleName(string roleName)
        => _dbSet.Where(role =>  role.RoleName == roleName)
            .Select(role => role.RoleId)
            .FirstOrDefault();

    public string GetRoleName(int roleId)
        => _dbSet.FirstOrDefault(role => role.RoleId == roleId)?.RoleName!;
  
    public void UpdateRole(Role role, string newRoleName) {
        role.RoleName = newRoleName;
        _context.SaveChanges();
    }
}
