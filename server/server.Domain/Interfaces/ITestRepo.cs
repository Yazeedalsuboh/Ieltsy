using server.Domain.Entities;
using server.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.Domain.Interfaces
{
    public interface ITestRepo
    {
        Task<List<Test>> GetAllAsync(TypeEnum? typeEnum);
        Task AddAsync(Test test);
        Task<Test?> GetByIdAsync(int id);
        Task<Test> UpdateAsync(Test test);
    }
}
