using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Repository.GenericRepository;

namespace PizzaOnline.DAL.Interface.IRepository
{
    public interface IIngredientsRepository : IGenericRepository<Ingredients> 
    {
        Task<IEnumerable<Ingredients>> GetIngredientId(int id);
    }
}
