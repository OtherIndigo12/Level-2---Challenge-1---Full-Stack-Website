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
    public class MLController : ControllerBase
    {
        private readonly IMadLibServices _madlibServices;


        public MLController(IMadLibServices madlibServices)
        {
            _madlibServices = madlibServices;
        }


      [HttpGet("madlib/{name}/{location}/{color}/{event1}/{number}/{letter}/{friend}/{eat}/{food}/{dessert}")]  
      public IActionResult madlib(
        string name, 
        string location, 
        string color,
        string event1,
        string number,
        string letter,
        string friend,
        string eat,
        string food,
        string dessert)
        {
           string MadLib = _madlibServices.madlib(name, location, color, event1, number, letter, friend, eat, food, dessert);

           return Ok(new {name, location, color, event1, number, letter, friend, eat, food, dessert, Result = MadLib }); 
        }
    }
}