using Microsoft.AspNetCore.Mvc;
using Tiendeo.Users.Application;

namespace Tiendeo.Users.Api.Controllers
{
    [ApiController]
    [Route("users")]
    public class PostUserController : Controller
    {
        private readonly ILogger<GetAllUsersController> _logger;
        private readonly CreateUserUseCase _createUserUseCase;

        public PostUserController(ILogger<GetAllUsersController> logger, CreateUserUseCase createUserUseCase)
        {
            _logger = logger;
            _createUserUseCase = createUserUseCase;
        }

        [HttpPost]
        public IActionResult Post(CreateUserRequest createUserDto)
        {
            try
            {
                Guid id = _createUserUseCase.Execute(createUserDto);
                return Created(new Uri($"{Request.Path}/{id}", UriKind.Relative), id);
            }
            catch (Exception e)
            {
                _logger.LogError(
                   $"[PostUserController] Error creating user",
                   $"{e.GetType().Name} - {e.StackTrace}"
               );
               return NotFound(e.GetType().Name);
            }
        }
    }
}
