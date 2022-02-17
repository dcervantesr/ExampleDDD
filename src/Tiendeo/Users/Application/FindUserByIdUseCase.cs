using Tiendeo.Users.Domain;

namespace Tiendeo.Users.Application
{
    public class FindUserByIdUseCase
    {
        private readonly FindUser _findUser;

        public FindUserByIdUseCase(FindUser findUser)
        { 
            _findUser = findUser;
        }

        public UserDto Execute(Guid id)
        {
            User user = _findUser.Execute(new UserId(id));
            return new UserDto() {
                Id = user.Id.Value,
                Name = user.Name.Value,
                Mobile = user.Mobile.Value,
            };
        }
    }
}
