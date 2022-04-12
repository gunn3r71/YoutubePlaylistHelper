namespace YoutubePlaylistHelper.Domain.ValueObjects
{
    public class Email : IValueObject
    {
        public Email(string address)
        {
            Address = address;
        }

        public string Address { get; private set; }

        public static bool operator ==(Email a, Email b)
        {
            if (a is null && b is null) return true;

            if (a is null || b is null) return false;

            return a.Address == b.Address;
        }

        public static bool operator !=(Email a, Email b) => !(a == b);
    }
}