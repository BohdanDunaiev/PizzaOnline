using System;
using System.Collections.Generic;
using System.Text;
using PizzaOnline2.DAL.Entities;
using PizzaOnline2.DAL.Interface;
using PizzaOnline2.DAL.Interface.IServices;

namespace PizzaOnline2.DAL.Services
{
    public class PizzaService : IPizzaService
    {
        IUnitOfWork _unitOfWork;
        public PizzaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Pizza> GetAllPizza()
        {
            return _unitOfWork.PizzaRepository.GetAll();
        }
        public Pizza GetByIdPizza(int id)
        {
            return _unitOfWork.PizzaRepository.GetById(id);
        }
        public void InsertPizza(Pizza pizza)
        {
            _unitOfWork.PizzaRepository.Insert(pizza);
        }
        public void UpdatePizza(Pizza pizza)
        {
            _unitOfWork.PizzaRepository.Update(pizza);
        }
        public void DeletePizza(Pizza id)
        {
            _unitOfWork.PizzaRepository.Delete(id);
        }
    }
}
