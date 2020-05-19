using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline2.BLL.IServices;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface;
using AutoMapper;
using PizzaOnline.BLL.DTOEntities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Models;
using System.Linq;

namespace PizzaOnline2.BLL.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public PizzaService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }    
        public async Task<Pizza> GetPizzaId(int id)
        {       
            return await _unitOfWork.PizzaRepository.GetPizzaId(id); 
        }
        public IEnumerable<DTOPizza> GetPizza(PizzaQueryParameters parameters)
        {
            //return _unitOfWork.PizzaRepository.GetPizza(parameters);
            var x =  _unitOfWork.PizzaRepository.GetPizza(parameters).ToList();
            var result = _mapper.Map<List<Pizza>, List<DTOPizza>>(x);
            return result;
        }
        //public async Task<IEnumerable<DTOPizza>> GetPizzaPriceRange(int maxPrice, int minPrice)
        //{
        //    return _mapper.Map<IEnumerable<Pizza>, IEnumerable<DTOPizza>>(await _unitOfWork.PizzaRepository.GetPizzaPriceRange(maxPrice, minPrice)); ;
        //}
        //public async Task<IEnumerable<DTOPizza>> GetPizzaName(string namepizza)
        //{
        //    return _mapper.Map <IEnumerable <Pizza> ,  IEnumerable < DTOPizza >>(await _unitOfWork.PizzaRepository.GetPizzaName(namepizza)); ;
        //}
        //public async Task<IEnumerable<DTOPizza>> GetPopular()
        //{
        //    var res = _mapper.Map<IEnumerable<Pizza>, IEnumerable<DTOPizza>>(await _unitOfWork.PizzaRepository.GetPopular());
        //    return res;
        //}
        //public async Task<IEnumerable<DTOPizza>> GetPopularIngredients()
        //{
        //    var res = _mapper.Map<IEnumerable<Pizza>, IEnumerable<DTOPizza>>(await _unitOfWork.PizzaRepository.GetPopularIngredients());
        //    return res;
        //}
        //CRUT operation
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
