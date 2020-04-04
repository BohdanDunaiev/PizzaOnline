using System;
using System.Collections.Generic;
using System.Text;
using PizzaOnline2.DAL.Entities;
using PizzaOnline2.DAL.Interface.IRepository;
using PizzaOnline2.DAL.Repository.GenericRepository;

namespace PizzaOnline2.DAL.Repository.EntetiesRepository
{
    public class IngredientsRepository : GenericRepository<Ingredients>, IIngredientsRepository
    {
        public IngredientsRepository(AplicationContext aplicationContext)
            : base(aplicationContext)
        {

        }
    }
}
