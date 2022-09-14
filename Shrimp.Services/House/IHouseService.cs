using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 using Shrimp.Models.House;

namespace Shrimp.Services.House
{
    public interface IHouseService
    {
        Task<IEnumerable<HouseList>> GetAllHousesAsync();
        Task<bool> CreateHouseAsync(HouseCreate request);
        Task<bool> UpdateHouseAsync(HouseUpdate request);
        Task<bool> DeleteHouseAsync(int id);
        Task<HouseDisplay> GetHouseByIDAsync(int id);
    }
}
