/// <summary>
/// An example program that gets an MP4 file and uploads it to Byte.
/// </summary>
public class PostByte
{
    static async Task Main(string[] args)
    {
        var byteService = RestService.For<IByteService>(new HttpClient
        {
            BaseAddress = new Uri(IByteService.BASE_URL),
            DefaultRequestHeaders = {
                    { "Authorization", "" } // Byte token goes here!
                }
        });

        // get the upload URL
        var uploadResponse = await byteService.UploadByte(new ByteUploadPayload
        {
            ContentType = "video/mp4"
        });

        // upload to google's servers
        ByteUpload.UploadFile(uploadResponse.Data.UploadUrl, "video/mp4", @"C:\Users\...\Desktop\video.mp4");

        // post the media to byte
        var postResponse = await byteService.PostByte(new BytePostPayload
        {
            Category = "wierd",
            VideoUploadId = uploadResponse.Data.UploadId,
            ThumbUploadId = uploadResponse.Data.UploadId, // you can optionally upload your own thumbnail as a jpeg but for now lets make it the same
            Caption = "Uploaded using ByteSharp - https://github.com/MixV2/ByteSharp"
        });

        Console.WriteLine("Post Success Response: " + (postResponse.Success == 1 ? "Yes" : "No"));
        Console.WriteLine("Posted At: " + postResponse.Data.Date);

        Console.ReadKey();
    }
}