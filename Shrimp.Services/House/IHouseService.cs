using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 using Shrimp.Models.House;

namespace Shrimp.Services.House
{
    public interface IHouseService
    {
        Task<bool> CreateHouseAsync(HouseCreate newHouse);
        Task<IEnumerable<HouseList>> GetAllHousesAsync();
        Task<HouseDisplay> GetHouseByIDAsync(int id);
        Task<IEnumerable<HouseList>> GetHousesByDistrictIdAsync(int districtId);
        Task<bool> UpdateHouseAsync(HouseUpdate request);
        Task<bool> DeleteHouseAsync(int id);
    }
}
