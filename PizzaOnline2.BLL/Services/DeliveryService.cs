using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline2.BLL.IServices;
using PizzaOnline.DAL.Interface;
using PizzaOnline.BLL.DTOEntities;
using AutoMapper;
using PizzaOnline.DAL.Entities;

namespace PizzaOnline2.BLL.Services
{
    public class DeliveryService : IDeliveryService
    {
        IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DeliveryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<DTODelivery>> GetAllDelivery()
        {
            var info = await _unitOfWork.DeliveryRepository.GetAllAsyn();

            List<DTODelivery> transferDTO = new List<DTODelivery>();

            foreach (var delivery in info)
                transferDTO.Add(_mapper.Map<Delivery, DTODelivery>(delivery));

            return transferDTO;
        }
        public async Task<DTODelivery> GetByIdDelivery(int id)
        {
            var info = await _unitOfWork.DeliveryRepository.GetByIdAsyn(id);
            return _mapper.Map<Delivery, DTODelivery>(info);
        }
        public async Task InsertDelivery(DTODelivery delivery)
        {
            var info = _mapper.Map<DTODelivery, Delivery>(delivery);
            await _unitOfWork.DeliveryRepository.InsertAsyn(info);
        }
        public async Task UpdateDelivery(DTODelivery delivery)
        {
            var info = _mapper.Map<DTODelivery, Delivery>(delivery);
            await _unitOfWork.DeliveryRepository.UpdateAsyn(info);
        }
        public async Task DeleteDelivery(int id)
        {
            await _unitOfWork.DeliveryRepository.DeleteAsyn(id);
        }       
    }
}
