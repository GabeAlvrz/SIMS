using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SIMS.API.Models;
namespace SIMS.API.Data
{
    public class ExitSurveyRepository : IExitSurveyRepository
    {
        private readonly DataContext _context;
        public ExitSurveyRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<ExitSurvey> GetExitSurvey(string ssId) 
        {
            var eSurvey = await _context.ExitSurveys.FirstOrDefaultAsync(n => n.ssId == ssId);

            return eSurvey;
        }

        public async Task<IEnumerable<ExitSurvey>> GetExitSurveys()
        {
          return await _context.ExitSurveys.ToListAsync();
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
