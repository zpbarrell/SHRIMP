using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shrimp.Data.Entities;
using Shrimp.Data;
 using Shrimp.Models.House;
using Microsoft.EntityFrameworkCore;

namespace Shrimp.Services.House
{
    public class HouseService : IHouseService
    {
        private readonly ApplicationDbContext _context;

        public HouseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateHouseAsync(HouseCreate newHouse)
        {
            var houseCreation = new HouseEntity
            {
                Address = newHouse.Address,
                HousePrice = newHouse.HousePrice,
                SquareFootage = newHouse.SquareFootage,
                Bedrooms = newHouse.Bedrooms,
                Bathrooms = newHouse.Bathrooms,
                HousingAmenities = newHouse.HousingAmenities,
                RadtiationLevels = newHouse.RadtiationLevels,
                SafetyRating = newHouse.SafetyRating,
                DistrictId = newHouse.DistrictId
            };
            _context.Houses.Add(houseCreation);

            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges == 1;
        }
        public async Task<IEnumerable<HouseList>> GetAllHousesAsync()
        {
            var houses = await _context.Houses.Select(entity => new HouseList
            {
                HouseID = entity.HouseID,
                Address = entity.Address,
                HousePrice = entity.HousePrice,
                SquareFootage = entity.SquareFootage,
                DistrictId = entity.DistrictId
            })
            .ToListAsync();

            return houses;
        }

        public async Task<HouseDisplay> GetHouseByIDAsync(int id)
        {
            var houses = await _context.Houses.FirstOrDefaultAsync(s => s.HouseID == id);
            return houses is null ? null : new HouseDisplay
            {
                Address = houses.Address,
                HousePrice = houses.HousePrice,
                SquareFootage = houses.SquareFootage,
                Bedrooms = houses.Bedrooms,
                Bathrooms = houses.Bathrooms,
                HousingAmenities = houses.HousingAmenities,
                RadtiationLevels = houses.RadtiationLevels,
                SafetyRating = houses.SafetyRating,
                DistrictId = houses.DistrictId
            };
        }
        public async Task<bool> UpdateHouseAsync(HouseUpdate request)
        {
            var houses = await _context.Houses.FindAsync(request.HouseID);

            houses.Address = request.Address;
            houses.HousePrice = request.HousePrice;
            houses.SquareFootage = request.SquareFootage;
            houses.Bedrooms = request.Bedrooms;
            houses.Bathrooms = request.Bathrooms;
            houses.HousingAmenities = request.HousingAmenities;
            houses.RadtiationLevels = request.RadtiationLevels;
            houses.SafetyRating = request.SafetyRating;
            houses.DistrictId = request.DistrictId;

            var numberOfChanges = await _context.SaveChangesAsync();

            return numberOfChanges == 1;
        }

        public async Task<bool> DeleteHouseAsync(int id)
        {
            var houses = await _context.Houses.FindAsync(id);

            _context.Houses.Remove(houses);
            return await _context.SaveChangesAsync() == 1;
        }
    }
}
