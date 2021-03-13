using System;
using System.Collections.Generic; 

namespace DesignPatterns.Proxy.Practical
{
    public class YouTubeCacheProxy : IThirdPartyYouTubeLib {
    private IThirdPartyYouTubeLib youtubeService;
    private Dictionary<string, Video> cachePopular = new Dictionary<string, Video>();
    private Dictionary<string, Video> cacheAll = new Dictionary<string, Video>();

    public YouTubeCacheProxy() {
        this.youtubeService = new ThirdPartyYouTubeClass();
    }


    public Dictionary<string, Video> PopularVideos() {
        if (cachePopular.Count == 0) {
            cachePopular = youtubeService.PopularVideos();
        } else {
            Console.WriteLine("Retrieved list from cache.");
        }
        return cachePopular;
    }


    public Video GetVideo(string videoId) {
        Video video;
        if (!cacheAll.TryGetValue (videoId, out video)) {
            video = youtubeService.GetVideo(videoId);
            cacheAll.Add(videoId, video);
        } else {
            Console.WriteLine("Retrieved video '" + videoId + "' from cache.");
        }
        return video;
    }

    public void Reset() {
        cachePopular.Clear();
        cacheAll.Clear();
    }
  }
}