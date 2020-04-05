using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline2.DAL.Entities;
using PizzaOnline2.DAL.Interface;
using PizzaOnline2.DAL.Interface.IServices;

namespace PizzaOnline2.DAL.Services
{
    public class DeliveryService : IDeliveryService
    {
        IUnitOfWork _unitOfWork;
        public DeliveryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Delivery>> GetAllDelivery()
        {
            return await _unitOfWork.DeliveryRepository.GetAllAsyn();
        }
        public async Task<Delivery> GetByIdDelivery(int id)
        {
            return await _unitOfWork.DeliveryRepository.GetByIdAsyn(id);
        }
        public async Task<Delivery> InsertDelivery(Delivery delivery)
        {
            return await _unitOfWork.DeliveryRepository.InsertAsyn(delivery);
        }
        public async Task<Delivery> UpdateDelivery(Delivery delivery, object key)
        {
            return await _unitOfWork.DeliveryRepository.UpdateAsyn(delivery, key);
        }
        public async Task<int> DeleteDelivery(Delivery id)
        {
            return await _unitOfWork.DeliveryRepository.DeleteAsyn(id);
        }       
    }
}
