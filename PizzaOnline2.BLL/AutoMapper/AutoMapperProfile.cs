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
            CreateMap<DTOUser, User>();            
            CreateMap<DTODelivery, Delivery>();
            CreateMap<DTOIngredients, Ingredients>();
            CreateMap<DTOOrder, Order>();
            CreateMap<DTOPizza, Pizza>();
            CreateMap<DTOPizzeria, Pizzeria>();

            // мапинг в обратную сторону

            CreateMap<User, DTOUser>();            
            CreateMap<Delivery, DTODelivery>();
            CreateMap<Delivery, DTOIngredients>();
            CreateMap<Order, DTOOrder>();
            CreateMap<Pizza, DTOPizza>();
            CreateMap<Pizzeria, DTOPizzeria>();
        }
    }
}
