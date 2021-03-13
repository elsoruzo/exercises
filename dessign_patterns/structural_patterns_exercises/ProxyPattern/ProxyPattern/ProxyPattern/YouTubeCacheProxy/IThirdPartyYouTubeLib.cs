using System;
using System.Collections.Generic; 

namespace DesignPatterns.Proxy.Practical
{
  public interface IThirdPartyYouTubeLib {
     Dictionary<string, Video> PopularVideos();

     Video GetVideo(String videoId);
  }
}