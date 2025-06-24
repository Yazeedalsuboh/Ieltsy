using Microsoft.EntityFrameworkCore;
using server.Domain.Entities;
using server.Domain.Enums;
using server.Domain.Interfaces;
using server.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Infrastructure.Repo
{
    public class TestRepo : ITestRepo
    {
        private readonly AppDbContext _context;

        public TestRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Test>> GetAllAsync(TypeEnum? typeEnum)
        {
            var query = _context.Tests.AsQueryable();
            if (typeEnum.HasValue)
            {
                if (!Enum.IsDefined(typeof(TypeEnum), typeEnum.Value))
                {
                    throw new ArgumentException("Invalid type value");
                }
                query = query.Where(e => e.Type == typeEnum.Value);
            }
            return await query.ToListAsync();
        }

        public async Task AddAsync(Test test)
        {
            _context.Tests.Add(test);
            await _context.SaveChangesAsync();
        }

        public async Task<Test?> GetByIdAsync(int id)
        {
            return await _context.Tests.FindAsync(id);
        }

        public async Task<Test> UpdateAsync(Test test)
        {
            _context.Tests.Update(test);
            await _context.SaveChangesAsync();
            return test;
        }
    }
}
