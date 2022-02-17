using Tiendeo.Users.Domain;

namespace Tiendeo.Users.Infraestructure
{
    public class InMemoryUserRepository : IUserRepository
    {
        private List<User> _context = new();

        public void Add(User user)
        {
            _context.Add(user);
        }

        public User? Find(UserId id)
        {
            return _context.Find(x => x.Id.Value == id.Value);
        }

        public List<User> GetAll()
        {
            return _context;
        }

        public bool Exist(UserId id)
        {
            return _context.Exists(x => x.Id.Value == id.Value);
        }
    }
}
