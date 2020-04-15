using System;
using AutoMapper;
using System.Collections.Generic;
using System.Text;
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
            CreateMap<DTOCustomer, Customer>();
            CreateMap<DTODelivery, Delivery>();
            CreateMap<DTOIngredients, Ingredients>();
            CreateMap<DTOOrder, Order>();
            CreateMap<DTOPizza, Pizza>();
            CreateMap<DTOPizzeria, Pizzeria>();            
        }
    }
}
