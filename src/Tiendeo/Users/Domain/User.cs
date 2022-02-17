namespace Tiendeo.Users.Domain
{
    public class User
    {
        public static User Create(UserId id, UserName name, UserMobile mobile)
        {
            return new User(id, name, mobile);
        }

        public UserId Id => _id;
        public UserName Name => _name;
        public UserMobile Mobile => _mobile;

        private UserId _id;
        private UserName _name;
        private UserMobile _mobile;
        
        private User(UserId id, UserName name, UserMobile mobile)
        {
            _id = id;
            _name = name;
            _mobile = mobile;
        }
    }

}
