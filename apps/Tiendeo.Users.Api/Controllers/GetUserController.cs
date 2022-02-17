using Microsoft.AspNetCore.Mvc;
using Tiendeo.Users.Application;

namespace Tiendeo.Users.Api.Controllers
{
    [ApiController]
    [Route("users")]
    public class GetUserController : Controller
    {
        private readonly ILogger<GetAllUsersController> _logger;
        private readonly FindUserByIdUseCase _findUserByIdUseCase;

        public GetUserController(ILogger<GetAllUsersController> logger, FindUserByIdUseCase findUserByIdUseCase)
        {
            _logger = logger;
            _findUserByIdUseCase = findUserByIdUseCase;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                return Ok(_findUserByIdUseCase.Execute(id));
            }
            catch (Exception e)
            {
                _logger.LogError(
                   $"[GetUserController] Error finding user",
                   $"Id: {id}, {e.GetType().Name} - {e.StackTrace}"
               );
               return NotFound(e.GetType().Name);
            }
        }
    }
}
