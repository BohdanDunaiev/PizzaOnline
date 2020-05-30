using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline2.BLL.IServices;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface;
using AutoMapper;
using PizzaOnline2.BLL.DTOEntities;

namespace PizzaOnline2.BLL.Services
{
    public class PizzaeriaService : IPizzeriaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public PizzaeriaService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<DTOPizzeria> GetPizzeriaId(int id)
        {
            return _mapper.Map<Pizzeria, DTOPizzeria>(await _unitOfWork.PizzeriaRepository.GetPizzeriaId(id)); ;
        }      
        //public async Task<IEnumerable<DTOPizzeria>> GetPizzeriaName(string namepizzeria)
        //{
        //    return _mapper.Map<IEnumerable<Pizzeria>, IEnumerable<DTOPizzeria>>(await _unitOfWork.PizzeriaRepository.GetPizzeriaName(namepizzeria)); ;
        //}
        //public async Task<IEnumerable<DTOPizzeria>> GetPizzeriaLocation(string address)
        //{
        //    return _mapper.Map<IEnumerable<Pizzeria>, IEnumerable<DTOPizzeria>>(await _unitOfWork.PizzeriaRepository.GetPizzeriaLocation(address)); ;
        //}
        //public async Task<IEnumerable<DTOPizzeria>> GetPopular()
        //{
        //    var res = _mapper.Map<IEnumerable<Pizzeria>, IEnumerable<DTOPizzeria>>(await _unitOfWork.PizzeriaRepository.GetPopular());
        //    return res;
        //}       
        //CRUT operation
        public async Task<IEnumerable<DTOPizzeria>> GetAllPizzeria()
        {
            var info = await _unitOfWork.PizzeriaRepository.GetAllAsyn();

            List<DTOPizzeria> transferDTO = new List<DTOPizzeria>();

            foreach (var pizzeria in info)
                transferDTO.Add(_mapper.Map<Pizzeria, DTOPizzeria>(pizzeria));

            return transferDTO;
        }
        public async Task<DTOPizzeria> GetByIdPizzeria(int id)
        {
            var info = await _unitOfWork.PizzeriaRepository.GetByIdAsyn(id);
            return _mapper.Map<Pizzeria, DTOPizzeria>(info);
        }
        public async Task InsertPizzeria(DTOPizzeria pizzeria)
        {
            var info = _mapper.Map<DTOPizzeria, Pizzeria>(pizzeria);
            await _unitOfWork.PizzeriaRepository.InsertAsyn(info);
        }
        public async Task UpdatePizzeria(DTOPizzeria pizzeria)
        {
            var info = _mapper.Map<DTOPizzeria, Pizzeria>(pizzeria);
            await _unitOfWork.PizzeriaRepository.UpdateAsyn(info);
        }
        public async Task DeletePizzeria(int id)
        {
            await _unitOfWork.PizzeriaRepository.DeleteAsyn(id);
        }        
    }
}
