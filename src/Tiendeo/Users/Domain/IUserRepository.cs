namespace Tiendeo.Users.Domain
{
    public interface IUserRepository
    {
        void Add(User user);
        User? Find(UserId id);
        List<User> GetAll();
        bool Exist(UserId id);
    }
}
