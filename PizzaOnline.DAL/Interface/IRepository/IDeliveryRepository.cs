using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Models;
using PizzaOnline.DAL.Repository.GenericRepository;

namespace PizzaOnline.DAL.Interface.IRepository
{
    public interface IDeliveryRepository : IGenericRepository<Delivery>
    {
        //public PagedList<Delivery> GetDelivery(DeliveryQueryParameters deliveryquery);
        public Task<Delivery> GetDeliveryId(int id);
        //Task<IEnumerable<Delivery>> GetDeliveryPriceRange(int maxPrice, int minPrice);  //ціна в межах от и до 
        //Task<IEnumerable<Delivery>> GetPopular();
        //Task<IEnumerable<Delivery>> GetDeliveryName(string namedelivery);
    }
}
