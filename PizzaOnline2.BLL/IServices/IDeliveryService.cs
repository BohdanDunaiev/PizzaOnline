using PizzaOnline.BLL.DTOEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaOnline2.BLL.IServices
{
    public interface IDeliveryService
    {
        Task<IEnumerable<DTODelivery>> GetAllDelivery();
        Task<DTODelivery> GetByIdDelivery(int id);
        Task InsertDelivery(DTODelivery obj);
        Task UpdateDelivery(DTODelivery obj);
        Task DeleteDelivery(int id);
    }
}
