using System.Text.RegularExpressions;

namespace Tiendeo.Users.Domain
{
    public readonly struct UserMobile
    {
        public string Value { get; }

        public UserMobile(string mobile)
        {
            if (!Regex.IsMatch(mobile, @"(6|9)\d{8}"))
            {
                throw new UserMobileInvalidException();
            }
            Value = mobile;
        }
    }
}
