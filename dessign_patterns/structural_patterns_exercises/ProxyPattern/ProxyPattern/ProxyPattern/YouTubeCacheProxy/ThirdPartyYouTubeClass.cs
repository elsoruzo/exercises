using System;
using System.Collections.Generic; 
using System.Threading;

namespace DesignPatterns.Proxy.Practical
{

  public class ThirdPartyYouTubeClass : IThirdPartyYouTubeLib {
  

      public Dictionary<string, Video> PopularVideos() {
          ConnectToServer("http://www.youtube.com");
          return GetRandomVideos();
      }
  
      
      public Video GetVideo(String videoId) {
          ConnectToServer("http://www.youtube.com/" + videoId);
          return GetSomeVideo(videoId);
      }
  
      // -----------------------------------------------------------------------
      // Fake methods to simulate network activity. They as slow as a real life.
  
      private int Random(int min, int max) {
          //return min + (int) (new Random().Next( int.MinValue, int.MaxValue ) * ((max - min) + 1));
          return new Random().Next( min, max );
      }
  
      private void ExperienceNetworkLatency() {
          int randomLatency = Random(5, 10);
          for (int i = 0; i < randomLatency; i++) {
              try {
                  Thread.Sleep(10);
              } catch (Exception ex) {
                 Console.WriteLine($"ex.Message! {ex.Message}\n");
              }
          }
      }
  
      private void ConnectToServer(string server) {
          Console.WriteLine("Connecting to " + server + "... ");
          ExperienceNetworkLatency();
          Console.WriteLine("Connected!" + "\n");
      }
  
      private Dictionary<string, Video> GetRandomVideos() {
          Console.WriteLine("Downloading populars... ");
  
          ExperienceNetworkLatency();
          Dictionary<string, Video> dict = new Dictionary<string, Video>();

          dict.Add("catzzzzzzzzz", new Video("sadgahasgdas", "Catzzzz.avi"));
          dict.Add("mkafksangasj", new Video("mkafksangasj", "Dog play with ball.mp4"));
          dict.Add("dancesvideoo", new Video("asdfas3ffasd", "Dancing video.mpq"));
          dict.Add("dlsdk5jfslaf", new Video("dlsdk5jfslaf", "Barcelona vs RealM.mov"));
          dict.Add("3sdfgsd1j333", new Video("3sdfgsd1j333", "Programing lesson#1.avi"));
  
          Console.WriteLine("Done!" + "\n");
          return dict;
      }
  
      private Video GetSomeVideo(String videoId) {
          Console.WriteLine("Downloading video... ");
  
          ExperienceNetworkLatency();
          Video video = new Video(videoId, "Some video title");
  
          Console.WriteLine("Done!" + "\n");
          return video;
      }
  
  }
}