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
    public class HelloController : ControllerBase
    {
        private readonly IHelloServices _helloServices;


        public HelloController(IHelloServices helloServices)
        {
            _helloServices = helloServices;
        }

        [HttpGet("sayhello/{name}")]

        public IActionResult SayHello(string name)
        {
            string yourName = _helloServices.SayHello(name); 
            return Ok (new {name, Result = name});
        }
    }
}