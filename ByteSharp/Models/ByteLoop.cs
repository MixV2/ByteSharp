using Newtonsoft.Json;

namespace ByteSharp.Models
{
    public struct ByteLoop
    {
        [JsonProperty("postID")] public string PostId;
        [JsonProperty("loopCount")] public int LoopCount;
    }
}
