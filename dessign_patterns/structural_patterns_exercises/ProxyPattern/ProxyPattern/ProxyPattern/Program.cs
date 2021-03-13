using System;
using DesignPatterns.Proxy.Conceptual;
using DesignPatterns.Proxy.Practical;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            Proxy proxy = new Proxy(realSubject);
            client.ClientCode(proxy);

            Console.WriteLine("Practical Part: YouTubeCacheProxy");

            YouTubeDownloader naiveDownloader = new YouTubeDownloader(new ThirdPartyYouTubeClass());
            YouTubeDownloader smartDownloader = new YouTubeDownloader(new YouTubeCacheProxy());

            Console.WriteLine("---naiveDownloader --- start--");
            TimeSpan naive = Test(naiveDownloader);
            Console.WriteLine("---naiveDownloader --- end--");
            Console.WriteLine("---smartDownloader --- start--");
            TimeSpan smart = Test(smartDownloader);
            Console.WriteLine("---smartDownloader --- end--");
            Console.WriteLine("Time saved by caching proxy: " + (naive - smart) + "ms");

        }

        private static TimeSpan Test(YouTubeDownloader downloader)
        {
            var startTime = DateTime.Now;

            // User behavior in our app:
            downloader.RenderPopularVideos();
            downloader.RenderVideoPage("catzzzzzzzzz");
            downloader.RenderPopularVideos();
            downloader.RenderVideoPage("dancesvideoo");
            // Users might visit the same page quite often.
            downloader.RenderVideoPage("catzzzzzzzzz");
            downloader.RenderVideoPage("someothervid");

            var estimatedTime = DateTime.Now - startTime;
            Console.WriteLine("Time elapsed: " + estimatedTime + "ms\n");
            return estimatedTime;
        }
    }
}
