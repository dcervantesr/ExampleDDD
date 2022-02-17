namespace Tiendeo.Users.Domain
{
    public class GetAllUsers
    {
        private readonly IUserRepository _userRepository;

        public GetAllUsers(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> Execute()
        {
            return _userRepository.GetAll();
        }
    }
}
