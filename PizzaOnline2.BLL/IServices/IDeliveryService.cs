using PizzaOnline.BLL.DTOEntities;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaOnline2.BLL.IServices
{
    public interface IDeliveryService
    {
        Task<IEnumerable<DTODelivery>> GetAll();
        Task<DTODelivery> GetByIdDelivery(int id);
        Task InsertDelivery(DTODelivery deliveryDTO);
        Task UpdateDelivery(DTODelivery obj);
        Task DeleteDelivery(int id);
        //repository
        Task<DTODelivery> GetDeliveryId(int id);
        //Task<IEnumerable<DTODelivery>> GetPopular();
        //Task<IEnumerable<DTODelivery>> GetDeliveryName(string namedelivery);
        //Task<IEnumerable<DTODelivery>> GetDeliveryPriceRange(int maxPrice, int minPrice);  //ціна в межах от и до 
    }
}
