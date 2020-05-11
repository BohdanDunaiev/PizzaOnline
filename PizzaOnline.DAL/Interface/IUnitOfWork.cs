using Microsoft.AspNetCore.Identity;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline.DAL.Interface
{
    public interface IUnitOfWork
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
        void Complete();
    }
}
