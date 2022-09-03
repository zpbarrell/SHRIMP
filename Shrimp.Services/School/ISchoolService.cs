using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shrimp.Models.School;

namespace Shrimp.Services.School
{
    public interface ISchoolService
    {
        Task<IEnumerable<SchoolList>> GetAllSchoolsAsync();
    }
}