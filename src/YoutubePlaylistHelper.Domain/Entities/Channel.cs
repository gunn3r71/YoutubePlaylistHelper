namespace YoutubePlaylistHelper.Domain.Entities
{
    public class Channel : Entity
    {
        protected Channel()
        {
        }

        public Channel(string name, string logoUrl, User user) : this()
        {
            Name = name;
            LogoUrl = logoUrl;
            User = user;
        }

        public string Name { get; private set; }
        public string LogoUrl { get; private set; }
        public User User { get; private set; }
    }
}