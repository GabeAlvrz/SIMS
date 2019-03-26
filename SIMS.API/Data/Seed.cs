using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using SIMS.API.Models;

namespace SIMS.API.Data
{
    public class Seed
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<Role> roleManager;
        public Seed(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public void SeedUsers()
        {
            if (!this.userManager.Users.Any())
            {
                var userData = System.IO.File.ReadAllText("Data/generated.json");
                var users = JsonConvert.DeserializeObject<List<User>>(userData);

                var roles = new List<Role>
                {
                    new Role{Name = "Admin"},
                    new Role{Name = "Staff"},
                    new Role{Name = "Faculty"},
                    new Role{Name = "Advisor"},
                    new Role{Name = "Student"}
                };

                foreach (var role in roles)
                {
                    this.roleManager.CreateAsync(role).Wait();
                }

                foreach (var user in users)
                {
                    this.userManager.CreateAsync(user, "password").Wait();
                    this.userManager.AddToRoleAsync(user, "Student").Wait();
                }

                var adminUser = new User
                {
                    UserName = "Admin"
                };

                IdentityResult result = this.userManager.CreateAsync(adminUser, "password").Result;

                if (result.Succeeded)
                {
                    var admin = this.userManager.FindByNameAsync("admin").Result;
                    this.userManager.AddToRolesAsync(admin, new[] {"Admin"}).Wait();
                }
            }
        }
    }
}