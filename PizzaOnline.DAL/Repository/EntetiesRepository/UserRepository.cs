using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface.IRepository;
using PizzaOnline.DAL.Repository.GenericRepository;

namespace PizzaOnline.DAL.Repository.EntetiesRepository
{
    public class UserRepository : GenericRepository<AspNetUsers>, IUserRepository
    {
        public UserRepository(AplicationContext aplicationContext)
           : base(aplicationContext)
        {

        }
    }
}
