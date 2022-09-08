using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shrimp.Models.School;

namespace Shrimp.Services.School
{
    public interface ISchoolService
    {
        Task<bool> CreateSchoolAsync(SchoolCreate request);
        Task<IEnumerable<SchoolList>> GetAllSchoolsAsync();
        Task<SchoolDisplay> GetSchoolByIdAsync(int id);
        Task<bool> UpdateSchoolAsync(SchoolUpdate request);
        Task<bool> DeleteSchoolAsync(int id);
    }
}