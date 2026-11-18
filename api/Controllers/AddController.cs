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
    public class AddController : ControllerBase
    {
        private readonly IAddServices _addServices;


        public AddController(IAddServices addServices)
        {
            _addServices = addServices;
        }


       [HttpGet("addition/{numOne}/{numTwo}")]
        public IActionResult Addition(int numOne, int numTwo)
        {
            int sum = _addServices.Addition(numOne, numTwo);
            return Ok(new {numOne, numTwo, Result = sum});
        } 
    }
}