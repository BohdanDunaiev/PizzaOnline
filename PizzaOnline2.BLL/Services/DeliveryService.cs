using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaOnline2.BLL.IServices;
using PizzaOnline.DAL.Interface;
using PizzaOnline.BLL.DTOEntities;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Models;

namespace PizzaOnline2.BLL.Services
{
    public class DeliveryService : IDeliveryService
    {
        IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
     
        public DeliveryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<DTODelivery> GetDeliveryId(int id)
        {
            return _mapper.Map<Delivery, DTODelivery>(await _unitOfWork.DeliveryRepository.GetDeliveryId(id)); ;
        }
        //public async Task<IEnumerable<DTODelivery>> GetDeliveryName(string namedelivery)
        //{
        //    return _mapper.Map<IEnumerable<Delivery>, IEnumerable<DTODelivery>>(await _unitOfWork.DeliveryRepository.GetDeliveryName(namedelivery)); ;
        //}
       
        //public async Task<IEnumerable<DTODelivery>> GetDeliveryPriceRange(int maxPrice, int minPrice)
        //{
        //    return _mapper.Map<IEnumerable<Delivery>, IEnumerable<DTODelivery>>(await _unitOfWork.DeliveryRepository.GetDeliveryPriceRange(maxPrice, minPrice)); ;
        //}
        //public async Task<IEnumerable<DTODelivery>> GetPopular()
        //{
        //    var res = _mapper.Map<IEnumerable<Delivery>, IEnumerable<DTODelivery>>(await _unitOfWork.DeliveryRepository.GetPopular());
        //    return res;
        //}
        //CRUT operation
        public async Task<IEnumerable<DTODelivery>> GetAll()
        {
            var data = await _unitOfWork.DeliveryRepository.GetAllAsyn();
            List<DTODelivery> transferedtoDTO = new List<DTODelivery>();

            foreach (var delivery in data)
                transferedtoDTO.Add(_mapper.Map<Delivery, DTODelivery>(delivery));

            return transferedtoDTO;
            //return _mapper.Map<IEnumerable<Delivery>, IEnumerable<DTODelivery>>(await _unitOfWork.DeliveryRepository.GetAllAsyn());            
        }
        public async Task<DTODelivery> GetByIdDelivery(int id)
        {
            var info = await _unitOfWork.DeliveryRepository.GetByIdAsyn(id);
            return _mapper.Map<Delivery, DTODelivery>(info);
        }
        public async Task InsertDelivery(DTODelivery delivery)
        {
            DTODelivery dDTO = new DTODelivery()
            {
                NameDelivery = delivery.NameDelivery,
                Time = delivery.Time,
                Price = delivery.Price
            };
            var info = _mapper.Map<Delivery, DTODelivery>(await _unitOfWork.DeliveryRepository.InsertAsyn(_mapper.Map<DTODelivery, Delivery>(dDTO)));
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
