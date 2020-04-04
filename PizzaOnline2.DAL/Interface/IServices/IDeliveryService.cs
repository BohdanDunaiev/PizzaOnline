using PizzaOnline2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline2.DAL.Interface.IServices
{
    public interface IDeliveryService
    {
        IEnumerable<Delivery> GetAllDelivery();
        Delivery GetByIdDelivery(int id);
        void InsertDelivery(Delivery obj);
        void UpdateDelivery(Delivery obj);
        void DeleteDelivery(Delivery id);
    }
}
