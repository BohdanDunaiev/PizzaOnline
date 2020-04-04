using System;
using System.Collections.Generic;
using System.Text;
using PizzaOnline2.DAL.Entities;

namespace PizzaOnline2.DAL.Interface.IServices
{
    public interface IIngredientsService 
    {
        IEnumerable<Ingredients> GetAllIngredients();
        Ingredients GetByIdIngredient(int id);
        void InsertIngredient(Ingredients obj);
        void UpdateIngredient(Ingredients obj);
        void DeleteIngredient(Ingredients id);
    }
}
