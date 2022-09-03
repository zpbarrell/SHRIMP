using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shrimp.Services.School;

namespace Shrimp.WebAPI.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ISchoolService _service;
        public SchoolController(ISchoolService service)
        {
            _service = service;
        }
    }
}