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
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantServices _restaurantServices;

        public RestaurantController(IRestaurantServices restaurantServices)
        {
            _restaurantServices = restaurantServices;
        }

        [HttpGet("select/{choice}")]

        public IActionResult Response(string choice)
        {
            string result = _restaurantServices.randomSelect(choice);
            return Ok (new {Choice = choice, Result = result});
        }
    }
}