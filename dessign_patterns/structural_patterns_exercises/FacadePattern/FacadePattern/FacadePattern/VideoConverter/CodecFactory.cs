namespace DesignPatterns.Facade.Practical
{
using System;
  public class CodecFactory {
    public static Codec Extract(VideoFile file) {
        string type = file.GetCodecType();
        if (type.Equals("mp4")) {
            Console.WriteLine("CodecFactory: extracting mpeg audio...");
            return new MPEG4CompressionCodec();
        }
        else {
            Console.WriteLine("CodecFactory: extracting ogg audio...");
            return new OggCompressionCodec();
        }
    }
  }
}