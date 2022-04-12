namespace YoutubePlaylistHelper.Domain.Entities
{
    public class Favorite : Entity
    {
        protected Favorite()
        {
        }

        public Favorite(Video video, User user) : this()
        {
            Video = video;
            User = user;
        }

        public Video Video { get; private set; }
        public User User { get; private set; }
    }
}