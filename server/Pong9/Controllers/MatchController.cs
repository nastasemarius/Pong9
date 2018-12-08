using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pong9.Data.Entities;
using Pong9.IServices;

namespace Pong9.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MatchController : Controller
    {
        private readonly IMatchService _matchService;

        public MatchController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        [HttpGet]
        public IActionResult GetAllMatches()
        {
            var matches = _matchService.GetAllMatches().Value;

            if (matches == null)
            {
                return BadRequest(new {message = "No matches were found."});
            }

            return Ok(matches);
        }

        
    }
}