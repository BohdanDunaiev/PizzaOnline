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
        private readonly ISortHelper<Delivery> _sortHelper;
        public DeliveryRepository(AplicationContext _context, ISortHelper<Delivery> sortHelper)
            : base(_context)
        {
            _sortHelper = sortHelper;
        }
        public PagedList<Delivery> GetDelivery(DeliveryQueryParameters deliveryParameters)
        {
            var delivery = FindByCondition(o => o.Price >= deliveryParameters.MinPrice &&
                                o.Price <= deliveryParameters.MaxPrice);

            SearchByName(ref delivery, deliveryParameters.Name);
            var result = _sortHelper.ApplySort(delivery, deliveryParameters);
            return PagedList<Delivery>.ToPagedList(FindAll(),
                deliveryParameters.PageNumber,
                deliveryParameters.PageSize);
        }
        //search.............
        private void SearchByName(ref IQueryable<Delivery> delivery, string deliveryName)
        {
            if (!delivery.Any() || string.IsNullOrWhiteSpace(deliveryName))
                return;

            delivery = delivery.Where(o => o.NameDelivery.ToLower().Contains(deliveryName.Trim().ToLower()));
        }

        public async Task<IEnumerable<Delivery>> GetDeliveryName(string namedelivery)
        {
            var res = _context.Delivery.Where(x => x.NameDelivery == namedelivery);
            return res;
        }
        public async Task<IEnumerable<Delivery>> GetPopular()
        {
            var res1 = _context.Delivery
                .OrderByDescending(e => e.Orders.Count());
            return res1;
        }
        public async Task<IEnumerable<Delivery>> GetDeliveryId(int id)
        {
            var res = _context.Delivery.Where(x => x.Id == id);
            return res;
        }
        public async Task<IEnumerable<Delivery>> GetDeliveryPriceRange(int maxPrice, int minPrice)
        {
            var res = _context.Delivery.Where(x => x.Price >= minPrice && x.Price <= maxPrice);
            return res;
        }
    }
}
