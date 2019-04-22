using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SIMS.API.Helpers;
using SIMS.API.Models;

namespace SIMS.API.Data
{
    public class SimsRepository : ISimsRepository
    {
        private readonly DataContext context;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<Role> roleManager;
        public SimsRepository(DataContext context, UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public void Add<T>(T entity) where T : class
        {
            this.context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            this.context.Remove(entity);
        }

        public async Task<User> GetUser(int id)
        {
            var user = await this.context.Users.Include(p => p.Photos)
                                               .FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<PagedList<User>> GetUsers(UserParams userParams)
        {
            var users = this.context.Users.Include(p => p.Photos).AsQueryable();
            var roles = this.context.UserRoles.Include(r => r.Role).Where(r => r.Role.Name == userParams.Role);

            var usersToReturn = users.Where(a => roles.Any(c => c.UserId == a.Id) && a.Id != userParams.UserId);

            if (!string.IsNullOrEmpty(userParams.SearchBy) && !string.IsNullOrEmpty(userParams.SearchByInput))
            {
                switch (userParams.SearchBy)
                {
                    case "firstName":
                        usersToReturn = usersToReturn.Where(u => u.FirstName.ToUpper().Contains(userParams.SearchByInput.ToUpper()));
                        break;
                    case "lastName":
                        usersToReturn = usersToReturn.Where(u => u.LastName.ToUpper().Contains(userParams.SearchByInput.ToUpper()));
                        break;
                }
            }


            if (!string.IsNullOrEmpty(userParams.OrderBy))
            {
                switch (userParams.OrderBy)
                {
                    case "Last Name: A-Z":
                        usersToReturn = usersToReturn.OrderBy(u => u.LastName);
                        break;
                    case "Last Name: Z-A":
                        usersToReturn = usersToReturn.OrderByDescending(u => u.LastName);
                        break;
                    case "First Name: A-Z":
                        usersToReturn = usersToReturn.OrderBy(u => u.FirstName);
                        break;
                    case "First Name: Z-A":
                        usersToReturn = usersToReturn.OrderByDescending(u => u.FirstName);
                        break;
                }
            }

            return await PagedList<User>.CreateAsync(usersToReturn, userParams.PageNumber, userParams.PageSize);
        }

        public async Task<bool> SaveAll()
        {
            return await this.context.SaveChangesAsync() > 0;
        }
    }
}