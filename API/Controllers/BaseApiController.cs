using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private readonly DataContext _context;

        // Create variable mediator
        private IMediator _mediator;

        // -- populate it with IMediator Service
        // IF another controller needs mediator
        // IF it has it in the mediator variable, great!
        // ELSE its going to go and get it
        protected IMediator Mediator => _mediator ??= 
            HttpContext.RequestServices.GetService<IMediator>();
    }
}
