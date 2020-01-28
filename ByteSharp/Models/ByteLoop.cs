using Newtonsoft.Json;

namespace ByteSharp.Models
{
    /// <summary>
    /// Represents a loop on a byte.
    /// </summary>
    public struct ByteLoop
    {
        [JsonProperty("postID")] public string PostId;
        [JsonProperty("loopCount")] public int LoopCount;
    }
}
