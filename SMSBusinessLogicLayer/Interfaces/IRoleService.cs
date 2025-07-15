using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSBusinessLogicLayer.Interfaces {
    public interface IRoleService {
        public int GetRoleId(string roleName);
        public bool HasPermission(User user, string permission);
    }
}
