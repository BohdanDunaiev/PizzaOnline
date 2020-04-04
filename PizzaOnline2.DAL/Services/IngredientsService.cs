using System;
using System.Collections.Generic;
using System.Text;
using PizzaOnline2.DAL.Entities;
using PizzaOnline2.DAL.Interface;
using PizzaOnline2.DAL.Interface.IServices;

namespace PizzaOnline2.DAL.Services
{
    public class IngredientsService : IIngredientsService
    {
        IUnitOfWork _unitOfWork;
        public IngredientsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Ingredients> GetAllIngredients()
        {
            return _unitOfWork.IngredientsRepository.GetAll();
        }
        public Ingredients GetByIdIngredient(int id)
        {
            return _unitOfWork.IngredientsRepository.GetById(id);
        }
        public void InsertIngredient(Ingredients ingredients)
        {
            _unitOfWork.IngredientsRepository.Insert(ingredients);
        }
        public void UpdateIngredient(Ingredients ingredients)
        {
            _unitOfWork.IngredientsRepository.Update(ingredients);
        }
        public void DeleteIngredient(Ingredients ingredients)
        {
            _unitOfWork.IngredientsRepository.Delete(ingredients);
        }
    }
}
