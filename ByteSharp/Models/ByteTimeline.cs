using Newtonsoft.Json;
using System.Collections.Generic;

namespace ByteSharp.Models
{
    /// <summary>
    /// Represents a timeline of bytes.
    /// </summary>
    public struct ByteTimeline
    {
        [JsonProperty("posts")] public BytePost[] Posts;
        [JsonProperty("cursor")] public string Cursor;
        [JsonProperty("accounts")] public Dictionary<string, ByteUser> Accounts;
    }
}
