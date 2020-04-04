using System;
using System.Collections.Generic;
using System.Text;
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
        public IEnumerable<Delivery> GetAllDelivery()
        {
            return _unitOfWork.DeliveryRepository.GetAll();
        }
        public Delivery GetByIdDelivery(int id)
        {
            return _unitOfWork.DeliveryRepository.GetById(id);
        }
        public void InsertDelivery(Delivery delivery)
        {
            _unitOfWork.DeliveryRepository.Insert(delivery);
        }
        public void UpdateDelivery(Delivery delivery)
        {
            _unitOfWork.DeliveryRepository.Update(delivery);
        }
        public void DeleteDelivery(Delivery id)
        {
            _unitOfWork.DeliveryRepository.Delete(id);
        }
    }
}
