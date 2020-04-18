using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaOnline2.BLL.DTOEntities;

namespace PizzaOnline2.BLL.IServices
{
    public interface IUserService
    {
        Task<IEnumerable<DTOUser>> GetAllUser();
        Task InsertUser(DTOUser obj);
        Task UpdateUser(DTOUser obj);
    }
}
