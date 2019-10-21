using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IValuesRepository _valuesRepository;
        public ValuesController(IValuesRepository valuesRepository)
        {
            _valuesRepository = valuesRepository;
        }
        [HttpGet]
        public IActionResult GetValues()
        {
            return Ok(_valuesRepository.GetValues());
        }
    }
}
