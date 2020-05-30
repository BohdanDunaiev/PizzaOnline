using Microsoft.AspNetCore.Identity;
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
        public Task<IdentityResult> Register(UserRegisterDTO myUser);
        public Task<LoginResult> Login(UserLoginDTO myUser);
        public Task<string> Logout();
        public Task<string> Delete(int Id);
        public Task<List<User>> UserList();
    }
}
