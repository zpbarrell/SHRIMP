using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shrimp.Data.Entities;
using Shrimp.Data;
using Shrimp.Models.School;
using Microsoft.EntityFrameworkCore;

namespace Shrimp.Services.School
{
    public class SchoolService : ISchoolService
    {
        private readonly ApplicationDbContext _context;
        public SchoolService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<SchoolList>> GetAllSchoolsAsync()
        {
            var schools = await _context.Schools.Select(entity => new SchoolList
            {
                SchoolId = entity.SchoolId,
                Name = entity.Name,
                Costs = entity.Costs
            })
            .ToListAsync();

            return schools;
        }
    }
}