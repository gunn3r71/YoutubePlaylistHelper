using System.Collections.Generic;
using YoutubePlaylistHelper.Domain.Enums;

namespace YoutubePlaylistHelper.Domain.Entities
{
    public class Video : Entity
    {
        protected Video()
        {
        }

        public Video(string title, string description, Channel channel, PlayList playList, int playListOrder, string youtubeVideoId, User indicatorUser, Status status, List<string> tags) : this()
        {
            Title = title;
            Description = description;
            Tags = tags;
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
        public Status Status { get; private set; }
    }
}