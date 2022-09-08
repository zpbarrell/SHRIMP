using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shrimp.Models.District;

namespace Shrimp.Services.District
{
    public interface IDistrictService
    {
        Task<bool> CreateDistrictAsync(DistrictCreate model);
        Task<IEnumerable<DistrictDetail>> GetAllDistrictsAsync();
        Task<bool> UpdateDistrictAsync(DistrictDetail request);
        Task<bool> DeleteDistrictAsync(int districtId);
    }
}