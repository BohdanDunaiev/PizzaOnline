using System;
using System.Collections.Generic;
using System.Text;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface.IRepository;
using PizzaOnline.DAL.Repository.GenericRepository;

namespace PizzaOnline.DAL.Repository.EntetiesRepository
{
    public class PizzaRepository : GenericRepository<Pizza>, IPizzaRepository
    {
        public PizzaRepository(AplicationContext aplicationContext)
            : base(aplicationContext)
        {

        }
    }
}
