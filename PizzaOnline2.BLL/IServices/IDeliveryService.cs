using PizzaOnline.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOnline2.BLL.IServices
{
    public interface IDeliveryService
    {
        Task<IEnumerable<Delivery>> GetAllDelivery();
        Task<Delivery> GetByIdDelivery(int id);
        Task<Delivery> InsertDelivery(Delivery obj);
        void UpdateDelivery(Delivery obj);
        Task<int> DeleteDelivery(Delivery id);
    }
}
