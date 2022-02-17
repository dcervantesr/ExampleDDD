namespace Tiendeo.Users.Domain
{
    public readonly struct UserName
    {
        public string Value { get; }

        public UserName(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new UserNameFieldRequiredException();
            }
            if (name.Length > 30)
            {
                throw new UserNameLengthExceededException();
            }
            Value = name;
        }
    }
}
