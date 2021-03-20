using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public interface IUniversityRepo
    {
        Task<List<University>> GetAll();
        Task<University> GetById(int id);
        Task<bool> Add(University university);
        Task<bool> Remove(University university);
        Task<bool> Update(int id, University university);
    }
}
