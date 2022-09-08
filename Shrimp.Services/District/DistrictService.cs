using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shrimp.Data;
using Shrimp.Data.Entities;
using Shrimp.Models.District;

namespace Shrimp.Services.District
{
    public class DistrictService : IDistrictService
    {
        private readonly ApplicationDbContext _context;
        public DistrictService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateDistrictAsync(DistrictCreate model)
        {
            var districtEntity = new DistrictEntity
            {
                NameOfDistrict = model.NameOfDistrict,
                CrimeRate = model.CrimeRate,
                Curfew = model.Curfew,
                CodeForDress = model.CodeForDress,
                AvailableResources = model.AvailableResources,
                PermitsNeeded = model.PermitsNeeded,
                WalkabilityRating = model.WalkabilityRating
            };
            _context.Districts.Add(districtEntity);
            var numberOfChanges = await _context.SaveChangesAsync();

            return numberOfChanges == 1;
        }
        public async Task<IEnumerable<DistrictDetail>> GetAllDistrictsAsync()
        {
            var districts = await _context.Districts.Select(entity => new DistrictDetail
            {
                DistrictId = entity.DistrictId,
                NameOfDistrict = entity.NameOfDistrict,
                CrimeRate = entity.CrimeRate,
                Curfew = entity.Curfew,
                CodeForDress = entity.CodeForDress,
                AvailableResources = entity.AvailableResources,
                PermitsNeeded = entity.PermitsNeeded,
                WalkabilityRating = entity.WalkabilityRating
            })
            .ToListAsync();
            return districts;
        }
        public async Task<bool> UpdateDistrictAsync(DistrictDetail request)
        {
            var updateEntity = await _context.Districts.FindAsync(request.DistrictId);
            
            updateEntity.DistrictId = request.DistrictId;
            updateEntity.NameOfDistrict = request.NameOfDistrict;
            updateEntity.CrimeRate = request.CrimeRate;
            updateEntity.Curfew = request.Curfew;
            updateEntity.CodeForDress = request.CodeForDress;
            updateEntity.AvailableResources = request.AvailableResources;
            updateEntity.PermitsNeeded = request.PermitsNeeded;
            updateEntity.WalkabilityRating = request.WalkabilityRating;

            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges == 1;
        }
        public async Task<bool> DeleteDistrictAsync(int districtId)
        {
            var deleteDistrict = await _context.Districts.FindAsync(districtId);

            //Add error handling if invalid ID is entered
            _context.Districts.Remove(deleteDistrict);
            return await _context.SaveChangesAsync() == 1;
        }

    }
}