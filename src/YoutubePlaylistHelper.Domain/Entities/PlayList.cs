using YoutubePlaylistHelper.Domain.Enums;

namespace YoutubePlaylistHelper.Domain.Entities
{
    public class PlayList : Entity
    {
        protected PlayList()
        {
        }

        public PlayList(string name, User user, Status status) : this()
        {
            Name = name;
            User = user;
            Status = status;
        }

        public string Name { get; private set; }
        public User User { get; private set; }
        public Status Status { get; private set; }
    }
}