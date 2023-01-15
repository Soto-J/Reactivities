using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private readonly DataContext _context;

        public BaseApiController(DataContext context)
        {
            _context = context;
        }
    }
}
