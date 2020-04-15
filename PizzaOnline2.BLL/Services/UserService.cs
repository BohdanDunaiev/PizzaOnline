using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface;
using PizzaOnline2.BLL.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOnline2.BLL.Services
{
    public class UserService : IUserService
    {
        IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<User>> GetAllUser()
        {
            return await _unitOfWork.UserRepository.GetAllAsyn();
        }
        public async Task<User> InsertUser(User user)
        {
            return await _unitOfWork.UserRepository.InsertAsyn(user);
        }
        public async void UpdateUser(User user)
        {
            _unitOfWork.UserRepository.UpdateAsyn(user);
        }
    }
}
