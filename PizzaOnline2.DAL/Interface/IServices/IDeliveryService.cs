using PizzaOnline2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOnline2.DAL.Interface.IServices
{
    public interface IDeliveryService
    {
        Task<IEnumerable<Delivery>> GetAllDelivery();
        Task<Delivery> GetByIdDelivery(int id);
        Task<Delivery> InsertDelivery(Delivery obj);
        Task<Delivery> UpdateDelivery(Delivery obj, object key);
        Task<int> DeleteDelivery(Delivery id);
    }
}
