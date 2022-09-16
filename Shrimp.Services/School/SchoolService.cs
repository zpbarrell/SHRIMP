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

        public async Task<bool> CreateSchoolAsync(SchoolCreate newSchool)
        {
            var schoolCreation = new SchoolEntity
            {
                Name = newSchool.Name,
                TypeOfClasses = newSchool.TypeOfClasses,
                NumberOfStudents = newSchool.NumberOfStudents,
                TeacherStudentRatio = newSchool.TeacherStudentRatio,
                Costs = newSchool.Costs,
                TypeOfASP = newSchool.TypeOfASP,
                DistrictId = newSchool.DistrictId,
            };
            _context.Schools.Add(schoolCreation);

            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges == 1;
        }
        public async Task<IEnumerable<SchoolList>> GetAllSchoolsAsync()
        {
            var schools = await _context.Schools.Select(entity => new SchoolList
            {
                SchoolId = entity.SchoolId,
                Name = entity.Name,
                Costs = entity.Costs,
                DistrictId = entity.DistrictId
            })
            .ToListAsync();

            return schools;
        }

        public async Task<SchoolDisplay> GetSchoolByIdAsync(int id)
        {
            var schools = await _context.Schools.FirstOrDefaultAsync(s => s.SchoolId == id);
            return schools is null ? null : new SchoolDisplay
            {
                SchoolId = schools.SchoolId,
                Name = schools.Name,
                TypeOfClasses = schools.TypeOfClasses,
                NumberOfStudents = schools.NumberOfStudents,
                TeacherStudentRatio = schools.TeacherStudentRatio,
                Costs = schools.Costs,
                TypeOfASP = schools.TypeOfASP
            };
        }
        public async Task<bool> UpdateSchoolAsync(SchoolUpdate request)
        {
            var schools = await _context.Schools.FindAsync(request.SchoolId);

            schools.Name = request.Name;
            schools.TypeOfClasses = request.TypeOfClasses;
            schools.NumberOfStudents = request.NumberOfStudents;
            schools.TeacherStudentRatio = request.TeacherStudentRatio;
            schools.Costs = request.Costs;
            schools.TypeOfASP = request.TypeOfASP;

            var numberOfChanges = await _context.SaveChangesAsync();

            return numberOfChanges == 1;
        }

        public async Task<bool> DeleteSchoolAsync(int id)
        {
            var schools = await _context.Schools.FindAsync(id);

            _context.Schools.Remove(schools);
            return await _context.SaveChangesAsync() == 1;
        }
    }
}