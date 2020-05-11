using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline2.BLL.IServices;
using PizzaOnline.DAL.Entities;
using AutoMapper;
using PizzaOnline.DAL.Interface;
using PizzaOnline.BLL.DTOEntities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Models;

namespace PizzaOnline2.BLL.Services
{
    public class OrderService : IOrderService
    {
        IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public  PagedList<DTOOrder> GetOrder(OrderQueryParameters parameters)
        {
            var x =  _unitOfWork.OrderRepository.GetOrder(parameters);
            var result = _mapper.Map<PagedList<DTOOrder>>(x);
            return result;
        }
        public async Task<Order> GetOrderId(int id)
        {
            return await _unitOfWork.OrderRepository.GetOrderId(id);
        }
        //CRUD
        public async Task<IEnumerable<DTOOrder>> GetAllOrders()
        {
            var info = await _unitOfWork.OrderRepository.GetAllAsyn();

            List<DTOOrder> transferDTO = new List<DTOOrder>();

            foreach (var order in info)
                transferDTO.Add(_mapper.Map<Order, DTOOrder>(order));

            return transferDTO;
        }
        public async Task<DTOOrder> GetByIdOrder(int id)
        {
            var info = await _unitOfWork.OrderRepository.GetByIdAsyn(id);
            return _mapper.Map<Order, DTOOrder>(info);
        }
        public async Task InsertOrder(DTOOrder order)
        {
            var info = _mapper.Map<DTOOrder, Order>(order);
            await _unitOfWork.OrderRepository.InsertAsyn(info);
        }
        public async Task UpdateOrder(DTOOrder order)
        {
            var info = _mapper.Map<DTOOrder, Order>(order);
            await _unitOfWork.OrderRepository.UpdateAsyn(info);
        }
        public async Task DeleteOrder(int id)
        {
            await _unitOfWork.OrderRepository.DeleteAsyn(id);
        }       
    }
}
