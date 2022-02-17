namespace Tiendeo.Users.Domain
{
    public readonly struct UserId
    {
        public Guid Value { get; }

        public UserId(Guid id)
        {
            Value = id;
        }
    }
}
