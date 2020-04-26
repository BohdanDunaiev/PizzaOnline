using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Interface.IRepository;
using PizzaOnline.DAL.Models;
using PizzaOnline.DAL.Repository.GenericRepository;

namespace PizzaOnline.DAL.Repository.EntetiesRepository
{
    public class DeliveryRepository : GenericRepository<Delivery>, IDeliveryRepository
    {
        public DeliveryRepository(AplicationContext _context)
            : base(_context)
        {
        }
        public PagedList<Delivery> GetOwners(DeliveryQueryParameters ownerParameters)
        {

            return PagedList<Delivery>.ToPagedList(FindAll(),
                ownerParameters.PageNumber,
                ownerParameters.PageSize);
        }
        public async Task<IEnumerable<Delivery>> GetDeliveryName(string namedelivery)
        {
            var res = _context.Deliveries.Where(x => x.NameDelivery == namedelivery);
            return res;
        }
        public async Task<IEnumerable<Delivery>> GetPopular()
        {
            var res1 = _context.Deliveries
                .OrderByDescending(e => e.Orders.Count());
            return res1;
        }
        public async Task<IEnumerable<Delivery>> GetDeliveryId(int id)
        {
            var res = _context.Deliveries.Where(x => x.Id == id);
            return res;
        }
        public async Task<IEnumerable<Delivery>> GetDeliveryPriceRange(int maxPrice, int minPrice)
        {
            var res = _context.Deliveries.Where(x => x.Price >= minPrice && x.Price <= maxPrice);
            return res;
        }
    }
}
