using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline2.BLL.IServices;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface;
using AutoMapper;
using PizzaOnline.BLL.DTOEntities;

namespace PizzaOnline2.BLL.Services
{
    public class PizzaService : IPizzaService
    {
        IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public PizzaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<DTOPizza>> GetAllPizza()
        {
            var info = await _unitOfWork.PizzaRepository.GetAllAsyn();

            List<DTOPizza> transferDTO = new List<DTOPizza>();

            foreach (var pizza in info)
                transferDTO.Add(_mapper.Map<Pizza, DTOPizza>(pizza));

            return transferDTO;
        }
        public async Task<DTOPizza> GetByIdPizza(int id)
        {
            var info = await _unitOfWork.PizzaRepository.GetByIdAsyn(id);
            return _mapper.Map<Pizza, DTOPizza>(info);
        }

        public async Task InsertPizza(DTOPizza pizza)
        {
            var info = _mapper.Map<DTOPizza, Pizza>(pizza);
            await _unitOfWork.PizzaRepository.InsertAsyn(info);
        }
        public async Task UpdatePizza(DTOPizza pizza )
        {
            var info = _mapper.Map<DTOPizza, Pizza>(pizza);
            await _unitOfWork.PizzaRepository.UpdateAsyn(info);
        }
        public async Task DeletePizza(int id)
        {
            await _unitOfWork.PizzaRepository.DeleteAsyn(id);
        }
    }
}
