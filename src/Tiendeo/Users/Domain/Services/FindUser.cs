namespace Tiendeo.Users.Domain
{
    public class FindUser
    {
        private readonly IUserRepository _userRepository;

        public FindUser(IUserRepository userRepository)
        { 
            _userRepository = userRepository;
        }

        public User Execute(UserId id)
        {
            User? user = _userRepository.Find(id);
            if (user == null)
            {
                throw new UserDoesNotExistException();
            }
            return user;
        }
    }
}
