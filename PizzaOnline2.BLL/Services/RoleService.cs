using AutoMapper;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface;
using PizzaOnline2.BLL.DTOEntities;
using PizzaOnline2.BLL.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOnline2.BLL.Services
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public RoleService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task CreateRole(RoleDTO roleDTO)
        {
            var role = _mapper.Map<RoleDTO, Role>(roleDTO);
            await _uow.roleManager.CreateAsync(role);
        }
        public async Task AppointRole(string id, string role)
        {
            User user = await _uow.userManager.FindByIdAsync(id);
            await _uow.userManager.AddToRoleAsync(user, role);
        }
        public async Task<IList<string>> GetAllRolesUser(string id)
        {
            User user = await _uow.userManager.FindByIdAsync(id);
            IList<string> userRoles = null;
            if (user != null)
                userRoles = await _uow.userManager.GetRolesAsync(user);
            return userRoles;
        }
    }
}
