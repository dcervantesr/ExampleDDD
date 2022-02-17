namespace Tiendeo.Users.Domain
{
    public class CreateUser
    {
        private readonly IUserRepository _userRepository;

        public CreateUser(IUserRepository userRepository)
        { 
            _userRepository = userRepository;
        }

        public void Execute(User user)
        {
            if (_userRepository.Exist(user.Id))
            {
                throw new UserAlreadyExistsException();
            }
            _userRepository.Add(user);
        }
    }
}
