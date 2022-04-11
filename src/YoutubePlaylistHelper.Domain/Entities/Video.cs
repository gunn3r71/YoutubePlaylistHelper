using System.Collections.Generic;

namespace YoutubePlaylistHelper.Domain.Entities
{
    public class Video : Entity
    {
        protected Video()
        {
            Tags = new List<string>();
        }

        public Video(string title, string description, Channel channel, PlayList playList, int playListOrder, string youtubeVideoId, User indicatorUser, string status) : this()
        {
            Title = title;
            Description = description;
            Channel = channel;
            PlayList = playList;
            PlayListOrder = playListOrder;
            YoutubeVideoId = youtubeVideoId;
            IndicatorUser = indicatorUser;
            Status = status;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public List<string> Tags { get; private set; }
        public Channel Channel { get; private set; }
        public PlayList PlayList { get; private set; }
        public int PlayListOrder { get; private set; }
        public string YoutubeVideoId { get; private set; }
        public User IndicatorUser { get; private set; }
        public string Status { get; private set; }
    }
}