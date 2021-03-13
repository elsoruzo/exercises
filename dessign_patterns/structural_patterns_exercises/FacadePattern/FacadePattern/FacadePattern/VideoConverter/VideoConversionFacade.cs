namespace DesignPatterns.Facade.Practical
{
  using System;
  public class VideoConversionFacade {
    public VideoFile ConvertVideo(String fileName, String format) {
        Console.WriteLine("VideoConversionFacade: conversion started.");
        VideoFile file = new VideoFile(fileName);
        Codec sourceCodec = CodecFactory.Extract(file);
        Codec destinationCodec;
        if (format.Equals("mp4")) {
            destinationCodec = new OggCompressionCodec();
        } else {
            destinationCodec = new MPEG4CompressionCodec();
        }
        VideoFile buffer = BitrateReader.Read(file, sourceCodec);
        VideoFile intermediateResult = BitrateReader.Convert(buffer, destinationCodec);
        VideoFile result = (new AudioMixer()).Fix(intermediateResult);
        Console.WriteLine("VideoConversionFacade: conversion completed.");
        return result;
    }
  }
}