using PizzaOnline.DAL.Interface.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline.DAL.Interface
{
    public interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }
        IDeliveryRepository DeliveryRepository { get; }
        IIngredientsRepository IngredientsRepository { get; }
        IOrderRepository OrderRepository { get; }
        IPizzaRepository PizzaRepository { get; }
        IPizzeriaRepository PizzeriaRepository { get; }
        void Complete();
    }
}
