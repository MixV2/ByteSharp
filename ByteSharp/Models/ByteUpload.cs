﻿using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;

namespace ByteSharp.Models
{
    /// <summary>
    /// Represents an upload response.
    /// </summary>
    public struct ByteUpload
    {
        [JsonProperty("uploadID")] public string UploadId;
        [JsonProperty("uploadURL")] public string UploadUrl;

        /// <summary>
        /// Uploads a media file.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="file"></param>
        public static void UploadFile(string address, string contentType, string file)
        {
            // TODO: Possible error handling?
            // Keep in mind that the video must be under 5MB to upload - otherwise, an error will be thrown.
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers["Content-Type"] = contentType;
                // TODO: Maybe use WebClient#UploadFileAsync() in future so to not block the main thread? Shouldn't be a problem for now..
                webClient.UploadFile(address, "PUT", file);
            }
        }
    }

    /// <summary>
    /// Represents an upload payload.
    /// </summary>
    public struct ByteUploadPayload
    {
        [JsonProperty("contentType")] public string ContentType; // video/mp4, image/jpeg
    }

    /// <summary>
    /// Represents a post payload.
    /// </summary>
    public struct BytePostPayload
    {
        [JsonProperty("category")] public string Category;
        [JsonProperty("videoUploadID")] public string VideoUploadId;
        [JsonProperty("thumbUploadID")] public string ThumbUploadId;
        [JsonProperty("caption")] public string Caption;
    }
}
