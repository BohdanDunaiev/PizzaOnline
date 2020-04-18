using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface;
using PizzaOnline2.BLL.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PizzaOnline2.BLL.DTOEntities;

namespace PizzaOnline2.BLL.Services
{
    public class UserService : IUserService
    {
        IUnitOfWork _unitOfWork; 
        private readonly IMapper _mapper;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<DTOUser>> GetAllUser()
        {
            var info = await _unitOfWork.UserRepository.GetAllAsyn();

            List<DTOUser> transferDTO = new List<DTOUser>();

            foreach (var user in info)
                transferDTO.Add(_mapper.Map<User, DTOUser>(user));

            return transferDTO;
        }
        public async Task InsertUser(DTOUser user)
        {
            var info = _mapper.Map<DTOUser, User>(user);
            await _unitOfWork.UserRepository.InsertAsyn(info);
        }
        public async Task UpdateUser(DTOUser user)
        {
            var data = _mapper.Map<DTOUser, User>(user);
            await _unitOfWork.UserRepository.UpdateAsyn(data);
        }
    }
}
