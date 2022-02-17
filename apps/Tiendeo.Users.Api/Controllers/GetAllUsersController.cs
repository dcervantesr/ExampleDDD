using Microsoft.AspNetCore.Mvc;
using Tiendeo.Users.Application;

namespace Tiendeo.Users.Api.Controllers
{
    [ApiController]
    [Route("users")]
    public class GetAllUsersController : Controller
    {
        private readonly ILogger<GetAllUsersController> _logger;
        private readonly GetAllUsersUseCase _getAllUsersUseCase;

        public GetAllUsersController(ILogger<GetAllUsersController> logger, GetAllUsersUseCase getAllUsersUseCase)
        {
            _logger = logger;
            _getAllUsersUseCase = getAllUsersUseCase;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_getAllUsersUseCase.Execute());
            }
            catch (Exception e)
            {
                _logger.LogError(
                   $"[GetAllUsersController] Error getting users.",
                   $"{e.GetType().Name} - {e.StackTrace}"
               );
               return NotFound(e.GetType().Name);
            }
        }
    }
}
