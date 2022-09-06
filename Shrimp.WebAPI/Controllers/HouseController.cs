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
    }
}