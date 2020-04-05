using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await _unitOfWork.OrderRepository.GetAllAsyn();
        }
        public async Task<Order> GetByIdOrder(int id)
        {
            return await _unitOfWork.OrderRepository.GetByIdAsyn(id);
        }
        public async Task<Order> InsertOrder(Order order)
        {
            return await _unitOfWork.OrderRepository.InsertAsyn(order);
        }
        public async Task<Order> UpdateOrder(Order order, object key)
        {
            return await _unitOfWork.OrderRepository.UpdateAsyn(order, key);
        }
        public async Task<int> DeleteOrder(Order id)
        {
            return await _unitOfWork.OrderRepository.DeleteAsyn(id);
        }       
    }
}
