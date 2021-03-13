namespace DesignPatterns.Facade.Practical
{
using System;
using System.IO;
  public class AudioMixer {
      public VideoFile Fix(VideoFile result){
          Console.WriteLine("AudioMixer: fixing audio...");
          return new VideoFile("tmp");
      }
  }
}