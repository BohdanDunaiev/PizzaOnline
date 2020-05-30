using Microsoft.AspNetCore.Identity;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOnline.DAL.Interface
{
    public interface IUnitOfWork : IDisposable
    {        
        IDeliveryRepository DeliveryRepository { get; }
        IIngredientsRepository IngredientsRepository { get; }
        IOrderRepository OrderRepository { get; }
        IPizzaRepository PizzaRepository { get; }
        IPizzeriaRepository PizzeriaRepository { get; }
        ICustomerRepository CustomerRepository { get; }

        UserManager<User> userManager { get; }
        RoleManager<Role> roleManager { get; }
        SignInManager<User> signInManager { get; }
        Task<int> Complete();
    }
}
