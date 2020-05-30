using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Interface.IRepository;
using PizzaOnline.DAL.Models;
using PizzaOnline.DAL.Repository.GenericRepository;

namespace PizzaOnline.DAL.Repository.EntetiesRepository
{
    public class DeliveryRepository : GenericRepository<Delivery, int>, IDeliveryRepository
    {
        public DeliveryRepository(AplicationContext _context)
            : base(_context)
        {
        }

        public async Task<Delivery> GetDeliveryId(int id)
        {
            var res = await _context.Delivery
                .Include(i => i.Orders)
                .Where(j => j.Id == id)
                .FirstOrDefaultAsync();
            return res;
        }
        //public PagedList<Delivery> GetDelivery(DeliveryQueryParameters deliveryParameters)
        //{
        //    var delivery = FindByCondition(o => o.Price >= deliveryParameters.MinPrice &&
        //                        o.Price <= deliveryParameters.MaxPrice);

        //    SearchByName(ref delivery, deliveryParameters.Name);
        //    var result = _sortHelper.ApplySort(delivery, deliveryParameters);
        //    return PagedList<Delivery>.ToPagedList(FindAll(),
        //        deliveryParameters.PageNumber,
        //        deliveryParameters.PageSize);
        //}
        //public async Task<IEnumerable<Delivery>> GetDeliveryName(string namedelivery)
        //{
        //    var res = _context.Delivery.Where(x => x.NameDelivery == namedelivery);
        //    return res;
        //}
        //public async Task<IEnumerable<Delivery>> GetPopular()
        //{
        //    var res1 = _context.Delivery
        //        .OrderByDescending(e => e.Orders.Count());
        //    return res1;
        //}

        //public async Task<IEnumerable<Delivery>> GetDeliveryPriceRange(int maxPrice, int minPrice)
        //{
        //    var res = _context.Delivery.Where(x => x.Price >= minPrice && x.Price <= maxPrice);
        //    return res;
        //}
    }
}
