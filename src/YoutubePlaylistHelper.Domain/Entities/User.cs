using YoutubePlaylistHelper.Domain.ValueObjects;

namespace YoutubePlaylistHelper.Domain.Entities
{
    public class User : Entity
    {
        protected User()
        {
        }

        public User(Name name, Email email, string password) : this()
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public string Password { get; private set; }
    }
}