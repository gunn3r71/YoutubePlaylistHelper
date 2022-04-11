namespace YoutubePlaylistHelper.Domain.Entities
{
    public class User : Entity
    {
        protected User()
        {
        }

        public User(string name, string email, string password) : this()
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}