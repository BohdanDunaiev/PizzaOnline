using PizzaOnline.DAL.Entities;
using PizzaOnline2.BLL.DTOEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOnline2.BLL.IServices
{
    public interface IAccountService
    {
        public Task<string> Register(UserRegisterDTO User);
        public Task<string> Create(CrUserDTO User);
        public Task<object> Login(UserLoginDTO User);
        public Task<string> Delete(int Id);
        public Task<List<User>> UserList();
        public Task<string> Logout();
    }
}
