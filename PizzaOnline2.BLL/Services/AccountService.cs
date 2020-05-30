using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PizzaOnline2.BLL.IServices;
using PizzaOnline.DAL.Interface;
using PizzaOnline2.BLL.DTOEntities;
using PizzaOnline.DAL.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace PizzaOnline2.BLL.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public AccountService(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<IdentityResult> Register(UserRegisterDTO User)
        {
            var customerId = await _unitOfWork.CustomerRepository.InsertAsyn(new Customer {});

            User user = new User { Email = User.Email, UserName = User.UserName, CustomerId = customerId };

            var result = await _unitOfWork.userManager.CreateAsync(user, User.Password);
            return result;
        }
        public async Task<LoginResult> Login(UserLoginDTO User)
        {
            User user = await _unitOfWork.userManager.FindByNameAsync(User.UserName);
            if (user != null)
            {
                var result = await _unitOfWork.signInManager.PasswordSignInAsync(User.UserName, User.Password, User.RememberMe, false);
                if (result.Succeeded)
                    return new LoginResult { token = await BuildToken(user), successful = true };
                else
                    return new LoginResult { successful = false, error = "Invalid password" };
            }
            return new LoginResult { successful = false, error = "User not found" };
        }
        public async Task<string> Logout()
        {
            await _unitOfWork.signInManager.SignOutAsync();
            return "Logout successful";
        }       
        public async Task<string> Delete(int Id)
        {
            User user = await _unitOfWork.userManager.FindByIdAsync(Id.ToString());
            if (user != null)
            {
                var result = await _unitOfWork.userManager.DeleteAsync(user);
                return "User deleted";
            }
            else
            {
                return "User not found";
            }
        }
        public async Task<List<User>> UserList()
        {
            return await _unitOfWork.userManager.Users.ToListAsync();
        }

        private async Task<string> BuildToken(User user)
        {
            var roles = await _unitOfWork.signInManager.UserManager.GetRolesAsync(user);
            var claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Name, user.UserName));
            claims.Add(new Claim("accountId", user.Id.ToString()));
            claims.Add(new Claim("customerId", user.CustomerId.ToString()));
            claims.Add(new Claim("email", user.Email));
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }


            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddDays(double.Parse(_configuration["JwtExpiryInDays"]));

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: _configuration["JwtIssuer"],
                audience: _configuration["JwtAudience"],
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: expiration,
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
