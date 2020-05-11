using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Models;
using PizzaOnline2.BLL.DTOEntities;

namespace PizzaOnline2.BLL.IServices
{
    public interface ICustomerService
    {
        Task<IEnumerable<DTOCustomer>> GetAllCustomer();
        Task<DTOCustomer> GetByIdCustomer(int id);
        Task InsertCustomer(DTOCustomer obj);
        Task UpdateCustomer(DTOCustomer obj);
        Task DeleteCustomer(int Id);
        //repository 
        Task<Customer> GetCustomerId(int Id);
        PagedList<DTOCustomer> GetCustomer(CustomerQueryParameters parameters);
    }
}
