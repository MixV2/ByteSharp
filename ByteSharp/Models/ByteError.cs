using Newtonsoft.Json;

namespace ByteSharp.Models
{
    /// <summary>
    /// Represents a Byte related error.
    /// </summary>
    public struct ByteError
    {
        [JsonProperty("message")] public string Message;
        [JsonProperty("code")] public int Code;
    }
}
