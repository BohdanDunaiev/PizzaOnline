using PizzaOnline.DAL.Interface;
using PizzaOnline.DAL.Interface.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly IIngredientsRepository _ingredientsRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IPizzaRepository _pizzaRepository;
        private readonly IPizzeriaRepository _pizzeriaRepository;

        public UnitOfWork(ICustomerRepository customerRepository,
             IDeliveryRepository deliveryRepository,
             IIngredientsRepository ingredientsRepository,
             IOrderRepository orderRepository,
             IPizzaRepository pizzaRepository,
             IPizzeriaRepository pizzeriaRepository)
        {
            _customerRepository = customerRepository;
            _deliveryRepository = deliveryRepository;
            _ingredientsRepository = ingredientsRepository;
            _orderRepository = orderRepository;
            _pizzaRepository = pizzaRepository;
            _pizzeriaRepository = pizzeriaRepository;
        }
        public ICustomerRepository CustomerRepository 
        {
            get
            {
                return _customerRepository;
            }
        }
        public IDeliveryRepository DeliveryRepository
        {
            get
            {
                return _deliveryRepository;
            }
        }
        public IIngredientsRepository IngredientsRepository
        {
            get
            {
                return _ingredientsRepository;
            }
        }
        public IOrderRepository OrderRepository
        {
            get
            {
                return _orderRepository;
            }
        }
        public IPizzaRepository PizzaRepository
        {
            get
            {
                return _pizzaRepository;
            }
        }
        public IPizzeriaRepository PizzeriaRepository
        {
            get
            {
                return _pizzeriaRepository;
            }
        }
        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
