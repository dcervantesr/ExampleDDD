using Tiendeo.Users.Domain;

namespace Tiendeo.Users.Application
{
    public class GetAllUsersUseCase
    {
        private readonly GetAllUsers _getAllUsers;

        public GetAllUsersUseCase(GetAllUsers getAllUsers)
        {
            _getAllUsers = getAllUsers;
        }

        public List<UserDto> Execute()
        {
            List<User> users = _getAllUsers.Execute();
            return users.Select(user => new UserDto() {
                Id = user.Id.Value,
                Name = user.Name.Value,
                Mobile = user.Mobile.Value
            }).ToList();
        }
    }
}
