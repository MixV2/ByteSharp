using Newtonsoft.Json;

namespace ByteSharp.Models
{
    /// <summary>
    /// Represents a user on Byte.
    /// </summary>
    public struct ByteUser
    {
        [JsonProperty("avatarURL")] public string AvatarUrl;
        [JsonProperty("bio")] public string Bio; // not applicable to all requests
        [JsonProperty("backgroundColor")] public string BackgroundColor;
        [JsonProperty("followerCount")] public int FollowerCount;
        [JsonProperty("followingCount")] public int FollowingCount;
        [JsonProperty("id")] public string Id;
        [JsonProperty("isChannel")] public bool IsChannel;
        [JsonProperty("isDeactivated")] public bool IsDeactivated;
        [JsonProperty("isRegistered")] public bool IsRegistered;
        [JsonProperty("isSuspended")] public bool IsSuspended;
        [JsonProperty("loopCount")] public int LoopCount;
        [JsonProperty("loopsConsumedCount")] public int LoopsConsumedCount;
        [JsonProperty("registrationDate")] public int RegistrationDate;
        [JsonProperty("username")] public string Username;
    }
}
