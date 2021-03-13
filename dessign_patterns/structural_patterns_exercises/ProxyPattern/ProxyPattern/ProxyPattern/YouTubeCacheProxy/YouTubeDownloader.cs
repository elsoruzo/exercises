using System;
using System.Collections.Generic; 

namespace DesignPatterns.Proxy.Practical
{
  public class YouTubeDownloader {
    private IThirdPartyYouTubeLib api;

    public YouTubeDownloader(IThirdPartyYouTubeLib api) {
        this.api = api;
    }

    public void RenderVideoPage(String videoId) {
        Video video = api.GetVideo(videoId);
        Console.WriteLine("\n-------------------------------");
        Console.WriteLine("Video page (imagine fancy HTML)");
        Console.WriteLine("ID: " + video.Id);
        Console.WriteLine("Title: " + video.Title);
        Console.WriteLine("Video: " + video.Data);
        Console.WriteLine("-------------------------------\n");
    }

    public void RenderPopularVideos() {
        Dictionary<string, Video> list = api.PopularVideos();
        Console.WriteLine("\n-------------------------------");
        Console.WriteLine("Most popular videos on YouTube (imagine fancy HTML)");
        foreach (var video in list) {
            Console.WriteLine("ID: " + video.Value.Id + " / Title: " + video.Value.Title);
        }
        Console.WriteLine("-------------------------------\n");
    }
  }
}