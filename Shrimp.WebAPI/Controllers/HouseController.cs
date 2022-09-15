using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shrimp.Services.House;

namespace Shrimp.WebAPI.Controllers
{
    public class HouseController : ControllerForHouse
    {
        private readonly IHouseService _houseService;
        public HouseController(IHouseService houseService)
        {
            _houseService = houseService;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateHouse([FromBody] HouseCreate newHouse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
             var houseCreateResult = await _houseService.CreateHouseAsync(newHouse);
             if (houseCreateResult)
             {
                return Ok("New house was created.");
             }
             return BadRequest("House creation was a failure.");
            
        }

        [HttpGet("List")]
        public async Task<IActionResult> GetAllHouses()
        {
            var houseListDisplay = await _houseService.GetAllHousesAsync();
            return Ok(houseListDisplay);
        }

        [HttpGet("{id:int}")]
        public async  Task<IActionResult> GetHouseById([FromRoute] int id)
        {
            var displayToUser = await _houseService.GetHouseByIdAsync(id);
            return displayToUser is not null ? Ok(displayToUser) : NotFound();
        }


        [HttpPut("Update")]
        public async Task<IActionResult> UpdateHouseById([FromBody] HouseUpdate houseToUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return await _houseService.UpdateHouseAsync(houseToUpdate) ? Ok("This house as successfully been updated.") : BadRequest("Could not update house. Please try again.");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteHouse([FromRoute] int id)
        {
            return await _houseService.DeleteHouseAsync(id) ? Ok("House was succesffully deleted.") : BadRequest("Failed to delete house.");


    }
}
