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
    public class IngredientsService : IIngredientsService
    {
        IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public IngredientsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<DTOIngredients> GetIngredientId(int id)
        {
            return _mapper.Map<Ingredients, DTOIngredients>(await _unitOfWork.IngredientsRepository.GetIngredientId(id)); ;
        }
        //CRUD
        public async Task<IEnumerable<DTOIngredients>> GetAllIngredients()
        {
            var info = await _unitOfWork.IngredientsRepository.GetAllAsyn();

            List<DTOIngredients> transferDTO = new List<DTOIngredients>();

            foreach (var ingredients in info)
                transferDTO.Add(_mapper.Map<Ingredients, DTOIngredients>(ingredients));

            return transferDTO;
        }
        public async Task<DTOIngredients> GetByIdIngredient(int id)
        {
            var info = await _unitOfWork.IngredientsRepository.GetByIdAsyn(id);
            return _mapper.Map<Ingredients, DTOIngredients>(info);
        }
        public async Task InsertIngredient(DTOIngredients ingredients)
        {
            var info = _mapper.Map<DTOIngredients, Ingredients>(ingredients);
            await _unitOfWork.IngredientsRepository.InsertAsyn(info);
        }
        public async Task UpdateIngredient(DTOIngredients ingredients)
        {
            var info = _mapper.Map<DTOIngredients, Ingredients>(ingredients);
            await _unitOfWork.IngredientsRepository.UpdateAsyn(info);
        }
        public async Task DeleteIngredient(int id)
        {
            await _unitOfWork.IngredientsRepository.DeleteAsyn(id);
        } 
    }
}
