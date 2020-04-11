using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline2.BLL.IServices;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface;

namespace PizzaOnline2.BLL.Services
{
    public class IngredientsService : IIngredientsService
    {
        IUnitOfWork _unitOfWork;
        public IngredientsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Ingredients>> GetAllIngredients()
        {
            return await _unitOfWork.IngredientsRepository.GetAllAsyn();
        }
        public async Task<Ingredients> GetByIdIngredient(int id)
        {
            return await _unitOfWork.IngredientsRepository.GetByIdAsyn(id);
        }
        public async Task<Ingredients> InsertIngredient(Ingredients ingredients)
        {
            return await _unitOfWork.IngredientsRepository.InsertAsyn(ingredients);
        }
        public async void UpdateIngredient(Ingredients ingredients)
        {
              _unitOfWork.IngredientsRepository.UpdateAsyn(ingredients);
        }
        public async Task<int> DeleteIngredient(Ingredients id)
        {
            return await _unitOfWork.IngredientsRepository.DeleteAsyn(id);
        } 
    }
}
