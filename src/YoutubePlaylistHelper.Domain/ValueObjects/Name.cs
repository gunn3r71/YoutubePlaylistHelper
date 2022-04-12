using System.Collections.Immutable;

namespace YoutubePlaylistHelper.Domain.ValueObjects
{
    public class Name : IValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public static bool operator ==(Name a, Name b)
        {
            if (a is null && b is null) return true;

            if (a is null || b is null) return false;

            return a.FirstName == b.FirstName && a.LastName == b.LastName;
        }

        public static bool operator !=(Name a, Name b) => !(a == b);
    }
}