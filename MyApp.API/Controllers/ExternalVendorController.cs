using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.Commands;
using MyApp.Application.Queries;
using MyApp.Core.Entities;

namespace MyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalVendorController : ControllerBase
    {
        private readonly ISender sender;
        public ExternalVendorController(ISender _sender)
        {
            sender = _sender;

        }
        [HttpGet("")]
        public async Task<IActionResult> GetCoindeskData()
        {
            var result = await sender.Send(new GetCoindeskDataQuery());
            return Ok(result);
        }

        [HttpGet("Joke")]
        public async Task<IActionResult> GetJoke()
        {
            var result = await sender.Send(new GetJokeQuery());
            return Ok(result);
        }
    }
}
