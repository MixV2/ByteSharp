# ByteSharp
A .NET client library for Byte.

## Example
An example program that lists through bytes on your following feed and logs information about each byte:
```csharp
using ByteSharp;
using Refit;

class Program
{
    static async Task Main(string[] args)
    {
        // setup the byte service
        var byteService = RestService.For<IByteService>(new HttpClient
        {
            BaseAddress = new Uri(IByteService.BASE_URL),
            DefaultRequestHeaders = {
                { "Authorization", "byte_token" } // Byte token goes here!
            }
        });

        var timeline = await byteService.GetTimeline();

        // loops through bytes in your following feed and prints some information about each individual byte!
        foreach (var post in timeline.Data.Posts)
        {
            Console.WriteLine("Post Caption: " + post.Caption);
            Console.WriteLine("Posted By: " + post.AuthorId);
            Console.WriteLine("Likes: " + post.LikeCount);
        }

        // wait for user input before closing the program
        Console.ReadKey();
    }
}
```

More code examples can be found in the [Examples](https://github.com/MixV2/ByteSharp/tree/master/Examples) section of the repository.
