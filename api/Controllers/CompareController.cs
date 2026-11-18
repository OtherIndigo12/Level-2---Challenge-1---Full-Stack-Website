using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Level_2___Challenge_1___Full_Stack_Website.Services;
using Microsoft.AspNetCore.Mvc;

namespace Level_2___Challenge_1___Full_Stack_Website.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompareController : ControllerBase
    {
        private readonly ICompareServices _compareServices;


        public CompareController(ICompareServices compareServices)
        {
            _compareServices = compareServices;
        }

        [HttpGet("compare/{numOne}/{numTwo}")]

        public IActionResult compare(int numOne, int numTwo)
        {
            string result = _compareServices.compare(numOne, numTwo);

            return Ok(new {numOne, numTwo, Result = result});
        }
    }
}