using System;
using System.Collections.Generic;
using System.Text;
using PizzaOnline2.DAL.Entities;
using PizzaOnline2.DAL.Interface;
using PizzaOnline2.DAL.Interface.IServices;

namespace PizzaOnline2.DAL.Services
{
    public class OrderService : IOrderService
    {
        IUnitOfWork _unitOfWork;    
        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Order> GetAllOrders()
        {
            return _unitOfWork.OrderRepository.GetAll();
        }
        public Order GetByIdOrder(int id)
        {
            return _unitOfWork.OrderRepository.GetById(id);
        }
        public void InsertOrder(Order order)
        {
            _unitOfWork.OrderRepository.Insert(order);
        }
        public void UpdateOrder(Order order)
        {
            _unitOfWork.OrderRepository.Update(order);
        }
        public void DeleteOrder(Order id)
        {
            _unitOfWork.OrderRepository.Delete(id);
        }
    }
}
