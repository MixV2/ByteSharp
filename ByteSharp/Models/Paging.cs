using Newtonsoft.Json;

namespace ByteSharp.Models
{
    /// <summary>
    /// Represents a response model.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public struct Paging<T>
    {
        [JsonProperty("data")] public T Data;
        [JsonProperty("success")] public int Success;
        [JsonProperty("error")] public ByteError Error; // only occurs if success is nil
    }
}
