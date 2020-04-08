using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline2.BLL.IServices;
using PizzaOnline2.DAL.Entities;
using PizzaOnline2.DAL.Interface;

namespace PizzaOnline2.BLL.Services
{
    public class PizzaService : IPizzaService
    {
        IUnitOfWork _unitOfWork;
        public PizzaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Pizza>> GetAllPizza()
        {
            return await _unitOfWork.PizzaRepository.GetAllAsyn();
        }
        public async Task<Pizza> GetByIdPizza(int id)
        {
            return await _unitOfWork.PizzaRepository.GetByIdAsyn(id);
        }
        public async Task<Pizza> InsertPizza(Pizza pizza)
        {
            return await _unitOfWork.PizzaRepository.InsertAsyn(pizza);
        }
        public async void UpdatePizza(Pizza pizza )
        {
              _unitOfWork.PizzaRepository.UpdateAsyn(pizza);
        }
        public async Task<int> DeletePizza(Pizza id)
        {
            return await _unitOfWork.PizzaRepository.DeleteAsyn(id);
        }
    }
}
