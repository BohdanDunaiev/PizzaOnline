using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline2.BLL.IServices;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface;


namespace PizzaOnline2.BLL.Services
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
        public async void UpdateDelivery(Delivery delivery)
        {
              _unitOfWork.DeliveryRepository.UpdateAsyn(delivery);
        }
        public async Task<int> DeleteDelivery(Delivery id)
        {
            return await _unitOfWork.DeliveryRepository.DeleteAsyn(id);
        }       
    }
}
