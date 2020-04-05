using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline2.DAL.Entities;

namespace PizzaOnline2.DAL.Interface.IServices
{
    public interface IIngredientsService 
    {
        Task<IEnumerable<Ingredients>> GetAllIngredients();
        Task<Ingredients> GetByIdIngredient(int id);
        Task<Ingredients> InsertIngredient(Ingredients obj);
        Task<Ingredients> UpdateIngredient(Ingredients obj, object key);
        Task<int> DeleteIngredient(Ingredients id);
    }
}
