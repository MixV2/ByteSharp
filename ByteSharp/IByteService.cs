using ByteSharp.Models;
using Newtonsoft.Json.Linq;
using Refit;
using System.Threading.Tasks;

namespace ByteSharp
{
    [Headers("User-Agent: byte/0.2 (co.byte.video; build:126; iOS 13.1.3) Alamofire/4.9.0")]
    public interface IByteService
    {
        /// <summary>
        /// The base URL for this service. Used on every request.
        /// </summary>
        static string BASE_URL
        {
            get
            {
                return "https://api.byte.co";
            }
        }

        /// <summary>
        /// Returns account information for the authenticated user.
        /// </summary>
        /// <returns></returns>
        [Get("/account/me")]
        Task<Paging<ByteUser>> GetMyAccount();

        /// <summary>
        /// Gets a list of bytes from following list.
        /// </summary>
        /// <returns></returns>
        [Get("/timeline")]
        Task<Paging<ByteTimeline>> GetTimeline();

        /// <summary>
        /// Gets a list of bytes from a category.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        [Get("/feed/{uri}")]
        Task<Paging<ByteTimeline>> GetFeed([AliasAs("uri")] string uri);

        /// <summary>
        /// Loop a byte.
        /// </summary>
        /// <param name="videoId"></param>
        /// <returns></returns>
        [Post("/post/id/{videoId}/loop")]
        Task<Paging<ByteLoop>> LoopByte([AliasAs("videoId")] string videoId);

        /// <summary>
        /// Upload a byte.
        /// </summary>
        /// <param name="uploadPayload"></param>
        /// <returns></returns>
        [Headers("Content-Type: application/json")]
        [Post("/upload")]
        Task UploadByte([Body] ByteUploadPayload uploadPayload);

        /// <summary>
        /// Gets a list of accounts the authenticated user is following.
        /// </summary>
        /// <returns></returns>
        [Get("/account/me/following")]
        Task<Paging<ByteUser>> GetFollowing();

        /// <summary>
        /// Follows a user.
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        [Post("/account/id/{accountId}/follow")]
        Task<Paging<JObject>> FollowUser([AliasAs("accountId")] string accountId);

        /// <summary>
        /// Unfollows a user.
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        [Delete("/account/id/{accountId}/follow")]
        Task<Paging<JObject>> UnfollowUser([AliasAs("accountId")] string accountId);
    }
}
