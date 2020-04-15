using System;
using System.Collections.Generic;
using System.Text;
using PizzaOnline.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOnline2.BLL.IServices
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUser();
        Task<User> InsertUser(User obj);
        void UpdateUser(User obj);
    }
}
