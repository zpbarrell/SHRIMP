using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shrimp.Models.District;
using Shrimp.Services.District;

namespace Shrimp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        private readonly IDistrictService _districtService;
        public DistrictController(IDistrictService districtService)
        {
            _districtService = districtService;
        }
        [HttpPost("Create")]
        public async Task<IActionResult> CreateDistrict([FromBody] DistrictCreate model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
                var createResult = await _districtService.CreateDistrictAsync(model);
                if(createResult)
                {
                    return Ok("District Created Successfully");
                }
            return BadRequest("District could not be created.");
        }
        [HttpGet("Get")]
        public async Task<IActionResult> GetAllDistricts()
        {
            var districts = await _districtService.GetAllDistrictsAsync();
            return Ok(districts);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> UpdateDistrictAsync([FromBody] DistrictDetail request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            return await _districtService.UpdateDistrictAsync(request) ? Ok("District was successfully updated") : BadRequest("District could not be updated");
        }
        [HttpPut("CrimeRate")]
        public async Task<IActionResult> UpdateCrimeRateByDistrictIdAsync([FromBody] DistrictUpdate newCrimeRate)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return await _districtService.UpdateCrimeRateByDistrictIdAsync(newCrimeRate) ? Ok ("CrimeRate was successfully updated") : BadRequest("CrimeRate could not be updated");
        }
        [HttpDelete("{districtId:int}")]
        public async Task<IActionResult> DeleteDistrict([FromRoute] int districtId)
        {
            return await _districtService.DeleteDistrictAsync(districtId) ? Ok($"District {districtId} was deleted.") : BadRequest($"District {districtId} could not be deleted.");
        }
    }
}
