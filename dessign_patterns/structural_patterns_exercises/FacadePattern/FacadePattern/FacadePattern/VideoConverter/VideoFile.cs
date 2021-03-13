namespace DesignPatterns.Facade.Practical
{
  using System;
  public class VideoFile {
    private string name;
    private string codecType;

    public VideoFile(string name) {
        this.name = name;
        this.codecType = name.Substring(name.IndexOf(".") + 1);
    }

    public string GetCodecType() {
        return codecType;
    }

    public string GetName() {
        return name;
    }
  }
}