using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SIMS.API.Helpers;
using SIMS.API.Models;

namespace SIMS.API.Data
{
    public class SimsRepository : ISimsRepository
    {
        private readonly DataContext context;
        public SimsRepository(DataContext context)
        {
            this.context = context;
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
            var user = await this.context.Users.Include(bm => bm.BachelorsMentor)
                                               .Include(a => a.BachelorsProjectAdvisor)
                                               .Include(a => a.BachelorsThesisAdvisor)
                                               .Include(a => a.MastersProjectAdvisor)
                                               .Include(a => a.MastersThesisAdvisor)
                                               .Include(c => c.MastersCommittee)
                                               .Include(a => a.DoctorateAdvisor)
                                               .Include(a => a.ExternalAdvisor)
                                               .Include(a => a.DoctorateCommittee)
                                               .Include(p => p.Photos)
                                               .FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<PagedList<User>> GetUsers(UserParams userParams)
        {
            var users = this.context.Users.Include(p => p.Photos).OrderByDescending(u => u.LastName).AsQueryable();

            users = users.Where(u => u.Id != userParams.UserId);

            //users = users.Where(u => u.Gender == userParams.Gender);

            if (userParams.MinAge != 18 || userParams.MaxAge != 99) {
                var minDob = DateTime.Today.AddYears(-userParams.MaxAge-1);
                var maxDob = DateTime.Today.AddYears(-userParams.MinAge);

                users = users.Where(u => u.DateOfBirth >= minDob && u.DateOfBirth <= maxDob);
            }

            if (!string.IsNullOrEmpty(userParams.OrderBy)) {
                // switch(userParams.OrderBy) {
                //     case "created":
                //         users = users.OrderByDescending(u => u.Created);
                //         break;
                //     default:
                //         users = users.OrderByDescending(u => u.LastActive);
                //         break;
                // }
            }

            return await PagedList<User>.CreateAsync(users, userParams.PageNumber, userParams.PageSize);
        }

        public async Task<bool> SaveAll()
        {
            return await this.context.SaveChangesAsync() > 0;
        }
    }
}