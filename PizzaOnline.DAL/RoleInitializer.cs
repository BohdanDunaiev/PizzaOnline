using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using PizzaOnline.DAL.Entities;

namespace PizzaOnline.DAL
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            string adminName = "admin";
            string adminEmail = "admin@gmail.com";
            string password = "Admin_2001";

            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new Role { Name = "admin" });
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new Role { Name = "user" });
            }
            if (await userManager.FindByNameAsync(adminName) == null)
            {
                User admin = new User { Email = adminEmail, UserName = adminName, CustomerId = 1 };
                IdentityResult result = await userManager.CreateAsync(admin, password);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                }
            }
        }
    }
}
