using ByteSharp.Models;
using Refit;
using System.Threading.Tasks;

namespace ByteSharp
{
    public interface IByteService
    {
        /// <summary>
        /// The base URL for this service. Used on every request.
        /// </summary>
        string BASE_URL
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

        [Get("/timeline")]
        Task<Paging<ByteTimeline>> GetTimeline();

        [Get("/feed/{feedId}")]
        Task<Paging<ByteTimeline>> GetFeed([AliasAs("feedId")] string feedId);
    }
}
