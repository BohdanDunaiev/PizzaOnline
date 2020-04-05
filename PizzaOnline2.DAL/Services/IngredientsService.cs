using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
        public async Task<IEnumerable<Ingredients>> GetAllIngredients()
        {
            return await _unitOfWork.IngredientsRepository.GetAllAsyn();
        }
        public async Task<Ingredients> GetByIdIngredient(int id)
        {
            return await _unitOfWork.IngredientsRepository.GetByIdAsyn(id);
        }
        public async Task<Ingredients> InsertIngredient(Ingredients customer)
        {
            return await _unitOfWork.IngredientsRepository.InsertAsyn(customer);
        }
        public async Task<Ingredients> UpdateIngredient(Ingredients customer, object key)
        {
            return await _unitOfWork.IngredientsRepository.UpdateAsyn(customer, key);
        }
        public async Task<int> DeleteIngredient(Ingredients id)
        {
            return await _unitOfWork.IngredientsRepository.DeleteAsyn(id);
        } 
    }
}
