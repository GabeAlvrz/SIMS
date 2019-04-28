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
            var user = await this.context.Users.Include(p => p.Photos).Include(ur => ur.UserRoles).ThenInclude(r => r.Role)
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
                var input = userParams.SearchByInput.ToUpper();

                switch (userParams.SearchBy)
                {
                    case "dawgTag":
                        usersToReturn = usersToReturn.Where(u => u.NormalizedUserName.Contains(input));
                        break;
                    case "firstName":
                        usersToReturn = usersToReturn.Where(u => u.FirstName.ToUpper().Contains(input));
                        break;
                    case "lastName":
                        usersToReturn = usersToReturn.Where(u => u.LastName.ToUpper().Contains(input));
                        break;
                    case "currentAcademicLevel":
                        usersToReturn = usersToReturn.Where(u => u.CurrentAcademicLevel.ToUpper().Contains(input));
                        break;
                    case "degreeProgram":
                        usersToReturn = usersToReturn.Where(u => u.DegreeProgram.ToUpper().Contains(input));
                        break;
                    case "currentProgram":
                        usersToReturn = usersToReturn.Where(u => u.CurrentProgram.ToUpper().Contains(input));
                        break;
                    case "interests":
                        usersToReturn = usersToReturn.Where(u => u.ResearchInterest.ToUpper().Contains(input));
                        break;
                    case "bachMentor":
                        usersToReturn = usersToReturn.Where(u => u.BachelorsMentor.ToUpper().Contains(input));
                        break;
                    case "bachProjectAdvisor":
                        usersToReturn = usersToReturn.Where(u => u.BachelorsProjectAdvisor.ToUpper().Contains(input));
                        break;
                    case "bachThesisAdvisor":
                        usersToReturn = usersToReturn.Where(u => u.BachelorsThesisAdvisor.ToUpper().Contains(input));
                        break;
                    case "bachProjectTitle":
                        usersToReturn = usersToReturn.Where(u => u.BachelorsProjectTitle.ToUpper().Contains(input));
                        break;
                    case "bachThesisTitle":
                        usersToReturn = usersToReturn.Where(u => u.BachelorsThesisTitle.ToUpper().Contains(input));
                        break;
                    case "mastersProjectAdvisor":
                        usersToReturn = usersToReturn.Where(u => u.MastersProjectAdvisor.ToUpper().Contains(input));
                        break;
                    case "mastersThesisAdvisor":
                        usersToReturn = usersToReturn.Where(u => u.MastersThesisAdvisor.ToUpper().Contains(input));
                        break;
                    case "mastersProjectTitle":
                        usersToReturn = usersToReturn.Where(u => u.MastersProjectTitle.ToUpper().Contains(input));
                        break;
                    case "mastersThesisTitle":
                        usersToReturn = usersToReturn.Where(u => u.MastersThesisTitle.ToUpper().Contains(input));
                        break;
                    case "doctorateAdvisor":
                        usersToReturn = usersToReturn.Where(u => u.DoctorateAdvisor.ToUpper().Contains(input));
                        break;
                    case "designation":
                        usersToReturn = usersToReturn.Where(u => u.Designation.ToUpper().Contains(input));
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