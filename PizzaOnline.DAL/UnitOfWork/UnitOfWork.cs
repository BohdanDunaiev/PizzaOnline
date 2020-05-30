using Microsoft.AspNetCore.Identity;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Interface;
using PizzaOnline.DAL.Interface.IRepository;
using System;
using System.Threading.Tasks;

namespace PizzaOnline.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AplicationContext _context;
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly IIngredientsRepository _ingredientsRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IPizzaRepository _pizzaRepository;
        private readonly IPizzeriaRepository _pizzeriaRepository;
        private readonly ICustomerRepository _userRepository;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly ISortHelper<Pizza> _carSortHelper;
        private readonly ISortHelper<Customer> _clientSortHelper;

        public UnitOfWork(IDeliveryRepository deliveryRepository,
             IIngredientsRepository ingredientsRepository,
             IOrderRepository orderRepository,
             IPizzaRepository pizzaRepository,
             IPizzeriaRepository pizzeriaRepository, ICustomerRepository userRepository,
             AplicationContext context, UserManager<User> userManager,
             SignInManager<User> signInManager, RoleManager<Role> roleManager,
              ISortHelper<Pizza> carSortHelper, ISortHelper<Customer> clientSortHelper)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _carSortHelper = carSortHelper;
            _clientSortHelper = clientSortHelper;
            _deliveryRepository = deliveryRepository;
            _ingredientsRepository = ingredientsRepository;
            _orderRepository = orderRepository;
            _pizzaRepository = pizzaRepository;
            _pizzeriaRepository = pizzeriaRepository;
            _userRepository = userRepository;
        }
        public UserManager<User> userManager
        {
            get
            {
                return _userManager;
            }
        }
        public RoleManager<Role> roleManager
        {
            get
            {
                return _roleManager;
            }
        }
        public SignInManager<User> signInManager
        {
            get
            {
                return _signInManager;
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
        public ICustomerRepository CustomerRepository
        {
            get
            {
                return _userRepository;
            }
        }
        public Task<int> Complete() => _context.SaveChangesAsync();
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
