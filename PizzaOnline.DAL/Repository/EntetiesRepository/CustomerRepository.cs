using Microsoft.EntityFrameworkCore;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Interface.IRepository;
using PizzaOnline.DAL.Models;
using PizzaOnline.DAL.Repository.GenericRepository;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline.DAL.Repository.EntetiesRepository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly ISortHelper<Customer> _sortHelper;
        public CustomerRepository(AplicationContext aplicationContext, ISortHelper<Customer> sortHelper)
           : base(aplicationContext)
        {
            _sortHelper = sortHelper;
        }
        public async Task<Customer> GetCustomerId(int id)
        {
            var res = await _context.Customer
                .Include(i => i.Orders)
                .Where(j => j.Id == id)
                .FirstOrDefaultAsync();
            return res;
        }
        public  PagedList<Customer> GetCustomer(CustomerQueryParameters parameters)
        {
            var customers = FindByCondition(x => x.Id >0);

            SearchByLastName(ref customers, parameters.LastName);

            customers = _sortHelper.ApplySort(customers, parameters);

            return PagedList<Customer>.ToPagedList(customers, parameters.PageNumber, parameters.PageSize);
        }
        private void SearchByLastName(ref IQueryable<Customer> customers, string lastName)
        {
            if (!customers.Any() || string.IsNullOrWhiteSpace(lastName))
                return;

            customers = customers.Where(x => x.LastName.ToLower().Contains(lastName.Trim().ToLower()));
        }
    }
}
