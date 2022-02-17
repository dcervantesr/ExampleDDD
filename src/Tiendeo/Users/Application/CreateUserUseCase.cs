using Tiendeo.Users.Domain;

namespace Tiendeo.Users.Application
{
    public class CreateUserUseCase
    {
        private readonly CreateUser _createUser;

        public CreateUserUseCase(CreateUser createUser)
        { 
            _createUser = createUser;
        }

        public Guid Execute(CreateUserRequest userDto)
        {
            User user = User.Create(new UserId(Guid.NewGuid()), new UserName(userDto.Name), new UserMobile(userDto.Mobile));
            _createUser.Execute(user);
            return user.Id.Value;
        }
    }
}
