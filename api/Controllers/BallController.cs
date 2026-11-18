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
    public class BallController : ControllerBase
    {
        private readonly IBallServices _ballServices;

        public BallController(IBallServices ballServices)
        {
            _ballServices = ballServices;
        }

        [HttpGet("ball/{question}")]

        public IActionResult Ask(string question)
        {
            string answer = _ballServices.userQuestion(question);
            return Ok(new {Question = question, Result = answer});
        }
    }
}