using Newtonsoft.Json;

namespace ByteSharp.Models
{
    /// <summary>
    /// Represents a list of accounts.
    /// </summary>
    public struct ByteAccounts
    {
        [JsonProperty("accounts")] public ByteUser[] Accounts;
        [JsonProperty("cursor")] public string Cursor;
    }
}
