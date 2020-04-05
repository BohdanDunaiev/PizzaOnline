using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline2.DAL.Entities;
using PizzaOnline2.DAL.Interface;
using PizzaOnline2.DAL.Interface.IServices;

namespace PizzaOnline2.DAL.Services
{
    public class PizzaeriaService : IPizzeriaService
    {
        IUnitOfWork _unitOfWork;
        public PizzaeriaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Pizzeria>> GetAllPizzeria()
        {
            return await _unitOfWork.PizzeriaRepository.GetAllAsyn();
        }
        public async Task<Pizzeria> GetByIdPizzeria(int id)
        {
            return await _unitOfWork.PizzeriaRepository.GetByIdAsyn(id);
        }
        public async Task<Pizzeria> InsertPizzeria(Pizzeria pizzeria)
        {
            return await _unitOfWork.PizzeriaRepository.InsertAsyn(pizzeria);
        }
        public async Task<Pizzeria> UpdatePizzeria(Pizzeria pizzeria, object key)
        {
            return await _unitOfWork.PizzeriaRepository.UpdateAsyn(pizzeria, key);
        }
        public async Task<int> DeletePizzeria(Pizzeria id)
        {
            return await _unitOfWork.PizzeriaRepository.DeleteAsyn(id);
        }        
    }
}
