using AutoMapper;
using PizzaOnline.BLL.DTOEntities;
using PizzaOnline.DAL.Entities;
using PizzaOnline2.BLL.DTOEntities;

namespace PizzaOnline2.BLL.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Customer, DTOCustomer>();
            CreateMap<Delivery, DTODelivery>();
            CreateMap<Ingredients, DTOIngredients>();
            CreateMap<Order, DTOOrder>();
            CreateMap<Pizza, DTOPizza>();
            CreateMap<Pizzeria, DTOPizzeria>();
            CreateMap<Role, RoleDTO>();
            // мапинг в обратную сторону
            CreateMap<DTOCustomer, Customer>();
            CreateMap<DTODelivery, Delivery>();
            CreateMap<DTOIngredients, Ingredients>();
            CreateMap<DTOOrder, Order>();
            CreateMap<DTOPizza, Pizza>();
            CreateMap<DTOPizzeria, Pizzeria>();
            CreateMap<RoleDTO, Role>();
        }
    }
}
