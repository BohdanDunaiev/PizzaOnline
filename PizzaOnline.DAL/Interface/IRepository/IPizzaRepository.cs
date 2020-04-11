using System;
using System.Collections.Generic;
using System.Text;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Repository.GenericRepository;

namespace PizzaOnline.DAL.Interface.IRepository
{
    public interface IPizzaRepository : IGenericRepository<Pizza>
    {

    }
}
