using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class UniversityRepo : IUniversityRepo
    {
        private readonly AppDbContext _context;

        public UniversityRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(University university)
        {
            try
            {
                _context.Universities.Add(university);
                await _context.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public Task<List<University>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<University> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Remove(University university)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(int id, University university)
        {
            throw new System.NotImplementedException();
        }
    }
}
