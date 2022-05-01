using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Services.Cars.Commands;
using Services.Cars.Queries;

namespace MediatR_Playground.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetAllCarsQuery()); 
            return Ok(result);
        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCarCommand command)
        {
            var result = await _mediator.Send(command); 
            return Ok(result);
        }
    }
}