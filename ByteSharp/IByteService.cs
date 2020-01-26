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
        [Get("{uri}")]
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
    }
}
