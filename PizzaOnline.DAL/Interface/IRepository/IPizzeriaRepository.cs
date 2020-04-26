﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Repository.GenericRepository;

namespace PizzaOnline.DAL.Interface.IRepository
{
    public interface IPizzeriaRepository : IGenericRepository<Pizzeria>
    {
        Task<IEnumerable<Pizzeria>> GetPopular();
        Task<IEnumerable<Pizzeria>> GetPizzeriaName(string namepizzeria);
        Task<IEnumerable<Pizzeria>> GetPizzeriaLocation(string address);
        Task<IEnumerable<Pizzeria>> GetPizzeriaId(int id);
    }
}
