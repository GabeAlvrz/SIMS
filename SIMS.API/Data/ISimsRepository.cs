using System.Collections.Generic;
using System.Threading.Tasks;
using SIMS.API.Helpers;
using SIMS.API.Models;

namespace SIMS.API.Data
{
    public interface ISimsRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T : class;
         Task<bool> SaveAll();
         Task<PagedList<User>> GetUsers(UserParams userParams);
         Task<User> GetUser(int id);
    }
}