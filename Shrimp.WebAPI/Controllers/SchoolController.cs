using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shrimp.Models.School;
using Shrimp.Services.School;

namespace Shrimp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : Controller
    {
        private readonly ISchoolService _schoolService;
        public SchoolController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateSchool([FromBody] SchoolCreate newSchool)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
             var schoolCreateResult = await _schoolService.CreateSchoolAsync(newSchool);
             if (schoolCreateResult)
             {
                return Ok("School created successfully");
             }
             return BadRequest("School could not be created successfully.");
            
        }

        [HttpGet("List")]
        public async Task<IActionResult> GetAllSchools()
        {
            var schoolListDisplay = await _schoolService.GetAllSchoolsAsync();
            return Ok(schoolListDisplay);
        }

        [HttpGet("{id:int}")]
        public async  Task<IActionResult> GetSchoolById([FromRoute] int id)
        {
            var displayToUser = await _schoolService.GetSchoolByIdAsync(id);
            return displayToUser is not null ? Ok(displayToUser) : NotFound();
        }
        [HttpGet("District/{districtId:int}")]
        public async Task<IActionResult> GetSchoolsByDistrictId([FromRoute] int districtId)
        {
            var districtSchool = await _schoolService.GetSchoolsByDistrictIdAsync(districtId);
            return districtSchool is not null ? Ok(districtSchool) : NotFound();
        }


        [HttpPut("Update")]
        public async Task<IActionResult> UpdateSchoolById([FromBody] SchoolUpdate schoolToUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return await _schoolService.UpdateSchoolAsync(schoolToUpdate) ? Ok("School has been updated!") : BadRequest("School could not be updated at this time.");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteSchool([FromRoute] int id)
        {
            return await _schoolService.DeleteSchoolAsync(id) ? Ok("This school has been deleted.") : BadRequest("School failed to be deleted.");
        }
    }
}