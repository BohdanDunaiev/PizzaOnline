using System;
using System.Collections.Generic;
using System.Text;
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
        public IEnumerable<Pizzeria> GetAllPizzeria()
        {
            return _unitOfWork.PizzeriaRepository.GetAll();
        }
        public Pizzeria GetByIdPizzeria(int id)
        {
            return _unitOfWork.PizzeriaRepository.GetById(id);
        }
        public void InsertPizzeria(Pizzeria pizzeria)
        {
            _unitOfWork.PizzeriaRepository.Insert(pizzeria);
        }
        public void UpdatePizzeria(Pizzeria pizzeria)
        {
            _unitOfWork.PizzeriaRepository.Update(pizzeria);
        }
        public void DeletePizzeria(Pizzeria id)
        {
            _unitOfWork.PizzeriaRepository.Delete(id);
        }
    }
}
