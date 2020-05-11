using PizzaOnline2.BLL.DTOEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOnline2.BLL.IServices
{
    public interface IRolesServices
    {
        Task CreateRole(RoleDTO role);
        Task AppointRole(string id, string role);
        Task<IList<string>> GetAllRolesUser(string id);
    }
}
