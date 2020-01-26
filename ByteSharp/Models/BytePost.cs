using Newtonsoft.Json;

namespace ByteSharp.Models
{
    /// <summary>
    /// Represents a byte.
    /// </summary>
    public struct BytePost
    {
        [JsonProperty("id")] public string Id;
        [JsonProperty("type")] public int Type;
        [JsonProperty("authorID")] public string AuthorId;
        [JsonProperty("caption")] public string Caption;
        [JsonProperty("allowCuration")] public bool AllowCuration;
        [JsonProperty("allowRemix")] public bool AllowRemix;
        [JsonProperty("category")] public string Category;
        [JsonProperty("mentions")] public ByteMention[] Mentions;
        [JsonProperty("date")] public int Date;
        [JsonProperty("videoSrc")] public string VideoSrc;
        [JsonProperty("thumbSrc")] public string ThumbSrc;
        [JsonProperty("commentCount")] public int CommentCount;
        [JsonProperty("comments")] public ByteComment[] Comments;
        [JsonProperty("likeCount")] public int LikeCount;
        [JsonProperty("likedByMe")] public bool LikedByMe;
        [JsonProperty("loopCount")] public int LoopCount;
        [JsonProperty("rebytedByMe")] public bool RebytedByMe;
    }

    /// <summary>
    /// Represents a comment on a byte.
    /// </summary>
    public struct ByteComment
    {
        [JsonProperty("id")] public string Id;
        [JsonProperty("postID")] public string PostId;
        [JsonProperty("authorID")] public string AuthorId;
        [JsonProperty("body")] public string Body;
        [JsonProperty("mentions")] public ByteMention[] Mentions;
        [JsonProperty("date")] public int Date;
    }

    /// <summary>
    /// Represents a user mention on a comment.
    /// </summary>
    public struct ByteMention
    {
        [JsonProperty("accountID")] public string AccountId;
        [JsonProperty("username")] public string Username;
        [JsonProperty("text")] public string Text;
        [JsonProperty("range")] public ByteRange Range;
        [JsonProperty("byteRange")] public ByteRange ByteRange;
    }

    /// <summary>
    /// Represents the range on a mention.
    /// </summary>
    public struct ByteRange
    {
        [JsonProperty("start")] public int Start;
        [JsonProperty("stop")] public int Stop;
    }
}
